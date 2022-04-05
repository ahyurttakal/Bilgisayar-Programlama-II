Random rnd = new Random();
int sayi= rnd.Next(0,10);            
label1.Text = sayi.ToString();

///////////////////////////////////////////////////

int[] dizi = newint[10];
for (int i = 0; i < 10; i++)
{
   dizi[i] = rnd.Next(0, 10);
   listBox1.Items.Add(dizi[i]);
}

////////////////////////////////////////////////////

Array.Sort(dizi); //Diziyi sıralar           
for (int j = 0; j < 10; j++)
{
    listBox2.Items.Add(dizi[j]);
}

/////////////////////////////////////////////////////

//foreach Kullanımı
//foreach (veritürü değişken in diziadı) 
Array.Reverse(dizi); //Diziyi ters çevirir
int sira = Array.IndexOf(dizi,3);
foreach (int j in dizi) 
{
  listBox2.Items.Add(j);
}
label1.Text = sira.ToString();

