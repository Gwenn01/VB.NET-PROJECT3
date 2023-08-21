Public Class Form1
    Private Sub btnexer1_Click(sender As Object, e As EventArgs) Handles btnexer1.Click
        Dim i As Integer
        Dim aiData(5) As Integer
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8


        For i = 0 To 4
            MsgBox(aiData(i))
        Next

    End Sub

    Private Sub btnexcer2_Click(sender As Object, e As EventArgs) Handles btnexcer2.Click
        Dim i As Integer
        Dim aiData(5) As Integer
        Dim result As String
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        result = ""

        For i = 0 To 4
            result = result & aiData(i) & " "
        Next

        MsgBox(result)

    End Sub

    Private Sub btnexer3_Click(sender As Object, e As EventArgs) Handles btnexer3.Click
        Dim i As Integer
        Dim aiData(5) As Integer
        Dim result As Integer
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            result = result + aiData(i)
        Next

        MsgBox(result)

    End Sub

    Private Sub btnexer4_Click(sender As Object, e As EventArgs) Handles btnexer4.Click
        Dim i As Integer
        Dim aiData(5) As Integer
        Dim sum As Integer
        Dim ave As Double
        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            sum = sum + aiData(i)
        Next
        ave = sum / 4
        MsgBox(ave)
    End Sub

    Private Sub btnexer5_Click(sender As Object, e As EventArgs) Handles btnexer5.Click
        Dim i As Integer
        Dim aiData(5) As Integer
        Dim sum As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            If aiData(i) > 20 Then
                sum = sum + aiData(i)
            End If

        Next

        MsgBox(sum)
    End Sub

    Private Sub btnexer6_Click(sender As Object, e As EventArgs) Handles btnexer6.Click
        Dim aiData(5) As Integer
        Dim max As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        max = aiData(0)

        For i = 0 To 4
            If aiData(i) > max Then
                max = aiData(i)
            End If
        Next

        MsgBox(max)
    End Sub

    Private Sub btnexer7_Click(sender As Object, e As EventArgs) Handles btnexer7.Click
        Dim aiData(5) As Integer
        Dim min As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        min = aiData(0)

        For i = 0 To 4
            If aiData(i) < min Then
                min = aiData(i)
            End If
        Next

        MsgBox(min)
    End Sub

    Private Sub btnexer8_Click(sender As Object, e As EventArgs) Handles btnexer8.Click
        Dim aiData(5) As Integer
        Dim temp(5) As Integer

        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        For i = 0 To 4
            temp(i) = aiData(i) + aiData(i)
            MsgBox(temp(i))
        Next


    End Sub
End Class
