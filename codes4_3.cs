int[] notlar = newint[30];
privatevoid Form1_Load(objectsender, EventArgs e)
        {

Randomrnd = newRandom();
for (int i = 0; i < 30; i++)
            {
                notlar[i] = rnd.Next(0, 100);
            }
        } 

privatevoid button1_Click(objectsender, EventArgs e)
        {
            listBox1.Items.Clear();
foreach (int i in notlar)
            {
                listBox1.Items.Add(i);
            }
        }

privatevoid button2_Click(objectsender, EventArgs e)
        {
            listBox1.Items.Clear();
foreach (int i in notlar)
            {
if (i < 30)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

privatevoid button3_Click(objectsender, EventArgs e)
        {
            listBox1.Items.Clear();
foreach (int i in notlar)
            {
if (i >70 && i<85)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

privatevoid button4_Click(objectsender, EventArgs e)
        {
double toplam = 0, ort;
foreach (int i in notlar)
            {
toplam = toplam + i;
            }
ort = toplam / 30;
            label1.Text = ort.ToString();
        }

privatevoid button5_Click(objectsender, EventArgs e)
        {
intenb = notlar[0];
for (int i = 1; i <notlar.Length; i++)
            {
if (enb< notlar[i])
enb = notlar[i];
            }
            label1.Text = enb.ToString();
        }

int gecen;
privatevoid button6_Click(objectsender, EventArgs e)
        {
foreach (int i in notlar)
            {
if (i >= 30)
gecen++;
            }
            label1.Text = gecen.ToString();
        }

privatevoid button7_Click(objectsender, EventArgs e)
        {
double oran;
oran = (gecen * 100) / 30;
            label1.Text = oran.ToString() + "%";
        }
