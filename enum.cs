enum renkler
{
   sari=0,
   kirmizi=1,
   mavi=2,
   yesil=3
}

private void button1_Click(objectsender, EventArgs e)
{
    foreach (stringiteminEnum.GetNames(typeof(renkler)))
    {
         listBox1.Items.Add(item);
    }
}
