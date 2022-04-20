            List<int> liste = new List<int>();
            liste.Add(32);
            liste.Add(03);
            liste.Add(20);
            liste.Add(45);
            liste.Add(66);
            label1.Text = liste.Count.ToString();
            
            //////////////////////////////////////////
            foreach (var item in liste) //1. Foreach
            {
                listBox1.Items.Add(item);
            }
            
            //////////////////////////////////////////
            liste.ForEach(item => MessageBox.Show(item.ToString())); //2. Foreach
            
            /////////////////////////////////////////
            liste.Remove(20); //Değere göre
            liste.RemoveAt(2); //İndise göre
            liste.ForEach(item => MessageBox.Show("Remove'dan sonra"+ item.ToString()));
            
            /////////////////////////////////////////
            int aranan = liste.BinarySearch(66);
            MessageBox.Show("Aranan Eleman "+aranan.ToString());

            /////////////////////////////////////////
            string[] isimler = new string[4];
            isimler[0] = "Ahmet";
            isimler[1] = "Mehmet";
            isimler[2] = "Mert";
            isimler[3] = "Elif";

            List<string> isimlerimiz = new List<string>(isimler);
            if (isimlerimiz.Contains("Ahmet"))
            {
                MessageBox.Show("Bulundu "+isimlerimiz.IndexOf("Ahmet")+". sırada");
            }
            else
                MessageBox.Show("Bulunamadı");
