﻿Public Class Form1
    Dim FirstNumber As Long
    Dim Operation As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles LCD.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles n1.Click
        If LCD.Text = "0" Then
            LCD.Text = "1"
        Else
            LCD.Text = LCD.Text & "1"
        End If
    End Sub

    Private Sub n2_Click(sender As Object, e As EventArgs) Handles n2.Click
        If LCD.Text = "0" Then
            LCD.Text = "2"
        Else
            LCD.Text = LCD.Text & "2"
        End If
    End Sub

    Private Sub n3_Click(sender As Object, e As EventArgs) Handles n3.Click
        If LCD.Text = "0" Then
            LCD.Text = "3"
        Else
            LCD.Text = LCD.Text & "3"
        End If
    End Sub


    Private Sub n4_Click(sender As Object, e As EventArgs) Handles n4.Click
        If LCD.Text = "0" Then
            LCD.Text = "4"
        Else
            LCD.Text = LCD.Text & "4"
        End If
    End Sub

    Private Sub n5_Click(sender As Object, e As EventArgs) Handles n5.Click
        If LCD.Text = "0" Then
            LCD.Text = "5"
        Else
            LCD.Text = LCD.Text & "5"
        End If
    End Sub

    Private Sub n6_Click(sender As Object, e As EventArgs) Handles n6.Click
        If LCD.Text = "0" Then
            LCD.Text = "6"
        Else
            LCD.Text = LCD.Text & "6"
        End If
    End Sub

    Private Sub n7_Click(sender As Object, e As EventArgs) Handles n7.Click
        If LCD.Text = "0" Then
            LCD.Text = "7"
        Else
            LCD.Text = LCD.Text & "7"
        End If
    End Sub

    Private Sub n8_Click(sender As Object, e As EventArgs) Handles n8.Click
        If LCD.Text = "0" Then
            LCD.Text = "8"
        Else
            LCD.Text = LCD.Text & "8"
        End If
    End Sub

    Private Sub n9_Click(sender As Object, e As EventArgs) Handles n9.Click
        If LCD.Text = "0" Then
            LCD.Text = "9"
        Else
            LCD.Text = LCD.Text & "9"
        End If
    End Sub

    Private Sub n0_Click(sender As Object, e As EventArgs) Handles n0.Click
        LCD.Text = LCD.Text & "0"

    End Sub


    Private Sub bc_Click(sender As Object, e As EventArgs) Handles bc.Click
        LCD.Text = "0"
    End Sub

    Private Sub bequal_Click(sender As Object, e As EventArgs) Handles bequal.Click
        Dim SecondNumber As Long
        Dim Result As Long

        SecondNumber = LCD.Text

        If Operation = "+" Then
            Result = FirstNumber + SecondNumber
        ElseIf Operation = "-" Then
            Result = FirstNumber - SecondNumber
        ElseIf Operation = "*" Then
            Result = FirstNumber * SecondNumber
        ElseIf Operation = "/" Then
            Result = FirstNumber / SecondNumber
        End If
        FirstNumber = Result
        LCD.Text = Result

    End Sub

    Private Sub bad_Click(sender As Object, e As EventArgs) Handles bad.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "+"
    End Sub

    Private Sub bsub_Click(sender As Object, e As EventArgs) Handles bsub.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "-"
    End Sub

    Private Sub bmult_Click(sender As Object, e As EventArgs) Handles bmult.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "*"
    End Sub

    Private Sub bdiv_Click(sender As Object, e As EventArgs) Handles bdiv.Click
        FirstNumber = LCD.Text
        LCD.Text = "0"
        Operation = "/"
    End Sub
End Class
