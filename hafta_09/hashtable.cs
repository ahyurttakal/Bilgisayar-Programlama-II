            Hashtable hashlistesi = new Hashtable();
            hashlistesi.Add("Isparta", 32);
            hashlistesi.Add(03,"Afyon");
            hashlistesi.Add(1,true);

            foreach (var item in hashlistesi.Keys)
            {
                listBox1.Items.Add(item.ToString());
            }
            foreach (var item in hashlistesi.Values)
            {
                listBox1.Items.Add(item.ToString());
            }
