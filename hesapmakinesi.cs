private void button1_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "1";
  else
                textBox1.Text += "1";
}

private void button24_Click(objectsender, EventArgs e)
{
            textBox1.Text = "0";
}

private void button2_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "2";
  else
                textBox1.Text += "2";
}

private void button3_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "3";
  else
                textBox1.Text += "3";
}

private void button4_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "4";
  else
                textBox1.Text += "4";
}

private void button5_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "5";
  else
                textBox1.Text += "5";
}

private void button6_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "6";
  else
                textBox1.Text += "6";
}

private void button7_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "7";
  else
                textBox1.Text += "7";
}

private void button8_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "8";
  else
                textBox1.Text += "8";
}

private void button9_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "9";
  else
                textBox1.Text += "9";
}

private void button10_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "0";
  else
                textBox1.Text += "0";
}

private void button23_Click(objectsender, EventArgs e)
{
  if (textBox1.Text == null || textBox1.Text == "0")
                textBox1.Text = "0.";
  else
                textBox1.Text += ".";
}

char islem;
double sayi1, sayi2;
private void button11_Click(objectsender, EventArgs e)
{
  islem = '+';
  sayi1 = Convert.ToDouble(textBox1.Text);
  textBox1.Text = "0";
}

private void button12_Click(objectsender, EventArgs e)
{
  islem = '-';
  sayi1 = Convert.ToDouble(textBox1.Text);
  textBox1.Text = "0";
}

private void button13_Click(objectsender, EventArgs e)
{
  islem = '*';
  sayi1 = Convert.ToDouble(textBox1.Text);
  textBox1.Text = "0";
}

private void button14_Click(objectsender, EventArgs e)
{
  islem = '/';
  sayi1 = Convert.ToDouble(textBox1.Text);
  textBox1.Text = "0";
}

doublesonuc;
private void button22_Click(objectsender, EventArgs e)
{
  sayi2 = Convert.ToDouble(textBox1.Text);
  switch (islem)
  {
    case'+':
      sonuc = sayi1 + sayi2;
      textBox1.Text = sonuc.ToString();
      break;
    case'-':
      sonuc = sayi1 - sayi2;
      textBox1.Text = sonuc.ToString();
      break;
    case'*':
      sonuc = sayi1 * sayi2;
      textBox1.Text = sonuc.ToString();
      break;
    case'/':
      if (sayi1 == 0)
         textBox1.Text = "Sayı 0'a bölünemez";
      else
      {
        sonuc = sayi1 / sayi2;
        textBox1.Text = sonuc.ToString();
      }
      break;
    case'p':
      sonuc = Math.Pow(sayi1, sayi2);
      textBox1.Text = sonuc.ToString();
      break;
  }
}

private void button15_Click(objectsender, EventArgs e)
{
  sayi1 = Convert.ToDouble(textBox1.Text);
  sonuc = Math.Sqrt(sayi1);
  textBox1.Text = sonuc.ToString();
}

private void button16_Click(objectsender, EventArgs e)
{
  sayi1 = Convert.ToDouble(textBox1.Text);
  sonuc = Math.Ceiling(sayi1);
  textBox1.Text = sonuc.ToString();
}

private void button17_Click(objectsender, EventArgs e)
{
   sayi1 = Convert.ToDouble(textBox1.Text);
   sonuc = Math.Floor(sayi1);
   textBox1.Text = sonuc.ToString();
}

private void button18_Click(objectsender, EventArgs e)
{
   sayi1 = Convert.ToDouble(textBox1.Text);
   sonuc = Math.Abs(sayi1);
   textBox1.Text = sonuc.ToString();
}

private void button19_Click(objectsender, EventArgs e)
{
  islem = 'p';
  sayi1 = Convert.ToDouble(textBox1.Text);
  textBox1.Text = "0";
}

private void button20_Click(objectsender, EventArgs e)
{
   sayi1 = Convert.ToDouble(textBox1.Text);
   sonuc = Math.Cos(sayi1);
   textBox1.Text = sonuc.ToString();
}

private void button21_Click(objectsender, EventArgs e)
{
   sayi1 = Convert.ToDouble(textBox1.Text);
   sonuc = Math.Sin(sayi1);
   textBox1.Text = sonuc.ToString();
}
