Imports Microsoft.VisualBasic
Imports System
Imports System.IO
Imports System.Data
Imports System.Text
Imports System.Data.SqlClient

'
 '* Autor: Ghiondea Alexandru
 '* Date: 08 october 2004
 '* Description: Implements methods for uploading and downloading files
 '*  with MS SQL Server
 '*
Namespace PicturesInSQLServer
	'''	<summary>
	'''	This class manages uploads and downloads to	and	from an	SQL	Server
	'''	</summary>
    Public Class TransferPictures

        ''' <summary>
        ''' Gets from the server a list of uploaded files into a dataSet
        ''' </summary>
        ''' <param name="ds">The dataset</param>
        ''' <param name="table">The table in the dataset</param>
        Public Sub GetUploadedFiles(ByRef ds As DataSet, ByVal table As String)
            '
            ' The variables required for connecting to the server.
            '
            Dim conn As SqlConnection = Nothing
            Dim cmd As SqlCommand = Nothing
            Dim da As SqlDataAdapter = Nothing
            ' ----------------------------------------------

            Try
                '
                ' If the table already exists, cleares its content. Else adds a new table.
                '
                If ds.Tables.Contains(table) Then
                    ds.Tables(table).Clear()
                Else
                    ds.Tables.Add(table)
                End If
                ' ----------------------------------------------


                '
                ' Creates a connection to the database and initilizes the command
                '
                conn = New SqlConnection(ConnectionString())
                cmd = New SqlCommand("getUploadedFiles", conn)
                cmd.CommandType = CommandType.StoredProcedure
                ' ----------------------------------------------

                '
                ' Initializes the DataAdapter used for retrieving the data
                '
                da = New SqlDataAdapter(cmd)
                ' ----------------------------------------------

                '
                ' Opens the connection and populates the dataset
                '
                conn.Open()
                da.Fill(ds, table)
                conn.Close()
                ' ----------------------------------------------
            Catch e As Exception
                '
                ' If an error occurs, we assign null to the result and display the error to the user,
                ' with information about the StackTrace for debugging purposes.
                '
                Console.WriteLine(e.Message & "	- " & e.StackTrace)
            End Try
        End Sub

        '''	<summary>
        '''	Uploads	a file to the database server.
        '''	</summary>
        '''	<param name="fileName">The filename	of the picture to be uploaded</param>
        '''	<returns>The id	of the file	on the server.</returns>
        Public Function UploadFile(ByVal FileName As String) As Long
            If (Not File.Exists(FileName)) Then
                Return -1
            End If

            Dim fs As FileStream = Nothing
            Try
                '#Region "Reading file"

                fs = New FileStream(FileName, FileMode.Open)

                '
                ' Finding out the size of the file to be uploaded
                '
                Dim fi As FileInfo = New FileInfo(FileName)
                Dim temp As Long = fi.Length
                Dim lung As Integer = Convert.ToInt32(temp)
                ' ------------------------------------------

                '
                ' Reading the content of the file into an array of bytes.
                '
                Dim picture As Byte() = New Byte(lung - 1) {}
                fs.Read(picture, 0, lung)
                fs.Close()
                ' ------------------------------------------
                '#End Region
                Dim result As Long = uploadFileToDatabase(picture, fi.Name)

                Return result
            Catch e As Exception
                Console.WriteLine(e.Message & "	- " & e.StackTrace)
                Return -1
            End Try
        End Function

        ''' <summary>
        ''' Wrapper for downloading a file from a database.
        ''' </summary>
        ''' <param name="kFileName">The Unique ID of the file in database</param>
        ''' <param name="fileName">The file name as it was stored in the database.</param>
        ''' <returns>The byte array required OR null if the ID is not found</returns>
        Public Function DownloadFile(ByVal kFileName As Long, ByRef fileName As String) As Byte()
            Dim result As Byte() = downloadFileFromDatabase(kFileName, fileName)
            Return result
        End Function

        '''	<summary>
        '''	Returns the connection string for connecting to the database
        '''	</summary>
        '''	<returns>The Connection string.</returns>
        Public Shared Function ConnectionString() As String
            '
            ' We consider that the database is situated on the same computer that runs the program.
            ' To connect to a remote server, replace 'Data Source' with the name of that server.
            '
            '---- Return "Connect Timeout=600;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Pictures;Packet Size=4096;Data Source=(local)"
            Return "Data Source = (local);Initial Catalog = PicDB;User ID =pic;Password =ml"

            '.........You can also use........
            'Dim Conn As String = "Server=.;uid=sa;pwd=;database=Pictures"
            'Return Conn
        End Function

        ''' <summary>
        ''' Uploades a file to an SQL Server.
        ''' </summary>
        ''' <param name="picture">A byte array that contains the information to be uploaded.</param>
        ''' <param name="fileName">The file name asociated with that byte array.</param>
        ''' <returns>The unique ID of the file on the server OR -1 if an error occurs. </returns>
        Private Function uploadFileToDatabase(ByVal picture As Byte(), ByVal fileName As String) As Long
            '
            ' Defining the variables required for accesing the database server.
            '
            Dim conn As SqlConnection = Nothing
            Dim cmd As SqlCommand = Nothing
            Dim kFileName As SqlParameter = Nothing
            'INSTANT VB NOTE: The local variable FileName was renamed since Visual Basic will not uniquely identify local variables when other local variables have the same name:
            Dim FileName_Renamed As SqlParameter = Nothing
            Dim pic As SqlParameter = Nothing
            ' By default, we assume we have an error. If we succed in uploading the file, we'll change this 
            '  to the unique id of the file
            Dim result As Long = -1

            Try
                '
                ' Connecting to database.
                '
                conn = New SqlConnection(ConnectionString())
                cmd = New SqlCommand("UploadFile", conn) ' We assume there is a stored procedure called UploadFile
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                ' ----------------------------------------------

                '
                ' Initializing parameters and assigning the values to be sent to the server
                '
                kFileName = New SqlParameter("@kFileName", System.Data.SqlDbType.BigInt, 4)
                kFileName.Direction = ParameterDirection.Output
                ' This parameter does not have a size because we do not know what the size is going to be.
                pic = New SqlParameter("@picture", SqlDbType.Image)
                pic.Value = picture

                FileName_Renamed = New SqlParameter("@FileName", SqlDbType.VarChar, 250)
                FileName_Renamed.Value = fileName
                ' ----------------------------------------------

                '
                ' Adding the parameters to the database. Remember that the order in which the parameters 
                '  are added is VERY important!
                '
                cmd.Parameters.Add(pic)
                cmd.Parameters.Add(FileName_Renamed)
                cmd.Parameters.Add(kFileName)
                ' ----------------------------------------------

                '
                ' Opening the connection and executing the command.
                '
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
                ' ----------------------------------------------

                '
                ' The result is the unique identifier created on the database.
                '
                'result = (long)kFileName.Value;
                result = CLng(kFileName.Value)
                ' ----------------------------------------------

                '
                ' Disposing of the objects so we don't occupy memory.
                '
                conn.Dispose()
                cmd.Dispose()
                ' ----------------------------------------------
            Catch e As Exception
                '
                ' If an error occurs, we report it to the user, with StackTrace for debugging purposes
                MsgBox(e.Message)
                Console.WriteLine(e.Message & "	- " & e.StackTrace)
                result = -1
                ' ----------------------------------------------
            End Try
            Return result
        End Function

        ''' <summary>
        ''' Downloades a file from a database according to the unique id in that database.
        ''' </summary>
        ''' <param name="kFile">The ID of the file in the database</param>
        ''' <param name="FileName">The filename of the file as it was stored in the database.</param>
        ''' <returns>A byte array containing the information required.</returns>
        Private Function downloadFileFromDatabase(ByVal kFile As Long, ByRef FileName As String) As Byte()
            Dim conn As SqlConnection = Nothing
            Dim cmd As SqlCommand = Nothing
            Dim kFileName As SqlParameter = Nothing
            'INSTANT VB NOTE: The local variable fileName was renamed since Visual Basic will not uniquely identify local variables when other local variables have the same name:
            Dim fileName_Renamed As SqlParameter = Nothing
            Dim dr As SqlDataReader = Nothing
            Dim result As Byte() = Nothing

            Try
                '
                ' Connecting to database.
                '
                conn = New SqlConnection(ConnectionString())
                cmd = New SqlCommand("DownloadFile", conn)
                cmd.CommandType = System.Data.CommandType.StoredProcedure
                ' ----------------------------------------------

                '
                ' Initializing parameters and assigning the values to be sent to the server
                '
                kFileName = New SqlParameter("@kFileName", System.Data.SqlDbType.BigInt, 8)
                kFileName.Value = kFile
                fileName_Renamed = New SqlParameter("@FileName", SqlDbType.VarChar, 250)
                fileName_Renamed.Direction = ParameterDirection.Output
                ' ----------------------------------------------

                '
                ' Adding the parameters to the database. Remember that the order in which the parameters 
                '  are added is VERY important!
                '
                cmd.Parameters.Add(kFileName)
                cmd.Parameters.Add(fileName_Renamed)
                ' ----------------------------------------------

                '
                ' Opening the connection and executing the command.
                '  The idea behind using a dataReader is that, on the SQL Server, we cannot assign to a
                ' variable the value of an image field. So, we use a querry to select the record we want 
                ' and we use a datareader to read that query.
                '  Because we are returnig information based on a primary key, we are always returning
                ' only one row of data.
                '
                conn.Open()
                dr = cmd.ExecuteReader()
                dr.Read()
                '
                ' We are casting the value returned by the datareader to the byte[] data type.
                '
                result = CType(dr.GetValue(0), Byte())
                '
                ' We are also returning the filename associated with the byte array.
                '
                FileName = CStr(dr.GetValue(1))

                '
                ' Closing the datareader and the connection
                '
                dr.Close()
                conn.Close()
                ' ------------------------------------------

                '
                ' Disposing of the objects so we don't occupy memory.
                '
                conn.Dispose()
                cmd.Dispose()
                ' ------------------------------------------
            Catch e As Exception
                '
                ' If an error occurs, we assign null to the result and display the error to the user,
                ' with information about the StackTrace for debugging purposes.
                MsgBox(e.Message)
                Console.WriteLine(e.Message & "	- " & e.StackTrace)
                result = Nothing
            End Try
            Return result
        End Function
    End Class
End Namespace