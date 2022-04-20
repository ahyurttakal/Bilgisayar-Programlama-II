            Dictionary<int, string> anahtarlistesi = new Dictionary<int, string>();
            anahtarlistesi.Add(03, "Afyon");
            anahtarlistesi.Add(32, "Isparta");
            anahtarlistesi.Add(45, "Manisa");
            anahtarlistesi.Add(67, "Zonguldak");
            
            ////////////////////////
            Dictionary<int, string>.KeyCollection sira = anahtarlistesi.Keys;
            foreach (var item in sira)
            {
                listBox1.Items.Add(item.ToString());
            }

            ////////////////////////
            Dictionary<int, string>.ValueCollection deger = anahtarlistesi.Values;
            foreach (var item in deger)
            {
                listBox1.Items.Add(item);
            }

            //////////////////////////
            foreach (KeyValuePair<int,string> item in anahtarlistesi)
            {
                MessageBox.Show(item.ToString());
            }

            //////////////////////////////////////////////////
            int anahtar = Convert.ToInt32(textBox1.Text);
            string deger2 = " ";
            if (anahtarlistesi.TryGetValue(anahtar, out deger2))
            {
                MessageBox.Show("Bulundu " + deger2);
            }
            else
                MessageBox.Show("Bulunamadı");
