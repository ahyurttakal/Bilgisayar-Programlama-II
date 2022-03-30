//Struct-Class karşılaştırması
//1.Struct Belleğin Stack kısmında tutulur. Class Belleğin Heap kısmında tutulur.
//2.Struct değer türündedir. Class referans türündedir.
//3.Struct daha az maliyetli ve erişim hızı yüksektir.
//4.Struct kalıtımla türetilemez. Class kalıtımla türetilebilir.


struct kitap
{
   public string kitapadi;
   public string yazaradi;
   public decimal fiyat;
   
   public decimal kdv
   {
      get
        {
          decimal deger = fiyat * 0.18m;
          return deger;
        }
   }
   public decimal toplam 
   {
      get
        {
          decimal sonuc = fiyat + kdv;
          return sonuc;
        }
    }
}

private void button1_Click(objectsender, EventArgs e)
{
    kitap yeni = newkitap();
    yeni.kitapadi = textBox1.Text;
    yeni.yazaradi = textBox2.Text;
    yeni.fiyat = Convert.ToDecimal(textBox3.Text);
    textBox4.Text = yeni.kdv.ToString("0.00TL");
    textBox5.Text = yeni.toplam.ToString("0.00TL");
}
