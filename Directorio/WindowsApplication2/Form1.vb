Imports System.IO
Imports System

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim directorio As New DirectoryInfo("c:\users")
        Dim subdirectorio As DirectoryInfo() = directorio.GetDirectories()
        Dim subcarpetas As DirectoryInfo
        For Each subcarpetas In subdirectorio
            ListBox1.Items.Add(subcarpetas.Name.ToString)
        Next
        Dim cantidad As String = ListBox1.Items.Count
        MsgBox(CStr(cantidad))

    End Sub
End Class
