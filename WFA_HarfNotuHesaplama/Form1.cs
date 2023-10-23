using System;

namespace WFA_HarfNotuHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int vize1, vize2, final, sonuc;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {

                vize1=Convert.ToInt32(txtVize1.Text);
                vize2=Convert.ToInt32(txtVize2.Text);
                final=Convert.ToInt32(txtFinal.Text);

                lblHarfnotu.Text= HarfNotuHesapla(vize1, vize2, final);
            }
            catch (Exception)
            {
               MessageBox.Show( MesajVer("Doðru Formatta Giriþ yapýnýz.Notlar boþ geçilemez!"));
                
            }

        }

        private string HarfNotuHesapla(int vize1, int vize2, int final)
        {
            //AA: 90 - 100 / Baþarýlý
            //BA: 80 - 89 / Baþarýlý
            //BB: 75 - 79 / Baþarýlý
            //CB: 70 - 74 / Baþarýlý
            //CC: 60 - 69 / Baþarýlý
            //DC: 50 - 59 / Koþullu Baþarýlý - Baþarýsýz
            //DD: 40 - 49 / Baþarýsýz
            //FD: 30 - 39 / Baþarýsýz
            //FF: 0 - 29 / Baþarýsýz
            sonuc= Convert.ToInt32((vize1+vize2)*0.3+final*0.4);
            string mesaj = string.Empty;
            if (final<50) mesaj=("Baþarýsýz ");
            else
            {
                if (sonuc>=90&&sonuc<=100) mesaj=("Harf Notu AA: Baþarýlý ");
                else if (sonuc>=80&&sonuc<=89) mesaj=("Harf Notu BA: Baþarýlý ");
                else if (sonuc>=75&&sonuc<=79) mesaj=("Harf Notu BB: Baþarýlý ");
                else if (sonuc>=70&&sonuc<=74) mesaj=("Harf Notu CB: Baþarýlý ");
                else if (sonuc>=60&&sonuc<=69) mesaj=("Harf Notu CC: Baþarýlý ");
                else if (sonuc>=50&&sonuc<=59) mesaj=("Harf Notu DC: Koþullu Baþarýlý - Baþarýsýz ");
                else if (sonuc>=40&&sonuc<=49) mesaj=("Harf Notu DD: Baþarýsýz ");
                else if (sonuc>=30&&sonuc<=39) mesaj=("Harf Notu FD: Baþarýsýz ");
                else if (sonuc>=0&&sonuc<=29) mesaj=("Harf Notu FF: Baþarýsýz ");

            }
            
            return mesaj;
        }
        private string MesajVer(string mesaj)
        {
            return mesaj;
        }

    }
}