Imports System.IO
Imports System
Imports System.Data.SqlClient
Imports System.Windows.Forms.StatusBarPanel
Imports System.Windows.Forms.StatusBar
Imports System.Windows.Forms.Control
Imports System.Windows.Forms.NativeWindow
Imports System.Drawing.Graphics
Imports System.Drawing.SystemColors

Public Class frmMain
    Inherits System.Windows.Forms.Form
    Private iJewelryQty, iJewelryTWT, iJewelryAveWt, iJewelryLOAN, iJewelryTotalRem, iJewelryTotalPrenda, iJewelrySummary As Integer
    Private iProcessQty, iProcessTWT, iProcessAveWt, iProcessLOAN, iProcessTotalRem, iProcessTotalPrenda As Integer
    Private iSumProcessQty, iSumProcessTWT, iSumProcessAveWt, iSumProcessLOAN, iSumProcessTotalRem, iSumProcessTotalPrenda As Integer
    Private iSummaryCell, iSummaryWatch, iSummaryGoodStock, iSummaryTakenBack As Integer
    Private iSummaryReceived, iSummaryUnreceived, iSummaryReleased, iSummaryUnreleased As Integer
    Private iComparativeAveWt, iComparativeOA, iComparativeFakeCoated, iComparativeCellWatchAppliance As Integer
    Private iGmMemoAppliance, iHrMemoMissing, iHrMemoFake, iHrMemoCoated, iHrOverApp, iHrIR As Integer
    Public sPath As String = Application.StartupPath

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Receiving As System.Windows.Forms.TabControl
    Friend WithEvents TabRem As System.Windows.Forms.TabPage
    Friend WithEvents TabPricing As System.Windows.Forms.TabPage
    Friend WithEvents TabDistri As System.Windows.Forms.TabPage
    Friend WithEvents TabShowroom As System.Windows.Forms.TabPage
    Friend WithEvents TabReports As System.Windows.Forms.TabPage
    Friend WithEvents TabSystem As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents btnReceivingReport As System.Windows.Forms.Button
    Friend WithEvents btnPTQuery As System.Windows.Forms.Button
    Friend WithEvents btnReceivingByBranch As System.Windows.Forms.Button
    Friend WithEvents btnBatchReceive As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnReceiving As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnPhoto As System.Windows.Forms.Button
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnALLSearch As System.Windows.Forms.Button
    Friend WithEvents btnBranchSearch As System.Windows.Forms.Button
    Friend WithEvents btnMemoReceiver As System.Windows.Forms.Button
    Friend WithEvents btnJewelryClass As System.Windows.Forms.Button
    Friend WithEvents btnActionClass As System.Windows.Forms.Button
    Friend WithEvents btnDistri As System.Windows.Forms.Button
    Friend WithEvents Consignee As System.Windows.Forms.Button
    Friend WithEvents Inventory As System.Windows.Forms.Button
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents btnPricing As System.Windows.Forms.Button
    Friend WithEvents btnIR As System.Windows.Forms.Button
    Friend WithEvents btnBRem As System.Windows.Forms.Button
    Friend WithEvents btnIREM As System.Windows.Forms.Button
    Friend WithEvents btnRMLWB As System.Windows.Forms.Button
    Friend WithEvents btnBMLWB As System.Windows.Forms.Button
    Friend WithEvents btnRPRICING As System.Windows.Forms.Button
    Friend WithEvents btnBPRICING As System.Windows.Forms.Button
    Friend WithEvents btnRDISTRI As System.Windows.Forms.Button
    Friend WithEvents btnBDISTRI As System.Windows.Forms.Button
    Friend WithEvents btnvwbar As System.Windows.Forms.Button
    Friend WithEvents btnGood As System.Windows.Forms.Button
    Friend WithEvents btnPRIVW As System.Windows.Forms.Button
    Friend WithEvents btnReLOuT As System.Windows.Forms.Button
    Friend WithEvents btnCost As System.Windows.Forms.Button
    Friend WithEvents btnBQuery As System.Windows.Forms.Button
    Friend WithEvents btnItem As System.Windows.Forms.Button
    Friend WithEvents btnvwPrice As System.Windows.Forms.Button
    Friend WithEvents btnHistoryB As System.Windows.Forms.Button
    Friend WithEvents btnUpdateHumres As System.Windows.Forms.Button
    Friend WithEvents btnUpdateBedryf As System.Windows.Forms.Button
    Friend WithEvents btnRelVIP As System.Windows.Forms.Button
    Friend WithEvents btnPicEdit As System.Windows.Forms.Button
    Friend WithEvents btnCVismin As System.Windows.Forms.Button
    Friend WithEvents btnCLuzon As System.Windows.Forms.Button
    Friend WithEvents btnComparative As System.Windows.Forms.Button
    Friend WithEvents btnTopBranch As System.Windows.Forms.Button
    Friend WithEvents btnVM As System.Windows.Forms.Button
    Friend WithEvents btnCreateInfo As System.Windows.Forms.Button
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents userName As System.Windows.Forms.StatusBarPanel
    Friend WithEvents AccountStat As System.Windows.Forms.StatusBarPanel
    Friend WithEvents Dt As System.Windows.Forms.StatusBarPanel
    Friend WithEvents DTime As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel6 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents AllDept As System.Windows.Forms.StatusBarPanel
    Friend WithEvents btnEditItem As System.Windows.Forms.Button
    Friend WithEvents cmdUnoRec As System.Windows.Forms.Button
    Friend WithEvents btnRelIndi As System.Windows.Forms.Button
    Friend WithEvents btnTop As System.Windows.Forms.Button
    Friend WithEvents btnBarcodeUtil As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnREMInventory As System.Windows.Forms.Button
    Friend WithEvents btnEditCode As System.Windows.Forms.Button
    Friend WithEvents btnREMrecode As System.Windows.Forms.Button
    Friend WithEvents btnProcessQty As System.Windows.Forms.Button
    Friend WithEvents btnSumProcessTWT As System.Windows.Forms.Button
    Friend WithEvents btnSumProcessAveWT As System.Windows.Forms.Button
    Friend WithEvents btnSumProcessLoan As System.Windows.Forms.Button
    Friend WithEvents btnSumProcessTREM As System.Windows.Forms.Button
    Friend WithEvents btnSUmProcessTPrenda As System.Windows.Forms.Button
    Friend WithEvents btnDistriInventory As System.Windows.Forms.Button
    Friend WithEvents btnInvPricing As System.Windows.Forms.Button
    Friend WithEvents btnInventory As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents btnSelfInven As System.Windows.Forms.Button
    Friend WithEvents btnUnReleased As System.Windows.Forms.Button
    Friend WithEvents btnReleased As System.Windows.Forms.Button
    Friend WithEvents btnUnReceived As System.Windows.Forms.Button
    Friend WithEvents btnReceived As System.Windows.Forms.Button
    Friend WithEvents btnCGPrice As System.Windows.Forms.Button
    Friend WithEvents btnDistriSInventory As System.Windows.Forms.Button
    Friend WithEvents btnMSInventory As System.Windows.Forms.Button
    Friend WithEvents btnPSInventory As System.Windows.Forms.Button
    Friend WithEvents btnREMSInventory As System.Windows.Forms.Button
    Friend WithEvents btnCDPrice As System.Windows.Forms.Button
    Friend WithEvents btnPearlPrice As System.Windows.Forms.Button
    Friend WithEvents btnStonePrice As System.Windows.Forms.Button
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.Receiving = New System.Windows.Forms.TabControl
        Me.TabRem = New System.Windows.Forms.TabPage
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnEditCode = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnGood = New System.Windows.Forms.Button
        Me.btnReLOuT = New System.Windows.Forms.Button
        Me.btnCost = New System.Windows.Forms.Button
        Me.btnReceiving = New System.Windows.Forms.Button
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.btnRelIndi = New System.Windows.Forms.Button
        Me.cmdUnoRec = New System.Windows.Forms.Button
        Me.btnRelVIP = New System.Windows.Forms.Button
        Me.btnItem = New System.Windows.Forms.Button
        Me.btnBQuery = New System.Windows.Forms.Button
        Me.btnBRem = New System.Windows.Forms.Button
        Me.btnIREM = New System.Windows.Forms.Button
        Me.btnReceivingReport = New System.Windows.Forms.Button
        Me.btnPTQuery = New System.Windows.Forms.Button
        Me.btnReceivingByBranch = New System.Windows.Forms.Button
        Me.btnBatchReceive = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnREMrecode = New System.Windows.Forms.Button
        Me.btnPhoto = New System.Windows.Forms.Button
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.btnUnReleased = New System.Windows.Forms.Button
        Me.btnReleased = New System.Windows.Forms.Button
        Me.btnUnReceived = New System.Windows.Forms.Button
        Me.btnReceived = New System.Windows.Forms.Button
        Me.btnIR = New System.Windows.Forms.Button
        Me.Button31 = New System.Windows.Forms.Button
        Me.Button30 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button26 = New System.Windows.Forms.Button
        Me.Button25 = New System.Windows.Forms.Button
        Me.Button24 = New System.Windows.Forms.Button
        Me.Button28 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.btnSumProcessTWT = New System.Windows.Forms.Button
        Me.btnProcessQty = New System.Windows.Forms.Button
        Me.btnTop = New System.Windows.Forms.Button
        Me.btnVM = New System.Windows.Forms.Button
        Me.btnTopBranch = New System.Windows.Forms.Button
        Me.btnCVismin = New System.Windows.Forms.Button
        Me.btnCLuzon = New System.Windows.Forms.Button
        Me.btnComparative = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button36 = New System.Windows.Forms.Button
        Me.Button35 = New System.Windows.Forms.Button
        Me.Button34 = New System.Windows.Forms.Button
        Me.Button33 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.btnSumProcessTREM = New System.Windows.Forms.Button
        Me.btnSUmProcessTPrenda = New System.Windows.Forms.Button
        Me.btnSumProcessLoan = New System.Windows.Forms.Button
        Me.btnSumProcessAveWT = New System.Windows.Forms.Button
        Me.Button22 = New System.Windows.Forms.Button
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button21 = New System.Windows.Forms.Button
        Me.Button16 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.Button19 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.Button15 = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnREMSInventory = New System.Windows.Forms.Button
        Me.btnPicEdit = New System.Windows.Forms.Button
        Me.btnALLSearch = New System.Windows.Forms.Button
        Me.btnBranchSearch = New System.Windows.Forms.Button
        Me.btnMemoReceiver = New System.Windows.Forms.Button
        Me.btnJewelryClass = New System.Windows.Forms.Button
        Me.btnActionClass = New System.Windows.Forms.Button
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.btnMSInventory = New System.Windows.Forms.Button
        Me.btnEditItem = New System.Windows.Forms.Button
        Me.btnvwbar = New System.Windows.Forms.Button
        Me.btnRMLWB = New System.Windows.Forms.Button
        Me.btnBMLWB = New System.Windows.Forms.Button
        Me.btnInventory = New System.Windows.Forms.Button
        Me.TabPricing = New System.Windows.Forms.TabPage
        Me.btnPSInventory = New System.Windows.Forms.Button
        Me.btnvwPrice = New System.Windows.Forms.Button
        Me.btnPRIVW = New System.Windows.Forms.Button
        Me.btnRPRICING = New System.Windows.Forms.Button
        Me.btnBPRICING = New System.Windows.Forms.Button
        Me.btnPricing = New System.Windows.Forms.Button
        Me.btnInvPricing = New System.Windows.Forms.Button
        Me.TabDistri = New System.Windows.Forms.TabPage
        Me.btnDistriSInventory = New System.Windows.Forms.Button
        Me.btnview = New System.Windows.Forms.Button
        Me.btnCreateInfo = New System.Windows.Forms.Button
        Me.btnRDISTRI = New System.Windows.Forms.Button
        Me.btnBDISTRI = New System.Windows.Forms.Button
        Me.btnDistri = New System.Windows.Forms.Button
        Me.btnDistriInventory = New System.Windows.Forms.Button
        Me.TabShowroom = New System.Windows.Forms.TabPage
        Me.TabReports = New System.Windows.Forms.TabPage
        Me.btnSelfInven = New System.Windows.Forms.Button
        Me.btnREMInventory = New System.Windows.Forms.Button
        Me.Inventory = New System.Windows.Forms.Button
        Me.TabSystem = New System.Windows.Forms.TabPage
        Me.btnStonePrice = New System.Windows.Forms.Button
        Me.btnPearlPrice = New System.Windows.Forms.Button
        Me.btnCDPrice = New System.Windows.Forms.Button
        Me.btnCGPrice = New System.Windows.Forms.Button
        Me.btnBarcodeUtil = New System.Windows.Forms.Button
        Me.btnUpdateHumres = New System.Windows.Forms.Button
        Me.btnUpdateBedryf = New System.Windows.Forms.Button
        Me.btnHistoryB = New System.Windows.Forms.Button
        Me.Consignee = New System.Windows.Forms.Button
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.userName = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel
        Me.AccountStat = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.Dt = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.DTime = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
        Me.AllDept = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel6 = New System.Windows.Forms.StatusBarPanel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Receiving.SuspendLayout()
        Me.TabRem.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.TabPricing.SuspendLayout()
        Me.TabDistri.SuspendLayout()
        Me.TabReports.SuspendLayout()
        Me.TabSystem.SuspendLayout()
        CType(Me.userName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountStat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllDept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Receiving
        '
        Me.Receiving.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Receiving.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.Receiving.Controls.Add(Me.TabRem)
        Me.Receiving.Controls.Add(Me.TabPage8)
        Me.Receiving.Controls.Add(Me.TabPricing)
        Me.Receiving.Controls.Add(Me.TabDistri)
        Me.Receiving.Controls.Add(Me.TabShowroom)
        Me.Receiving.Controls.Add(Me.TabReports)
        Me.Receiving.Controls.Add(Me.TabSystem)
        Me.Receiving.Location = New System.Drawing.Point(0, 0)
        Me.Receiving.Name = "Receiving"
        Me.Receiving.SelectedIndex = 0
        Me.Receiving.Size = New System.Drawing.Size(1032, 504)
        Me.Receiving.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.Receiving.TabIndex = 5
        '
        'TabRem
        '
        Me.TabRem.Controls.Add(Me.TabControl1)
        Me.TabRem.Location = New System.Drawing.Point(4, 27)
        Me.TabRem.Name = "TabRem"
        Me.TabRem.Size = New System.Drawing.Size(1024, 473)
        Me.TabRem.TabIndex = 2
        Me.TabRem.Text = "REM"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(60, 18)
        Me.TabControl1.Location = New System.Drawing.Point(-8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1040, 471)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.btnEditCode)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btnGood)
        Me.TabPage1.Controls.Add(Me.btnReLOuT)
        Me.TabPage1.Controls.Add(Me.btnCost)
        Me.TabPage1.Controls.Add(Me.btnReceiving)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1032, 445)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ITEM"
        Me.TabPage1.Visible = False
        '
        'btnEditCode
        '
        Me.btnEditCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditCode.Location = New System.Drawing.Point(8, 128)
        Me.btnEditCode.Name = "btnEditCode"
        Me.btnEditCode.Size = New System.Drawing.Size(216, 32)
        Me.btnEditCode.TabIndex = 31
        Me.btnEditCode.Text = "RECODE"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(8, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(216, 32)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "RECEIVE OUTSOURCE/RETURNS BATCH"
        '
        'btnGood
        '
        Me.btnGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGood.Location = New System.Drawing.Point(8, 48)
        Me.btnGood.Name = "btnGood"
        Me.btnGood.Size = New System.Drawing.Size(216, 32)
        Me.btnGood.TabIndex = 29
        Me.btnGood.Text = "REPORT"
        '
        'btnReLOuT
        '
        Me.btnReLOuT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReLOuT.Location = New System.Drawing.Point(8, 168)
        Me.btnReLOuT.Name = "btnReLOuT"
        Me.btnReLOuT.Size = New System.Drawing.Size(216, 32)
        Me.btnReLOuT.TabIndex = 28
        Me.btnReLOuT.Text = "RELEASE"
        '
        'btnCost
        '
        Me.btnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCost.Location = New System.Drawing.Point(8, 88)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(216, 32)
        Me.btnCost.TabIndex = 27
        Me.btnCost.Text = "COSTING"
        '
        'btnReceiving
        '
        Me.btnReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceiving.Location = New System.Drawing.Point(8, 8)
        Me.btnReceiving.Name = "btnReceiving"
        Me.btnReceiving.Size = New System.Drawing.Size(216, 32)
        Me.btnReceiving.TabIndex = 25
        Me.btnReceiving.Text = "OutSource/Returns"
        Me.btnReceiving.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnRelIndi)
        Me.TabPage4.Controls.Add(Me.cmdUnoRec)
        Me.TabPage4.Controls.Add(Me.btnRelVIP)
        Me.TabPage4.Controls.Add(Me.btnItem)
        Me.TabPage4.Controls.Add(Me.btnBQuery)
        Me.TabPage4.Controls.Add(Me.btnBRem)
        Me.TabPage4.Controls.Add(Me.btnIREM)
        Me.TabPage4.Controls.Add(Me.btnReceivingReport)
        Me.TabPage4.Controls.Add(Me.btnPTQuery)
        Me.TabPage4.Controls.Add(Me.btnReceivingByBranch)
        Me.TabPage4.Controls.Add(Me.btnBatchReceive)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1032, 447)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "RECEIVING"
        '
        'btnRelIndi
        '
        Me.btnRelIndi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelIndi.Location = New System.Drawing.Point(616, 120)
        Me.btnRelIndi.Name = "btnRelIndi"
        Me.btnRelIndi.Size = New System.Drawing.Size(216, 32)
        Me.btnRelIndi.TabIndex = 30
        Me.btnRelIndi.Text = "Release Individually"
        Me.btnRelIndi.Visible = False
        '
        'cmdUnoRec
        '
        Me.cmdUnoRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUnoRec.Location = New System.Drawing.Point(24, 280)
        Me.cmdUnoRec.Name = "cmdUnoRec"
        Me.cmdUnoRec.Size = New System.Drawing.Size(216, 32)
        Me.cmdUnoRec.TabIndex = 29
        Me.cmdUnoRec.Text = "UNDO RECEIVING"
        Me.cmdUnoRec.Visible = False
        '
        'btnRelVIP
        '
        Me.btnRelVIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelVIP.Location = New System.Drawing.Point(616, 160)
        Me.btnRelVIP.Name = "btnRelVIP"
        Me.btnRelVIP.Size = New System.Drawing.Size(216, 32)
        Me.btnRelVIP.TabIndex = 28
        Me.btnRelVIP.Text = "Release to VP"
        Me.btnRelVIP.Visible = False
        '
        'btnItem
        '
        Me.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnItem.Location = New System.Drawing.Point(24, 40)
        Me.btnItem.Name = "btnItem"
        Me.btnItem.Size = New System.Drawing.Size(216, 32)
        Me.btnItem.TabIndex = 27
        Me.btnItem.Text = "ITEM"
        '
        'btnBQuery
        '
        Me.btnBQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBQuery.Location = New System.Drawing.Point(24, 200)
        Me.btnBQuery.Name = "btnBQuery"
        Me.btnBQuery.Size = New System.Drawing.Size(216, 32)
        Me.btnBQuery.TabIndex = 16
        Me.btnBQuery.Text = "BARCODE QUERY"
        '
        'btnBRem
        '
        Me.btnBRem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBRem.Location = New System.Drawing.Point(24, 80)
        Me.btnBRem.Name = "btnBRem"
        Me.btnBRem.Size = New System.Drawing.Size(216, 32)
        Me.btnBRem.TabIndex = 14
        Me.btnBRem.Text = "BATCH RECEIVING"
        '
        'btnIREM
        '
        Me.btnIREM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIREM.Location = New System.Drawing.Point(24, 120)
        Me.btnIREM.Name = "btnIREM"
        Me.btnIREM.Size = New System.Drawing.Size(216, 32)
        Me.btnIREM.TabIndex = 13
        Me.btnIREM.Text = "RECEIVE PTN INDIVIDUALLY"
        '
        'btnReceivingReport
        '
        Me.btnReceivingReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceivingReport.Location = New System.Drawing.Point(24, 160)
        Me.btnReceivingReport.Name = "btnReceivingReport"
        Me.btnReceivingReport.Size = New System.Drawing.Size(216, 32)
        Me.btnReceivingReport.TabIndex = 12
        Me.btnReceivingReport.Text = "RECEIVING REPORT"
        '
        'btnPTQuery
        '
        Me.btnPTQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPTQuery.Location = New System.Drawing.Point(24, 240)
        Me.btnPTQuery.Name = "btnPTQuery"
        Me.btnPTQuery.Size = New System.Drawing.Size(216, 32)
        Me.btnPTQuery.TabIndex = 11
        Me.btnPTQuery.Text = "PTQUERY"
        '
        'btnReceivingByBranch
        '
        Me.btnReceivingByBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceivingByBranch.Location = New System.Drawing.Point(616, 80)
        Me.btnReceivingByBranch.Name = "btnReceivingByBranch"
        Me.btnReceivingByBranch.Size = New System.Drawing.Size(216, 32)
        Me.btnReceivingByBranch.TabIndex = 10
        Me.btnReceivingByBranch.Text = "Receiving by Branch"
        '
        'btnBatchReceive
        '
        Me.btnBatchReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBatchReceive.Location = New System.Drawing.Point(616, 40)
        Me.btnBatchReceive.Name = "btnBatchReceive"
        Me.btnBatchReceive.Size = New System.Drawing.Size(216, 32)
        Me.btnBatchReceive.TabIndex = 9
        Me.btnBatchReceive.Text = "Batch Receiving"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ACTION"
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(1032, 447)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "RELEASING"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnREMrecode)
        Me.TabPage2.Controls.Add(Me.btnPhoto)
        Me.TabPage2.Controls.Add(Me.Button23)
        Me.TabPage2.Controls.Add(Me.Button5)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1032, 447)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PROCESS"
        Me.TabPage2.Visible = False
        '
        'btnREMrecode
        '
        Me.btnREMrecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnREMrecode.Location = New System.Drawing.Point(8, 160)
        Me.btnREMrecode.Name = "btnREMrecode"
        Me.btnREMrecode.Size = New System.Drawing.Size(216, 32)
        Me.btnREMrecode.TabIndex = 32
        Me.btnREMrecode.Text = "RECODE"
        '
        'btnPhoto
        '
        Me.btnPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPhoto.Location = New System.Drawing.Point(8, 80)
        Me.btnPhoto.Name = "btnPhoto"
        Me.btnPhoto.Size = New System.Drawing.Size(216, 32)
        Me.btnPhoto.TabIndex = 25
        Me.btnPhoto.Text = "PHOTO"
        '
        'Button23
        '
        Me.Button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button23.Location = New System.Drawing.Point(8, 200)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(216, 32)
        Me.Button23.TabIndex = 22
        Me.Button23.Text = "SORTED LIST"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(8, 120)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(216, 32)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "COSTING"
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(8, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(216, 32)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "SORTING"
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.btnUnReleased)
        Me.TabPage6.Controls.Add(Me.btnReleased)
        Me.TabPage6.Controls.Add(Me.btnUnReceived)
        Me.TabPage6.Controls.Add(Me.btnReceived)
        Me.TabPage6.Controls.Add(Me.btnIR)
        Me.TabPage6.Controls.Add(Me.Button31)
        Me.TabPage6.Controls.Add(Me.Button30)
        Me.TabPage6.Controls.Add(Me.Button29)
        Me.TabPage6.Controls.Add(Me.Label9)
        Me.TabPage6.Controls.Add(Me.Label8)
        Me.TabPage6.Controls.Add(Me.Button26)
        Me.TabPage6.Controls.Add(Me.Button25)
        Me.TabPage6.Controls.Add(Me.Button24)
        Me.TabPage6.Controls.Add(Me.Button28)
        Me.TabPage6.Controls.Add(Me.Button27)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(1032, 447)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "LIST/MEMO"
        Me.TabPage6.Visible = False
        '
        'btnUnReleased
        '
        Me.btnUnReleased.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnReleased.Location = New System.Drawing.Point(608, 152)
        Me.btnUnReleased.Name = "btnUnReleased"
        Me.btnUnReleased.Size = New System.Drawing.Size(216, 32)
        Me.btnUnReleased.TabIndex = 31
        Me.btnUnReleased.Text = "SUMMARY OF UNRELEASED BRANCHES"
        '
        'btnReleased
        '
        Me.btnReleased.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReleased.Location = New System.Drawing.Point(608, 112)
        Me.btnReleased.Name = "btnReleased"
        Me.btnReleased.Size = New System.Drawing.Size(216, 32)
        Me.btnReleased.TabIndex = 30
        Me.btnReleased.Text = "SUMMARY OF RELEASED BRANCHES"
        '
        'btnUnReceived
        '
        Me.btnUnReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnReceived.Location = New System.Drawing.Point(608, 72)
        Me.btnUnReceived.Name = "btnUnReceived"
        Me.btnUnReceived.Size = New System.Drawing.Size(216, 32)
        Me.btnUnReceived.TabIndex = 29
        Me.btnUnReceived.Text = "SUMMARY OF UNRECEIVED BRANCHES"
        '
        'btnReceived
        '
        Me.btnReceived.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceived.Location = New System.Drawing.Point(608, 32)
        Me.btnReceived.Name = "btnReceived"
        Me.btnReceived.Size = New System.Drawing.Size(216, 32)
        Me.btnReceived.TabIndex = 28
        Me.btnReceived.Text = "SUMMARY OF RECEIVED BRANCHES"
        '
        'btnIR
        '
        Me.btnIR.Enabled = False
        Me.btnIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIR.Location = New System.Drawing.Point(16, 192)
        Me.btnIR.Name = "btnIR"
        Me.btnIR.Size = New System.Drawing.Size(216, 32)
        Me.btnIR.TabIndex = 23
        Me.btnIR.Text = "INCIDENT REPORT/IR"
        '
        'Button31
        '
        Me.Button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button31.Location = New System.Drawing.Point(336, 112)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(216, 32)
        Me.Button31.TabIndex = 22
        Me.Button31.Text = "SUMMARY GOOD STOCKS"
        '
        'Button30
        '
        Me.Button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button30.Location = New System.Drawing.Point(336, 72)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(216, 32)
        Me.Button30.TabIndex = 21
        Me.Button30.Text = "SUMMARY WATCHES"
        '
        'Button29
        '
        Me.Button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button29.Location = New System.Drawing.Point(336, 32)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(216, 32)
        Me.Button29.TabIndex = 20
        Me.Button29.Text = "SUMMARY CELL"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(328, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "SUMMARY"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "MEMO"
        '
        'Button26
        '
        Me.Button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button26.Location = New System.Drawing.Point(16, 152)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(216, 32)
        Me.Button26.TabIndex = 12
        Me.Button26.Text = "HR MEMO OVER APPRAISED"
        '
        'Button25
        '
        Me.Button25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button25.Location = New System.Drawing.Point(16, 112)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(216, 32)
        Me.Button25.TabIndex = 11
        Me.Button25.Text = "HR MEMO COATED"
        '
        'Button24
        '
        Me.Button24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button24.Location = New System.Drawing.Point(16, 72)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(216, 32)
        Me.Button24.TabIndex = 10
        Me.Button24.Text = "HR MEMO FAKE"
        '
        'Button28
        '
        Me.Button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button28.Location = New System.Drawing.Point(16, 72)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(216, 32)
        Me.Button28.TabIndex = 9
        Me.Button28.Text = "GM Memo Appliance"
        Me.Button28.Visible = False
        '
        'Button27
        '
        Me.Button27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button27.Location = New System.Drawing.Point(16, 32)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(216, 32)
        Me.Button27.TabIndex = 8
        Me.Button27.Text = "HR MEMO MISSING ITEM"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnSumProcessTWT)
        Me.TabPage5.Controls.Add(Me.btnProcessQty)
        Me.TabPage5.Controls.Add(Me.btnTop)
        Me.TabPage5.Controls.Add(Me.btnVM)
        Me.TabPage5.Controls.Add(Me.btnTopBranch)
        Me.TabPage5.Controls.Add(Me.btnCVismin)
        Me.TabPage5.Controls.Add(Me.btnCLuzon)
        Me.TabPage5.Controls.Add(Me.btnComparative)
        Me.TabPage5.Controls.Add(Me.Label2)
        Me.TabPage5.Controls.Add(Me.Button36)
        Me.TabPage5.Controls.Add(Me.Button35)
        Me.TabPage5.Controls.Add(Me.Button34)
        Me.TabPage5.Controls.Add(Me.Button33)
        Me.TabPage5.Controls.Add(Me.Button13)
        Me.TabPage5.Controls.Add(Me.Button12)
        Me.TabPage5.Controls.Add(Me.Button11)
        Me.TabPage5.Controls.Add(Me.Button10)
        Me.TabPage5.Controls.Add(Me.btnSumProcessTREM)
        Me.TabPage5.Controls.Add(Me.btnSUmProcessTPrenda)
        Me.TabPage5.Controls.Add(Me.btnSumProcessLoan)
        Me.TabPage5.Controls.Add(Me.btnSumProcessAveWT)
        Me.TabPage5.Controls.Add(Me.Button22)
        Me.TabPage5.Controls.Add(Me.Button20)
        Me.TabPage5.Controls.Add(Me.Button21)
        Me.TabPage5.Controls.Add(Me.Button16)
        Me.TabPage5.Controls.Add(Me.Button17)
        Me.TabPage5.Controls.Add(Me.Button14)
        Me.TabPage5.Controls.Add(Me.Button19)
        Me.TabPage5.Controls.Add(Me.Button18)
        Me.TabPage5.Controls.Add(Me.Button15)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1032, 447)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "REPORTS"
        Me.TabPage5.Visible = False
        '
        'btnSumProcessTWT
        '
        Me.btnSumProcessTWT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSumProcessTWT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSumProcessTWT.Location = New System.Drawing.Point(248, 64)
        Me.btnSumProcessTWT.Name = "btnSumProcessTWT"
        Me.btnSumProcessTWT.Size = New System.Drawing.Size(216, 32)
        Me.btnSumProcessTWT.TabIndex = 25
        Me.btnSumProcessTWT.Text = "REM PROCESS SUMMARY TWT"
        Me.btnSumProcessTWT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnProcessQty
        '
        Me.btnProcessQty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcessQty.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcessQty.Location = New System.Drawing.Point(248, 32)
        Me.btnProcessQty.Name = "btnProcessQty"
        Me.btnProcessQty.Size = New System.Drawing.Size(216, 32)
        Me.btnProcessQty.TabIndex = 24
        Me.btnProcessQty.Text = "REM PROCESS SUMMARY QTY/PCS"
        Me.btnProcessQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnTop
        '
        Me.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTop.Location = New System.Drawing.Point(16, 208)
        Me.btnTop.Name = "btnTop"
        Me.btnTop.Size = New System.Drawing.Size(216, 32)
        Me.btnTop.TabIndex = 23
        Me.btnTop.Text = "TOP 10 BRANCHES"
        '
        'btnVM
        '
        Me.btnVM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVM.Location = New System.Drawing.Point(248, 208)
        Me.btnVM.Name = "btnVM"
        Me.btnVM.Size = New System.Drawing.Size(216, 32)
        Me.btnVM.TabIndex = 22
        Me.btnVM.Text = "LUZON AND VISMIN MONTHLY COMPARATIVE REPORT"
        '
        'btnTopBranch
        '
        Me.btnTopBranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTopBranch.Location = New System.Drawing.Point(16, 176)
        Me.btnTopBranch.Name = "btnTopBranch"
        Me.btnTopBranch.Size = New System.Drawing.Size(216, 32)
        Me.btnTopBranch.TabIndex = 21
        Me.btnTopBranch.Text = "TOP 10 BRANCHES LUZON, VISMIN AND SHOWROOM"
        '
        'btnCVismin
        '
        Me.btnCVismin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCVismin.Location = New System.Drawing.Point(248, 240)
        Me.btnCVismin.Name = "btnCVismin"
        Me.btnCVismin.Size = New System.Drawing.Size(216, 32)
        Me.btnCVismin.TabIndex = 20
        Me.btnCVismin.Text = "COMPARATIVE REPORT VISMIN"
        '
        'btnCLuzon
        '
        Me.btnCLuzon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCLuzon.Location = New System.Drawing.Point(248, 240)
        Me.btnCLuzon.Name = "btnCLuzon"
        Me.btnCLuzon.Size = New System.Drawing.Size(216, 32)
        Me.btnCLuzon.TabIndex = 19
        Me.btnCLuzon.Text = "COMPARATIVE REPORT LUZON"
        '
        'btnComparative
        '
        Me.btnComparative.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComparative.Location = New System.Drawing.Point(248, 176)
        Me.btnComparative.Name = "btnComparative"
        Me.btnComparative.Size = New System.Drawing.Size(216, 32)
        Me.btnComparative.TabIndex = 18
        Me.btnComparative.Text = "COMPARATIVE REPORT LUZON, VISMIN AND SHOWROOM"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "ACTION"
        '
        'Button36
        '
        Me.Button36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button36.Location = New System.Drawing.Point(480, 64)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(216, 32)
        Me.Button36.TabIndex = 15
        Me.Button36.Text = "COMPARATIVE FAKE, COATED"
        Me.Button36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button35
        '
        Me.Button35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button35.Location = New System.Drawing.Point(480, 96)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(216, 32)
        Me.Button35.TabIndex = 16
        Me.Button35.Text = "COMPARATIVE CELL, WATCH, APPLIANCE"
        '
        'Button34
        '
        Me.Button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button34.Location = New System.Drawing.Point(480, 32)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(216, 32)
        Me.Button34.TabIndex = 14
        Me.Button34.Text = "COMPARATIVE OVER APPRAISED"
        Me.Button34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button33
        '
        Me.Button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button33.Location = New System.Drawing.Point(480, 32)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(216, 32)
        Me.Button33.TabIndex = 13
        Me.Button33.Text = "Comparative Ave. Wt"
        Me.Button33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button13
        '
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Location = New System.Drawing.Point(16, 96)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(216, 32)
        Me.Button13.TabIndex = 10
        Me.Button13.Text = "REM PROCESS LOAN"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button12
        '
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Location = New System.Drawing.Point(16, 96)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(216, 32)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "REM Process Ave WT"
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(16, 64)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(216, 32)
        Me.Button11.TabIndex = 8
        Me.Button11.Text = "REM PROCESS TWT"
        Me.Button11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(16, 32)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(216, 32)
        Me.Button10.TabIndex = 7
        Me.Button10.Text = "REM PROCESS QTY/PCS"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSumProcessTREM
        '
        Me.btnSumProcessTREM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSumProcessTREM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSumProcessTREM.Location = New System.Drawing.Point(248, 32)
        Me.btnSumProcessTREM.Name = "btnSumProcessTREM"
        Me.btnSumProcessTREM.Size = New System.Drawing.Size(216, 32)
        Me.btnSumProcessTREM.TabIndex = 28
        Me.btnSumProcessTREM.Text = "REM Process Summary % to Total REM"
        Me.btnSumProcessTREM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSUmProcessTPrenda
        '
        Me.btnSUmProcessTPrenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSUmProcessTPrenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSUmProcessTPrenda.Location = New System.Drawing.Point(248, 64)
        Me.btnSUmProcessTPrenda.Name = "btnSUmProcessTPrenda"
        Me.btnSUmProcessTPrenda.Size = New System.Drawing.Size(216, 32)
        Me.btnSUmProcessTPrenda.TabIndex = 29
        Me.btnSUmProcessTPrenda.Text = "REM Process Summary % to Total Prenda"
        Me.btnSUmProcessTPrenda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSumProcessLoan
        '
        Me.btnSumProcessLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSumProcessLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSumProcessLoan.Location = New System.Drawing.Point(248, 96)
        Me.btnSumProcessLoan.Name = "btnSumProcessLoan"
        Me.btnSumProcessLoan.Size = New System.Drawing.Size(216, 32)
        Me.btnSumProcessLoan.TabIndex = 27
        Me.btnSumProcessLoan.Text = "REM PROCESS SUMMARY LOAN"
        Me.btnSumProcessLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSumProcessAveWT
        '
        Me.btnSumProcessAveWT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSumProcessAveWT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSumProcessAveWT.Location = New System.Drawing.Point(248, 96)
        Me.btnSumProcessAveWT.Name = "btnSumProcessAveWT"
        Me.btnSumProcessAveWT.Size = New System.Drawing.Size(216, 32)
        Me.btnSumProcessAveWT.TabIndex = 26
        Me.btnSumProcessAveWT.Text = "REM Process Summary Ave. WT"
        Me.btnSumProcessAveWT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button22
        '
        Me.Button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button22.Location = New System.Drawing.Point(16, 128)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(216, 32)
        Me.Button22.TabIndex = 6
        Me.Button22.Text = "REM JEWELRY SUMMARY"
        Me.Button22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button20
        '
        Me.Button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button20.Location = New System.Drawing.Point(16, 64)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(216, 32)
        Me.Button20.TabIndex = 4
        Me.Button20.Text = "REM Jewelry % to Total REM"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button20.Visible = False
        '
        'Button21
        '
        Me.Button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button21.Location = New System.Drawing.Point(16, 96)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(216, 32)
        Me.Button21.TabIndex = 5
        Me.Button21.Text = "REM Jewelry % to Total Prenda"
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button21.Visible = False
        '
        'Button16
        '
        Me.Button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button16.Location = New System.Drawing.Point(16, 32)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(216, 32)
        Me.Button16.TabIndex = 0
        Me.Button16.Text = "REM Jewelry Qty/Pcs"
        Me.Button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button16.Visible = False
        '
        'Button17
        '
        Me.Button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button17.Location = New System.Drawing.Point(16, 64)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(216, 32)
        Me.Button17.TabIndex = 1
        Me.Button17.Text = "REM Jewelry TWT"
        Me.Button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button17.Visible = False
        '
        'Button14
        '
        Me.Button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button14.Location = New System.Drawing.Point(16, 64)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(216, 32)
        Me.Button14.TabIndex = 11
        Me.Button14.Text = "REM Process % to Total REM"
        Me.Button14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button19
        '
        Me.Button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button19.Location = New System.Drawing.Point(16, 96)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(216, 32)
        Me.Button19.TabIndex = 3
        Me.Button19.Text = "REM Jewelry LOAN"
        Me.Button19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button19.Visible = False
        '
        'Button18
        '
        Me.Button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button18.Location = New System.Drawing.Point(16, 96)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(216, 32)
        Me.Button18.TabIndex = 2
        Me.Button18.Text = "REM Jewelry Ave. Wt."
        Me.Button18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button18.Visible = False
        '
        'Button15
        '
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(16, 96)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(216, 32)
        Me.Button15.TabIndex = 12
        Me.Button15.Text = "REM Process % to Total Prenda"
        Me.Button15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnREMSInventory)
        Me.TabPage3.Controls.Add(Me.btnPicEdit)
        Me.TabPage3.Controls.Add(Me.btnALLSearch)
        Me.TabPage3.Controls.Add(Me.btnBranchSearch)
        Me.TabPage3.Controls.Add(Me.btnMemoReceiver)
        Me.TabPage3.Controls.Add(Me.btnJewelryClass)
        Me.TabPage3.Controls.Add(Me.btnActionClass)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1032, 447)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "REM: SYSTEM"
        Me.TabPage3.Visible = False
        '
        'btnREMSInventory
        '
        Me.btnREMSInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnREMSInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnREMSInventory.Location = New System.Drawing.Point(288, 8)
        Me.btnREMSInventory.Name = "btnREMSInventory"
        Me.btnREMSInventory.Size = New System.Drawing.Size(216, 32)
        Me.btnREMSInventory.TabIndex = 116
        Me.btnREMSInventory.Text = "SELF INVENTORY"
        '
        'btnPicEdit
        '
        Me.btnPicEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPicEdit.Location = New System.Drawing.Point(8, 168)
        Me.btnPicEdit.Name = "btnPicEdit"
        Me.btnPicEdit.Size = New System.Drawing.Size(216, 32)
        Me.btnPicEdit.TabIndex = 115
        Me.btnPicEdit.Text = "EDIT PICTURE"
        '
        'btnALLSearch
        '
        Me.btnALLSearch.Enabled = False
        Me.btnALLSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnALLSearch.Location = New System.Drawing.Point(8, 208)
        Me.btnALLSearch.Name = "btnALLSearch"
        Me.btnALLSearch.Size = New System.Drawing.Size(216, 32)
        Me.btnALLSearch.TabIndex = 114
        Me.btnALLSearch.Text = "SEARCH MAXIMUM A.L.L. BARCODE"
        '
        'btnBranchSearch
        '
        Me.btnBranchSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBranchSearch.Location = New System.Drawing.Point(8, 128)
        Me.btnBranchSearch.Name = "btnBranchSearch"
        Me.btnBranchSearch.Size = New System.Drawing.Size(216, 32)
        Me.btnBranchSearch.TabIndex = 113
        Me.btnBranchSearch.Text = "BRANCH SEARCH"
        '
        'btnMemoReceiver
        '
        Me.btnMemoReceiver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMemoReceiver.Location = New System.Drawing.Point(8, 88)
        Me.btnMemoReceiver.Name = "btnMemoReceiver"
        Me.btnMemoReceiver.Size = New System.Drawing.Size(216, 32)
        Me.btnMemoReceiver.TabIndex = 112
        Me.btnMemoReceiver.Text = "MEMO RECEIVER"
        '
        'btnJewelryClass
        '
        Me.btnJewelryClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJewelryClass.Location = New System.Drawing.Point(8, 48)
        Me.btnJewelryClass.Name = "btnJewelryClass"
        Me.btnJewelryClass.Size = New System.Drawing.Size(216, 32)
        Me.btnJewelryClass.TabIndex = 9
        Me.btnJewelryClass.Text = "JEWELRY CLASS"
        '
        'btnActionClass
        '
        Me.btnActionClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActionClass.Location = New System.Drawing.Point(8, 8)
        Me.btnActionClass.Name = "btnActionClass"
        Me.btnActionClass.Size = New System.Drawing.Size(216, 32)
        Me.btnActionClass.TabIndex = 8
        Me.btnActionClass.Text = "ACTION CLASS"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.btnMSInventory)
        Me.TabPage8.Controls.Add(Me.btnEditItem)
        Me.TabPage8.Controls.Add(Me.btnvwbar)
        Me.TabPage8.Controls.Add(Me.btnRMLWB)
        Me.TabPage8.Controls.Add(Me.btnBMLWB)
        Me.TabPage8.Controls.Add(Me.btnInventory)
        Me.TabPage8.Location = New System.Drawing.Point(4, 25)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(1024, 475)
        Me.TabPage8.TabIndex = 10
        Me.TabPage8.Text = "MLWB"
        '
        'btnMSInventory
        '
        Me.btnMSInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMSInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMSInventory.Location = New System.Drawing.Point(8, 168)
        Me.btnMSInventory.Name = "btnMSInventory"
        Me.btnMSInventory.Size = New System.Drawing.Size(216, 32)
        Me.btnMSInventory.TabIndex = 17
        Me.btnMSInventory.Text = "SELF INVENTORY"
        '
        'btnEditItem
        '
        Me.btnEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditItem.Location = New System.Drawing.Point(8, 48)
        Me.btnEditItem.Name = "btnEditItem"
        Me.btnEditItem.Size = New System.Drawing.Size(216, 32)
        Me.btnEditItem.TabIndex = 15
        Me.btnEditItem.Text = "EDIT ITEM"
        '
        'btnvwbar
        '
        Me.btnvwbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvwbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvwbar.Location = New System.Drawing.Point(8, 128)
        Me.btnvwbar.Name = "btnvwbar"
        Me.btnvwbar.Size = New System.Drawing.Size(216, 32)
        Me.btnvwbar.TabIndex = 14
        Me.btnvwbar.Text = "VIEW A.L.L. BARCODE DETAILS"
        '
        'btnRMLWB
        '
        Me.btnRMLWB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRMLWB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRMLWB.Location = New System.Drawing.Point(8, 88)
        Me.btnRMLWB.Name = "btnRMLWB"
        Me.btnRMLWB.Size = New System.Drawing.Size(216, 32)
        Me.btnRMLWB.TabIndex = 13
        Me.btnRMLWB.Text = "RELEASING"
        '
        'btnBMLWB
        '
        Me.btnBMLWB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBMLWB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBMLWB.Location = New System.Drawing.Point(8, 8)
        Me.btnBMLWB.Name = "btnBMLWB"
        Me.btnBMLWB.Size = New System.Drawing.Size(216, 32)
        Me.btnBMLWB.TabIndex = 12
        Me.btnBMLWB.Text = "RECEIVING"
        '
        'btnInventory
        '
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.Location = New System.Drawing.Point(8, 128)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(216, 32)
        Me.btnInventory.TabIndex = 16
        Me.btnInventory.Text = "Inventory by Custodian"
        '
        'TabPricing
        '
        Me.TabPricing.Controls.Add(Me.btnPSInventory)
        Me.TabPricing.Controls.Add(Me.btnvwPrice)
        Me.TabPricing.Controls.Add(Me.btnPRIVW)
        Me.TabPricing.Controls.Add(Me.btnRPRICING)
        Me.TabPricing.Controls.Add(Me.btnBPRICING)
        Me.TabPricing.Controls.Add(Me.btnPricing)
        Me.TabPricing.Controls.Add(Me.btnInvPricing)
        Me.TabPricing.Location = New System.Drawing.Point(4, 25)
        Me.TabPricing.Name = "TabPricing"
        Me.TabPricing.Size = New System.Drawing.Size(1024, 475)
        Me.TabPricing.TabIndex = 8
        Me.TabPricing.Text = "PRICING"
        '
        'btnPSInventory
        '
        Me.btnPSInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPSInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPSInventory.Location = New System.Drawing.Point(8, 208)
        Me.btnPSInventory.Name = "btnPSInventory"
        Me.btnPSInventory.Size = New System.Drawing.Size(216, 32)
        Me.btnPSInventory.TabIndex = 19
        Me.btnPSInventory.Text = "SELF INVENTORY"
        '
        'btnvwPrice
        '
        Me.btnvwPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnvwPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvwPrice.Location = New System.Drawing.Point(8, 128)
        Me.btnvwPrice.Name = "btnvwPrice"
        Me.btnvwPrice.Size = New System.Drawing.Size(216, 32)
        Me.btnvwPrice.TabIndex = 17
        Me.btnvwPrice.Text = "VIEW PRICED ITEM"
        '
        'btnPRIVW
        '
        Me.btnPRIVW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPRIVW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPRIVW.Location = New System.Drawing.Point(8, 168)
        Me.btnPRIVW.Name = "btnPRIVW"
        Me.btnPRIVW.Size = New System.Drawing.Size(216, 32)
        Me.btnPRIVW.TabIndex = 16
        Me.btnPRIVW.Text = "VIEW A.L.L. BARCODE DETAILS"
        '
        'btnRPRICING
        '
        Me.btnRPRICING.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRPRICING.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRPRICING.Location = New System.Drawing.Point(8, 88)
        Me.btnRPRICING.Name = "btnRPRICING"
        Me.btnRPRICING.Size = New System.Drawing.Size(216, 32)
        Me.btnRPRICING.TabIndex = 15
        Me.btnRPRICING.Text = "RELEASING"
        '
        'btnBPRICING
        '
        Me.btnBPRICING.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBPRICING.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBPRICING.Location = New System.Drawing.Point(8, 8)
        Me.btnBPRICING.Name = "btnBPRICING"
        Me.btnBPRICING.Size = New System.Drawing.Size(216, 32)
        Me.btnBPRICING.TabIndex = 14
        Me.btnBPRICING.Text = "RECEIVING"
        '
        'btnPricing
        '
        Me.btnPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPricing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPricing.Location = New System.Drawing.Point(8, 48)
        Me.btnPricing.Name = "btnPricing"
        Me.btnPricing.Size = New System.Drawing.Size(216, 32)
        Me.btnPricing.TabIndex = 0
        Me.btnPricing.Text = "PRICING"
        '
        'btnInvPricing
        '
        Me.btnInvPricing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInvPricing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInvPricing.Location = New System.Drawing.Point(8, 128)
        Me.btnInvPricing.Name = "btnInvPricing"
        Me.btnInvPricing.Size = New System.Drawing.Size(216, 32)
        Me.btnInvPricing.TabIndex = 18
        Me.btnInvPricing.Text = "Inventory by Custodian"
        '
        'TabDistri
        '
        Me.TabDistri.Controls.Add(Me.btnDistriSInventory)
        Me.TabDistri.Controls.Add(Me.btnview)
        Me.TabDistri.Controls.Add(Me.btnCreateInfo)
        Me.TabDistri.Controls.Add(Me.btnRDISTRI)
        Me.TabDistri.Controls.Add(Me.btnBDISTRI)
        Me.TabDistri.Controls.Add(Me.btnDistri)
        Me.TabDistri.Controls.Add(Me.btnDistriInventory)
        Me.TabDistri.Location = New System.Drawing.Point(4, 25)
        Me.TabDistri.Name = "TabDistri"
        Me.TabDistri.Size = New System.Drawing.Size(1024, 475)
        Me.TabDistri.TabIndex = 1
        Me.TabDistri.Text = "DISTRIBUTION"
        '
        'btnDistriSInventory
        '
        Me.btnDistriSInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDistriSInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDistriSInventory.Location = New System.Drawing.Point(8, 208)
        Me.btnDistriSInventory.Name = "btnDistriSInventory"
        Me.btnDistriSInventory.Size = New System.Drawing.Size(216, 32)
        Me.btnDistriSInventory.TabIndex = 21
        Me.btnDistriSInventory.Text = "SELF INVENTORY"
        '
        'btnview
        '
        Me.btnview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.Location = New System.Drawing.Point(8, 168)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(216, 32)
        Me.btnview.TabIndex = 20
        Me.btnview.Text = "VIEW A.L.L. BARCODE DETAILS"
        '
        'btnCreateInfo
        '
        Me.btnCreateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateInfo.Location = New System.Drawing.Point(8, 88)
        Me.btnCreateInfo.Name = "btnCreateInfo"
        Me.btnCreateInfo.Size = New System.Drawing.Size(216, 32)
        Me.btnCreateInfo.TabIndex = 18
        Me.btnCreateInfo.Text = "CREATE CUSTOMER OR BRANCH ADDRESS"
        '
        'btnRDISTRI
        '
        Me.btnRDISTRI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRDISTRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRDISTRI.Location = New System.Drawing.Point(8, 128)
        Me.btnRDISTRI.Name = "btnRDISTRI"
        Me.btnRDISTRI.Size = New System.Drawing.Size(216, 32)
        Me.btnRDISTRI.TabIndex = 17
        Me.btnRDISTRI.Text = "RELEASING"
        '
        'btnBDISTRI
        '
        Me.btnBDISTRI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBDISTRI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDISTRI.Location = New System.Drawing.Point(8, 8)
        Me.btnBDISTRI.Name = "btnBDISTRI"
        Me.btnBDISTRI.Size = New System.Drawing.Size(216, 32)
        Me.btnBDISTRI.TabIndex = 16
        Me.btnBDISTRI.Text = "RECEIVING"
        '
        'btnDistri
        '
        Me.btnDistri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDistri.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDistri.Location = New System.Drawing.Point(8, 48)
        Me.btnDistri.Name = "btnDistri"
        Me.btnDistri.Size = New System.Drawing.Size(216, 32)
        Me.btnDistri.TabIndex = 12
        Me.btnDistri.Text = "CONSIGNMENT"
        '
        'btnDistriInventory
        '
        Me.btnDistriInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDistriInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDistriInventory.Location = New System.Drawing.Point(8, 88)
        Me.btnDistriInventory.Name = "btnDistriInventory"
        Me.btnDistriInventory.Size = New System.Drawing.Size(216, 32)
        Me.btnDistriInventory.TabIndex = 19
        Me.btnDistriInventory.Text = " Inventory  by Custodian"
        '
        'TabShowroom
        '
        Me.TabShowroom.Location = New System.Drawing.Point(4, 25)
        Me.TabShowroom.Name = "TabShowroom"
        Me.TabShowroom.Size = New System.Drawing.Size(1024, 475)
        Me.TabShowroom.TabIndex = 5
        Me.TabShowroom.Text = "SHOWROOM"
        '
        'TabReports
        '
        Me.TabReports.Controls.Add(Me.btnSelfInven)
        Me.TabReports.Controls.Add(Me.btnREMInventory)
        Me.TabReports.Controls.Add(Me.Inventory)
        Me.TabReports.Location = New System.Drawing.Point(4, 25)
        Me.TabReports.Name = "TabReports"
        Me.TabReports.Size = New System.Drawing.Size(1024, 475)
        Me.TabReports.TabIndex = 6
        Me.TabReports.Text = "REPORTS"
        '
        'btnSelfInven
        '
        Me.btnSelfInven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelfInven.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelfInven.Location = New System.Drawing.Point(8, 48)
        Me.btnSelfInven.Name = "btnSelfInven"
        Me.btnSelfInven.Size = New System.Drawing.Size(216, 32)
        Me.btnSelfInven.TabIndex = 3
        Me.btnSelfInven.Text = "SELF INVENTORY"
        '
        'btnREMInventory
        '
        Me.btnREMInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnREMInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnREMInventory.Location = New System.Drawing.Point(8, 88)
        Me.btnREMInventory.Name = "btnREMInventory"
        Me.btnREMInventory.Size = New System.Drawing.Size(216, 32)
        Me.btnREMInventory.TabIndex = 2
        Me.btnREMInventory.Text = "REM INVENTORY"
        Me.btnREMInventory.Visible = False
        '
        'Inventory
        '
        Me.Inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Inventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inventory.Location = New System.Drawing.Point(8, 8)
        Me.Inventory.Name = "Inventory"
        Me.Inventory.Size = New System.Drawing.Size(216, 32)
        Me.Inventory.TabIndex = 1
        Me.Inventory.Text = "INVENTORY"
        '
        'TabSystem
        '
        Me.TabSystem.Controls.Add(Me.btnStonePrice)
        Me.TabSystem.Controls.Add(Me.btnPearlPrice)
        Me.TabSystem.Controls.Add(Me.btnCDPrice)
        Me.TabSystem.Controls.Add(Me.btnCGPrice)
        Me.TabSystem.Controls.Add(Me.btnBarcodeUtil)
        Me.TabSystem.Controls.Add(Me.btnUpdateHumres)
        Me.TabSystem.Controls.Add(Me.btnUpdateBedryf)
        Me.TabSystem.Controls.Add(Me.btnHistoryB)
        Me.TabSystem.Controls.Add(Me.Consignee)
        Me.TabSystem.Location = New System.Drawing.Point(4, 25)
        Me.TabSystem.Name = "TabSystem"
        Me.TabSystem.Size = New System.Drawing.Size(1024, 475)
        Me.TabSystem.TabIndex = 7
        Me.TabSystem.Text = "SYSTEM"
        '
        'btnStonePrice
        '
        Me.btnStonePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStonePrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStonePrice.Location = New System.Drawing.Point(8, 176)
        Me.btnStonePrice.Name = "btnStonePrice"
        Me.btnStonePrice.Size = New System.Drawing.Size(216, 32)
        Me.btnStonePrice.TabIndex = 11
        Me.btnStonePrice.Text = "CHANGE STONE PRICE"
        '
        'btnPearlPrice
        '
        Me.btnPearlPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPearlPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPearlPrice.Location = New System.Drawing.Point(8, 136)
        Me.btnPearlPrice.Name = "btnPearlPrice"
        Me.btnPearlPrice.Size = New System.Drawing.Size(216, 32)
        Me.btnPearlPrice.TabIndex = 10
        Me.btnPearlPrice.Text = "CHANGE PEARL PRICE"
        '
        'btnCDPrice
        '
        Me.btnCDPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCDPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCDPrice.Location = New System.Drawing.Point(8, 96)
        Me.btnCDPrice.Name = "btnCDPrice"
        Me.btnCDPrice.Size = New System.Drawing.Size(216, 32)
        Me.btnCDPrice.TabIndex = 9
        Me.btnCDPrice.Text = "CHANGE DIAMOND PRICE"
        '
        'btnCGPrice
        '
        Me.btnCGPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCGPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCGPrice.Location = New System.Drawing.Point(8, 56)
        Me.btnCGPrice.Name = "btnCGPrice"
        Me.btnCGPrice.Size = New System.Drawing.Size(216, 32)
        Me.btnCGPrice.TabIndex = 8
        Me.btnCGPrice.Text = "CHANGE GOLD PRICE"
        '
        'btnBarcodeUtil
        '
        Me.btnBarcodeUtil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarcodeUtil.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarcodeUtil.Location = New System.Drawing.Point(328, 16)
        Me.btnBarcodeUtil.Name = "btnBarcodeUtil"
        Me.btnBarcodeUtil.Size = New System.Drawing.Size(216, 32)
        Me.btnBarcodeUtil.TabIndex = 7
        Me.btnBarcodeUtil.Text = "RECODE BARCODE UTILITY"
        '
        'btnUpdateHumres
        '
        Me.btnUpdateHumres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateHumres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateHumres.Location = New System.Drawing.Point(328, 136)
        Me.btnUpdateHumres.Name = "btnUpdateHumres"
        Me.btnUpdateHumres.Size = New System.Drawing.Size(216, 32)
        Me.btnUpdateHumres.TabIndex = 6
        Me.btnUpdateHumres.Text = "UPDATE HUMRES"
        '
        'btnUpdateBedryf
        '
        Me.btnUpdateBedryf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateBedryf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBedryf.Location = New System.Drawing.Point(328, 96)
        Me.btnUpdateBedryf.Name = "btnUpdateBedryf"
        Me.btnUpdateBedryf.Size = New System.Drawing.Size(216, 32)
        Me.btnUpdateBedryf.TabIndex = 5
        Me.btnUpdateBedryf.Text = "UPDATE BEDRYF"
        '
        'btnHistoryB
        '
        Me.btnHistoryB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistoryB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistoryB.Location = New System.Drawing.Point(8, 16)
        Me.btnHistoryB.Name = "btnHistoryB"
        Me.btnHistoryB.Size = New System.Drawing.Size(216, 32)
        Me.btnHistoryB.TabIndex = 4
        Me.btnHistoryB.Text = "BARCODE HISTORY"
        '
        'Consignee
        '
        Me.Consignee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Consignee.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Consignee.Location = New System.Drawing.Point(328, 56)
        Me.Consignee.Name = "Consignee"
        Me.Consignee.Size = New System.Drawing.Size(216, 32)
        Me.Consignee.TabIndex = 3
        Me.Consignee.Text = "CONSIGNEE"
        '
        'StatusBar1
        '
        Me.StatusBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusBar1.Location = New System.Drawing.Point(0, 504)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.userName, Me.StatusBarPanel1, Me.AccountStat, Me.StatusBarPanel2, Me.Dt, Me.StatusBarPanel3, Me.DTime, Me.StatusBarPanel4, Me.AllDept, Me.StatusBarPanel6})
        Me.StatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(1024, 16)
        Me.StatusBar1.TabIndex = 30
        Me.StatusBar1.Text = "StatusBar1"
        '
        'userName
        '
        Me.userName.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.userName.Icon = CType(resources.GetObject("userName.Icon"), System.Drawing.Icon)
        Me.userName.Text = "USERNAME:"
        Me.userName.Width = 119
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Width = 150
        '
        'AccountStat
        '
        Me.AccountStat.Text = "JOB TITLE:"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Width = 150
        '
        'Dt
        '
        Me.Dt.Text = "DATE:"
        Me.Dt.Width = 45
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Width = 150
        '
        'DTime
        '
        Me.DTime.Text = "TIME:"
        Me.DTime.Width = 50
        '
        'AllDept
        '
        Me.AllDept.Text = "A.L.L. DEPT:"
        '
        'StatusBarPanel6
        '
        Me.StatusBarPanel6.Width = 150
        '
        'Timer1
        '
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(1030, 520)
        Me.Controls.Add(Me.Receiving)
        Me.Controls.Add(Me.StatusBar1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASYS 5.2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Receiving.ResumeLayout(False)
        Me.TabRem.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPricing.ResumeLayout(False)
        Me.TabDistri.ResumeLayout(False)
        Me.TabReports.ResumeLayout(False)
        Me.TabSystem.ResumeLayout(False)
        CType(Me.userName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountStat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllDept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region " private declarations "
    Private objclass As New clsCommon
    Dim str As String
#End Region
#Region " UpdateBedryf"
    Private Sub callbedryfupdatevisayas()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            str = "exec UpdatebedryfVisayas"
            objclass.Command3(str)
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub callbedryfupdatemindanao()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            str = "exec UpdatebedryfMindanao"
            objclass.Command3(str)
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub callbedryfUpdateluzon()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            str = "Exec UpdateBedryfLuzon"
            objclass.Command3(str)
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception
        End Try
    End Sub
    Private Sub callbedryfUpdateShowroom()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            str = "Exec UpdateBedryfShowroom"
            objclass.Command3(str)
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub callhumresupdatevismin()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            str = "exec UpdateHumresVismin"
            objclass.Command3(str)
            objclass.Execute3()
            objclass.Close3()
            objclass = Nothing
        Catch ex As Exception

        End Try
    End Sub

    Private Sub callhumresupdateluzon()
        Try
            objclass = New clsCommon
            objclass.Connectionstring3()
            objclass.Open3()
            str = "exec UpdateHumresLuzon"
            objclass.Command3(str)
            objclass.Execute3()
            objclass = Nothing
        Catch ex As Exception

        End Try
    End Sub
#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm1 As New frmMountedPricing
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button1_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm1 As New frmPTQuery
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button2_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm1 As New frmRel
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button4_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm1 As New frmActionClass
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button6_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm1 As New frmJewelry
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button7_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm1 As New frmMemo
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button8_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm1 As New Report
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button9_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm1 As New frmSummary
            frm1.iSummary = iSummaryTakenBack
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button32_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
           

            If FlagGroup = True Then
                If SelectedTab = "TabPage1" Then
                    TabControl1.SelectedTab = TabPage1
                ElseIf SelectedTab = "TabPage2" Then
                    TabControl1.SelectedTab = TabPage2
                ElseIf SelectedTab = "TabPage3" Then
                    TabControl1.SelectedTab = TabPage3
                ElseIf SelectedTab = "TabPage4" Then
                    TabControl1.SelectedTab = TabPage4
                ElseIf SelectedTab = "TabPage5" Then
                    TabControl1.SelectedTab = TabPage5
                ElseIf SelectedTab = "TabPage6" Then
                    TabControl1.SelectedTab = TabPage6
                End If
                FlagGroup = False
            End If

           

            loadme = True

            Me.StatusBar1.ForeColor = Color.Red
            Me.StatusBar1.Panels.Item(1).Text = UCase(userLog)
            If job_title = "ALLBOSMAN" Then
                Me.StatusBar1.Panels.Item(3).Text = "DATA CONTROLLER"
            ElseIf job_title = "MLWB" Or job_title = "PRICING" Or job_title = "DISTRI" Then
                Me.StatusBar1.Panels.Item(3).Text = "JEWELRY CUSTODIAN"
            Else
                Me.StatusBar1.Panels.Item(3).Text = UCase(job_title)
            End If
            Me.StatusBar1.Panels.Item(5).Text = UCase(CStr(CStr(MonthName(Now.Month)))) + " " + CStr(Now.Day) + ", " + CStr(Now.Year)
            'Me.StatusBar1.Panels.Item(7).Text = TimeOfDay
            Timer1_Tick(sender, e)
            btnTop.Text = btnTop.Text & " " & UCase(sDB)
            Me.btnBatchReceive.Visible = False
            Me.btnReceivingByBranch.Visible = False
            'Me.btnReceivingReport.Visible = False

            iJewelryQty = 1
            iJewelryTWT = 2
            iJewelryAveWt = 3
            iJewelryLOAN = 4
            iJewelryTotalRem = 5
            iJewelryTotalPrenda = 6
            iJewelrySummary = 7

            iProcessQty = 1
            iProcessTWT = 2
            iProcessAveWt = 3
            iProcessLOAN = 4
            iProcessTotalRem = 5
            iProcessTotalPrenda = 6

            iSumProcessQty = 1
            iSumProcessTWT = 2
            iSumProcessAveWt = 3
            iSumProcessLOAN = 4
            iSumProcessTotalRem = 5
            iSumProcessTotalPrenda = 6


            iSummaryCell = 1
            iSummaryWatch = 2
            iSummaryGoodStock = 3
            iSummaryTakenBack = 4

            iSummaryReceived = 5
            iSummaryUnreceived = 6
            iSummaryReleased = 7
            iSummaryUnreleased = 8

            iComparativeAveWt = 1
            iComparativeOA = 2
            iComparativeFakeCoated = 3
            iComparativeCellWatchAppliance = 4

            iGmMemoAppliance = 1
            iHrMemoMissing = 2
            iHrMemoFake = 3
            iHrMemoCoated = 4
            iHrOverApp = 5
            iHrIR = 6

            'fullname = ""
            'idnumber = 0

            If MainCost = "" Then
                MainCost = "REM"
                Me.StatusBar1.Panels.Item(9).Text = UCase(MainCost)
            End If

            If job_title = "ADMNISTRATOR" Then
                cmdUnoRec.Visible = True
            End If

            If job_title <> "ALLDEPTMNGR" Then
                Label2.Visible = False
                Button16.Visible = False
                Button17.Visible = False
                Button18.Visible = False
                Button19.Visible = False
                Button20.Visible = False
                Button21.Visible = False
                Button22.Visible = False
                Button10.Visible = False
                Button11.Visible = False
                Button12.Visible = False
                Button13.Visible = False
                Button14.Visible = False
                Button15.Visible = False
                Button33.Visible = False
                Button34.Visible = False
                Button35.Visible = False
                Button36.Visible = False
                btnProcessQty.Visible = False
                btnSumProcessTWT.Visible = False
                btnSumProcessAveWT.Visible = False
                btnSumProcessLoan.Visible = False
                btnSumProcessTREM.Visible = False
                btnSUmProcessTPrenda.Visible = False
                btnTop.Visible = False
                btnTopBranch.Visible = False
                btnVM.Visible = False
                btnComparative.Visible = False
                btnCLuzon.Visible = False
                btnCVismin.Visible = False
            End If

            If sDB = "Luzon" Then
                Me.Text = Me.Text + "(LUZON)"
                btnCVismin.Visible = False
                'ElseIf sDB = "Vismin" Then
                '    Me.Text = Me.Text + "(VISMIN)"
            ElseIf sDB = "Visayas" Then
                Me.Text = Me.Text + "(VISAYAS)"
                btnCLuzon.Visible = False
            ElseIf sDB = "Showroom" Then
                Me.Text = Me.Text + "(SHOWROOM)"
                btnCLuzon.Visible = False
            ElseIf sDB = "Mindanao" Then
                Me.Text = Me.Text + "(MINDANAO)"
                btnCLuzon.Visible = False
            ElseIf sDB = "LNCR" Then
                Me.Text = Me.Text + "(LNCR)"
                btnCLuzon.Visible = False
            End If

            Dim objclass As New clsCommon
            Dim dr As SqlDataReader

            objclass.ConnDb()
            objclass.Open5()
            objclass.Command5("Select job_title from " & humres2 & " where fullname='" & userLog & "'")
            dr = objclass.OpenDataReader5
            If dr.Read Then
                Dim a As String
                a = Trim(dr.Item("job_title"))
                a = Nothing
            End If

            If UCase(job_title = "SORTER") Or job_title = "ALLDEPTMNGR" Then
                If sDB <> "" Then
                    Me.Receiving.TabPages.Item(1).Enabled = False
                    Me.Receiving.TabPages.Item(2).Enabled = False
                    Me.Receiving.TabPages.Item(3).Enabled = False
                    Me.Receiving.TabPages.Item(4).Enabled = False
                    Me.Receiving.TabPages.Item(5).Enabled = False
                    Me.Receiving.TabPages.Item(6).Enabled = False
                    'btnRREM.Enabled = True
                    'btnRelVIP.Enabled = True
                    TabPage1.Enabled = True
                    btnReceiving.Enabled = False
                    btnGood.Enabled = True
                    btnCost.Enabled = True
                    btnReLOuT.Enabled = True
                    cmdUnoRec.Visible = False
                    btnCGPrice.Enabled = False
                    'btnRREM.Enabled = True
                    btnRelVIP.Enabled = True
                    btnActionClass.Enabled = False
                    btnMemoReceiver.Enabled = False
                    btnJewelryClass.Enabled = False
                End If
            End If
            If UCase(job_title) = "VERIFIER" Then
                Me.Receiving.TabPages.Item(0).Enabled = True
                Me.Receiving.TabPages.Item(1).Enabled = False
                Me.Receiving.TabPages.Item(2).Enabled = False
                Me.Receiving.TabPages.Item(3).Enabled = False
                Me.Receiving.TabPages.Item(4).Enabled = False
                Me.Receiving.TabPages.Item(5).Enabled = False
                Me.Receiving.TabPages.Item(6).Enabled = False
                Me.TabControl1.TabPages.Item(1).Enabled = True
                Me.TabControl1.TabPages.Item(2).Enabled = True
                Me.TabControl1.TabPages.Item(3).Enabled = True
                Me.TabControl1.TabPages.Item(4).Enabled = True
                Me.TabControl1.TabPages.Item(5).Enabled = True
                btnCGPrice.Enabled = False
            End If

            If UCase(job_title) = "MLWB" Then
                btnBMLWB.Enabled = True
                btnEditItem.Enabled = False
                btnRMLWB.Enabled = True
                btnInventory.Enabled = False
                Me.Receiving.TabPages.Item(0).Enabled = False
                Me.Receiving.TabPages.Item(1).Enabled = True
                Me.Receiving.TabPages.Item(2).Enabled = False
                Me.Receiving.TabPages.Item(3).Enabled = False
                Me.Receiving.TabPages.Item(4).Enabled = False
                Me.Receiving.TabPages.Item(5).Enabled = False
                Me.Receiving.TabPages.Item(6).Enabled = False
                btnCGPrice.Enabled = False
            End If

            If UCase(job_title) = "PRICING" Then
                btnBPRICING.Enabled = True
                btnPricing.Enabled = True
                btnRPRICING.Enabled = True
                btnEditCode.Enabled = True
                btnvwPrice.Enabled = True
                btnInvPricing.Enabled = False
                Me.Receiving.TabPages.Item(0).Enabled = False
                Me.Receiving.TabPages.Item(1).Enabled = False
                Me.Receiving.TabPages.Item(2).Enabled = True
                Me.Receiving.TabPages.Item(3).Enabled = False
                Me.Receiving.TabPages.Item(4).Enabled = False
                Me.Receiving.TabPages.Item(5).Enabled = False
                Me.Receiving.TabPages.Item(6).Enabled = False
                btnCGPrice.Enabled = False
            End If

            ''If UCase(job_title) = "DISTRIBUTION" Or UCase(job_title) = "DISTRI" Then
            If UCase(job_title) = "DISTRI" Then
                btnDistri.Enabled = True
                btnDistriInventory.Enabled = False
                btnCreateInfo.Enabled = True
                btnRDISTRI.Enabled = False

                Me.Receiving.TabPages.Item(0).Enabled = False
                Me.Receiving.TabPages.Item(1).Enabled = False
                Me.Receiving.TabPages.Item(2).Enabled = False
                Me.Receiving.TabPages.Item(3).Enabled = True
                Me.Receiving.TabPages.Item(4).Enabled = False
                Me.Receiving.TabPages.Item(5).Enabled = False
                Me.Receiving.TabPages.Item(6).Enabled = False
                btnCGPrice.Enabled = False
            End If

            dr.Close()
            objclass.Close5()
            btnALLSearch.Visible = False
            Me.btnMemoReceiver.Enabled = False
        Catch ex As Exception
            MsgBox("frmMain/frmMain_Load: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub enabledAll()
        Try
            Me.Receiving.TabPages.Item(1).Enabled = True
            Me.Receiving.TabPages.Item(2).Enabled = True
            Me.Receiving.TabPages.Item(3).Enabled = True
            Me.Receiving.TabPages.Item(4).Enabled = True
            Me.Receiving.TabPages.Item(5).Enabled = True
            Me.Receiving.TabPages.Item(6).Enabled = True
        Catch ex As Exception
            MsgBox("frmMain/enabledAll: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub enabledAllMLWB()
        Try
            Me.Receiving.TabPages.Item(0).Enabled = False
            Me.Receiving.TabPages.Item(1).Enabled = True
            Me.Receiving.TabPages.Item(2).Enabled = False
            Me.Receiving.TabPages.Item(3).Enabled = False
            Me.Receiving.TabPages.Item(4).Enabled = False
            Me.Receiving.TabPages.Item(5).Enabled = False
            Me.Receiving.TabPages.Item(6).Enabled = False
        Catch ex As Exception
            MsgBox("frmMain/enabledAllMLWB: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub enabledAllDISTRI()
        Try
            Me.Receiving.TabPages.Item(0).Enabled = False
            Me.Receiving.TabPages.Item(1).Enabled = False
            Me.Receiving.TabPages.Item(2).Enabled = False
            Me.Receiving.TabPages.Item(3).Enabled = True
            Me.Receiving.TabPages.Item(4).Enabled = False
            Me.Receiving.TabPages.Item(5).Enabled = False
            Me.Receiving.TabPages.Item(6).Enabled = False
        Catch ex As Exception
            MsgBox("frmMain/enabledAllDISTRI: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub enabledAllPRICING()
        Try
            Me.Receiving.TabPages.Item(0).Enabled = False
            Me.Receiving.TabPages.Item(1).Enabled = False
            Me.Receiving.TabPages.Item(2).Enabled = True
            Me.Receiving.TabPages.Item(3).Enabled = False
            Me.Receiving.TabPages.Item(4).Enabled = False
            Me.Receiving.TabPages.Item(5).Enabled = False
            Me.Receiving.TabPages.Item(6).Enabled = False
        Catch ex As Exception
            MsgBox("frmMain/enabledAllPRICING: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm1 As New frmListReceiver
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button38_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim A As New frmSearch
            A.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSearch_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Undo Sorting button
    'Private Sub btnundo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim undosort As New frmUndoSort
    '    undosort.Width = 1000
    '    undosort.Height = 384
    '    undosort.showdialog()
    '    undosort.ComboBox1.Focus()
    'End Sub
    'Undo Receiving button

    Private Sub btnBatchReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatchReceive.Click
    End Sub

    Public Sub frmrec()
        Try
            If MainCost = "REM" Then
                Dim frm As New FrmNewReceiving
                frm.Text = "REM BATCH RECEIVING FORM"
                'frm.SetDesktopLocation(5, 125)
                frm.Showdialog()
            ElseIf MainCost = "MLWB" Then
                Dim frmMLWBReceiving As New frmMLWBReceiving
                frmMLWBReceiving.Text = "MLWB RECEIVING FORM"
                'frmMLWBReceiving.SetDesktopLocation(5, 125)
                frmMLWBReceiving.ShowDialog()
            ElseIf MainCost = "PRICING" Then
                Dim frmPricingReceiving As New FrmPricingReceiving
                'frmPricingReceiving.SetDesktopLocation(5, 125)
                frmPricingReceiving.ShowDialog()
            ElseIf MainCost = "DISTRI" Then
                Dim frm As New FrmDISTRIReceiving
                'frm.SetDesktopLocation(5, 125)
                frm.Showdialog()
            End If
        Catch ex As Exception
            MsgBox("frmMain/frmrec: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnReceivingByBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivingByBranch.Click
        Try
            Dim frm1 As New frmListReceiver
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnReceivingByBranch_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnPTQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPTQuery.Click
        Try
            Dim frm1 As New frmPTQuery
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnPTQuery_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnReceivingReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceivingReport.Click
        Try
            recrelrep = True
            Dim frm As New Report
            frm.Label6.Visible = False
            frm.TextBox2.Visible = False
            frm.Text = "RECEIVING REPORT"
            sDB = myregion
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnReceivingReport_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Try
            Dim frm1 As New frmMemo_rpt
            frm1.iMemo = iHrMemoMissing
            frm1.Text = "HR MEMO MISSING ITEM"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button27_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Try
            Dim frm1 As New frmMemo_rpt
            frm1.iMemo = iGmMemoAppliance
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button28_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Try
            Dim frm1 As New frmMemo_rpt
            frm1.iMemo = iHrMemoFake
            frm1.Text = "HR MEMO FAKE"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button24_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        Try
            Dim frm1 As New frmMemo_rpt
            frm1.iMemo = iHrMemoCoated
            frm1.Text = "HR MEMO COATED"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button25_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        Try
            Dim frm1 As New frmMemo_rpt
            frm1.iMemo = iHrOverApp
            frm1.Text = "HR MEMO OVER APPRAISED"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button26_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Try


            Dim frm1 As New frmSummary
            frm1.iSummary = iSummaryCell
            frm1.Text = "SUMMARY CELL"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button29_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Try
            Dim frm1 As New frmSummary
            frm1.iSummary = iSummaryWatch
            frm1.Text = "SUMMARY WATCHES"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button30_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Try
            Dim frm1 As New frmSummary
            frm1.GroupBox1.Visible = False
            sDB = myregion
            frm1.Label4.Text = ""
            frm1.iSummary = iSummaryGoodStock
            frm1.Text = "SUMMARY GOOD STOCKS"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button31_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnReceiving_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceiving.Click
        Try
            Dim frm2 As New Form2
            sDB = ""
            frm2.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnReceiving_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim frm1 As New frmSort
            sDB = myregion

            If sort = False Then
                sort = True
                frm1.Show()
            End If
        Catch ex As Exception
            'MsgBox("frmMain/Button3_Click" & ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            prcing = False
            Dim frm1 As New frmCost
            frm1.btnSaveMLWB.Visible = False
            frm1.Button13.Visible = True
            SelectedForm = "frmCost"
            sDB = myregion
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button5_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Try
            Dim frm1 As New frmSortedList
            sDB = myregion
            frm1.Text = "SORTED LIST"
            frm1.Show()
        Catch ex As Exception
            MsgBox("frmMain/Button23_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Try
            Dim frm1 As New frmJewelry_rpt
            frm1.iJewelry = iJewelryQty
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button16_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Try
            Dim frm1 As New frmJewelry_rpt
            frm1.iJewelry = iJewelryTWT
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button17_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Try
            Dim frm1 As New frmJewelry_rpt
            frm1.iJewelry = iJewelryAveWt
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button18_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Try
            Dim frm1 As New frmJewelry_rpt
            frm1.iJewelry = iJewelryLOAN
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button19_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Try
            Dim frm1 As New frmJewelry_rpt
            frm1.iJewelry = iJewelryTotalRem
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button20_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        Try
            Dim frm1 As New frmJewelry_rpt
            frm1.iJewelry = iJewelryTotalPrenda
            frm1.Label2.Text = "PRENDA MONTH"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button21_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        Try
            'Dim frm1 As New frmJewelry_rpt
            'frm1.iJewelry = iJewelrySummary
            'frm1.ShowDialog()
            Dim frm As New frmJewelSum
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button22_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Try
            Dim frm1 As New frmProcess
            frm1.iProcess = iProcessQty
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button10_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Try
            Dim frm1 As New frmProcess
            frm1.iProcess = iProcessTWT
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button11_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Try
            Dim frm1 As New frmProcess
            frm1.iProcess = iProcessAveWt
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button12_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Try
            Dim frm1 As New frmProcess
            frm1.iProcess = iProcessLOAN
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button13_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Try
            Dim frm1 As New frmProcess
            frm1.iProcess = iProcessTotalRem
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button14_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        Try
            Dim frm1 As New frmProcess
            frm1.iProcess = iProcessTotalPrenda
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button15_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        Try
            Dim frm1 As New frmComparative
            frm1.iComparative = iComparativeAveWt
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button33_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        Try
            Dim frm1 As New frmComparative
            frm1.iComparative = iComparativeOA
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button34_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Try
            Dim frm1 As New frmComparative
            frm1.iComparative = iComparativeFakeCoated
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button36_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        Try
            Dim frm1 As New frmComparative
            frm1.iComparative = iComparativeCellWatchAppliance
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button36_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnActionClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActionClass.Click
        Try
            Dim frm1 As New frmActionClass
            frm1.Text = "ACTION CLASS"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnActionClass_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnJewelryClass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJewelryClass.Click
        Try
            Dim frm1 As New frmJewelry
            frm1.Text = "JEWELRY CLASS"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnJewelryClass_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnMemoReceiver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMemoReceiver.Click
        Try
            Dim frm1 As New frmMemo
            frm1.Text = "MEMO RECEIVER"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnMemoReceiver_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnBranchSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBranchSearch.Click
        Try
            Dim A As New frmSearch
            A.Text = "BRANCH SEARCH"
            A.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnBranchSearch_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnALLSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnALLSearch.Click
        Try
            Dim frm As New mAXbArcode
            frm.Text = "SEARCH MAXIMUM A.L.L BARCODE"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnALLSearch_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnDistri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistri.Click
        Try
            Dim frmdistri As New Form1
            If oo = False Then
                SelectedForm = "Form1"
                frmdistri.ShowDialog()
            End If
            'Me.SendToBack()
            'frmdistri.BringToFront()
            'frmdistri.Button3.Focus()
        Catch ex As Exception
            MsgBox("frmMain/btnDistri_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Inventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Inventory.Click
        Try
            Dim frm As New frmInventory
            frm.ShowDialog()
            frm.BringToFront()
        Catch ex As Exception
            MsgBox("frmMain/Inventory_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Public Sub frmrel()
        Try
            If MainCost = "REM" Then
                Dim frm As New frmReleasing
                frm.Text = "REM RELEASING FORM"
                frm.ShowDialog()
            ElseIf MainCost = "MLWB" Then
                Dim frm As New frmMLWBReleasing
                FRM.Text = "MLWB RELEASING FORM"
                frm.ShowDialog()
            ElseIf MainCost = "PRICING" Then
                Dim frm As New frmPRICINGReleasing
                frm.ShowDialog()
            ElseIf MainCost = "DISTRI" Then
                Dim frm As New frmDISTRIReleasing
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("frmMain/frmrel: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhoto.Click
        Try
            Dim frmPhoto As New frmPhotoMover
            frmPhoto.btnEditPic.Visible = False
            frmPhoto.TextBox2.Visible = False
            frmPhoto.TextBox1.Visible = True
            frmPhoto.PictureBox1.BringToFront()
            hulagway = True
            'sDB = myregion
            frmPhoto.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnPhoto_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnPricing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPricing.Click
        Try
            prcing = True
            Dim frm As New frmEditPricing
            frm.txtPrice.ReadOnly = False
            frm.btnSaveMLWB.Visible = False
            frm.Button13.Visible = True
            frm.Text = "PRICING"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnPricing_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    'Private Sub btnRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim fr As New frmMain
    '        If UCase(job_title) <> "SORTER" Or job_title <> "ALLDEPTMNGR" Then
    '            If sDB = "" Then
    '                Dim GrpSelect As New GrpSelect
    '                ambot = 2
    '                GrpSelect.Label1.BringToFront()
    '                GrpSelect.btnVismin.BringToFront()
    '                GrpSelect.btnLuzon.BringToFront()
    '                GrpSelect.GroupBox1.SetBounds(24, 16, 304, 160)
    '                GrpSelect.Label2.Visible = False
    '                GrpSelect.Label3.Visible = False
    '                GrpSelect.txtPWord.Visible = False
    '                GrpSelect.txtUserName.Visible = False
    '                GrpSelect.Visible = True
    '                Me.Hide()
    '            Else
    '                Dim frmrec As New frmnewrec
    '                frmrec.showdialog()
    '            End If
    '        Else
    '            Dim frmrec As New frmnewrec
    '            frmrec.showdialog()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, , TitleMsgBox)
    '    End Try

    'End Sub
    Private Sub btnIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIR.Click
        Try
            Dim frm1 As New frmMemo_rpt
            frm1.iMemo = iHrIR
            frm1.Text = "INCIDENT REPORT/IR"
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnIR_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Receiving_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Receiving.SelectedIndexChanged
        Try
            Call CostMain()
            If TabPage8.Focus = True Or TabPricing.Focus = True Or TabDistri.Focus = True Or TabShowroom.Focus = True Or TabReports.Focus = True Or TabSystem.Focus = True Then
                If UCase(job_title) <> "SORTER" Or job_title <> "ALLDEPTMNGR" Then
                    sDB = ""
                    Call enabledAll()
                    Me.Text = TitleMsgBox
                    If MainCost = "DISTRI" Then
                        Me.StatusBar1.Panels.Item(9).Text = MainCost & "BUTION"
                    Else
                        Me.StatusBar1.Panels.Item(9).Text = MainCost
                    End If

                End If
            End If
            If TabPage1.Focus = True Or TabPricing.Focus = True Or TabDistri.Focus = True Or TabShowroom.Focus = True Or TabReports.Focus = True Or TabSystem.Focus = True Then
                If UCase(job_title) = "MLWB" Then
                    sDB = ""
                    Call enabledAllMLWB()
                    Me.Text = "ASYS 5.2 Synergy Showroom"
                    Me.StatusBar1.Panels.Item(9).Text = MainCost
                End If
            End If
            If TabPage1.Focus = True Or TabPricing.Focus = True Or TabPage8.Focus = True Or TabShowroom.Focus = True Or TabReports.Focus = True Or TabSystem.Focus = True Then
                If UCase(job_title) = "PRICING" Then
                    sDB = ""
                    Call enabledAllPRICING()
                    Me.Text = "ASYS 5.2 Synergy Showroom"
                    Me.StatusBar1.Panels.Item(9).Text = MainCost
                End If
            End If
            If TabPage1.Focus = True Or TabPricing.Focus = True Or TabPage8.Focus = True Or TabShowroom.Focus = True Or TabReports.Focus = True Or TabSystem.Focus = True Then
                If UCase(job_title) = "DISTRI" Or UCase(job_title) = "DISTRIBUTION" Then
                    sDB = ""
                    Call enabledAllDISTRI()
                    Me.Text = "ASYS 5.2 Synergy Showroom"
                    Me.StatusBar1.Panels.Item(9).Text = MainCost
                End If
            End If
            If TabRem.Focus = True Then
                Me.StatusBar1.Panels.Item(9).Text = MainCost
            End If

        Catch ex As Exception
            MsgBox("frmMain/Receiving_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
 
    Private Sub btnBRem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBRem.Click
        Try
            sDB = myregion
            SelectedForm = "FrmNewReceiving"
            Call frmrec()
        Catch ex As Exception
            MsgBox("frmMain/btnBRem_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnIREM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIREM.Click
        Try
            Dim frmrec As New frmnewrec
            sDB = myregion
            frmrec.Text = "RECEIVE PTN INDIVIDUALLY"
            frmrec.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnIREM_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub CostMain()
        Try
            If TabRem.Focus = True Then
                MainCost = "REM"
            ElseIf TabPage8.Focus = True Then
                MainCost = "MLWB"
            ElseIf TabPricing.Focus = True Then
                MainCost = "PRICING"
            ElseIf TabDistri.Focus = True Then
                MainCost = "DISTRI"
            ElseIf TabShowroom.Focus = True Then
                MainCost = "SHOWROOM"
            ElseIf TabReports.Focus = True Then
                MainCost = "REPORTS"
            ElseIf TabSystem.Focus = True Then
                MainCost = "SYSTEM"
            End If
        Catch ex As Exception
            MsgBox("frmMain/CostMain: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnBMLWB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBMLWB.Click
        Try
            SelectedForm = "frmMLWBReceiving"
            Call frmrec()
        Catch ex As Exception
            MsgBox("frmMain/btnBMLWB_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnRMLWB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRMLWB.Click
        Try
            SelectedForm = "frmMLWBReleasing"
            Call frmrel()
        Catch ex As Exception
            MsgBox("frmMain/btnRMLWB_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnBPRICING_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBPRICING.Click
        Try
            SelectedForm = "FrmPricingReceiving"

            Call frmrec()
        Catch ex As Exception
            MsgBox("frmMain/btnBPRICING_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnRPRICING_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRPRICING.Click
        Try
            SelectedForm = "frmPRICINGReleasing"
            Call frmrel()
        Catch ex As Exception
            MsgBox("frmMain/btnRPRICING_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnBDISTRI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBDISTRI.Click
        Try
            SelectedForm = "FrmDISTRIReceiving"
            Call frmrec()
        Catch ex As Exception
            MsgBox("frmMain/btnBDISTRI_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnRDISTRI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRDISTRI.Click
        Try
            SelectedForm = "frmDISTRIReleasing"
            Call frmrel()
        Catch ex As Exception
            MsgBox("frmMain/btnRDISTRI_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            If job_title <> "SORTER" Or job_title <> "ALLDEPTMNGR" Then
                If TabPage4.Focus = True Or TabPage2.Focus = True Or TabPage6.Focus = True Or TabPage5.Focus = True Or TabPage7.Focus = True Then
                    If sDB = "" Then
                        If myregion = "" Then
                            Dim GrpSelect As New frmLoginNew
                            GrpSelect.Label1.BringToFront()
                            GrpSelect.rdVisayas.BringToFront()
                            GrpSelect.rdLuzon.BringToFront()
                            GrpSelect.rdShowroom.BringToFront()
                            GrpSelect.GroupBox1.Visible = False
                            'GrpSelect.GroupBox1.SetBounds(24, 16, 304, 160)
                            GrpSelect.Label2.Visible = False
                            GrpSelect.Label3.Visible = False
                            GrpSelect.txtPWord.Visible = False
                            GrpSelect.txtUserName.Visible = False
                            SelectedTab = TabControl1.SelectedTab.Name.ToString
                            FlagGroup = True
                            GrpSelect.ShowDialog()
                            Me.Hide()
                            ''''''Me.Show()
                            '''If FlagClose = True Then
                            '''    TabControl1.SelectedTab = TabPage1
                            '''Else
                            '''    Me.Hide()
                            '''    Me.Show()
                            '''    If SelectedTab = "TabPage1" Then
                            '''        TabControl1.SelectedTab = TabPage1
                            '''    ElseIf SelectedTab = "TabPage2" Then
                            '''        TabControl1.SelectedTab = TabPage2
                            '''    ElseIf SelectedTab = "TabPage3" Then
                            '''        TabControl1.SelectedTab = TabPage3
                            '''    ElseIf SelectedTab = "TabPage4" Then
                            '''        TabControl1.SelectedTab = TabPage4
                            '''    ElseIf SelectedTab = "TabPage5" Then
                            '''        TabControl1.SelectedTab = TabPage5
                            '''    ElseIf SelectedTab = "TabPage6" Then
                            '''        TabControl1.SelectedTab = TabPage6
                            '''    End If
                            '''End If

                        Else
                            sDB = myregion
                        End If
                    ElseIf TabPage7.Focus = True Then
                        sDB = myregion
                        outsource = False
                        force = False
                        SelectedForm = "frmReleasingReceiving"
                        Dim frm As New frmReleasing
                        frm.Text = "REM RELEASING"
                        frm.ShowDialog()
                    End If
                    If TabPage1.Focus = True Then
                        sDB = ""
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("frmMain/TabControl1_SelectedIndexChanged: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnRREM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            sDB = myregion
            outsource = False
            force = False
            SelectedForm = "frmReleasingReceiving"
            Call frmrel()
        Catch ex As Exception
            MsgBox("frmMain/btnRREM_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnvwbar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvwbar.Click
        Try
            Dim frm As New FrmDistri
            frm.Text = "VIEW A.L.L. BARCODE DETAILS"
            frm.Button13.Visible = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnvwbar_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnPho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New frmPhotoMover
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnPho_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnCost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCost.Click
        Try
            Dim frm As New frmCost
            sDB = ""
            frm.Text = "COSTING"
            'outsource = True
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnCost_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnReLOuT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReLOuT.Click
        Try
            Dim frm As New frmReleasing
            force = True
            outsource = True
            frm.Text = "RELEASE"
            sDB = ""
            SelectedForm = "frmReleasingItem"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnReLOuT_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnGood_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGood.Click
        Try
            Dim frm As New frmOutSource_Return
            outsource = True
            sDB = ""
            frm.txtlotno.Text = ""
            frm.cmbEmp.Text = UCase(userLog)
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnGood_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnPRIVW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPRIVW.Click
        Try
            Dim frm As New FrmDistri
            frm.Text = "VIEW A.L.L. BARCODE DETAILS"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnPRIVW_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnBQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBQuery.Click
        Try
            Dim frm As New frmBarcodeQuery
            frm.Button1.Visible = False
            frm.Button4.Visible = False
            frm.Text = "BARCODE QUERY"
            recode = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnBQuery_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItem.Click
        Try
            Dim frm As New Form2
            'frm.btnReturn.Enabled = False
            SelectedForm = "Form2"
            frm.Text = "ITEM"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnItem_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnvwPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvwPrice.Click
        Try
            Dim frm As New frmVwPrice
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnvwPrice_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnHistoryB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHistoryB.Click
        Try
            Dim frm As New frmBarcodeHistory
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnHistoryB_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnUpdateBedryf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateBedryf.Click
        Try
            callbedryfupdatevisayas()
            callbedryfupdatemindanao()
            callbedryfUpdateluzon()
            MsgBox("Bedryf has been successfully updated.", MsgBoxStyle.Information, TitleMsgBox)
        Catch ex As Exception
            MsgBox("frmMain/btnUpdateBedryf_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnUpdateHumres_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateHumres.Click
        Try
            callhumresupdateluzon()
            callhumresupdatevismin()
            MsgBox("Humres has been successfully updated.", MsgBoxStyle.Information, TitleMsgBox)
        Catch ex As Exception
            MsgBox("frmMain/btnUpdateHumres_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnRelVIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelVIP.Click
        Try
            Dim frm As New frmRel
            frm.Text = "RELEASE TO VP"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnRelVIP_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnPicEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPicEdit.Click
        Try
            Dim frm As New frmPhotoMover
            'frm.btnEditPic.Visible = True
            frm.TextBox1.Visible = False
            frm.TextBox2.Visible = True
            pt = True
            frm.Save.Visible = False
            hulagway = False
            frm.PictureBox3.BringToFront()
            frm.TextBox2.Focus()
            frm.TextBox2.Select()
            frm.Text = "EDIT PICTURE"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnPicEdit_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub frmMain_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        FlagLoggedIn = False
        End
    End Sub
    Private Sub btnComparative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComparative.Click
        Try
            Dim frm As New NewRematadoReport
            frm.Label3.Text = 2
            frm.ComboBox3.Visible = False
            frm.ComboBox4.Visible = False
            frm.Label4.Visible = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnComparative_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnCVismin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCVismin.Click
        Try
            Dim frm As New NewRematadoReport
            frm.Label3.Text = 4
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnCVismin_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnCLuzon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCLuzon.Click
        Try
            Dim frm As New NewRematadoReport
            frm.Label3.Text = 3
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnCLuzon_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnTopBranch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopBranch.Click
        Try
            Dim frm As New NewRematadoReport
            frm.Label1.Text = "PRENDA MONTH"
            frm.Label3.Text = 1
            frm.Label4.Visible = False
            frm.ComboBox3.Visible = False
            frm.ComboBox4.Visible = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnTopBranch_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnVM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVM.Click
        Try
            Dim frm As New NewRematadoReport
            frm.Label3.Text = 5
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnVM_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnCreateInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateInfo.Click
        Try
            Dim frm As New frmCreateBranchAdd
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnCreateInfo_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnEditItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditItem.Click
        Try
            mlPrcing = True
            Dim frm As New frmCost
            frm.txtPrice.ReadOnly = True
            frm.btnSaveMLWB.Visible = True
            frm.Button13.Visible = False
            frm.txtCost.Enabled = False
            frm.Text = "EDIT ITEM"
            SelectedForm = "btnEditItem_Click"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnEditItem_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub cmdUnoRec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnoRec.Click
        Try
            Dim undorec As New frmUndoReceive
            undorec.Width = 1000
            undorec.Height = 366
            undorec.ShowDialog()
            undorec.ComboBox1.Focus()
        Catch ex As Exception
            MsgBox("frmMain/cmdUnoRec_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnRelIndi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelIndi.Click
        Try
            Dim frm As New frmReleaseIndividually
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnRelIndi_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub
    Private Sub btnTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTop.Click
        Try
            Dim frm As New NewRematadoReport
            frm.Label1.Text = "PRENDA MONTH"
            frm.Label3.Text = 0
            frm.Label4.Visible = False
            frm.ComboBox3.Visible = False
            frm.ComboBox4.Visible = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnTop_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnBarcodeUtil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBarcodeUtil.Click
        Try
            Dim frm As New BarcodeEditUtility
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnBarcodeUtil_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim frm As New frmREMOutSourceBRcv
            SelectedForm = "frmREMOutSourceBRcv"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button1_Click_1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnREMInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMInventory.Click
        Try
            Dim frm As New frmREMInventory
            frm.Text = "REM INVENTORY"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnREMInventory_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventory.Click
        Try
            Dim frm As New frmMLWBInventory
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnInventory_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnEditCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditCode.Click
        Try
            Dim frm As New frmBarcodeQuery
            frm.Text = "RECODE"
            recode = True
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnEditCode_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnREMrecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMrecode.Click
        Try
            Dim frm As New frmBarcodeQuery
            frm.Text = "RECODE"
            recode = True
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnREMrecode_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnInvPricing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInvPricing.Click
        Try
            Dim fr As New frmPRICINGInventory
            fr.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnInvPricing_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnProcessQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessQty.Click
        Try
            Dim frm1 As New frmProcessSummary
            frm1.sProcess = iSumProcessQty
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnProcessQty_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSumProcessTWT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumProcessTWT.Click
        Try
            Dim frm1 As New frmProcessSummary
            frm1.sProcess = iSumProcessTWT
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSumProcessTWT_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSumProcessAveWT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumProcessAveWT.Click
        Try
            Dim frm1 As New frmProcessSummary
            frm1.sProcess = iSumProcessAveWt
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSumProcessAveWT_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSumProcessLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumProcessLoan.Click
        Try
            Dim frm1 As New frmProcessSummary
            frm1.sProcess = iSumProcessLOAN
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSumProcessLoan_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSumProcessTREM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumProcessTREM.Click
        Try
            Dim frm1 As New frmProcessSummary
            frm1.sProcess = iSumProcessTotalRem
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSumProcessTREM_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSUmProcessTPrenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSUmProcessTPrenda.Click
        Try
            Dim frm1 As New frmProcessSummary
            frm1.sProcess = iSumProcessTotalRem
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSUmProcessTPrenda_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnDistriInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistriInventory.Click
        Try
            Dim frm As New frmDistriInventory
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnDistriInventory_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New frmMLWBInventory
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button2_Click_1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim fr As New frmPRICINGInventory
            fr.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button4_Click_1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frm As New frmDistriInventory
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/Button6_Click_1: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'paopao la lang, la lng lingaw...hehehe 03202010
        Try
            Me.StatusBar1.Panels.Item(7).Text = Now.ToLongTimeString
            Me.Timer1.Interval = 1000
            Timer1.Enabled = True
        Catch ex As Exception
            MsgBox("frmMain/Timer1_Tick: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        Try
            Dim frm As New FrmDistri
            frm.Text = "VIEW A.L.L. BARCODE DETAILS"
            frm.Button5.Enabled = False
            frm.Button6.Enabled = False
            frm.Button7.Enabled = False
            frm.Button8.Enabled = False
            frm.Button10.Enabled = False
            frm.Button11.Enabled = False
            frm.Button12.Enabled = False
            frm.Button13.Visible = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnview_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnSelfInven_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelfInven.Click
        Try
            Dim frm As New frmSelfInventory
            frm.Text = "SELF INVENTORY"
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSelfInven_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnReceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceived.Click
        Try
            Dim frm1 As New frmSummary
            frm1.iSummary = iSummaryReceived
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnReceived_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnUnReceived_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnReceived.Click
        Try
            Dim frm1 As New frmSummary
            frm1.iSummary = iSummaryUnreceived
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnUnReceived_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnReleased_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReleased.Click
        Try
            Dim frm1 As New frmSummary
            frm1.iSummary = iSummaryReleased
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnReleased_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub btnUnReleased_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnReleased.Click
        Try
            Dim frm1 As New frmSummary
            frm1.iSummary = iSummaryUnreleased
            frm1.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnUnReleased_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub Consignee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Consignee.Click

    End Sub

    Private Sub btnCGPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCGPrice.Click
        Dim frm As New frmPhoto
        frm.ShowDialog()
    End Sub


    Private Sub btnDistriSInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistriSInventory.Click
        Try
            Dim frm As New frmSelfInventory
            frm.Text = "SELF INVENTORY"
            frm.cboCostCenter.Text = "DISTRI"
            frm.cboCostCenter.Enabled = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSelfInven_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub btnMSInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMSInventory.Click
        Try
            Dim frm As New frmSelfInventory
            frm.Text = "SELF INVENTORY"
            frm.cboCostCenter.Text = "MLWB"
            frm.cboCostCenter.Enabled = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSelfInven_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub btnPSInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPSInventory.Click
        Try
            Dim frm As New frmSelfInventory
            frm.Text = "SELF INVENTORY"
            frm.cboCostCenter.Text = "PRICING"
            frm.cboCostCenter.Enabled = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSelfInven_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub btnREMSInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREMSInventory.Click
        Try
            Dim frm As New frmSelfInventory
            frm.Text = "SELF INVENTORY"
            frm.cboCostCenter.Text = "REM"
            frm.cboCostCenter.Enabled = False
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox("frmMain/btnSelfInven_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub


    Private Sub btnCDPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCDPrice.Click
        Try
            Dim frm As New frmDiamondPrice
            frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPearlPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPearlPrice.Click
        Try
            Dim frm As New frmCPearlPrice
            frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnStonePrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStonePrice.Click
        Try
            Dim frm As New frmCStonePrice
            frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            sDB = myregion
            outsource = False
            force = False
            SelectedForm = "frmReleasingReceiving"
            Call frmrel()
        Catch ex As Exception
            MsgBox("frmMain/btnRREM_Click: " & ex.Message, MsgBoxStyle.Information, TitleMsgBox)
        End Try
    End Sub

    Private Sub TabReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabReports.Click

    End Sub

    Private Sub TabPage4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage4.Click

    End Sub
End Class
