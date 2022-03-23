private int okek(int[] dizi)
{
  int deger, i = 0, k, sonuc = 1;
  bool carp;
  deger = dizi[0];
  k = 2;
  while (k <deger)
  {
    carp = false;
    for (i = 0; i <dizi.Length; i++)
    {
      if (dizi[i] % k == 0)
      {
        carp = true;
        dizi[i] = dizi[i] / k; //bolum
      }
    }
    if (carp == true)
    {
      sonuc = sonuc * k; 
      k = 1;
    }
    k++;
  }
  return sonuc;
}
private void button1_Click(objectsender, EventArgs e)
{
   int adet = listBox1.Items.Count;
   int[] dizi = new int[adet];
   for (int i = 0; i < adet; i++)
   {
      dizi[i] = Convert.ToInt32(listBox1.Items[i]);
   }
   int sonuc = okek(dizi);
   MessageBox.Show(sonuc.ToString());
}
