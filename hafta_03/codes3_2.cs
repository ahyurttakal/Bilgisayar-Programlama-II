int toplam = 0;
for (int i = 0; i <= 100; i++)
{
  if (i % 2 == 0)
  {
    listBox1.Items.Add(i.ToString());
    toplam += i;
  }
}
MessageBox.Show(toplam.ToString());

/////////////////////////////////////////////////////

int sayi = Convert.ToInt32(textBox1.Text);
int faktoriyel = 1;
for (int i = 1; i <= sayi; i++)
{
  faktoriyel *= i;
}
MessageBox.Show(faktoriyel.ToString());

//////////////////////////////////////////////////////

int i = 10;
while (i <= 5)
{
  listBox1.Items.Add(i + " Yaşasın Cumhuriyet");
  i++;
}

//////////////////////////////////////////////////////

int j = 10;
do
{
   listBox1.Items.Add(j + " Yaşasın Cumhuriyet");
   j++;
} while (j <= 5);



