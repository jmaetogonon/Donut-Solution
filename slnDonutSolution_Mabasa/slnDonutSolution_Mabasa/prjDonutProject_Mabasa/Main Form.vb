Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    'calculate donut funciton
    Private Function getDoughnut() As Decimal
        Dim decDonutCost As Decimal

        If radGlazed.Checked Then
            decDonutCost = 0.75D
        ElseIf radSugar.Checked Then
            decDonutCost = 0.75D
        ElseIf radChoco.Checked Then
            decDonutCost = 0.75D
        ElseIf radFilled.Checked Then
            decDonutCost = 0.95D
        End If
        'return 
        Return decDonutCost
    End Function

    'calculate coffee funciton
    Private Function getCoffee() As Decimal
        Dim decCoffeeCost As Decimal

        If radNone.Checked Then
            decCoffeeCost = 0D
        ElseIf radRegular.Checked Then
            decCoffeeCost = 1.5D
        ElseIf radCappucino.Checked Then
            decCoffeeCost = 2.75D
        End If

        'return coffee
        Return decCoffeeCost
    End Function

    'calculate tax funciton
    Private Function getTax(ByVal decTotal As Decimal) As Decimal
        Return decTotal * 0.045D
    End Function
    'form load
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radNone.Checked = True
        radGlazed.Checked = True
    End Sub

    'btnCALC
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decSubTotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotal As Decimal

        'coffee and donut function
        decSubTotal = getDoughnut() + getCoffee()

        'use a function to get the tax
        decSalesTax = getTax(decSubTotal)

        'calculate total
        decTotal = decSubTotal + decSalesTax

        'displays
        lblSub.Text = decSubTotal.ToString("N2")
        lblTax.Text = decSalesTax.ToString("N2")
        lblTotal.Text = decTotal.ToString("N2")
    End Sub
    'exit button
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    'iclear ang displays
    Private Sub radGlazed_CheckedChanged(sender As Object, e As EventArgs) Handles radGlazed.CheckedChanged, radCappucino.CheckedChanged, radChoco.CheckedChanged, radFilled.CheckedChanged, radNone.CheckedChanged, radRegular.CheckedChanged, radSugar.CheckedChanged
        lblSub.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
