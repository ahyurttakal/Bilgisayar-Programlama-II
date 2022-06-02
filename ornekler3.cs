private void button1_Click(object sender, EventArgs e)
        {
            //string str = textBox1.Text;
            //int max = 0, i,ascii;
            //int[] dizi = new int[255];
           
            //i = 0;
            //while (i < str.Length)
            //{
            //    ascii = (int)str[i];
            //    dizi[ascii]++;
            //    i++;
            //}

            //max = 0;
            //for (i = 0; i < 255; i++)
            //{
            //    if (i != 32)
            //    {
            //        if (dizi[i] > dizi[max])
            //            max = i;
            //    }
            //}
            //MessageBox.Show((char)max+" "+max+" "+dizi[max]);

    ///////////////////////////////////////////////////////////////

            //string str = textBox1.Text;
            //string str2 = null;
            //int l = str.Length - 1;
            //while (l >= 0)
            //{
            //    str2 += str[l];
            //    l--;
            //}
            //textBox2.Text = str2;

    ////////////////////////////////////////////////////////////////

            //string str = textBox1.Text;
            //string str2=null;
            //char[] dizi;
            //char tmp;
            //dizi = str.ToCharArray(0, str.Length);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 0; j < str.Length-1; j++)
            //    {
            //        if (dizi[j] > dizi[j + 1])
            //        {
            //            tmp = dizi[j];
            //            dizi[j] = dizi[j + 1];
            //            dizi[j + 1] = tmp;
            //        }
            //    }
            //}
            //foreach (char c in dizi)
            //{
            //    str2 += c;
            //}
            //textBox2.Text = str2;

            //////////////////////////////////////////

            //int[] dizi = {5,3,4,3,4,6,7,2,3,2,6};
            //int sayac;
            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    sayac = 0;
            //    for (int j = i+1; j < dizi.Length; j++)
            //    {
            //        if (dizi[i] == dizi[j])
            //        {
            //            sayac++;
            //            i++;
            //        }                  
            //    }
            //    if (sayac == 0)
            //    {
            //        MessageBox.Show(dizi[i].ToString());
            //    }
            //}

            ///////////////////////////////////

            tekyazdir(1, 15);

        }
        public static void tekyazdir(int bas, int son)
        {
            if (bas > son)
                return;
            MessageBox.Show(bas.ToString());
            tekyazdir(bas + 2, son);
        }
