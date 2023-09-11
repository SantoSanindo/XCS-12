Option Explicit On
Imports System.IO
Imports System.Threading
Imports System.Net

Public Class frmMain
    Dim AssyBuf As String
    Dim CheckWO As String
    Dim ReadTagFlag As Boolean
    Dim EnableCount As Boolean
    Dim SlideCount As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SlideCount = 27
        Timer2.Enabled = True

        Dim fullPath As String = System.AppDomain.CurrentDomain.BaseDirectory
        Dim projectFolder As String = fullPath.Replace("\XCS-12\bin\Debug\", "").Replace("\XCS-12\bin\Release\", "")

        If Dir(projectFolder & "\Config\Config.INI") = "" Then 'This is to initalize the program during start up
            MsgBox("Config.INI is missing")
            End
        End If
        ReadINI(projectFolder & "\Config\Config.INI")

        GetLastConfig()
        'Modbus
        frmMsg.Show()
        frmMsg.Label1.Text = "Establishing link with PLC..."
        Modbus.Show()
        Modbus.Hide()
        If Modbus.lbl_status.Text <> "Connected" Then
            Ethernet.BackColor = Color.Red
            End
        End If
        frmMsg.Label1.Text = "Connection to PLC established"
        'frmMsg.Hide()
        Ethernet.BackColor = Color.Lime

        Dim strHostName As String = Dns.GetHostName()
        Dim hostname As IPHostEntry = Dns.GetHostByName(strHostName)
        Dim ip As IPAddress() = hostname.AddressList
        lbl_localhostname.Text = "PC Name : " & strHostName
        lbl_localip.Text = "PC IP Address : " & ip(0).ToString

        Thread.Sleep(10)
        Reset_PLC()
        frmMsg.Label1.Text = "Loading parameters..."

        'Load parameters
        If Not LoadParameter(LoadWOfrRFID.JobModelName) Then
            MsgBox("Unable to load parameters...")
            End
        End If

        If Not LoadParameter2PLC() Then
            MsgBox("Unable to communicate with PLC...")
            End
        End If

        lbl_WOnos.Text = LoadWOfrRFID.JobNos
        lbl_currentref.Text = LoadWOfrRFID.JobModelName
        lbl_wocounter.Text = CStr(LoadWOfrRFID.JobQTy)
        lbl_currcounter.Text = CStr(LoadWOfrRFID.JobUnitaryCount)
        lbl_tagnos.Text = LoadWOfrRFID.JobRFIDTag
        lbl_ArticleNos.Text = LoadWOfrRFID.JobArticle

        'Load Rack Material List
        If Not LoadRackMaterial() Then
            MsgBox("Unable to load Rack Materials")
            End
        End If

        'Load Model Material
        If Not LoadModelMaterial(LoadWOfrRFID.JobModelName) Then
            MsgBox("Unable to load Model Material")
            End
        End If
        frmMsg.Label1.Text = "Refreshing indicators..."

        'Update Rack indicator
        If Not ActivateRackLED() Then
            MsgBox("Unable to communicate with PLC")
            End
        End If

        RFID_Comm.Open()
        Barcode_Comm.Open()
        frmMsg.Close()
        Timer1.Enabled = True
    End Sub

    Private Sub cmd_quit_Click(sender As Object, e As EventArgs) Handles cmd_quit.Click
        Barcode_Comm.Close()
        RFID_Comm.Close()
        End
    End Sub

    Private Sub cmd_material_Click(sender As Object, e As EventArgs) Handles cmd_material.Click
        FrmMaterial.ShowDialog()
    End Sub

    Private Sub cmd_database_Click(sender As Object, e As EventArgs) Handles cmd_database.Click
        'FrmLogin.ShowDialog()
        'If Login Then
        frmDatabase.ShowDialog()
        'End If
    End Sub

    Private Sub Cmd_Refresh_Click(sender As Object, e As EventArgs) Handles Cmd_Refresh.Click
        Cmd_Refresh.Enabled = False
        Timer1.Enabled = False

        GetLastConfig()
        'Load parameters
        If Not LoadParameter(LoadWOfrRFID.JobModelName) Then
            MsgBox("Unable to load parameters...")
            End
        End If
        Reset_PLC()
        If Not LoadParameter2PLC Then
            MsgBox("Unable to communicate with PLC...")
            End
        End If

        'Load Rack Material List
        If Not LoadRackMaterial Then
            MsgBox("Unable to load Rack Materials")
            Cmd_Refresh.Enabled = True
            Timer1.Enabled = True
            Exit Sub
        End If

        'Load Model Material
        If Not LoadModelMaterial(LoadWOfrRFID.JobModelName) Then
            MsgBox("Unable to load Model Material")
            Cmd_Refresh.Enabled = True
            Timer1.Enabled = True
            Exit Sub
        End If
        frmMsg.Label1.Text = "Refreshing indicators..."

        'Update Rack indicator
        If Not ActivateRackLED Then
            MsgBox("Unable to communicate with PLC")
            Cmd_Refresh.Enabled = True
            Timer1.Enabled = True
            Exit Sub
        End If
        lbl_WOnos.Text = LoadWOfrRFID.JobNos
        lbl_currentref.Text = LoadWOfrRFID.JobModelName
        lbl_wocounter.Text = CStr(LoadWOfrRFID.JobQTy)
        lbl_currcounter.Text = CStr(LoadWOfrRFID.JobUnitaryCount)
        lbl_tagnos.Text = LoadWOfrRFID.JobRFIDTag
        lbl_ArticleNos.Text = LoadWOfrRFID.JobArticle

        Timer1.Enabled = True
        Cmd_Refresh.Enabled = True
    End Sub

    Private Sub Cmd_Modbus_Click(sender As Object, e As EventArgs) Handles Cmd_Modbus.Click
        Modbus.ShowDialog()
    End Sub

    Private Sub Command4_Click(sender As Object, e As EventArgs) Handles Command4.Click
        If Command4.Text = "Skip" Then
            Command4.Text = "No Skip"
            Modbus.tulisModbus(40401, 0)
        ElseIf Command4.Text = "No Skip" Then
            Command4.Text = "Skip"
            Modbus.tulisModbus(40401, 1)
        End If
    End Sub

    Private Sub Command3_Click(sender As Object, e As EventArgs) Handles Command3.Click
        Modbus.tulisModbus(40001, 1)
    End Sub

    Private Sub Command2_Click(sender As Object, e As EventArgs) Handles Command2.Click
        Modbus.tulisModbus(40600, 1)
    End Sub

    Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click
        If Command1.Text = "Eye Open" Then
            If Not Modbus.tulisModbus(40109, 1) Then
                Txt_Msg.Text = "--> Unable to communicate with PLC - %MW109"
                Exit Sub
            End If
            Command1.Text = "Eye Close"

        ElseIf Command1.Text = "Eye Close" Then
            If Not Modbus.tulisModbus(40109, 0) Then
                Txt_Msg.Text = "--> Unable to communicate with PLC - %MW109"
                Exit Sub
            End If
            Command1.Text = "Eye Open"
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If Command1.Visible = False Then
            Command1.Visible = True
            Command2.Visible = True
            Command3.Visible = True
        Else
            Command1.Visible = False
            Command2.Visible = False
            Command3.Visible = False
        End If
    End Sub

    Private Function LoadParameter(csmodel As String) As Boolean
        Try
            Dim query = "SELECT * FROM TESE.dbo.Parameter WHERE ModelName = '" & csmodel & "'"
            Dim dt = KoneksiDB.bacaData(query).Tables(0)

            LoadWOfrRFID.JobArticle = dt.Rows(0).Item("ArticleNos")
            LoadWOfrRFID.JobModelFW = dt.Rows(0).Item("ProductVer")
            LoadWOfrRFID.JobProductMaterial = dt.Rows(0).Item("MaterialType")

            Return True
            Exit Function
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function LoadParameter2PLC() As Boolean
        If LoadWOfrRFID.JobProductMaterial = "Zamak" Then
            If Not Modbus.tulisModbus(40100, 1) Then
                Return False
                Exit Function
            End If
        Else
            If Not Modbus.tulisModbus(40100, 0) Then
                Return False
                Exit Function
            End If
        End If

        Modbus.tulisModbus(40600, 1)
        Return True
        Exit Function
    End Function

    Private Function LoadModelMaterial(Unitname As String) As Boolean
        Dim filePath As String = INIMATERIALPATH & "Station4\" & Unitname & ".Txt"

        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            Dim lineArray As New List(Of String)()

            For Each line As String In lines
                lineArray.Add(line)
            Next
            LoadWOfrRFID.JobModelMaterial = lineArray.ToArray()
            Return True
        Else
            Return False
        End If
    End Function

    Private Function LoadRackMaterial() As Boolean
        Dim filePath As String = INIMATERIALPATH & "Rack\" & "Station4"

        If File.Exists(filePath) Then
            Dim lines As String() = File.ReadAllLines(filePath)
            Dim lineArray As New List(Of String)()

            For Each line As String In lines
                lineArray.Add(line)
            Next
            Unitmaterial.PartNos = lineArray.ToArray()

            ReDim Unitmaterial.PartPLCWord(lines.Length - 1)
            For i As Integer = 0 To lines.Length - 1
                Unitmaterial.PartPLCWord(i) = 40200 + i
            Next

            Return True
        Else
            Return False
        End If
    End Function

    Private Function ActivateRackLED() As Boolean
        Dim i As Integer
        Dim N As Integer

        For i = 0 To LoadWOfrRFID.JobModelMaterial.Length - 1
            If LoadWOfrRFID.JobModelMaterial(i) <> "" Then
                For N = 0 To Unitmaterial.PartNos.Length - 1
                    If LoadWOfrRFID.JobModelMaterial(i) = Unitmaterial.PartNos(N) Then
                        If Not Modbus.tulisModbus(Unitmaterial.PartPLCWord(N), 1) Then
                            GoTo ErrorHandler
                        End If
                    End If
                Next
            End If
        Next

        Return True
        Exit Function
ErrorHandler:
        Return False
    End Function

    Public Sub Reset_PLC()
        Modbus.tulisModbus(40500, 1)
    End Sub

    Private Function ValidiateWONos(strName As String) As String
        Try
            Dim temp As String
            Dim query = "SELECT * FROM TESE.dbo.CSUNIT WHERE WONOS = '" & strName & "'"
            Dim dt = KoneksiDB.bacaData(query).Tables(0)

            temp = dt.Rows(0).Item("STATUS")
            Return temp
        Catch ex As Exception
            Return "NOK"
        End Try
    End Function

    Private Sub ErasePSNFileInfo()
        PSNFileInfo.DateCompleted = ""
        PSNFileInfo.DateCreated = ""
        PSNFileInfo.DebugComment = ""
        PSNFileInfo.DebugStatus = ""
        PSNFileInfo.DebugTechnican = ""
        PSNFileInfo.ElectroMagnet = ""
        PSNFileInfo.FTCheckIn = ""
        PSNFileInfo.FTCheckOut = ""
        PSNFileInfo.FTStatus = ""
        PSNFileInfo.MainPCBA = ""
        PSNFileInfo.ModelName = ""
        PSNFileInfo.OperatorID = ""
        PSNFileInfo.PackagingCheckIn = ""
        PSNFileInfo.PackagingCheckOut = ""
        PSNFileInfo.PackagingStatus = ""
        PSNFileInfo.PSN = ""
        PSNFileInfo.RepairDate = ""
        PSNFileInfo.ScrewStnCheckIn = ""
        PSNFileInfo.ScrewStnCheckOut = ""
        PSNFileInfo.ScrewStnStatus = ""
        PSNFileInfo.SecondaryPCBA = ""
        PSNFileInfo.Stn5CheckIn = ""
        PSNFileInfo.Stn5CheckOut = ""
        PSNFileInfo.Stn5Status = ""
        PSNFileInfo.WONos = ""
    End Sub

    Private Function RefCheck(strName As String) As Boolean
        Dim query = "SELECT * FROM TESE.dbo.Parameter WHERE ModelName = '" & strName & "'"
        Dim dt = KoneksiDB.bacaData(query).Tables(0)

        If dt.Rows(0).Item("ModelName") = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub ZbrPrinter(SerialNos As String)
        Dim FILENO As Integer
        FILENO = FreeFile()
        On Error Resume Next

        '========= Zebra USB PORT ==========
        Dim lhPrinter As Integer
        Dim lReturn As Integer
        Dim lpcWritten As Integer
        Dim lDoc As Integer
        Dim MyDocInfo As DOCINFO
        Dim sPrinterName As String

        sPrinterName = "Zebra TLP2844-Z"
        'lReturn = OpenPrinter(Printer.DeviceName, lhPrinter, 0)
        lReturn = OpenPrinter(sPrinterName, lhPrinter, 0)
        If lReturn = 0 Then
            MsgBox("The Printer Name you typed wasn't recognised.")
            Exit Sub
        End If
        MyDocInfo.pDocName = "Servo 3"
        MyDocInfo.pOutputFile = vbNullString
        MyDocInfo.pDataType = vbNullString
        lDoc = StartDocPrinter(lhPrinter, 1, MyDocInfo)
        StartPagePrinter(lhPrinter)
        'sWrittendata = "^XA^FO370,60^A0,10,15^FD" & "1234567890" & "^FS^FO310,40^BXN,5,400^FD" & "12345" & "^FS^XZ"
        sWrittendata = "^XA^FO360,50^A0,15,15^FD" & SerialNos & "^FS^FO300,35^BXN,3,200^FD" & SerialNos & "^FS^XZ"
        lReturn = WritePrinter(lhPrinter, sWrittendata, Len(sWrittendata), lpcWritten)

        ' read data
        Dim sReadData As String
        Dim lpcRead As Integer

        lReturn = ReadPrinter(lhPrinter, sReadData, Len(sReadData), lpcRead)

        lReturn = EndPagePrinter(lhPrinter)
        lReturn = EndDocPrinter(lhPrinter)
        lReturn = ClosePrinter(lhPrinter)
        '=======================================
    End Sub

    Private Sub CMD_Read_Inputs_Click(sender As Object, e As EventArgs) Handles CMD_Read_Inputs.Click
        ZbrPrinter("123456001091100001")
    End Sub

    Private Sub Barcode_Comm_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles Barcode_Comm.DataReceived
        AssyBuf = Barcode_Comm.ReadExisting()
        If InStr(1, AssyBuf, vbCrLf) <> 0 Then
            Me.Invoke(Sub()
                          Txt_Msg.BackColor = Color.LightGray
                          Txt_Msg.Text = ""
                          Label9.Text = ""
                          AssyBuf = Mid(AssyBuf, 1, InStr(1, AssyBuf, vbCr) - 1)
                          Image1.Image = Nothing

                          If lbl_WOnos.Text <> "MASTER" Then
                              'Checking Current WO first b4 Change Series is allowed. If WO status is open, check Quantity
                              CheckWO = ValidiateWONos(lbl_WOnos.Text)
                              If CheckWO = "NOK" Then
                                  Txt_Msg.Text = "Invalid WO - WO is not registered in Server"
                                  lbl_msg.Text = "Ask for technical assistance"
                                  AssyBuf = ""
                                  Exit Sub
                              End If
                              If CheckWO <> "DISTRUP" Then
                                  'If Command1.Caption = "Eye Open" Then
                                  '   If Val(lbl_currcounter.Caption) >= Val(lbl_wocounter.Caption) Then
                                  '      Txt_Msg.Text = "Quantity Reached. WO Completed"
                                  '     lbl_msg.Caption = "STOP PROCESS"
                                  '       AssyBuf = ""
                                  '      Exit Sub
                                  ' End If
                                  'End If
                              Else
                                  Txt_Msg.Text = "WO Distrupted"
                                  lbl_msg.Text = "PLEASE CHANGE SERIES"
                                  AssyBuf = ""
                                  Exit Sub
                              End If
                          Else 'If MASTER TAG in use
                              If Val(lbl_currcounter.Text) >= Val(lbl_wocounter.Text) Then
                                  Txt_Msg.Text = "Quantity reached. WO Completed"
                                  lbl_msg.Text = "STOP PROCESS"
                                  AssyBuf = ""
                                  Exit Sub
                              End If
                          End If

                          'Check Article Nos
                          If Microsoft.VisualBasic.Left(AssyBuf, 6) <> LoadWOfrRFID.JobArticle Then
                              Txt_Msg.Text = "--> PSN - " & AssyBuf & " = wrong reference"
                              Txt_Msg.BackColor = Color.Red
                              AssyBuf = ""
                              Exit Sub
                          Else
                              Txt_Msg.Text = "PSN - " & AssyBuf & vbCrLf
                              PSNFileInfo.PSN = AssyBuf
                          End If

                          Txt_Msg.Text = Txt_Msg.Text & "Loading " & AssyBuf & ".Txt..." & vbCrLf
                          If Dir(INIPSNFOLDERPATH & AssyBuf & ".Txt") = "" Then
                              Txt_Msg.Text = Txt_Msg.Text & "--> Unable to find " & AssyBuf & ".Txt" & vbCrLf
                              Txt_Msg.BackColor = Color.Red
                              AssyBuf = ""
                              Exit Sub
                          End If
                          If Not LOADPSNFILE(AssyBuf) Then
                              Txt_Msg.Text = Txt_Msg.Text & "--> Unable to load " & AssyBuf & ".Txt" & vbCrLf
                              Txt_Msg.BackColor = Color.Red
                              AssyBuf = ""
                              Exit Sub
                          End If
                          Txt_Msg.Text = "PSN - " & AssyBuf & " verified" & vbCrLf

                          PSNFileInfo.ScrewStnCheckIn = Today & "," & TimeOfDay

                          If Not Modbus.tulisModbus(40105, 1) Then 'Inform PLC, PSN is verified
                              Txt_Msg.Text = "--> Unable to communicate with PLC - MW105" & vbCrLf
                              Txt_Msg.BackColor = Color.Red
                              AssyBuf = ""
                              Exit Sub
                          End If
                          lbl_msg.Text = "Please proceed with process..."
                          AssyBuf = ""
                          Exit Sub
                      End Sub)
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Image2.Image = Image.FromFile(INISLIDEPATH & "Slide" & SlideCount & ".JPG")
        SlideCount = SlideCount + 1
        If SlideCount = 31 Then SlideCount = 27
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Tagref As String
        Dim Tagnos As String
        Dim TagQty As String
        Dim Tagid As String

        Ethernet.BackColor = Color.Black
        ReadTagFlag = True
        Tagnos = RD_MULTI_RFID("0000", 10)

        If Tagnos = "NOK" Then GoTo NoChange
        Tagid = RD_MULTI_RFID("0040", 3) 'Read Tag ID
        Dim CheckWO As String
        If Tagnos = "MASTER" Then
            If Tagid = lbl_tagnos.Text Then GoTo NoChange
            If lbl_WOnos.Text <> "MASTER" Then
                'update the Current WO into the database before changing
                If CheckWOExist((lbl_WOnos.Text)) Then
                    UpdateWO(lbl_WOnos.Text, lbl_currcounter.Text)
                Else
                    AddWO((lbl_WOnos.Text))
                    UpdateWO(lbl_WOnos.Text, lbl_currcounter.Text)
                End If
                GoTo WOChange
            ElseIf lbl_WOnos.Text = "MASTER" Then
                GoTo WOChange
            End If
        ElseIf Tagnos <> LoadWOfrRFID.JobNos Then
Master:
            If lbl_WOnos.Text <> "MASTER" Then
                'Checking Current WO first b4 Change Series is allowed. If WO status is open, check Quantity
                CheckWO = ValidiateWONos(lbl_WOnos.Text)
                If CheckWO = "NOK" Then
                    Txt_Msg.Text = "Invalid WO - WO is not registered in Server"
                    GoTo NoChange
                ElseIf CheckWO = "OPEN" Then

                ElseIf CheckWO = "CLOSED" Then

                ElseIf CheckWO = "FORCED" Then

                ElseIf CheckWO = "DISTRUP" Then

                End If
                'update the Current WO into the database before changing
                If CheckWOExist(lbl_WOnos.Text) Then
                    Call UpdateWO(lbl_WOnos.Text, lbl_currcounter.Text)
                Else
                    Call AddWO(lbl_WOnos.Text)
                    Call UpdateWO(lbl_WOnos.Text, lbl_currcounter.Text)
                End If
            End If
WOChange:
            Txt_Msg.Text = "Changing Series..." & vbCrLf
            Txt_Msg.Text = Txt_Msg.Text & "Reading info from RFID Tag..." & vbCrLf
            LoadWOfrRFID.JobNos = Tagnos
            Tagref = RD_MULTI_RFID("0014", 10) 'Read WO Reference from Tag
            If Tagref = "NOK" Then
                Txt_Msg.Text = Txt_Msg.Text & "--> Unable to read from RFID Tag" & vbCrLf
                Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
                ReadTagFlag = False
                Exit Sub
            End If
            TagQty = RD_MULTI_RFID("0028", 10) 'Read WO Qty from Tag
            If TagQty = "NOK" Then
                Txt_Msg.Text = Txt_Msg.Text & "--> Unable to read from RFID Tag" & vbCrLf
                Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
                ReadTagFlag = False
                Exit Sub
            End If
            Tagid = RD_MULTI_RFID("0040", 3) 'Read Tag ID
            If Tagid = "NOK" Then
                Txt_Msg.Text = Txt_Msg.Text & "--> Unable to read from RFID Tag" & vbCrLf
                Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
                ReadTagFlag = False
                Exit Sub
            End If
            'Check if reference is valid from the database
            If Not RefCheck(Tagref) Then
                Txt_Msg.Text = Txt_Msg.Text & "--> Invalid Reference" & vbCrLf
                Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
                ReadTagFlag = False
                Exit Sub
            End If
            Txt_Msg.Text = Txt_Msg.Text & "loading parameters of new reference..." & vbCrLf
            If Not LoadModelMaterial(Tagref) Then
                Txt_Msg.Text = Txt_Msg.Text & "--> Unable to load Model parameter" & vbCrLf
                Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
                ReadTagFlag = False
                Exit Sub
            End If
            'Load parameters
            Txt_Msg.Text = Txt_Msg.Text & "loading parameters to PLC..." & vbCrLf
            If Not LoadParameter(Tagref) Then
                MsgBox("Unable to load parameters...")
                End
            End If
            If Not LoadParameter2PLC() Then
                MsgBox("Unable to communicate with PLC...")
                End
            End If
            Reset_PLC()
            If Not ActivateRackLED() Then
                Txt_Msg.Text = Txt_Msg.Text & "--> Unable to communicate with PLC" & vbCrLf
                Txt_Msg.Text = Txt_Msg.Text & "--> Change Series fail" & vbCrLf
                ReadTagFlag = False
                Exit Sub
            End If

            lbl_WOnos.Text = Tagnos
            LoadWOfrRFID.JobNos = Tagnos
            lbl_currentref.Text = Tagref
            LoadWOfrRFID.JobModelName = Tagref
            lbl_wocounter.Text = TagQty
            LoadWOfrRFID.JobQTy = CShort(TagQty)
            lbl_tagnos.Text = Tagid
            LoadWOfrRFID.JobRFIDTag = Tagid
            lbl_ArticleNos.Text = LoadWOfrRFID.JobArticle

            If Tagnos <> "MASTER" Then
                If CheckWOExist(Tagnos) Then
                    LoadWOfrRFID.JobUnitaryCount = Val(RetrieveWOQty(Tagnos))
                    lbl_currcounter.Text = CStr(LoadWOfrRFID.JobUnitaryCount)
                Else
                    Call AddWO(Tagnos)
                    LoadWOfrRFID.JobUnitaryCount = 0 'Reset output counter
                    lbl_currcounter.Text = "0"
                End If
            Else
                lbl_currcounter.Text = "0"
                LoadWOfrRFID.JobUnitaryCount = 0
            End If



            UpdateStnStatus()
            Txt_Msg.Text = Txt_Msg.Text & "Change Series completed" & vbCrLf
            ErasePSNFileInfo() 'clearing all variable
            PSNFileInfo.ModelName = LoadWOfrRFID.JobModelName
            PSNFileInfo.WONos = LoadWOfrRFID.JobNos
        End If
        ReadTagFlag = False
NoChange:

        Dim Station_status As Integer
        Dim Failcode As Integer
        Dim Verifydata As String
        Dim Verifypsn As String

        Station_status = Modbus.bacaModbus(40101)
        Text2.Text = CStr(Station_status)
        Ethernet.BackColor = Color.Lime
        Select Case Station_status
            Case 0 'Waiting for new product
                lbl_msg.Text = "Please scan the PSN barcode..."
            Case 1 'PSN scan and verified, waiting for start button to be depressed
                lbl_msg.Text = "Please load product and start process..."
            Case 2 'Testing in progress
                Image1.Image = Nothing
                Txt_Msg.BackColor = System.Drawing.ColorTranslator.FromOle(&HE0E0E0)
                lbl_msg.Text = "Please wait, in progress..."
                If Command1.Text = "Eye Close" Then
                    Txt_Msg.Text = ""
                End If
                Label10.Text = CStr(Modbus.bacaModbus(40400))
                Label9.Text = Dec2Bin(CDbl(Label10.Text))
            Case 3 'Testing completed, waiting for screwing sequence to be completed
                lbl_msg.Text = "Please proceed with the screwing process..."
            Case 4 'PLC inform PC about completion of process, read test outcome
                If Modbus.bacaModbus(40102) = 1 Then 'Pass
                    EnableCount = False
                    If PSNFileInfo.ScrewStnStatus = "" Or PSNFileInfo.ScrewStnStatus = "FAIL" Then
                        EnableCount = True
                    End If
                    PSNFileInfo.ScrewStnStatus = "PASS"
                    Image1.Image = My.Resources.Pass
                Else 'Fail
                    PSNFileInfo.ScrewStnStatus = "FAIL"
                    Image1.Image = My.Resources.Fail
                    Txt_Msg.BackColor = System.Drawing.Color.Red

                    Failcode = Modbus.bacaModbus(40110)
                    If Failcode = 5 Then
                        Txt_Msg.Text = "--> Mis-Match of Head and Body" & vbCrLf
                    ElseIf Failcode = 6 Then
                        Txt_Msg.Text = "--> Wrong Body or Head Orientation" & vbCrLf
                    ElseIf Failcode = 7 Then
                        Txt_Msg.Text = "--> Missing Mechanism Cover screw" & vbCrLf
                    ElseIf Failcode = 8 Then
                        Txt_Msg.Text = "--> Missing CMS Cover" & vbCrLf
                    ElseIf Failcode = 9 Then
                        Txt_Msg.Text = "--> Missing Insulation Base" & vbCrLf
                    End If
                End If

                'Updating the PSN text file
                If Command1.Text = "Eye Open" Then
                    PSNFileInfo.ScrewStnCheckOut = Today & "," & TimeOfDay

                    Txt_Msg.Text = Txt_Msg.Text & "Updating " & PSNFileInfo.PSN & ".Txt..." & vbCrLf
                    lbl_msg.Text = "Please wait..."
ReWrite:
                    Verifydata = PSNFileInfo.ScrewStnStatus
                    Verifypsn = PSNFileInfo.PSN
                    If Not WRITEPSNFILE(PSNFileInfo.PSN) Then
                        Txt_Msg.Text = Txt_Msg.Text & "--> Unable to access " & PSNFileInfo.PSN & ".Txt in the server" & vbCrLf
                        Txt_Msg.BackColor = Color.Red
                        GoTo 500
                    End If
                    If Not LOADPSNFILE(Verifypsn) Then
                        Txt_Msg.Text = Txt_Msg.Text & "--> Unable to load " & Verifypsn & ".Txt again" & vbCrLf
                        Txt_Msg.BackColor = Color.Red
                        GoTo 500
                    End If
                    If PSNFileInfo.ScrewStnStatus <> Verifydata Then
                        Txt_Msg.Text = Txt_Msg.Text & "Rewriting PSN.Txt file again..." & vbCrLf
                        GoTo ReWrite
                    End If
                    'Skip increment if repeated
                    If PSNFileInfo.ScrewStnStatus = "PASS" Then
                        If EnableCount = True Then
                            lbl_currcounter.Text = CStr(Val(lbl_currcounter.Text) + 1)
                        End If
                        LoadWOfrRFID.JobUnitaryCount = Val(lbl_currcounter.Text)
                    End If
                    If Val(lbl_currcounter.Text) >= Val(lbl_wocounter.Text) Then
                        Txt_Msg.Text = "WO Quantity Reached - WO Completed"
                        lbl_msg.Text = "STOP PROCESS"
                    End If
                    Txt_Msg.Text = Txt_Msg.Text & PSNFileInfo.PSN & ".Txt updated." & vbCrLf
                    UpdateStnStatus()
                End If
500:

                If Not Modbus.tulisModbus(40101, 10) Then 'Inform PLC that PC already read result
                    Txt_Msg.Text = Txt_Msg.Text & "--> Unable to communicate with PLC - MW105" & vbCrLf
                    Txt_Msg.BackColor = Color.Red
                    Exit Sub
                End If
        End Select
    End Sub
End Class
