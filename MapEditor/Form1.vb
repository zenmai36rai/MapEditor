' MapEditor for DragonQuest Open Source Software Writen by Kyosuke Miyazawa 2024
Public Class Form1
    Private Sub ButtonCalcStart_Click(sender As Object, e As EventArgs) Handles ButtonCalcStart.Click
        Dim bmp = PictureBoxOriginal.Image
        PictureBoxDifferent.Image = bmp
    End Sub
End Class
