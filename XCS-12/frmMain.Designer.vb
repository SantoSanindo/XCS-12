<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_ArticleNos = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_tagnos = New System.Windows.Forms.Label()
        Me.lbl_WOnos = New System.Windows.Forms.Label()
        Me.lbl_wocounter = New System.Windows.Forms.Label()
        Me.lbl_currentref = New System.Windows.Forms.Label()
        Me.cmd_quit = New System.Windows.Forms.Button()
        Me.cmd_material = New System.Windows.Forms.Button()
        Me.cmd_database = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.Command4 = New System.Windows.Forms.Button()
        Me.Cmd_Modbus = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_msg = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Msg = New System.Windows.Forms.TextBox()
        Me.lbl_currcounter = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.lbl_localip = New System.Windows.Forms.Label()
        Me.lbl_localhostname = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Ethernet = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Image2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Barcode_Comm = New System.IO.Ports.SerialPort(Me.components)
        Me.RFID_Comm = New System.IO.Ports.SerialPort(Me.components)
        Me.Cmd_Refresh = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CMD_Read_Inputs = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Ethernet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_ArticleNos)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_tagnos)
        Me.GroupBox1.Controls.Add(Me.lbl_WOnos)
        Me.GroupBox1.Controls.Add(Me.lbl_wocounter)
        Me.GroupBox1.Controls.Add(Me.lbl_currentref)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 111)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(70, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Work Order Qty :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(737, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 55)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "SC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(65, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Work Order Nos :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(19, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 18)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Work Order Reference :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(83, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 18)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "RFID Tag Nos :"
        '
        'lbl_ArticleNos
        '
        Me.lbl_ArticleNos.AutoSize = True
        Me.lbl_ArticleNos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ArticleNos.ForeColor = System.Drawing.Color.Green
        Me.lbl_ArticleNos.Location = New System.Drawing.Point(218, 89)
        Me.lbl_ArticleNos.Name = "lbl_ArticleNos"
        Me.lbl_ArticleNos.Size = New System.Drawing.Size(14, 18)
        Me.lbl_ArticleNos.TabIndex = 14
        Me.lbl_ArticleNos.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(107, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Article Nos :"
        '
        'lbl_tagnos
        '
        Me.lbl_tagnos.AutoSize = True
        Me.lbl_tagnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tagnos.ForeColor = System.Drawing.Color.Green
        Me.lbl_tagnos.Location = New System.Drawing.Point(218, 69)
        Me.lbl_tagnos.Name = "lbl_tagnos"
        Me.lbl_tagnos.Size = New System.Drawing.Size(14, 18)
        Me.lbl_tagnos.TabIndex = 14
        Me.lbl_tagnos.Text = "-"
        '
        'lbl_WOnos
        '
        Me.lbl_WOnos.AutoSize = True
        Me.lbl_WOnos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_WOnos.ForeColor = System.Drawing.Color.Green
        Me.lbl_WOnos.Location = New System.Drawing.Point(218, 9)
        Me.lbl_WOnos.Name = "lbl_WOnos"
        Me.lbl_WOnos.Size = New System.Drawing.Size(14, 18)
        Me.lbl_WOnos.TabIndex = 14
        Me.lbl_WOnos.Text = "-"
        '
        'lbl_wocounter
        '
        Me.lbl_wocounter.AutoSize = True
        Me.lbl_wocounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_wocounter.ForeColor = System.Drawing.Color.Green
        Me.lbl_wocounter.Location = New System.Drawing.Point(218, 49)
        Me.lbl_wocounter.Name = "lbl_wocounter"
        Me.lbl_wocounter.Size = New System.Drawing.Size(14, 18)
        Me.lbl_wocounter.TabIndex = 14
        Me.lbl_wocounter.Text = "-"
        '
        'lbl_currentref
        '
        Me.lbl_currentref.AutoSize = True
        Me.lbl_currentref.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currentref.ForeColor = System.Drawing.Color.Green
        Me.lbl_currentref.Location = New System.Drawing.Point(218, 29)
        Me.lbl_currentref.Name = "lbl_currentref"
        Me.lbl_currentref.Size = New System.Drawing.Size(14, 18)
        Me.lbl_currentref.TabIndex = 14
        Me.lbl_currentref.Text = "-"
        '
        'cmd_quit
        '
        Me.cmd_quit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_quit.Image = CType(resources.GetObject("cmd_quit.Image"), System.Drawing.Image)
        Me.cmd_quit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_quit.Location = New System.Drawing.Point(916, 12)
        Me.cmd_quit.Name = "cmd_quit"
        Me.cmd_quit.Size = New System.Drawing.Size(88, 57)
        Me.cmd_quit.TabIndex = 18
        Me.cmd_quit.Text = "Quit"
        Me.cmd_quit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_quit.UseVisualStyleBackColor = True
        '
        'cmd_material
        '
        Me.cmd_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_material.Image = CType(resources.GetObject("cmd_material.Image"), System.Drawing.Image)
        Me.cmd_material.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_material.Location = New System.Drawing.Point(916, 75)
        Me.cmd_material.Name = "cmd_material"
        Me.cmd_material.Size = New System.Drawing.Size(88, 57)
        Me.cmd_material.TabIndex = 19
        Me.cmd_material.Text = "Rack"
        Me.cmd_material.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_material.UseVisualStyleBackColor = True
        '
        'cmd_database
        '
        Me.cmd_database.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_database.Image = CType(resources.GetObject("cmd_database.Image"), System.Drawing.Image)
        Me.cmd_database.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_database.Location = New System.Drawing.Point(916, 138)
        Me.cmd_database.Name = "cmd_database"
        Me.cmd_database.Size = New System.Drawing.Size(88, 57)
        Me.cmd_database.TabIndex = 20
        Me.cmd_database.Text = "Material"
        Me.cmd_database.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_database.UseVisualStyleBackColor = True
        '
        'Command1
        '
        Me.Command1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
        Me.Command1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command1.Location = New System.Drawing.Point(916, 670)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(88, 57)
        Me.Command1.TabIndex = 21
        Me.Command1.Text = "Eye Open"
        Me.Command1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command1.UseVisualStyleBackColor = True
        '
        'Command2
        '
        Me.Command2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command2.Image = CType(resources.GetObject("Command2.Image"), System.Drawing.Image)
        Me.Command2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command2.Location = New System.Drawing.Point(916, 574)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(88, 90)
        Me.Command2.TabIndex = 22
        Me.Command2.Text = "Reset Screw Counter"
        Me.Command2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command2.UseVisualStyleBackColor = True
        '
        'Command3
        '
        Me.Command3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command3.Image = CType(resources.GetObject("Command3.Image"), System.Drawing.Image)
        Me.Command3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command3.Location = New System.Drawing.Point(916, 493)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(88, 75)
        Me.Command3.TabIndex = 23
        Me.Command3.Text = "Reset Sequence"
        Me.Command3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command3.UseVisualStyleBackColor = True
        '
        'Command4
        '
        Me.Command4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.Image = CType(resources.GetObject("Command4.Image"), System.Drawing.Image)
        Me.Command4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Command4.Location = New System.Drawing.Point(916, 430)
        Me.Command4.Name = "Command4"
        Me.Command4.Size = New System.Drawing.Size(88, 57)
        Me.Command4.TabIndex = 24
        Me.Command4.Text = "No Skip"
        Me.Command4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Command4.UseVisualStyleBackColor = True
        '
        'Cmd_Modbus
        '
        Me.Cmd_Modbus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Modbus.Image = CType(resources.GetObject("Cmd_Modbus.Image"), System.Drawing.Image)
        Me.Cmd_Modbus.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cmd_Modbus.Location = New System.Drawing.Point(916, 264)
        Me.Cmd_Modbus.Name = "Cmd_Modbus"
        Me.Cmd_Modbus.Size = New System.Drawing.Size(88, 57)
        Me.Cmd_Modbus.TabIndex = 26
        Me.Cmd_Modbus.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_Modbus.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_msg)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Txt_Msg)
        Me.GroupBox2.Controls.Add(Me.lbl_currcounter)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Image1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(431, 492)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'lbl_msg
        '
        Me.lbl_msg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_msg.ForeColor = System.Drawing.Color.Red
        Me.lbl_msg.Location = New System.Drawing.Point(7, 379)
        Me.lbl_msg.Name = "lbl_msg"
        Me.lbl_msg.Size = New System.Drawing.Size(418, 93)
        Me.lbl_msg.TabIndex = 21
        Me.lbl_msg.Text = "Please scan the PSN barcode..."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 355)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Operator's Instruction"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "System Information"
        '
        'Txt_Msg
        '
        Me.Txt_Msg.BackColor = System.Drawing.Color.LightGray
        Me.Txt_Msg.Location = New System.Drawing.Point(6, 131)
        Me.Txt_Msg.Multiline = True
        Me.Txt_Msg.Name = "Txt_Msg"
        Me.Txt_Msg.Size = New System.Drawing.Size(419, 209)
        Me.Txt_Msg.TabIndex = 18
        '
        'lbl_currcounter
        '
        Me.lbl_currcounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_currcounter.ForeColor = System.Drawing.Color.Green
        Me.lbl_currcounter.Location = New System.Drawing.Point(60, 51)
        Me.lbl_currcounter.Name = "lbl_currcounter"
        Me.lbl_currcounter.Size = New System.Drawing.Size(172, 43)
        Me.lbl_currcounter.TabIndex = 16
        Me.lbl_currcounter.Text = "0"
        Me.lbl_currcounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(60, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 31)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Qty Output :"
        '
        'Image1
        '
        Me.Image1.Location = New System.Drawing.Point(314, 14)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(111, 111)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image1.TabIndex = 0
        Me.Image1.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.CMD_Read_Inputs)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.Label75)
        Me.GroupBox7.Controls.Add(Me.lbl_localip)
        Me.GroupBox7.Controls.Add(Me.lbl_localhostname)
        Me.GroupBox7.Controls.Add(Me.Label72)
        Me.GroupBox7.Controls.Add(Me.Ethernet)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 627)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(431, 100)
        Me.GroupBox7.TabIndex = 28
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Ethernet"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.Green
        Me.Label75.Location = New System.Drawing.Point(12, 75)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(179, 15)
        Me.Label75.TabIndex = 9
        Me.Label75.Text = "PLC IP Address : 126.254.108.2"
        '
        'lbl_localip
        '
        Me.lbl_localip.AutoSize = True
        Me.lbl_localip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localip.ForeColor = System.Drawing.Color.Green
        Me.lbl_localip.Location = New System.Drawing.Point(12, 60)
        Me.lbl_localip.Name = "lbl_localip"
        Me.lbl_localip.Size = New System.Drawing.Size(45, 15)
        Me.lbl_localip.TabIndex = 9
        Me.lbl_localip.Text = "Label1"
        '
        'lbl_localhostname
        '
        Me.lbl_localhostname.AutoSize = True
        Me.lbl_localhostname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_localhostname.ForeColor = System.Drawing.Color.Green
        Me.lbl_localhostname.Location = New System.Drawing.Point(12, 45)
        Me.lbl_localhostname.Name = "lbl_localhostname"
        Me.lbl_localhostname.Size = New System.Drawing.Size(45, 15)
        Me.lbl_localhostname.TabIndex = 9
        Me.lbl_localhostname.Text = "Label1"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Green
        Me.Label72.Location = New System.Drawing.Point(57, 25)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(52, 15)
        Me.Label72.TabIndex = 9
        Me.Label72.Text = "Connect"
        '
        'Ethernet
        '
        Me.Ethernet.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Ethernet.Location = New System.Drawing.Point(16, 22)
        Me.Ethernet.Name = "Ethernet"
        Me.Ethernet.Size = New System.Drawing.Size(25, 20)
        Me.Ethernet.TabIndex = 0
        Me.Ethernet.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Text2)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Image2)
        Me.GroupBox3.Location = New System.Drawing.Point(449, 129)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(461, 598)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        '
        'Text2
        '
        Me.Text2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.Location = New System.Drawing.Point(103, 555)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(100, 26)
        Me.Text2.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 558)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 20)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "%MW101 - "
        '
        'Image2
        '
        Me.Image2.Location = New System.Drawing.Point(6, 14)
        Me.Image2.Name = "Image2"
        Me.Image2.Size = New System.Drawing.Size(449, 521)
        Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image2.TabIndex = 1
        Me.Image2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'Barcode_Comm
        '
        '
        'Cmd_Refresh
        '
        Me.Cmd_Refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Refresh.Image = CType(resources.GetObject("Cmd_Refresh.Image"), System.Drawing.Image)
        Me.Cmd_Refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Cmd_Refresh.Location = New System.Drawing.Point(916, 201)
        Me.Cmd_Refresh.Name = "Cmd_Refresh"
        Me.Cmd_Refresh.Size = New System.Drawing.Size(88, 57)
        Me.Cmd_Refresh.TabIndex = 29
        Me.Cmd_Refresh.Text = "Refresh"
        Me.Cmd_Refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_Refresh.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(275, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "-"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(275, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 20)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "-"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CMD_Read_Inputs
        '
        Me.CMD_Read_Inputs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_Read_Inputs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CMD_Read_Inputs.Location = New System.Drawing.Point(204, 16)
        Me.CMD_Read_Inputs.Name = "CMD_Read_Inputs"
        Me.CMD_Read_Inputs.Size = New System.Drawing.Size(65, 57)
        Me.CMD_Read_Inputs.TabIndex = 30
        Me.CMD_Read_Inputs.Text = "READ PLC"
        Me.CMD_Read_Inputs.UseVisualStyleBackColor = True
        Me.CMD_Read_Inputs.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 739)
        Me.Controls.Add(Me.Cmd_Refresh)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Cmd_Modbus)
        Me.Controls.Add(Me.Command4)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.cmd_database)
        Me.Controls.Add(Me.cmd_material)
        Me.Controls.Add(Me.cmd_quit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Head to Body Assembly Station - Developed by SESEA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Ethernet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_ArticleNos As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_tagnos As Label
    Friend WithEvents lbl_WOnos As Label
    Friend WithEvents lbl_wocounter As Label
    Friend WithEvents lbl_currentref As Label
    Friend WithEvents cmd_quit As Button
    Friend WithEvents cmd_material As Button
    Friend WithEvents cmd_database As Button
    Friend WithEvents Command1 As Button
    Friend WithEvents Command2 As Button
    Friend WithEvents Command3 As Button
    Friend WithEvents Command4 As Button
    Friend WithEvents Cmd_Modbus As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Image1 As PictureBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label75 As Label
    Friend WithEvents lbl_localip As Label
    Friend WithEvents lbl_localhostname As Label
    Friend WithEvents Label72 As Label
    Friend WithEvents Ethernet As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Image2 As PictureBox
    Friend WithEvents lbl_currcounter As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Txt_Msg As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_msg As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Barcode_Comm As IO.Ports.SerialPort
    Friend WithEvents RFID_Comm As IO.Ports.SerialPort
    Friend WithEvents Text2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Cmd_Refresh As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CMD_Read_Inputs As Button
End Class
