Public Class Form1
    Dim value = New Integer() {1000, 500, 200, 100, 50, 20, 10, 5, 1}
    Dim quantity = New Integer() {5, 5, 5, 5, 5, 5, 5, 5, 5}
    Private Sub Display()
        lblValue1.Text = value(0)
        lblValue2.Text = value(1)
        lblValue3.Text = value(2)
        lblValue4.Text = value(3)
        lblValue5.Text = value(4)
        lblValue6.Text = value(5)
        lblValue7.Text = value(6)
        lblValue8.Text = value(7)
        lblValue9.Text = value(8)

        lblQuantity1.Text = quantity(0)
        lblQuantity2.Text = quantity(1)
        lblQuantity3.Text = quantity(2)
        lblQuantity4.Text = quantity(3)
        lblQuantity5.Text = quantity(4)
        lblQuantity6.Text = quantity(5)
        lblQuantity7.Text = quantity(6)
        lblQuantity8.Text = quantity(7)
        lblQuantity9.Text = quantity(8)

        Dim totalAmount As Integer
        Dim i As Integer
        i = 0

        Do While i < 9
            totalAmount = totalAmount + value(i) * quantity(i)
            i = i + 1
        Loop
        lblTotalCahOutput.Text = totalAmount

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Display()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim input As Integer
        Dim outputDispenser As String

        input = txtInputAmount.Text
        Dim i As Integer
        Dim count As Integer

        Do While Not input = 0
            For i = 0 To value.Length - 1
                If input >= value(i) And quantity(i) > 0 Then
                    input = input - value(i)
                    quantity(i) = quantity(i) - 1
                    Exit For
                End If
            Next
            If quantity(0) = 0 And quantity(1) = 0 And quantity(2) = 0 And quantity(3) = 0 And quantity(4) = 0 And quantity(5) = 0 And quantity(6) = 0 And quantity(7) = 0 And quantity(8) = 0 Then
                lblOutput.Text = "Insufficient Balance"
                Exit Sub
            End If
        Loop

        outputDispenser = ""

        For i = 0 To quantity.Length - 1
            If quantity(i) < 5 Then
                Dim temp As Integer
                temp = 5 - quantity(i)
                outputDispenser = outputDispenser & value(i) & " * " & temp & vbNewLine
            End If
        Next


        lblOutput.Text = outputDispenser

        Display()
    End Sub
End Class