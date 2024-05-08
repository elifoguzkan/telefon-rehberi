Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.GridLines = True
        ListView1.Columns.Add("Ad", 100)
        ListView1.Columns.Add("Soyad", 100)
        ListView1.Columns.Add("Telefon", 100)
        ListView1.Columns.Add("E-Posta", 100)
        ListView1.Columns.Add("Adres", 100)
        ListView1.Columns.Add("Şehir", 100)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.Length > 0 AndAlso TextBox2.Text.Length > 0 AndAlso TextBox3.Text.Length > 0 AndAlso TextBox4.Text.Length > 0 AndAlso TextBox5.Text.Length > 0 AndAlso TextBox6.Text.Length > 0) Then
            VeriEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
        Else MessageBox.Show("Alanlar boş geçilemez")
        End If
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub
    Private Sub VeriEkle(ad As String, soyad As String, telefon As String, adres As String, email As String, sehir As String)
        Dim item As New ListViewItem(ad)
        item.SubItems.Add(soyad)
        item.SubItems.Add(telefon)
        item.SubItems.Add(adres)
        item.SubItems.Add(email)
        item.SubItems.Add(sehir)
        ListView1.Items.Add(item)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListView1.SelectedItems.Count > 0 Then
            TextBox1.Text = ListView1.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = ListView1.SelectedItems(0).SubItems(1).Text
            TextBox3.Text = ListView1.SelectedItems(0).SubItems(2).Text
            TextBox4.Text = ListView1.SelectedItems(0).SubItems(3).Text
            TextBox5.Text = ListView1.SelectedItems(0).SubItems(4).Text
            TextBox6.Text = ListView1.SelectedItems(0).SubItems(5).Text 'güncelleyi düzelt'
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            ListView1.SelectedItems(0).Remove()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text.Length > 0 AndAlso TextBox2.Text.Length > 0 AndAlso TextBox3.Text.Length > 0 AndAlso TextBox4.Text.Length > 0 AndAlso TextBox5.Text.Length > 0 AndAlso TextBox6.Text.Length > 0) Then
            VeriEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
        Else MessageBox.Show("Alanlar boş geçilemez")
        End If
        ListView1.SelectedItems(0).Remove()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim input As String
        input = TextBox7.Text
        If ListView1.Items.Count > 0 Then
            If input.Length > 0 Then
                Dim foundItem As ListViewItem = ListView1.FindItemWithText(input, True, 0, True)
                If foundItem IsNot Nothing Then
                    MsgBox("Listede Var")
                Else
                    MsgBox("Listede yok")
                End If
            Else
                MsgBox("Lütfen aranacak değeri girin.")
            End If
        Else
            MsgBox("Listede aranacak kayıt yok.")
        End If
        TextBox7.Clear()
    End Sub
End Class
