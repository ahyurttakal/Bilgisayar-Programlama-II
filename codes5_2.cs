private void boya(string nesne, string renk)
{
  foreach (Control eleman inthis.Controls)
  {
    if (eleman isButton&& nesne == "button")
      eleman.BackColor = Color.FromName(renk);
    if (eleman isTextBox&& nesne == "textbox")
      eleman.BackColor = Color.FromName(renk);
    if (eleman isListBox&& nesne == "listbox")
      eleman.BackColor = Color.FromName(renk);
   }
}

private void button3_Click(objectsender, EventArgs e)
{
  //Random rnd = new Random();
  //int rsayi = rnd.Next(5);
  //int nsayi = rnd.Next(3);
  //string nesne = listBox1.Items[nsayi].ToString();
  //string renk = listBox2.Items[rsayi].ToString();
  string nesne = listBox1.SelectedItem.ToString();
  string renk = listBox2.SelectedItem.ToString();
  boya(nesne,renk);
}
