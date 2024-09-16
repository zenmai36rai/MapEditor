' MapEditor for DragonQuest Open Source Software Writen by Kyosuke Miyazawa 2024
Public Class Form1
    Public MAP_X As Integer = 135
    Public MAP_Y As Integer = 132
    Public CHIP_W As Integer = 16
    Public CHIP_H As Integer = 16
    Public TEXT_MAP(MAP_X, MAP_Y) As Int16
    Private Sub ButtonCalcStart_Click(sender As Object, e As EventArgs) Handles ButtonCalcStart.Click
        Dim CHIP_COUNT = 0
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
                Dim chip_number = 0
                For i = 0 To ImageList.Count - 1
                    Dim chip1 As Bitmap = ImageList(i)
                    Dim chip2 As Bitmap = mapchip
                    If SameBitmap(chip1, chip2) Then
                        AllDiff = False
                        chip_number = i
                        TEXT_MAP(x, y) = chip_number
                    End If
                Next
                If AllDiff Then
                    ImageList.Add(mapchip)
                    TEXT_MAP(x, y) = CHIP_COUNT
                    CHIP_COUNT = CHIP_COUNT + 1
                End If
            Next
        Next
        Dim tex As String = ""
        For y = 0 To MAP_Y - 1
            For x = 0 To MAP_X - 1
                Dim str As String = Hex(TEXT_MAP(x, y))
                If str.Length = 1 Then
                    str = "0" + str
                End If
                tex += str
            Next
            tex = tex + vbCrLf
        Next
        RichTextBoxMap.Text = tex
        Dim canvas As New Bitmap(PictureBoxChip.Width, PictureBoxChip.Height)
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
        PictureBoxChip.Image = canvas
        Dim diff As New Bitmap(PictureBoxDifferent.Width, PictureBoxDifferent.Height)
        Dim g3 = Graphics.FromImage(diff)
        For y2 = 0 To MAP_Y - 1
            For x2 = 0 To MAP_X - 1
                For i = 0 To ImageList.Count
                    If TEXT_MAP(x2, y2) = i Then
                        Dim mapchip = ImageList(i)
                        Dim d As Rectangle = New Rectangle(x2 * CHIP_W, y2 * CHIP_H, CHIP_W, CHIP_H)
                        Dim s As Rectangle = New Rectangle(0, 0, CHIP_W, CHIP_H)
                        g3.DrawImage(mapchip, d, s, GraphicsUnit.Pixel)
                    End If
                Next
            Next
        Next
        g3.Dispose()
        PictureBoxDifferent.Image = diff
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

    Private Sub ButtonCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopyText.Click
        Clipboard.SetText(RichTextBoxMap.Text)
    End Sub

    Private Sub ButtonCopyImage_Click(sender As Object, e As EventArgs) Handles ButtonCopyImage.Click
        Clipboard.SetImage(PictureBoxChip.Image)
    End Sub
End Class
