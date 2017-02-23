Public Class Form1
    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim basicSalary As Double
        Dim netSalaryInKsh As Double
        Dim tookLeave As Integer
        Dim tookAdvance As Double
        Dim tax As Double
        Dim advance As Double
        Dim nssf As Double
        Dim nhif As Double
        Dim totalDeductions As Double
        Dim overtimeHrs As Integer
        Dim leaveAllowance As Double
        Dim houseAllowance As Double
        Dim totalRemuneration As Double


        basicSalary = Val(txtBasicSalary.Text)
        netSalaryInKsh = Val(txtNetSalaryInKsh.Text)
        tookLeave = Val(cboTookLeave.Text)
        tookAdvance = Val(cboTookAdvance.Text)
        tax = Val(txtTax.Text)
        advance = Val(txtAdvance.Text)
        nssf = Val(txtNssf.Text)
        nhif = Val(txtNhif.Text)
        totalDeductions = Val(txtTotalDeductions.Text)
        overtimeHrs = Val(txtOvertimeHrs.Text)
        leaveAllowance = Val(txtLeaveAllowance.Text)
        houseAllowance = Val(txtHouseAllowance.Text)
        totalRemuneration = Val(txtTotalRemuneration.Text)

        netSalaryInKsh = (basicSalary - totalDeductions) + totalRemuneration
        txtNetSalaryInKsh.Text = netSalaryInKsh

        houseAllowance = 7000
        txtHouseAllowance.Text = houseAllowance

        totalRemuneration = (overtimeHrs * 100) + leaveAllowance + houseAllowance
        txtTotalRemuneration.Text = totalRemuneration

        If cboTookLeave.SelectedItem = "Annual allowance" Then leaveAllowance = 3500
        txtLeaveAllowance.Text = leaveAllowance
        'If cboTookLeave.SelectedItem = "House allowance" Then leaveAllowance = 7000
        'txtLeaveAllowance.Text = leaveAllowance

        totalDeductions = (tax + advance + nssf + nhif)
        txtTotalDeductions.Text = totalDeductions

        If cboTookAdvance.SelectedItem = "25% basic salary" Then advance = (0.25 * basicSalary)
        txtAdvance.Text = advance
        If cboTookAdvance.SelectedItem = "50% basic salary" Then advance = (0.5 * basicSalary)
        txtAdvance.Text = advance


        txtSlip.Text = ""
        txtSlip.AppendText("" + vbNewLine)

        txtSlip.AppendText("INFOTECH SYSTEMS SERVICE PAYSLIP" + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText(vbTab + "Pay date: " + vbTab & DateTimePicker1.Value + vbNewLine)
        txtSlip.AppendText(vbTab + "Time: " + vbTab + vbTab & DateTimePicker1.Value + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText("======================================================" + vbNewLine)
        txtSlip.AppendText(vbNewLine)
        txtSlip.AppendText("Personal details: " + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText(vbTab + "NAME: " + vbTab + vbTab + vbTab & txtEmpName.Text + vbNewLine)
        txtSlip.AppendText(vbTab + "MARITAL STATUS: " + vbTab & cboMaritalStatus.Text + vbNewLine)
        txtSlip.AppendText(vbTab + "SEX: " + vbTab + vbTab + vbTab & cboSex.Text + vbNewLine)
        txtSlip.AppendText(vbTab + "LEAVE: " + vbTab + vbTab + vbTab & cboTookLeave.Text + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText("======================================================" + vbNewLine)
        txtSlip.AppendText(vbNewLine)
        txtSlip.AppendText(vbTab + "BASIC SALARY: " + vbTab + vbTab & txtBasicSalary.Text + vbNewLine)
        txtSlip.AppendText(vbTab + "REMUNERATIONS: " + vbTab & txtTotalRemuneration.Text + vbNewLine)
        txtSlip.AppendText(vbTab + "GROSS PAY: " + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText("DEDUCTIONS: " + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText(vbTab + "Tax: " + vbTab + vbTab + vbTab & txtTax.Text + vbNewLine)
        txtSlip.AppendText(vbTab + "Advance: " + vbTab + vbTab & txtAdvance.Text + vbNewLine)
        txtSlip.AppendText(vbTab + "NSSF: " + vbTab + vbTab + vbTab & txtNssf.Text + vbNewLine)
        txtSlip.AppendText(vbTab + "NHIF: " + vbTab + vbTab + vbTab & txtNhif.Text + vbNewLine)
        txtSlip.AppendText(vbTab + "TOTAL DEDUCTIONS: " + vbTab & txtTotalDeductions.Text + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText("======================================================" + vbNewLine)
        txtSlip.AppendText(vbNewLine)
        txtSlip.AppendText(vbTab + "NET SALARY IN KSH: " + vbTab & txtNetSalaryInKsh.Text + vbNewLine)
        txtSlip.AppendText(vbNewLine)
        txtSlip.AppendText("======================================================" + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText(vbTab + "Compiled by: " + vbTab + vbTab & txtEmpName.Text + vbNewLine)

        txtSlip.AppendText(vbNewLine)
        


    End Sub

    Private Sub chkTookLeave_CheckedChanged(sender As Object, e As EventArgs) Handles chkTookLeave.CheckedChanged
        If chkTookLeave.Checked = True Then
            cboTookLeave.Enabled = True
        Else
            cboTookLeave.Enabled = False
        End If
    End Sub

    Private Sub chkTookAdvance_CheckedChanged(sender As Object, e As EventArgs) Handles chkTookAdvance.CheckedChanged
        If chkTookAdvance.Checked = True Then
            cboTookAdvance.Enabled = True
        Else
            cboTookAdvance.Enabled = False
        End If
    End Sub

    Private Sub chkWorkedOvertime_CheckedChanged(sender As Object, e As EventArgs) Handles chkWorkedOvertime.CheckedChanged
        If chkWorkedOvertime.Checked = True Then
            txtOvertimeHrs.Enabled = True
        Else
            txtOvertimeHrs.Enabled = False
        End If
    End Sub

    Private Sub txtSlip_TextChanged(sender As Object, e As EventArgs) Handles txtSlip.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub btnPaySlip_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class
