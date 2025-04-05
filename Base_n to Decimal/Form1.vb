Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cmbBase.Items.Count > 1 Then
            cmbBase.SelectedIndex = 0
            txtInput.Focus()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intInput, intRemainder As Integer
        Dim cbBase As Boolean = cmbBase.SelectedIndex
        Dim strOutput As String = Nothing
        Dim strRemainder As String = Nothing

        Try
            intInput = txtInput.Text
            If Int(txtInput.Text) > 0 And intInput = txtInput.Text Then
                Select Case cbBase
                    Case cmbBase.SelectedIndex = -1
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 2
                            intInput \= 2
                            strOutput &= intRemainder
                        Loop
                        txtResult.Text = "The Binary equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 1
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 3
                            intInput \= 3
                            strOutput &= intRemainder
                        Loop
                        txtResult.Text = "The Ternary equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 2
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 4
                            intInput \= 4
                            strOutput &= intRemainder
                        Loop
                        txtResult.Text = "The Quarternary equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 3
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 5
                            intInput \= 5
                            strOutput &= intRemainder
                        Loop
                        txtResult.Text = "The Quinary equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 4
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 6
                            intInput \= 6
                            strOutput &= intRemainder
                        Loop
                        txtResult.Text = "The Senary equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 5
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 7
                            intInput \= 7
                            strOutput &= intRemainder
                        Loop
                        txtResult.Text = "The Septenary equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 6
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 8
                            intInput \= 8
                            strOutput &= intRemainder
                        Loop
                        txtResult.Text = "The Octal equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 7
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 9
                            intInput \= 9
                            strOutput &= intRemainder
                        Loop
                        txtResult.Text = "The Nonary equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 8
                        txtResult.Text = "The Decimal equivalent of " & txtInput.Text _
                            & " is " & txtInput.Text & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 9
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 11
                            Select Case intRemainder
                                Case 10
                                    strRemainder = "A"
                                Case Else
                                    strRemainder = intRemainder
                            End Select
                            strOutput &= strRemainder
                            intInput \= 11
                        Loop
                        txtResult.Text = "The Undenary equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 10
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 12
                            Select Case intRemainder
                                Case 10
                                    strRemainder = "A"
                                Case 11
                                    strRemainder = "B"
                                Case Else
                                    strRemainder = intRemainder
                            End Select
                            strOutput &= strRemainder
                            intInput \= 12
                        Loop
                        txtResult.Text = "The Duodecimal equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 11
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 13
                            Select Case intRemainder
                                Case 10
                                    strRemainder = "A"
                                Case 11
                                    strRemainder = "B"
                                Case 12
                                    strRemainder = "C"
                                Case Else
                                    strRemainder = intRemainder
                            End Select
                            intInput \= 13
                            strOutput &= strRemainder
                        Loop
                        txtResult.Text = "The Tridecimal equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 12
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 14
                            Select Case intRemainder
                                Case 10
                                    strRemainder = "A"
                                Case 11
                                    strRemainder = "B"
                                Case 12
                                    strRemainder = "C"
                                Case 13
                                    strRemainder = "D"
                                Case Else
                                    strRemainder = intRemainder
                            End Select
                            intInput \= 14
                            strOutput &= strRemainder
                        Loop
                        txtResult.Text = "The Quadrodecimal equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 13
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 15
                            Select Case intRemainder
                                Case 10
                                    strRemainder = "A"
                                Case 11
                                    strRemainder = "B"
                                Case 12
                                    strRemainder = "C"
                                Case 13
                                    strRemainder = "D"
                                Case 14
                                    strRemainder = "E"
                                Case Else
                                    strRemainder = intRemainder
                            End Select
                            intInput \= 15
                            strOutput &= strRemainder
                        Loop
                        txtResult.Text = "The Quindecimal equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                    Case cmbBase.SelectedIndex = 14
                        Do Until intInput <= 0
                            intRemainder = intInput Mod 16
                            Select Case intRemainder
                                Case 10
                                    strRemainder = "A"
                                Case 11
                                    strRemainder = "B"
                                Case 12
                                    strRemainder = "C"
                                Case 13
                                    strRemainder = "D"
                                Case 14
                                    strRemainder = "E"
                                Case 15
                                    strRemainder = "F"
                                Case Else
                                    strRemainder = intRemainder
                            End Select
                            intInput \= 16
                            strOutput &= strRemainder
                        Loop
                        txtResult.Text = "The Hexadecimal equivalent of " & txtInput.Text _
                            & " is " & StrReverse(strOutput) & "."
                        txtResult.Enabled = True
                End Select
            Else
                txtInput.SelectAll()
                txtResult.Clear()
                txtInput.Focus()
                txtResult.Enabled = False
                MessageBox.Show("Please Enter Positive Integer", "Input Error")
            End If
        Catch NoInput As System.InvalidCastException
            txtInput.Clear()
            txtResult.Clear()
            txtInput.Focus()
            txtResult.Enabled = False
            MessageBox.Show("Please input a number!", "Error")
        Catch OverFlow As System.OverflowException
            txtInput.Clear()
            txtResult.Clear()
            txtInput.Focus()
            txtResult.Enabled = False
            MessageBox.Show(OverFlow.Message, "Error")
        Catch Other As System.Exception
            txtInput.Clear()
            txtResult.Clear()
            txtInput.Focus()
            txtResult.Enabled = False
            MessageBox.Show(Other.Message, "Error")
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click,
        ResetToolStripMenuItem.Click

        Dim ResetYN = MsgBox("Do you really want to reset?", MsgBoxStyle.YesNo, "Reset?")

        If ResetYN = MsgBoxResult.Yes Then
            txtInput.Clear()
            cmbBase.SelectedIndex = 0
            txtResult.Clear()
            txtInput.Focus()
            txtResult.Enabled = False
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles _
        AboutToolStripMenuItem.Click

        Dim form2 As New Form2()

        form2.ShowDialog()
    End Sub
    Private Sub Form1_Closing(sender As Object, e As FormClosingEventArgs) Handles _
        MyBase.Closing
        Dim ExitYN2 = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo, "Exit?")

        If ExitYN2 = MsgBoxResult.No Then e.Cancel = True
    End Sub
End Class
