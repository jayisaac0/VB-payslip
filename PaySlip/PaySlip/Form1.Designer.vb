<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpIncome = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNetSalaryInKsh = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtNetSalaryInKsh = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.grpJobDetails = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.cboTookLeave = New System.Windows.Forms.ComboBox()
        Me.cboTookAdvance = New System.Windows.Forms.ComboBox()
        Me.lblTookLeave = New System.Windows.Forms.Label()
        Me.lblTookAdvance = New System.Windows.Forms.Label()
        Me.lblWorkedOvertime = New System.Windows.Forms.Label()
        Me.chkTookLeave = New System.Windows.Forms.CheckBox()
        Me.chkTookAdvance = New System.Windows.Forms.CheckBox()
        Me.chkWorkedOvertime = New System.Windows.Forms.CheckBox()
        Me.grpPersonaldetails = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblMaritalStatus = New System.Windows.Forms.Label()
        Me.cboMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grpRemunerations = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalRemuneration = New System.Windows.Forms.Label()
        Me.lblOvertimeHrs = New System.Windows.Forms.Label()
        Me.lblLeaveAllowance = New System.Windows.Forms.Label()
        Me.lblHouseAllowance = New System.Windows.Forms.Label()
        Me.txtOvertimeHrs = New System.Windows.Forms.TextBox()
        Me.txtLeaveAllowance = New System.Windows.Forms.TextBox()
        Me.txtHouseAllowance = New System.Windows.Forms.TextBox()
        Me.txtTotalRemuneration = New System.Windows.Forms.TextBox()
        Me.grpDeductions = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTotalDeductions = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblAdvance = New System.Windows.Forms.Label()
        Me.lblNssf = New System.Windows.Forms.Label()
        Me.lblNhif = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.txtAdvance = New System.Windows.Forms.TextBox()
        Me.txtNssf = New System.Windows.Forms.TextBox()
        Me.txtNhif = New System.Windows.Forms.TextBox()
        Me.txtTotalDeductions = New System.Windows.Forms.TextBox()
        Me.grpPaySlip = New System.Windows.Forms.GroupBox()
        Me.txtSlip = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.txtBasicSalary = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.lblBasicSalary = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpIncome.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpJobDetails.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.grpPersonaldetails.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpRemunerations.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.grpDeductions.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.grpPaySlip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpIncome
        '
        Me.grpIncome.Controls.Add(Me.TableLayoutPanel2)
        Me.grpIncome.Location = New System.Drawing.Point(295, 12)
        Me.grpIncome.Name = "grpIncome"
        Me.grpIncome.Size = New System.Drawing.Size(280, 87)
        Me.grpIncome.TabIndex = 0
        Me.grpIncome.TabStop = False
        Me.grpIncome.Text = "Income"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblNetSalaryInKsh, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDate, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNetSalaryInKsh, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePicker1, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(268, 53)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'lblNetSalaryInKsh
        '
        Me.lblNetSalaryInKsh.AutoSize = True
        Me.lblNetSalaryInKsh.Location = New System.Drawing.Point(3, 0)
        Me.lblNetSalaryInKsh.Name = "lblNetSalaryInKsh"
        Me.lblNetSalaryInKsh.Size = New System.Drawing.Size(86, 13)
        Me.lblNetSalaryInKsh.TabIndex = 0
        Me.lblNetSalaryInKsh.Text = "Net salary in Ksh"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(3, 26)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"
        '
        'txtNetSalaryInKsh
        '
        Me.txtNetSalaryInKsh.Location = New System.Drawing.Point(137, 3)
        Me.txtNetSalaryInKsh.Name = "txtNetSalaryInKsh"
        Me.txtNetSalaryInKsh.Size = New System.Drawing.Size(128, 20)
        Me.txtNetSalaryInKsh.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(137, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(128, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'grpJobDetails
        '
        Me.grpJobDetails.Controls.Add(Me.TableLayoutPanel3)
        Me.grpJobDetails.Location = New System.Drawing.Point(283, 19)
        Me.grpJobDetails.Name = "grpJobDetails"
        Me.grpJobDetails.Size = New System.Drawing.Size(274, 150)
        Me.grpJobDetails.TabIndex = 0
        Me.grpJobDetails.TabStop = False
        Me.grpJobDetails.Text = "Job details"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.41791!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.58209!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.cboTookLeave, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.cboTookAdvance, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblTookLeave, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblTookAdvance, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblWorkedOvertime, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.chkTookLeave, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.chkTookAdvance, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.chkWorkedOvertime, 0, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(262, 80)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'cboTookLeave
        '
        Me.cboTookLeave.Enabled = False
        Me.cboTookLeave.FormattingEnabled = True
        Me.cboTookLeave.Items.AddRange(New Object() {"Annual allowance", "House allowance"})
        Me.cboTookLeave.Location = New System.Drawing.Point(130, 3)
        Me.cboTookLeave.Name = "cboTookLeave"
        Me.cboTookLeave.Size = New System.Drawing.Size(121, 21)
        Me.cboTookLeave.TabIndex = 4
        '
        'cboTookAdvance
        '
        Me.cboTookAdvance.Enabled = False
        Me.cboTookAdvance.FormattingEnabled = True
        Me.cboTookAdvance.Items.AddRange(New Object() {"25% basic salary", "50% basic salary"})
        Me.cboTookAdvance.Location = New System.Drawing.Point(130, 28)
        Me.cboTookAdvance.Name = "cboTookAdvance"
        Me.cboTookAdvance.Size = New System.Drawing.Size(121, 21)
        Me.cboTookAdvance.TabIndex = 5
        '
        'lblTookLeave
        '
        Me.lblTookLeave.AutoSize = True
        Me.lblTookLeave.Location = New System.Drawing.Point(24, 0)
        Me.lblTookLeave.Name = "lblTookLeave"
        Me.lblTookLeave.Size = New System.Drawing.Size(61, 13)
        Me.lblTookLeave.TabIndex = 1
        Me.lblTookLeave.Text = "Took leave"
        '
        'lblTookAdvance
        '
        Me.lblTookAdvance.AutoSize = True
        Me.lblTookAdvance.Location = New System.Drawing.Point(24, 25)
        Me.lblTookAdvance.Name = "lblTookAdvance"
        Me.lblTookAdvance.Size = New System.Drawing.Size(77, 13)
        Me.lblTookAdvance.TabIndex = 2
        Me.lblTookAdvance.Text = "Took advance"
        '
        'lblWorkedOvertime
        '
        Me.lblWorkedOvertime.AutoSize = True
        Me.lblWorkedOvertime.Location = New System.Drawing.Point(24, 50)
        Me.lblWorkedOvertime.Name = "lblWorkedOvertime"
        Me.lblWorkedOvertime.Size = New System.Drawing.Size(88, 13)
        Me.lblWorkedOvertime.TabIndex = 3
        Me.lblWorkedOvertime.Text = "Worked overtime"
        '
        'chkTookLeave
        '
        Me.chkTookLeave.AutoSize = True
        Me.chkTookLeave.Location = New System.Drawing.Point(3, 3)
        Me.chkTookLeave.Name = "chkTookLeave"
        Me.chkTookLeave.Size = New System.Drawing.Size(15, 14)
        Me.chkTookLeave.TabIndex = 7
        Me.chkTookLeave.UseVisualStyleBackColor = True
        '
        'chkTookAdvance
        '
        Me.chkTookAdvance.AutoSize = True
        Me.chkTookAdvance.Location = New System.Drawing.Point(3, 28)
        Me.chkTookAdvance.Name = "chkTookAdvance"
        Me.chkTookAdvance.Size = New System.Drawing.Size(15, 14)
        Me.chkTookAdvance.TabIndex = 8
        Me.chkTookAdvance.UseVisualStyleBackColor = True
        '
        'chkWorkedOvertime
        '
        Me.chkWorkedOvertime.AutoSize = True
        Me.chkWorkedOvertime.Location = New System.Drawing.Point(3, 53)
        Me.chkWorkedOvertime.Name = "chkWorkedOvertime"
        Me.chkWorkedOvertime.Size = New System.Drawing.Size(15, 14)
        Me.chkWorkedOvertime.TabIndex = 9
        Me.chkWorkedOvertime.UseVisualStyleBackColor = True
        '
        'grpPersonaldetails
        '
        Me.grpPersonaldetails.Controls.Add(Me.TableLayoutPanel4)
        Me.grpPersonaldetails.Location = New System.Drawing.Point(6, 19)
        Me.grpPersonaldetails.Name = "grpPersonaldetails"
        Me.grpPersonaldetails.Size = New System.Drawing.Size(271, 150)
        Me.grpPersonaldetails.TabIndex = 0
        Me.grpPersonaldetails.TabStop = False
        Me.grpPersonaldetails.Text = "Personal details"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblSex, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblMaritalStatus, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cboMaritalStatus, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.cboSex, 1, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(200, 57)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(3, 28)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(25, 13)
        Me.lblSex.TabIndex = 2
        Me.lblSex.Text = "Sex"
        '
        'lblMaritalStatus
        '
        Me.lblMaritalStatus.AutoSize = True
        Me.lblMaritalStatus.Location = New System.Drawing.Point(3, 0)
        Me.lblMaritalStatus.Name = "lblMaritalStatus"
        Me.lblMaritalStatus.Size = New System.Drawing.Size(69, 13)
        Me.lblMaritalStatus.TabIndex = 1
        Me.lblMaritalStatus.Text = "Marital status"
        '
        'cboMaritalStatus
        '
        Me.cboMaritalStatus.FormattingEnabled = True
        Me.cboMaritalStatus.Items.AddRange(New Object() {"Single", "Married"})
        Me.cboMaritalStatus.Location = New System.Drawing.Point(103, 3)
        Me.cboMaritalStatus.Name = "cboMaritalStatus"
        Me.cboMaritalStatus.Size = New System.Drawing.Size(94, 21)
        Me.cboMaritalStatus.TabIndex = 6
        '
        'cboSex
        '
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboSex.Location = New System.Drawing.Point(103, 31)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(94, 21)
        Me.cboSex.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.grpJobDetails)
        Me.GroupBox4.Controls.Add(Me.grpPersonaldetails)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(563, 182)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'grpRemunerations
        '
        Me.grpRemunerations.Controls.Add(Me.TableLayoutPanel6)
        Me.grpRemunerations.Location = New System.Drawing.Point(295, 310)
        Me.grpRemunerations.Name = "grpRemunerations"
        Me.grpRemunerations.Size = New System.Drawing.Size(280, 134)
        Me.grpRemunerations.TabIndex = 0
        Me.grpRemunerations.TabStop = False
        Me.grpRemunerations.Text = "Remunerations"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lblTotalRemuneration, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.lblOvertimeHrs, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lblLeaveAllowance, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblHouseAllowance, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.txtOvertimeHrs, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.txtLeaveAllowance, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.txtHouseAllowance, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.txtTotalRemuneration, 1, 3)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 4
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(268, 106)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'lblTotalRemuneration
        '
        Me.lblTotalRemuneration.AutoSize = True
        Me.lblTotalRemuneration.Location = New System.Drawing.Point(3, 77)
        Me.lblTotalRemuneration.Name = "lblTotalRemuneration"
        Me.lblTotalRemuneration.Size = New System.Drawing.Size(95, 13)
        Me.lblTotalRemuneration.TabIndex = 7
        Me.lblTotalRemuneration.Text = "Total remuneration"
        '
        'lblOvertimeHrs
        '
        Me.lblOvertimeHrs.AutoSize = True
        Me.lblOvertimeHrs.Location = New System.Drawing.Point(3, 0)
        Me.lblOvertimeHrs.Name = "lblOvertimeHrs"
        Me.lblOvertimeHrs.Size = New System.Drawing.Size(66, 13)
        Me.lblOvertimeHrs.TabIndex = 4
        Me.lblOvertimeHrs.Text = "Overtime hrs"
        '
        'lblLeaveAllowance
        '
        Me.lblLeaveAllowance.AutoSize = True
        Me.lblLeaveAllowance.Location = New System.Drawing.Point(3, 26)
        Me.lblLeaveAllowance.Name = "lblLeaveAllowance"
        Me.lblLeaveAllowance.Size = New System.Drawing.Size(88, 13)
        Me.lblLeaveAllowance.TabIndex = 5
        Me.lblLeaveAllowance.Text = "Leave allowance"
        '
        'lblHouseAllowance
        '
        Me.lblHouseAllowance.AutoSize = True
        Me.lblHouseAllowance.Location = New System.Drawing.Point(3, 52)
        Me.lblHouseAllowance.Name = "lblHouseAllowance"
        Me.lblHouseAllowance.Size = New System.Drawing.Size(89, 13)
        Me.lblHouseAllowance.TabIndex = 6
        Me.lblHouseAllowance.Text = "House allowance"
        '
        'txtOvertimeHrs
        '
        Me.txtOvertimeHrs.Enabled = False
        Me.txtOvertimeHrs.Location = New System.Drawing.Point(137, 3)
        Me.txtOvertimeHrs.Name = "txtOvertimeHrs"
        Me.txtOvertimeHrs.Size = New System.Drawing.Size(128, 20)
        Me.txtOvertimeHrs.TabIndex = 8
        '
        'txtLeaveAllowance
        '
        Me.txtLeaveAllowance.Location = New System.Drawing.Point(137, 29)
        Me.txtLeaveAllowance.Name = "txtLeaveAllowance"
        Me.txtLeaveAllowance.Size = New System.Drawing.Size(128, 20)
        Me.txtLeaveAllowance.TabIndex = 9
        '
        'txtHouseAllowance
        '
        Me.txtHouseAllowance.Location = New System.Drawing.Point(137, 55)
        Me.txtHouseAllowance.Name = "txtHouseAllowance"
        Me.txtHouseAllowance.Size = New System.Drawing.Size(128, 20)
        Me.txtHouseAllowance.TabIndex = 10
        '
        'txtTotalRemuneration
        '
        Me.txtTotalRemuneration.Location = New System.Drawing.Point(137, 80)
        Me.txtTotalRemuneration.Name = "txtTotalRemuneration"
        Me.txtTotalRemuneration.Size = New System.Drawing.Size(128, 20)
        Me.txtTotalRemuneration.TabIndex = 11
        '
        'grpDeductions
        '
        Me.grpDeductions.Controls.Add(Me.TableLayoutPanel5)
        Me.grpDeductions.Location = New System.Drawing.Point(12, 310)
        Me.grpDeductions.Name = "grpDeductions"
        Me.grpDeductions.Size = New System.Drawing.Size(277, 160)
        Me.grpDeductions.TabIndex = 0
        Me.grpDeductions.TabStop = False
        Me.grpDeductions.Text = "Deductions"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lblTotalDeductions, 0, 4)
        Me.TableLayoutPanel5.Controls.Add(Me.lblTax, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblAdvance, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.lblNssf, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.lblNhif, 0, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.txtTax, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.txtAdvance, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.txtNssf, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.txtNhif, 1, 3)
        Me.TableLayoutPanel5.Controls.Add(Me.txtTotalDeductions, 1, 4)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 5
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(265, 131)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'lblTotalDeductions
        '
        Me.lblTotalDeductions.AutoSize = True
        Me.lblTotalDeductions.Location = New System.Drawing.Point(3, 102)
        Me.lblTotalDeductions.Name = "lblTotalDeductions"
        Me.lblTotalDeductions.Size = New System.Drawing.Size(86, 13)
        Me.lblTotalDeductions.TabIndex = 8
        Me.lblTotalDeductions.Text = "Total deductions"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(3, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 13)
        Me.lblTax.TabIndex = 3
        Me.lblTax.Text = "Tax"
        '
        'lblAdvance
        '
        Me.lblAdvance.AutoSize = True
        Me.lblAdvance.Location = New System.Drawing.Point(3, 26)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(50, 13)
        Me.lblAdvance.TabIndex = 5
        Me.lblAdvance.Text = "Advance"
        '
        'lblNssf
        '
        Me.lblNssf.AutoSize = True
        Me.lblNssf.Location = New System.Drawing.Point(3, 52)
        Me.lblNssf.Name = "lblNssf"
        Me.lblNssf.Size = New System.Drawing.Size(44, 13)
        Me.lblNssf.TabIndex = 6
        Me.lblNssf.Text = "N.S.S.F"
        '
        'lblNhif
        '
        Me.lblNhif.AutoSize = True
        Me.lblNhif.Location = New System.Drawing.Point(3, 77)
        Me.lblNhif.Name = "lblNhif"
        Me.lblNhif.Size = New System.Drawing.Size(41, 13)
        Me.lblNhif.TabIndex = 7
        Me.lblNhif.Text = "N.H.I.F"
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(135, 3)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(127, 20)
        Me.txtTax.TabIndex = 9
        '
        'txtAdvance
        '
        Me.txtAdvance.Enabled = False
        Me.txtAdvance.Location = New System.Drawing.Point(135, 29)
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(127, 20)
        Me.txtAdvance.TabIndex = 10
        '
        'txtNssf
        '
        Me.txtNssf.Location = New System.Drawing.Point(135, 55)
        Me.txtNssf.Name = "txtNssf"
        Me.txtNssf.Size = New System.Drawing.Size(127, 20)
        Me.txtNssf.TabIndex = 11
        '
        'txtNhif
        '
        Me.txtNhif.Location = New System.Drawing.Point(135, 80)
        Me.txtNhif.Name = "txtNhif"
        Me.txtNhif.Size = New System.Drawing.Size(127, 20)
        Me.txtNhif.TabIndex = 12
        '
        'txtTotalDeductions
        '
        Me.txtTotalDeductions.Location = New System.Drawing.Point(135, 105)
        Me.txtTotalDeductions.Name = "txtTotalDeductions"
        Me.txtTotalDeductions.Size = New System.Drawing.Size(127, 20)
        Me.txtTotalDeductions.TabIndex = 13
        '
        'grpPaySlip
        '
        Me.grpPaySlip.Controls.Add(Me.txtSlip)
        Me.grpPaySlip.Location = New System.Drawing.Point(597, 12)
        Me.grpPaySlip.Name = "grpPaySlip"
        Me.grpPaySlip.Size = New System.Drawing.Size(352, 513)
        Me.grpPaySlip.TabIndex = 0
        Me.grpPaySlip.TabStop = False
        Me.grpPaySlip.Text = "PAY SLIP"
        '
        'txtSlip
        '
        Me.txtSlip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSlip.Location = New System.Drawing.Point(6, 19)
        Me.txtSlip.Multiline = True
        Me.txtSlip.Name = "txtSlip"
        Me.txtSlip.Size = New System.Drawing.Size(338, 488)
        Me.txtSlip.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmpName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBasicSalary, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmpName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBasicSalary, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 31)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 53)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Location = New System.Drawing.Point(3, 0)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(60, 13)
        Me.lblEmpName.TabIndex = 0
        Me.lblEmpName.Text = "Emp_name"
        '
        'txtBasicSalary
        '
        Me.txtBasicSalary.Location = New System.Drawing.Point(103, 29)
        Me.txtBasicSalary.Name = "txtBasicSalary"
        Me.txtBasicSalary.Size = New System.Drawing.Size(94, 20)
        Me.txtBasicSalary.TabIndex = 3
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(103, 3)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(94, 20)
        Me.txtEmpName.TabIndex = 2
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.AutoSize = True
        Me.lblBasicSalary.Location = New System.Drawing.Point(3, 26)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(63, 13)
        Me.lblBasicSalary.TabIndex = 1
        Me.lblBasicSalary.Text = "Basic salary"
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(12, 476)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(137, 23)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(155, 476)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(134, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 537)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpRemunerations)
        Me.Controls.Add(Me.grpDeductions)
        Me.Controls.Add(Me.grpPaySlip)
        Me.Controls.Add(Me.grpIncome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Pay roll"
        Me.grpIncome.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.grpJobDetails.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.grpPersonaldetails.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.grpRemunerations.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.grpDeductions.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.grpPaySlip.ResumeLayout(False)
        Me.grpPaySlip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpIncome As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblNetSalaryInKsh As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtNetSalaryInKsh As TextBox
    Friend WithEvents grpJobDetails As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents lblWorkedOvertime As Label
    Friend WithEvents lblTookLeave As Label
    Friend WithEvents lblTookAdvance As Label
    Friend WithEvents cboTookLeave As ComboBox
    Friend WithEvents cboTookAdvance As ComboBox
    Friend WithEvents grpPersonaldetails As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblSex As Label
    Friend WithEvents lblMaritalStatus As Label
    Friend WithEvents cboMaritalStatus As ComboBox
    Friend WithEvents cboSex As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents grpRemunerations As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents grpDeductions As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblTax As Label
    Friend WithEvents grpPaySlip As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblTotalRemuneration As Label
    Friend WithEvents lblOvertimeHrs As Label
    Friend WithEvents lblLeaveAllowance As Label
    Friend WithEvents lblHouseAllowance As Label
    Friend WithEvents txtOvertimeHrs As TextBox
    Friend WithEvents txtLeaveAllowance As TextBox
    Friend WithEvents txtHouseAllowance As TextBox
    Friend WithEvents txtTotalRemuneration As TextBox
    Friend WithEvents lblTotalDeductions As Label
    Friend WithEvents lblAdvance As Label
    Friend WithEvents lblNssf As Label
    Friend WithEvents lblNhif As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtAdvance As TextBox
    Friend WithEvents txtNssf As TextBox
    Friend WithEvents txtNhif As TextBox
    Friend WithEvents txtTotalDeductions As TextBox
    Friend WithEvents lblEmpName As Label
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents lblBasicSalary As Label
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents chkTookLeave As CheckBox
    Friend WithEvents chkTookAdvance As CheckBox
    Friend WithEvents chkWorkedOvertime As CheckBox
    Friend WithEvents txtSlip As TextBox
End Class
