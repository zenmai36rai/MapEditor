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
                Dim AllDiff = True
                For i = 0 To ImageList.Count - 1
                    Dim chip1 As Bitmap = ImageList(i)
                    Dim chip2 As Bitmap = mapchip
                    If SameBitmap(chip1, chip2) Then
                        AllDiff = False
                    End If
                Next
                If AllDiff Then
                    ImageList.Add(mapchip)
                End If
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
    Private Function SameBitmap(ByVal c1 As Bitmap, ByVal c2 As Bitmap) As Boolean
        If (c1.Width <> c2.Width) Or (c1.Height <> c2.Height) Then
            Return False
        End If
        For y = 0 To c1.Height - 1
            For x = 0 To c1.Width - 1
                Dim p1 = c1.GetPixel(x, y)
                Dim p2 = c2.GetPixel(x, y)
                If p1 <> p2 Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function
End Class
