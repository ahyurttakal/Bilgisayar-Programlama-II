//Overloading
private void yaz()
{
  MessageBox.Show("Merhaba");
}

private void yaz(ref string ad)
{
  MessageBox.Show("Günaydın "+ad);
  ad = "Özkan";
}

private void goster(string[] adlar)
{
  for (int i = 0; i <adlar.Length; i++)
  {
    MessageBox.Show(adlar[i]);
  }

  foreach (string item in adlar)
  {
    MessageBox.Show(item);
  }
}

private void button1_Click(objectsender, EventArgs e)
{
   yaz();

   string ad = textBox1.Text;
   yaz(ref ad);
   this.Text = ad;

   int adet = listBox1.Items.Count;
   string[] adlar = newstring[adet];
   for (int i = 0; i < adet; i++)
   {
      adlar[i] = listBox1.Items[i].ToString();
   }
   goster(adlar);
 }
