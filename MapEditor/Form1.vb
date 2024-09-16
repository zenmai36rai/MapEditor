' MapEditor for DragonQuest Open Source Software Writen by Kyosuke Miyazawa 2024
Public Class Form1
    Private Sub ButtonCalcStart_Click(sender As Object, e As EventArgs) Handles ButtonCalcStart.Click
        Dim mapchip As New Bitmap(16, 16)
        Dim g = Graphics.FromImage(mapchip)
        Dim bmp As Bitmap = New Bitmap(PictureBoxOriginal.Image)
        Dim ImageList = New List(Of Bitmap)
        Dim d As Rectangle = New Rectangle(0, 0, 15, 15)
        Dim s As Rectangle = New Rectangle(0, 0, 15, 15)
        g.DrawImage(bmp, d, s, GraphicsUnit.Pixel)
        g.Dispose()
        PictureBoxDifferent.Image = mapchip
    End Sub
End Class
