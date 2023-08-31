Option Explicit On
Imports System.IO
Public Class frmDatabase
    Private Sub frmDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query = "SELECT ModelName FROM TESE.dbo.Parameter"
        Dim dt = KoneksiDB.bacaData(query).Tables(0)

        For i As Integer = 0 To dt.Rows.Count - 1
            Combo2.Items.Add(dt.Rows(i).Item(0))
        Next
    End Sub

    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Close()
    End Sub

    Private Sub Combo2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo2.SelectedIndexChanged
        If Combo2.Text = "" Then Exit Sub
        Dim query = "SELECT * FROM TESE.dbo.Parameter WHERE ModelName = '" & Combo2.Text & "'"
        Dim dt = KoneksiDB.bacaData(query).Tables(0)

        Text20.Text = dt.Rows(0).Item("PrimaryPCBAType")
        Text21.Text = dt.Rows(0).Item("SecondaryPCBAType")
        Text22.Text = dt.Rows(0).Item("ElectroMagnetType")
        Text10.Text = dt.Rows(0).Item("ARTICLENOS")

        Dim filePath As String = INIMATERIALPATH & "Station4\" & Combo2.Text & ".Txt"

        If File.Exists(filePath) Then
            Using sr As New StreamReader(filePath)
                Dim textBoxes As List(Of TextBox) = New List(Of TextBox) From {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10, TextBox11, TextBox12, TextBox13, TextBox14, TextBox15, TextBox16, TextBox17, TextBox18, TextBox19, TextBox20, TextBox21, TextBox22, TextBox23, TextBox24, TextBox25, TextBox26, TextBox27, TextBox28, TextBox29, TextBox30}
                Dim lineIndex As Integer = 0
                Dim line As String

                While Not sr.EndOfStream AndAlso lineIndex < textBoxes.Count
                    line = sr.ReadLine()
                    textBoxes(lineIndex).Text = line
                    lineIndex += 1
                End While

                For i As Integer = lineIndex To textBoxes.Count - 1
                    textBoxes(i).Text = String.Empty
                Next
            End Using
        Else
            MsgBox("File .txt not found")
        End If
    End Sub
End Class