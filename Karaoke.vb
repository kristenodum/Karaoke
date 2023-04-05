'Author: Kristen Odum 
'Program Name: Karaoke Music Night Windows Application 
'Purpose: Karaoke Music Night Windows Application

Option Strict On
Public Class Karaoke
    Private _decSong As Decimal = 2.99D
    Private _decHourlyRate As Decimal = 8.99D
    Private Sub frmKaraoke_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Will hold the splash screen for 6 seconds 
        Threading.Thread.Sleep(3000)
        ClearForm()
    End Sub
    Private Function ValidateInput() As Boolean
        'This procedure validates the input 
        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            'converts the target amount to an integer value
            intNumber = Convert.ToInt32(txtValue.Text)
            If intNumber >= 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
            End If

        Catch Exception As FormatException
            'This catch block detects letters, symbols, blank entries
            MsgBox("Please enter a valid amount", , "Error")

        Catch Exception As OverflowException
            'This catch block detects numbers that are too large or too small
            MsgBox("Please enter a reasonable amount", , "Error")
        Catch Exception As SystemException
            'This catch block detects a generic excpetion not caught by earlier Catch blocks 
            MsgBox("Entry invalid. Please enter a valid number representing the number in your party", , "Error")
        End Try
        'Place focus back onto the textbox
        txtValue.Focus()
        txtValue.Clear()
        Return blnValid
    End Function
    Private Function ComputeSongCost(ByVal intPass As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = intPass * _decSong

        Return decPassCost
    End Function
    Private Function ComputeRoomCost(ByVal intPass As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = intPass * _decHourlyRate

        Return decTicketCost
    End Function

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        Dim blnAmountIsValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        blnAmountIsValid = ValidateInput()

        If blnAmountIsValid = True Then
            intValue = Convert.ToInt32(txtValue.Text)
            If cboSelectAction.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            Else
                decTotal = ComputeRoomCost(intValue)

            End If
            lblDisplay.Visible = True
            lblDisplay.Text = "Total Cost of the Karaoke Night - " & decTotal.ToString("C")
        End If
    End Sub
    Private Sub ClearForm()
        'Clears the Form 
        cboSelectAction.SelectedIndex = -1
        lblDisplay.Visible = False
        lblHourlyRental.Visible = False
        txtValue.Visible = False
        btnValue.Visible = False
        btnValue.Visible = False
        btnClear.Visible = False
        lblDisplay.Visible = False
        txtValue.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub cboSelectAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectAction.SelectedIndexChanged
        If cboSelectAction.SelectedIndex = 0 Then
            lblDisplay.Text = "Number of Karaoke Songs"
            lblDisplay.Visible = True
            txtValue.Visible = True
            btnValue.Visible = True
            lblHourlyRental.Visible = True
            btnClear.Visible = True
            txtValue.Focus()
        End If
        If cboSelectAction.SelectedIndex = 1 Then
            lblDisplay.Text = "Hourly Rental of Karaoke Room: "
            lblDisplay.Visible = True
            txtValue.Visible = True
            lblHourlyRental.Visible = True
            btnValue.Visible = True
            btnClear.Visible = True
            txtValue.Focus()
        End If
    End Sub
End Class
