  internal class ogrenci
    {
        public string ad;
        public string soyad;
        public int mat;
        public int fizik;
        public int kimya;
        public string sonuc;
        public int ort;

        public int hesapla 
        {
            get
            {
                ort = (mat + fizik + kimya) / 3;
                return ort;
            }
            set
            {
                ort = value;
            }
        }

        public string hesaplas
        {
            get
            {
                if (ort > 60)
                    return "Geçti";
                else
                    return "Kaldı";
            }
            set
            {
                sonuc = value;
            }
        }
    }
   
   //////////////////////////////////////////
    Button Click Event'e;
    
    ogrenci ogr = new ogrenci();
    ogr.ad = textBox2.Text;
    ogr.soyad = textBox3.Text;
    ogr.mat = Convert.ToInt32(textBox4.Text);
    ogr.fizik = Convert.ToInt32(textBox5.Text);
    ogr.kimya = Convert.ToInt32(textBox6.Text);
    ogr.ort = ogr.hesapla;
    ogr.sonuc = ogr.hesaplas;
    label1.Text = ogr.sonuc;
    
