            int[] dizi = { 3,3,5,5,5,6,6,6,6};

            for (int i = 0; i < dizi.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i] == dizi[j])
                        count = count + 1;
                }
                listBox1.Items.Add(dizi[i] + " " + count);
            }
            
///////////////////////////////////////////////////////////////////
            int[] yedek = new int[10];
            for (int i = 0; i < 9; i++)
                yedek[i] = -1;
            for (int i = 0; i < dizi.Length; i++)
            {
                int sayac = 1;
                for (int j = i + 1; j < dizi.Length; j++)
                {
                    if (dizi[i] == dizi[j])
                    {
                        sayac++;
                        yedek[j] = 0;
                    }
                }
                if (yedek[i] != 0)
                {
                    yedek[i] = sayac;
                }
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                if (yedek[i] != 0)
                    listBox1.Items.Add(dizi[i] + " " + yedek[i]);
            }
            
////////////////////////////////////////////////////////////////////
            var dict = new Dictionary<int, int>();
            foreach (var i in dizi)
            {
                dict.TryGetValue(i, out int sayac);
                dict[i] = sayac + 1;
            }
            foreach (var i in dict)
            {
                listBox1.Items.Add(i.Key + " " + i.Value);
            }
            
//////////////////////////////////////////////////////////////////
            ArrayList tkrr = new ArrayList();
            for (int i = 0; i < dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i].Equals(dizi[j]))
                    {
                        if (!tkrr.Contains(dizi[i]))
                            tkrr.Add(dizi[i]);  
                    }
                }
            }
            for (int i = 0; i < tkrr.Count; i++)
            {
                listBox1.Items.Add(tkrr[i]);
            }
/////////////////////////////////////////////////////////////////
            int[] dizi = { 3, 3, 5, 5, 5, 6, 6, 6, 6 };
            int tmp = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    if (dizi[j] > dizi[i])
                    {
                        tmp = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = tmp;
                    }
                }
            }
         
            for (int i = 0; i < 9; i++)
            {
                listBox1.Items.Add(dizi[i]);
            }
//////////////////////////////////////////////////////////
            int[] dizi = { 3, 3, 5, 6, 6, 6, 6 ,7,7};
            int ara = 4, x = 0;
            for (int i = 0; i < 9; i++)
            {
                if (ara < dizi[i])
                {
                    x = i;
                    break;
                }
            }
            
            for (int i = 8; i > x; i--)
            {
                dizi[i] = dizi[i - 1];
            }
            dizi[x] = ara;

            for (int i = 0; i < 9; i++)
            {
                listBox1.Items.Add(dizi[i]);
            }
            ArrayList arr=new ArrayList(dizi);
            arr.Insert(x, ara);   
            foreach (var item in arr)
            {
                listBox1.Items.Add(item);
            }
////////////////////////////////////////////////////////
            int num = 123;
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            MessageBox.Show(sum.ToString());
