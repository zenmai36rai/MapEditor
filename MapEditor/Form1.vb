' MapEditor for DragonQuest Open Source Software Writen by Kyosuke Miyazawa 2024
Public Class Form1
    Public MAP_X As Integer = 16
    Public MAP_Y As Integer = 16
    Public CHIP_W As Integer = 16
    Public CHIP_H As Integer = 16
    Private Sub ButtonCalcStart_Click(sender As Object, e As EventArgs) Handles ButtonCalcStart.Click
        Dim bmp As Bitmap = New Bitmap(PictureBoxOriginal.Image)
        Dim ImageList = New List(Of Bitmap)
        For y = 0 To MAP_Y - 1
            For x = 0 To MAP_X - 1
                Dim mapchip As New Bitmap(CHIP_W, CHIP_H)
                Dim g = Graphics.FromImage(mapchip)
                Dim d As Rectangle = New Rectangle(0, 0, CHIP_W, CHIP_H)
                Dim s As Rectangle = New Rectangle(x * CHIP_W, y * CHIP_H, CHIP_W, CHIP_H)
                g.DrawImage(bmp, d, s, GraphicsUnit.Pixel)
                g.Dispose()
                ImageList.Add(mapchip)
            Next
        Next
        Dim canvas As New Bitmap(PictureBoxDifferent.Width, PictureBoxDifferent.Height)
        Dim g2 = Graphics.FromImage(canvas)
        For i = 0 To ImageList.Count - 1
            Dim mapchip = ImageList(i)
            Dim x As Integer = i Mod MAP_X
            Dim y As Integer = (i - x) / MAP_X
            Dim d As Rectangle = New Rectangle(x * CHIP_W, y * CHIP_H, CHIP_W, CHIP_H)
            Dim s As Rectangle = New Rectangle(0, 0, CHIP_W, CHIP_H)
            g2.DrawImage(mapchip, d, s, GraphicsUnit.Pixel)
        Next
        g2.Dispose()
        PictureBoxDifferent.Image = canvas
    End Sub
End Class
