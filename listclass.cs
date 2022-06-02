     class ogrenci
    {
        public int ogrno { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int not { get; set; }
    }

//////////////////////////////////////////////////////////////////

            List<ogrenci> ogrenciler = new List<ogrenci>();

            ogrenci kisi1 = new ogrenci();
            ogrenci kisi2 = new ogrenci();
            kisi1.ogrno = 1;
            kisi1.ad = "Ahmet";
            kisi1.soyad = "Yurt";
            kisi1.not = 90;
            kisi2.ogrno = 2;
            kisi2.ad = "Mehmet";
            kisi2.soyad = "Al";
            kisi2.not = 40;

            ogrenciler.Add(kisi1);
            ogrenciler.Add(kisi2);

            foreach (ogrenci item in ogrenciler)
            {
                MessageBox.Show(item.ad+ " " + item.not.ToString());
            }
