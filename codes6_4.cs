class ogrenci
{
  public string ad;
  public string soyad;
  public string bolum;
  public int not1;
  public int not2;
  public int not3;
  public int ort;

  public int ortalama 
  {
      get
        {
           ort=(not1 + not2 + not3) / 3;
           return ort;
        }
      set
        {
           ort = value;
        }
   }
}
 
/////////////////////////////////////////////////////

private void button1_Click(objectsender, EventArgs e)
{
  ogrenci yeni = new ogrenci();
  yeni.ad = textBox1.Text;
  yeni.soyad = textBox2.Text;
  yeni.bolum = textBox3.Text;
  yeni.not1 = Convert.ToInt32(textBox4.Text);
  yeni.not2 = Convert.ToInt32(textBox5.Text);
  yeni.not3 = Convert.ToInt32(textBox6.Text);
  //yeni.ort = (yeni.not1 + yeni.not2 + yeni.not3) / 3;
  yeni.ort = yeni.ortalama;//Prop
  listBox1.Items.Add(yeni.ad+ " " +yeni.bolum+" "+ yeni.ort);
}
