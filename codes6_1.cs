private void button1_Click(objectsender, EventArgs e)
{
   timer1.Start();
}

private void button2_Click(objectsender, EventArgs e)
{
   timer1.Stop();
}

intsayac = 0;
private void timer1_Tick(objectsender, EventArgs e)
{
   sayac++;
   label1.Text = sayac.ToString();
   ///////////////////////////////
   if (sayac>= 0 &&sayac<= 10)
      this.BackColor = Color.Red;
   if (sayac> 10 &&sayac<= 13)
      this.BackColor = Color.Yellow;
   if (sayac> 13 &&sayac<= 23)
      this.BackColor = Color.Green;
   if (sayac> 23)
      this.BackColor = Color.Black;
   /////////////////////////////////////
   if (progressBar1.Value == 100)
      progressBar1.Value = 1;
   else
      progressBar1.Value += 10;
}

private void button3_Click(objectsender, EventArgs e)
{
  try
    {
        progressBar1.Value += 10;
    }
  catch(Exception ex)
    {
        MessageBox.Show("Beklenmeyen hata oluştu\n" + ex.Message.ToString());
    }
  finally
    {
        MessageBox.Show("Yine bekleriz:)");
    }
}

private void button4_Click(objectsender, EventArgs e)
{
   try
     {
         int sayi1 = Convert.ToInt32(textBox1.Text);
         int sayi2 = Convert.ToInt32(textBox2.Text);
         int toplam = sayi1 + sayi2;
         MessageBox.Show(toplam.ToString());
     }
   catch (Exception ex)
     {
         MessageBox.Show("Beklenmeyen hata oluştu\n" + ex.Message.ToString());
     }
}

private void button5_Click(objectsender, EventArgs e)
{
   string metin = textBox3.Text;
   //textBox4.Text = metin.ToLower();
   //textBox4.Text = metin.ToUpper();
   //textBox4.Text = metin.Trim();
   //textBox4.Text = metin.Replace("?","!");
   textBox4.Text = metin.Substring(4);
}

