
int a, b, toplam;
a = Convert.ToInt32(textBox1.Text);
b = Int32.Parse(textBox2.Text);           
toplam = a + b;
MessageBox.Show(toplam.ToString());

///////////////////////////////////////////////////////////

byte c;
int sayi = Convert.ToInt32(textBox1.Text);
c = (byte) sayi; //Cast Operatörü
MessageBox.Show(c.ToString());

///////////////////////////////////////////////////////////

short a, b, toplam;
a = Convert.ToInt16(textBox1.Text);
b = Convert.ToInt16(textBox2.Text);
toplam = (short)((short) a + b);
MessageBox.Show(toplam.ToString());

//////////////////////////////////////////////////////////////

decimal a, b, toplam;
a = Convert.ToDecimal(textBox1.Text);
b = 3.2m;
toplam = a + b;
MessageBox.Show(toplam.ToString());

///////////////////////////////////////////////////////////////////

long a = Convert.ToInt64(textBox1.Text);
long b = Convert.ToInt64(textBox2.Text);
long toplam, cikarma, carpma, bolme, us, mod;
toplam = a + b;
cikarma = a - b;
bolme = a / b;
carpma = a * b;
us =(long) Math.Pow(a, b);
mod = a % b;

///////////////////////////////////////////////////////////////////

///// + birleştirme operatörü, string ifadeleri birleştirir
MessageBox.Show(toplam.ToString() + " " + 
                cikarma.ToString() + " "+
                carpma.ToString() + " "+
                bolme.ToString() + " "+
                us.ToString() + " "+
                mod.ToString());

//////////////////////////////////////////////////////////////////////////

///// Bitsel Operatörler &, |, ^
///// Karşılaştırma &&, ||, >, <, >=, <=, !=, ==

//////////////////////////////////////////////////////////////////////////

int a=Convert.ToInt32(textBox1.Text);
if (a <= 100 && a >= 0)
{
    MessageBox.Show("Girilen not istenilen aralıkta");
    if (a > 50)
        MessageBox.Show("Geçti");
    else
        MessageBox.Show("Kaldı");
}
else
    MessageBox.Show("Girdiğiniz not istenilen aralıkta değil");

//////////////////////////////////////////////////////////////////////////

char a = Convert.ToChar(textBox1.Text);
if (a == 'g')
    textBox2.Text = "Galatasaray";
else if (a == 'f')
    textBox2.Text = "Fenerbahçe";
else if (a == 'b')
    textBox2.Text = "Beşiktaş";  

///////////////////////////////////////////////////////////////////////////

int a = Convert.ToInt32(textBox1.Text);
switch (a)
{
    case 30:
        textBox2.Text = "D";
        break;
    case 40:
        textBox2.Text = "C";
        break;
    case 50:
        textBox2.Text = "B";
        break;
    case 60:
        textBox2.Text = "A";
        break;
    case 70:
        goto case 60;
        break;
    default:
        textBox2.Text = "Farklı bir sayı";
        break;
}

////////////////////////////////////////////////////////////////////////

DateTime dt = Convert.ToDateTime(dateTimePicker1.Text);
switch (dt.DayOfWeek)
{
case 0:
       textBox2.Text = "Pazar";
       break;
case 1:
       textBox2.Text = "Pazartesi";
       break;
case 2:
       textBox2.Text = "Salı";
       break;
case 3:
       textBox2.Text = "Çarşamba";
       break;
case 4:
       textBox2.Text = "Perşembe";
       break;
case 5:
       textBox2.Text = "Cuma";
       break;
case 6:
       textBox2.Text = "Cumartesi";
       break;
}
