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
               MessageBox.Show( MesajVer("Do�ru Formatta Giri� yap�n�z.Notlar bo� ge�ilemez!"));
                
            }

        }

        private string HarfNotuHesapla(int vize1, int vize2, int final)
        {
            //AA: 90 - 100 / Ba�ar�l�
            //BA: 80 - 89 / Ba�ar�l�
            //BB: 75 - 79 / Ba�ar�l�
            //CB: 70 - 74 / Ba�ar�l�
            //CC: 60 - 69 / Ba�ar�l�
            //DC: 50 - 59 / Ko�ullu Ba�ar�l� - Ba�ar�s�z
            //DD: 40 - 49 / Ba�ar�s�z
            //FD: 30 - 39 / Ba�ar�s�z
            //FF: 0 - 29 / Ba�ar�s�z
            sonuc= Convert.ToInt32((vize1+vize2)*0.3+final*0.4);
            string mesaj = string.Empty;
            if (final<50) mesaj=("Ba�ar�s�z ");
            else
            {
                if (sonuc>=90&&sonuc<=100) mesaj=("Harf Notu AA: Ba�ar�l� ");
                else if (sonuc>=80&&sonuc<=89) mesaj=("Harf Notu BA: Ba�ar�l� ");
                else if (sonuc>=75&&sonuc<=79) mesaj=("Harf Notu BB: Ba�ar�l� ");
                else if (sonuc>=70&&sonuc<=74) mesaj=("Harf Notu CB: Ba�ar�l� ");
                else if (sonuc>=60&&sonuc<=69) mesaj=("Harf Notu CC: Ba�ar�l� ");
                else if (sonuc>=50&&sonuc<=59) mesaj=("Harf Notu DC: Ko�ullu Ba�ar�l� - Ba�ar�s�z ");
                else if (sonuc>=40&&sonuc<=49) mesaj=("Harf Notu DD: Ba�ar�s�z ");
                else if (sonuc>=30&&sonuc<=39) mesaj=("Harf Notu FD: Ba�ar�s�z ");
                else if (sonuc>=0&&sonuc<=29) mesaj=("Harf Notu FF: Ba�ar�s�z ");

            }
            
            return mesaj;
        }
        private string MesajVer(string mesaj)
        {
            return mesaj;
        }

    }
}