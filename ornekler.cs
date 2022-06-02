            while (sayi / 10 != 0)
            {
                int toplam = 0;
                int i = 10;
                int j = 1;

                while (sayi / j >= 1)
                {
                    toplam += (sayi % i / j);

                    i *= 10;
                    j *= 10;
                }

                sayi = toplam;
            }
      MessageBox.Show(sayi.ToString());

//////////////////////////////////////////////////////////////////////////////
      
      string metin = "Merhaba.Ahmet";
            char ch = '.';

            string ilk = null;
            string ikinci = null;

            for (int i = 0; i <= metin.Length - 1; i++)
            {
                if (metin[i] != ch)
                {
                    ikinci += metin[i];
                }
                else
                {
                    for (int j = i + 1; j <= metin.Length - 1; j++)
                    {
                        ilk += metin[j];
                    }
                    break;
                }
            }

            MessageBox.Show(ilk + ch + ikinci);
//////////////////////////////////////////////////////////////////////////////

public static int kontrol(int[] dizi)
        {
            Array.Sort(dizi);
            for (int i = 1; i < dizi.Length; i++)
                if (dizi[i] - dizi[i - 1] != 1)
                    return dizi[i];
            return 0;

        }
//////////////////////////////////////////////////////////////////////////////
            












      int i, j;
            int[,] matris1 = { { 1, 2 }, { 3, 4 } };
            int[,] matris2 = { { 1, 2 }, { 3, 4 } };
            int[,] sonuc = new int[50, 50];

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                    MessageBox.Show(matris1[i, j].ToString());
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                    MessageBox.Show(matris2[i, j].ToString());
            }
//////////////////////////////////////////////////////////////////////////////
            for (i = 0; i < 2; i++)
                for (j = 0; j < 2; j++)
                    sonuc[i, j] = matris1[i, j] + matris2[i, j];


            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                    MessageBox.Show(sonuc[i, j].ToString());
            }
