string[] iller = newstring[3];
iller[0] = "Afyon";
iller[1] = "Isparta";
iller[2] = "Yozgat";
label1.Text = iller[1];

double[] sayilar = {2.1, 3.2, 4.3 };
label2.Text = sayilar[1].ToString();

/////////////////////////////////////////////////////////////

int[] dizi = { 32, 35, 48, 63, 24, 12, 16, 42 };
label3.Text = dizi.Length.ToString();
int i = 0;
while (i <dizi.Length)
{
  listBox1.Items.Add(i + ". indis= " + dizi[i]);
  i++;
}

/////////////////////////////////////////////////////////////

int toplam = 0;
for (int j = 0; j <dizi.Length; j++)
{
  if (dizi[j] % 2 == 0)
  {
    listBox2.Items.Add(j + ". indis= " + dizi[j]);
    toplam = toplam + dizi[j];
  }
}
label4.Text = toplam.ToString();

///////////////////////////////////////////

//int k = 0, toplam = 0;
//do{
//    if (dizi[k] % 2 != 0)
//    {
//        toplam = toplam + dizi[k];
//    }
//}while(k<dizi.Length);
//label4.Text = toplam.ToString();

