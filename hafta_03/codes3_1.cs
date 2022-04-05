int hak, toplamhak;
private void button1_Click(objectsender, EventArgs e)
{
  toplamhak = 3;
  if (txtNick.Text == "ahy" && txtPsw.Text == "123")
    MessageBox.Show("Giriş Başarılı");
  else
  {
    hak++;
    label3.Text = "Kullanıcı Adı veya Şifre Yanlış";
    label3.Visible = true;
    MessageBox.Show("Toplam "+(toplamhak-hak)+" hakkınız kaldı");
    if (hak == 3)
      Application.Exit();
   }
}

