            Random rnd = new Random();
            int[] calisan = new int[20];
            for(int i=0;i<20;i++)
            {
                calisan[i] = rnd.Next(20, 65);
            }
////////////////////////////////////////////////////////////////
            if(radioButton1.Checked==true)
            {
                listBox1.Items.Clear();
                foreach (var item in calisan)
                {
                    listBox1.Items.Add(item);    
                }
            }
            else if(radioButton2.Checked==true)
            {
                listBox1.Items.Clear();
                foreach (var item in calisan)
                {
                    if(item>20 && item<35)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if(radioButton3.Checked==true)
            {
                listBox1.Items.Clear();
                foreach (var item in calisan)
                {
                    if (item > 35 && item < 50)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
            else if(radioButton4.Checked==true)
            {
                listBox1.Items.Clear();
                foreach (var item in calisan)
                {
                    if (item > 50 && item < 65)
                    {
                        listBox1.Items.Add(item);
                    }
                }
            }
//////////////////////////////////////////////////////////
            double toplam=0, ort;
            foreach(var item in calisan)
            {
                toplam += item;
            }
            ort = toplam / 20;
/////////////////////////////////////////////////////////////
            int adet = 0;
            for(int i=0; i<20;i++)
            {
                if(calisan[i]>ort)
                {
                    adet++;
                }
            }
            MessageBox.Show(adet.ToString());
