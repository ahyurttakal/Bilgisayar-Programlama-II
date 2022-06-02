//Form Yüklendiğinde 30 elemanlı (0-100) notlar adlı bir dizi oluşturulacaktır.
//Buton1: Oluşturulan diziyi listboxa aktar
//Buton2: 60’dan küçük notları listele
//Buton3: 70-85 arası notları listele
//Buton4: Tüm notların ortalamasını label aktar
//Buton5: En yüksek notu label aktar
//Buton6:Geçen öğrenci sayısını labelda göster
//Buton7:Başarı yüzdesini labelda göster


int[] notlar = newint[30];
private void Form1_Load(objectsender, EventArgs e)
{
   Random rnd = new Random();
   for (int i = 0; i < 30; i++)
   {
      notlar[i] = rnd.Next(0, 100);
   }
} 

private void button1_Click(objectsender, EventArgs e)
{
    listBox1.Items.Clear();
    foreach (int i in notlar)
    {
       listBox1.Items.Add(i);
    }
}

private void button2_Click(objectsender, EventArgs e)
{
     listBox1.Items.Clear();
     foreach (int i in notlar)
     {
        if (i < 30)
        {
            listBox1.Items.Add(i);
        }
     }
}
   
private void button3_Click(objectsender, EventArgs e)
{
   listBox1.Items.Clear();
   foreach (int i in notlar)
   {
       if (i >70 && i<85)
       {
             listBox1.Items.Add(i);
       }
   }
}

private void button4_Click(objectsender, EventArgs e)
{
   double toplam = 0, ort;
   foreach (int i in notlar)
   {
        toplam = toplam + i;
   }
   ort = toplam / 30;
   label1.Text = ort.ToString();
}

private void button5_Click(objectsender, EventArgs e)
{
   int enb = notlar[0];
   for (int i = 1; i <notlar.Length; i++)
   {
        if (enb< notlar[i])
                enb = notlar[i];
   }
   label1.Text = enb.ToString();
}

int gecen;
private void button6_Click(objectsender, EventArgs e)
{
    foreach (int i in notlar)
    {
        if (i >= 30)
                gecen++;
    }
    label1.Text = gecen.ToString();
}

private void button7_Click(objectsender, EventArgs e)
{
     double oran;
     oran = (gecen * 100) / 30;
     label1.Text = oran.ToString() + "%";
}
