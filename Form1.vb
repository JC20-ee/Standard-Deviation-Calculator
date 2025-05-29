Public Class Form1
    Dim dblArray() As Double = {}
    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _
        txtInput.KeyPress

        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        If Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c OrElse e.KeyChar = "-"c) Then
            e.Handled = True
        End If

        If e.KeyChar = "."c AndAlso (txtInput.SelectionStart = 0 OrElse
            txtInput.Text.Contains(".")) Then
            e.Handled = True
        End If

        If e.KeyChar = "-"c AndAlso (txtInput.SelectionStart <> 0 OrElse
            txtInput.Text.Contains("-")) Then

            e.Handled = True
        End If
    End Sub
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        Try
            Dim dblInput As Double = txtInput.Text
            Dim intUB As Integer = UBound(dblArray)
            Dim dblOut As String = ""

            ReDim Preserve dblArray(intUB + 1)

            dblArray(intUB + 1) = dblInput

            For intcounter As Integer = 0 To intUB + 1
                dblOut = dblOut & vbNewLine & intcounter + 1 & vbTab & dblArray(intcounter)
            Next

            txtInput.Focus()
            txtInput.SelectAll()
            btnCompute.Enabled = True
            btnChange.Enabled = True

            txtDisplay.Text = dblOut

        Catch NoInput As System.InvalidCastException
            MessageBox.Show("Please enter a value!", "Error")
            txtInput.Focus()
            txtDisplay.Text = "index" & vbTab & "value"
            lblMean.Text = "Mean: N/A"
            lblstd.Text = "Std dev: N/A"
            btnCompute.Enabled = False
            btnChange.Enabled = False
            ReDim dblArray(-1)
        End Try
    End Sub
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim sum, average, sqr, std As Double
        Dim intUB As Integer = UBound(dblArray)

        ReDim Preserve dblArray(intUB + 1)

        btnInput.Enabled = False

        Try
            If intUB <= 0 Then
                MessageBox.Show("Please enter two or more numbers.", "Enter a value")
                FormReset(Nothing, Nothing)
            Else
                For intcount As Integer = 0 To intUB
                    sum += dblArray(intcount)
                Next

                average = sum / UBound(dblArray)

                For intcount1 As Integer = 0 To intUB
                    sqr += (dblArray(intcount1) - average) ^ 2
                Next

                std = Math.Sqrt(sqr / UBound(dblArray))

                lblMean.Text = "Mean: " & Math.Round(average, 3)
                lblstd.Text = "Std dev: " & Math.Round(std, 3)
            End If

        Catch Overflow As System.OverflowException
            MsgBox(Overflow.Message, MsgBoxStyle.OkOnly, "Error")
            txtInput.Focus()
            txtDisplay.Text = "index" & vbTab & "value"
            lblMean.Text = "Mean: N/A"
            lblstd.Text = "Std dev: N/A"
            btnCompute.Enabled = False
            btnChange.Enabled = False
            btnInput.Enabled = True
            ReDim dblArray(-1)
        End Try
    End Sub
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim Newvalue, index, sum, average, sqr, std As Double
        Dim dblOut As String = ""

        Try
            index = InputBox("What index value?", "Change Value")
            Newvalue = InputBox("Change to what value?", "New Value")

            If index < 1 And Int(index) <> index And index > UBound(dblArray) Then
                MessageBox.Show("Please enter a value!", "Error")
                lblMean.Text = "Mean: N/A"
                lblstd.Text = "Std dev: N/A"
                btnCompute.Enabled = False
                btnChange.Enabled = False
            Else
                dblArray(index - 1) = Newvalue
                For intcount As Integer = 0 To UBound(dblArray) - 1
                    dblOut = dblOut & vbNewLine & intcount + 1 & vbTab & dblArray(intcount)
                Next

                For intcount As Integer = 0 To UBound(dblArray) - 1
                    sum += dblArray(intcount)
                Next

                average = sum / UBound(dblArray)

                For intcount1 As Integer = 0 To UBound(dblArray) - 1
                    sqr += (dblArray(intcount1) - average) ^ 2
                Next

                std = Math.Sqrt(sqr / UBound(dblArray))

                lblMean.Text = "Mean: " & Math.Round(average, 3)
                lblstd.Text = "Std dev: " & Math.Round(std, 3)

                btnInput.Enabled = False
                btnCompute.Enabled = False
                txtDisplay.Text = dblOut
            End If

        Catch NoInput As System.InvalidCastException
            MessageBox.Show("Please enter a value!", "Error")
            txtDisplay.Text = "index" & vbTab & "value"
            lblMean.Text = "Mean: N/A"
            lblstd.Text = "Std dev: N/A"
            btnCompute.Enabled = False
            btnChange.Enabled = False
        Catch Other As System.Exception
            Exit Sub
        End Try
    End Sub
    Private Sub FormReset(sender As Object, e As EventArgs) Handles Me.Load, btnReset.Click, ResetToolStripMenuItem.Click
        txtInput.Clear()
        txtInput.Focus()
        txtDisplay.Text = "index" & vbTab & "value"
        lblMean.Text = "Mean: N/A"
        lblstd.Text = "Std dev: N/A"
        btnInput.Enabled = True
        btnCompute.Enabled = False
        btnChange.Enabled = False
        ReDim dblArray(-1)
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _
        ExitToolStripMenuItem.Click

        Me.Close()
    End Sub
    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles _
        MyBase.FormClosing

        Dim ExitYNC = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "Exit?")

        If ExitYNC = MsgBoxResult.No Then e.Cancel = True
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles _
        ToolStripMenuItem2.Click

        Dim Form2A As New Form2()

        Form2A.ShowDialog()
    End Sub
End Class