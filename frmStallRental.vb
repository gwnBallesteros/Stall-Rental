'Name of the Program    Stall Rental
'Developer              G.T. Ballesteros
'Date                   June  23, 2022
'Purpose                This application calculates and display the total costs
'                       of renting a stall in a specified number of days.

Option Strict On

Public Class frmStallRental

    'Cost per day of Stall Rental
    Const _cdecPricePerDay As Decimal = 150.75D

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCostPerDay.Text = _cdecPricePerDay.ToString("C") & " per Day"
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picStallRental.Click

    End Sub

    Private Sub lblCostPerDay_Click(sender As Object, e As EventArgs) Handles lblCostPerDay.Click

    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecPricePerDay
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
