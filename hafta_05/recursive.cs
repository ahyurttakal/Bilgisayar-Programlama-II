private double hesapla(double a, double b, double c)
{
  double sonuc = (b * b) - (4 * a * c);
  return sonuc;
}

private double hesapla(double a, double b)
{
  double sonuc = 2 * a * b;
  return sonuc;
}

private double fhesapla(double f) ///Recursive
{
  double sonuc = 1;
  if (f > 0)
    sonuc = f * fhesapla(f-1);
  return sonuc;
}

private void button1_Click(objectsender, EventArgs e)
{
  double a = Convert.ToDouble(textBox1.Text);
  double b = Convert.ToDouble(textBox2.Text);
  double c = Convert.ToDouble(textBox3.Text);            
  double sonuc = hesapla(a, b, c);
  double sonuc2 = hesapla(a, b);
  MessageBox.Show(sonuc.ToString()+ " "+sonuc2.ToString());



  double f = Convert.ToDouble(textBox4.Text);
  doublefaktoriyel = fhesapla(f);
  MessageBox.Show(faktoriyel.ToString());
}

