using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harjoitustehtävä
{
    public partial class HenkTiedot : Form
    {   //Formikohtaiset muuttujat ovat tässä.
        public string errorMSG = ""; //Kaikki virheviestit tallennetaan tähän muttuujaan.
        public bool HenkTun;    // Apumuuttuja henkilötunnuksen tarkastamisessa.
        public double TunnusLuku; // Apumuuttuja henkilötunnuksen tarkastamisessa.
        public string Tarkistusmerkki; // Apumuuttuja henkilötunnuksen tarkastamisessa.
        public int ajanlasku = 30; //Tallenna-napin timerin apumuuttuja.
        public string filepath; //Apumuuttuja HaeTiedosto()-funktiolle.
        public string tiedosto = "c:\\temp\\Henkilötiedot.json"; //Apumuuttuja TallennaTiedosto()-funktiolle.
        public string LOKI; //Lokitiedostoa varten.
        public HenkTiedot()
        {
            InitializeComponent();
            dgTiedot.DataSource = lista;
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            tslblStatus.Text = "";
            filepath = "";
            LOKI += "Käyttäjä: " + Environment.UserName + " Avasi sovelluksen: "+DateTime.Now.ToShortDateString()+
                " klo: " + DateTime.Now.ToShortTimeString();
        }
        //Luodaan tietue Henkilo, johon tallennetaan tekstikentistä saadut tiedot.
        public struct Henkilo
        {
            public string etunimet;
            public string Etunimet { get { return etunimet; } }
            public string sukunimi;
            public string Sukunimi { get { return sukunimi; } }
            public string kutsumanimi;
            public string Kutsumanimi { get { return kutsumanimi; } }
            public string henkilotunnus;
            public string Henkilotunnus { get { return henkilotunnus; } }
            public string kotiosoite;
            public string Kotiosoite { get { return kotiosoite; } }
            public string postinumero;
            public string Postinumero { get { return postinumero; } }
            public string postitoimipaikka;
            public string Postitoimipaikka { get { return postitoimipaikka; } }
            public string alkamispaiva;
            public string Alkamispaiva { get { return alkamispaiva; } }
            public string paattymispaiva;
            public string Paattymispaiva { get { return paattymispaiva; } }
            public string nimike;
            public string Nimike { get { return nimike; } }
            public string yksikko;
            public string Yksikko { get { return yksikko; } }

        }
        
        //Lista, jolle tallennetaan Henkilötiedot.
        public BindingList<Henkilo> lista = new BindingList<Henkilo>();

        //Tarkistetaan henkilötunnus. Lähetetään virheviesti, jos kentässä on väärän muotoinen Henkilötunnus. 
        //Alunperin oli tarkoitus tehdä if-viidakko, mutta tämä toimii samalla tavalla. Ainoa huonopuoli on se, ettei käyttäjä tiedä mikä on vikana.
        public bool TarkistaHetu()
        {
            try
            {
                if (string.IsNullOrEmpty(tbHetu.Text) || !tbHetu.Text.Contains("-") ||
                    tbHetu.Text.Length < 11 || tbHetu.Text.Length > 11 || tbHetu.Text.StartsWith("ABCDEFGHIJKLMNOPQRSTUVWXYZOÅÄÖ"))
                {
                    errorMSG = "Henkilötunnus on virheellinen";
                    LOKI += "\n"+ "Käyttäjä: " + Environment.UserName.ToString() + 
                        " Henkilötunnuksen tallentaminen ei onnistunut " + DateTime.Now.ToLongDateString() + " klo: " 
                        + DateTime.Now.ToShortTimeString();
                    return HenkTun = false;                     
                }                                               
                else if (tbHetu.Text.Any(Char.IsLetterOrDigit)) 
                {
                     string Hetu = tbHetu.Text.Remove(6, 1); //Muutetaan isoiksi kirjaimiksi - muotoa "000000-222F"
                    Hetu.ToUpper(); // Korvataan henkilötunnuksen väliviiva tyhjällä merkillä - muotoa "000000222F"
                    int Asciiarvo = 55; //Asciiarvoa tarvitsee kun muutetaan yksittäinen kirjain lukuarvoksi.
                    Tarkistusmerkki = Hetu.Substring(9); //Tallennetaan tarkistusmerkki muuttujaan
                    if (Char.IsLetter(char.Parse(Tarkistusmerkki))) // Muutetaan mahdollinen kirjain numeroksi.
                        TunnusLuku = double.Parse(Tarkistusmerkki) - Asciiarvo;
                    string Tarkistus = Hetu + TunnusLuku.ToString();
                    double tarkistusluku = double.Parse(Tarkistus.Remove(0, 4));
                    tarkistusluku *= 31;
                    tarkistusluku = Math.Ceiling(tarkistusluku); //Pyöristetään tarkistuluku ylöspäin.
                    if (tarkistusluku == double.Parse(Tarkistusmerkki))// Verrataan tarkistusmerkkiä alkuperäiseen arvoon.
                        return HenkTun = true;

                    LOKI+= "\n"+ "Käyttäjä: " + Environment.UserName.ToString() + " Henkilötunnuksen tarkistus onnistui. " 
                        + DateTime.Now.ToLongDateString()+" klo: "+DateTime.Now.ToShortTimeString();
                    epVirhe.SetError(tbHetu, "");
                }
                return HenkTun = false;
            }
            catch (Exception)
            {
                tslblStatus.Text = errorMSG;
                
            }
            errorMSG = "";
            return HenkTun = true;
            
        }
        //Tallennetaan tiedot tiedostoon (etunimi sukunimi.json)
        public void TallennaTiedostoon()
        {
            string json = JsonConvert.SerializeObject(lista);
            using (FileStream fs = File.Create(tiedosto))
            {
                fs.Close();
                using (StreamWriter sw = new StreamWriter(tiedosto))
                {
                    sw.WriteLine(json);
                    sw.Close();
                }
            }
            tslblStatus.Text = "Tiedot tallennettu tiedostoon!";
            LOKI += "\n"+ "Käyttäjä: " + Environment.UserName.ToString() + " Tallensi tiedot tiedostoon Henkilötiedot.json : " + DateTime.Now.ToShortDateString() +
                " klo: " + DateTime.Now.ToShortTimeString();
        }
        public void HaeTiedostosta()
        {
            
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\temp\\";
                ofd.Filter = "json files (*.json)|*.json";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog()==DialogResult.OK)
                {
                     filepath = ofd.FileName;
                    tslblStatus.Text = "Tiedosto on olemassa!";
                }


            }
            if (File.Exists(filepath))
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    string json = sr.ReadToEnd();
                    lista = JsonConvert.DeserializeObject<BindingList<Henkilo>>(json);
                }
                dgTiedot.DataSource = lista;
                tslblStatus.Text += " Tietojen haku onnistui!";
            }
            else
                tslblStatus.Text += " Tiedostoa ei löytynyt";
            LOKI += "\n"+ "Käyttäjä: " + Environment.UserName.ToString() + " Haki tiedoston Henkilotiedot.json kansiosta \\temp: " + DateTime.Now.ToShortDateString() +
                " klo: " + DateTime.Now.ToShortTimeString();
        }
        public void TiedotDataGrid()
        {
            Henkilo h;
            h.etunimet = tbEtunimet.Text;
            h.sukunimi = tbSukunimi.Text;
            h.kutsumanimi = tbKutsumanimi.Text;
            h.henkilotunnus = tbHetu.Text;
            h.kotiosoite = tbKotiOsoite.Text;
            h.postinumero = tbPostinum.Text;
            h.postitoimipaikka = tbPostitmp.Text;
            h.alkamispaiva = dtpAlkamispv.Value.ToShortDateString();
            if (rbVoimassaOleva.Checked == true)
                h.paattymispaiva = "Toimisuhde on toistaiseksi voimassa";
            else
                h.paattymispaiva = dtpPaattymispv.Value.ToShortDateString();

            h.nimike = tbNimike.Text;
            h.yksikko = tbYksikko.Text;
            lista.Add(h);
            dgTiedot.DataSource = null;
            lista.AllowEdit = true;
            dgTiedot.DataSource = lista;
            LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Lisäsi henkilötiedon Datagridiin: " + DateTime.Now.ToShortDateString() +
                " klo: " + DateTime.Now.ToShortTimeString();
        }
        
        //Validoidaan tekstiboxin sisältö ja tarpeen mukaan korjautetaan.
        private void tbEtunimet_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (string.IsNullOrEmpty(tb.Text))
            {
                epVirhe.SetError(tb, "Tiedot puuttuvat!");
                e.Cancel = true; 
                return;
            }
        }
        //Jos tiedot ovat validit, nollataan errorprovider (epVirhe).
        private void tbEtunimet_Validated(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            epVirhe.SetError(tb, "");
            LOKI+="\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Tekstikentän "+tb.Name.Substring(2).ToString()+
                " kenttä validoitu onnistuneesti. "+ DateTime.Now.ToShortDateString() +" klo: " 
                + DateTime.Now.ToShortTimeString();
        }
        //Muuttaa Postitoimipaikan automaattisesti kahden luvun avulla.
        private void MuutaPostitmp()
        {
            string[] Helsinki = new string[] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" };
            string[] Hameenlinna = new string[] { "11", "12", "13", "14"};
            string[] Lahti = new string[] { "15", "16", "17", "18", "19" };
            //jne. jne.
            string[] Kuopio = new string[] { "70", "71", "72", "73", "74", "75"};
            if (tbPostinum.TextLength >=2)
            {
                foreach (var luku in Helsinki)
                {
                    if (tbPostinum.Text.Equals(luku))
                    {
                        tbPostitmp.Text = "Helsinki";
                    } 
                }
                foreach (var luku in Hameenlinna)
                {
                    if (tbPostinum.Text.Equals(luku))
                    {
                        tbPostitmp.Text = "Hämeenlinna";
                    }
                }
                foreach (var luku in Lahti)
                {
                    if (tbPostinum.Text.Equals(luku))
                    {
                        tbPostitmp.Text = "Lahti";
                    }
                }
                foreach (var luku in Kuopio)
                {
                    if (tbPostinum.Text.Equals(luku))
                    {
                        tbPostitmp.Text = "Kuopio";
                    }
                }

            }
            else
                tbPostitmp.Text = "";
        }
        //Tyhjentää tekstikentät.
        private void ClearTB()
        {
            tbEtunimet.Text="";
            tbSukunimi.Text = "";
            tbKutsumanimi.Text = ""; 
            tbKotiOsoite.Text = "";
            tbHetu.Text = "";
            tbPostinum.Text = "";
            tbPostitmp.Text = "";
            dtpAlkamispv.Value = DateTime.Today;
            dtpPaattymispv.Value= DateTime.Today;
            rbVoimassaOleva.Checked = false;
            tbNimike.Text = "";
            tbYksikko.Text = "";
            tslblStatus.Text = "";

            LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Tyhjensi tekstikentät. " + DateTime.Now.ToShortDateString() +
                " klo: " + DateTime.Now.ToShortTimeString();
        }
        //Tutkii tekstikentän tekstin vaihtumista ja toteuttaa sen mukaan funktion.
        private void tbPostinum_TextChanged(object sender, EventArgs e)
        {
            MuutaPostitmp();
        }
        // Hae-napin funktiot tänne.
        private void tsbEtsi_Click(object sender, EventArgs e)
        {
            HaeTiedostosta();
            
        }
        //Asetetaan formin sulkunappi aktiiviseksi vaikka se on estetty ylhäällä olevassa funktiossa.
        //Tallennetaan Lokitiedot tekstitiedostoon.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            using (StreamWriter sw = new StreamWriter("c:\\temp\\LokiTiedot.txt"))
            {
                sw.WriteLine(LOKI);
            }
        }
        //Disabloidaan radiobtutton, jos päivämäärä on vaihdettu.
        private void dtpPaattymispv_ValueChanged(object sender, EventArgs e)
        {
            rbVoimassaOleva.Checked = false;
        }
        //Lisätään tiedot DataGridiin ja tyhjennetään tekstikentät.
        private void btnLisaa_Click_1(object sender, EventArgs e)
        {
            TiedotDataGrid(); 
            ClearTB();
            LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Painoi Lisää-nappia. " + DateTime.Now.ToShortDateString() +
                " klo: " + DateTime.Now.ToShortTimeString();
        }
        //Nappi, joka tallentaa kenttiin syötetyt tiedot Henkilotiedot.json-tiedostoon.
        //Tyhjentää DataGridView:n.
        private void btnTallenna_Click(object sender, EventArgs e)
        {
            TallennaTiedostoon();
            dgTiedot.DataSource = null;
            ClearTB();
            LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Painoi Tallenna-nappia. " + DateTime.Now.ToShortDateString() +
                " klo: " + DateTime.Now.ToShortTimeString();
        }
        //Ylävalikossa oleva poista-nappi.
        private void tsbtnPoista_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "c:\\temp\\";
                ofd.Filter = "json files (*.json)|*.json";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filepath = ofd.FileName;
                    DialogResult result = MessageBox.Show("Oletko varma että haluat poistaa tiedoston?", "Poista tiedosto" + ofd.FileName, MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        File.Delete(filepath);
                        tslblStatus.Text = "Tiedosto on poistettu pysyvästi.";
                    }

                }


            }
            LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Painoi Poista-nappia. " + DateTime.Now.ToShortDateString() +
                " klo: " + DateTime.Now.ToShortTimeString();

        }
        //ylävalikossa oleva refresh-nappi.
        private void tsbtnPaivita_Click(object sender, EventArgs e)
        {
            ClearTB();
            dgTiedot.DataSource = null;
            LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Painoi Päivitä-nappia. " + DateTime.Now.ToShortDateString() +
                " klo: " + DateTime.Now.ToShortTimeString();
        }
        //Tapahtuu kun poistutaan tekstikentästä. Asetettu melkein jokaiseen tekstikenttään.
        private void tbEtunimet_Leave(object sender, EventArgs e)
        {
            
            TextBox tb = (TextBox)sender;
            LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Kirjoitti tekstikenttään. " +tb.Name.Substring(2).ToString()+
                DateTime.Now.ToShortDateString() +" klo: " + DateTime.Now.ToShortTimeString();
        }
        //Formin sisällä oleva Poista rivi-nappi.
        private void btnPoista_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow rw in dgTiedot.SelectedRows)
                {
                    dgTiedot.Rows.RemoveAt(rw.Index);
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Valitse kaikki poistettavat rivit ennen Poista rivi-napin painallusta.", "Virhe!");
            }
        }
        //Tapahtuu kun DataGridView:n kolumnin 
        private void dgTiedot_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            DataGridViewColumn column = dgTiedot.Columns[e.ColumnIndex];
            if (column.Name == "Kutsumanimi")
            {
                var sortedKutsuma = new BindingList<Henkilo>(lista.OrderBy(a => a.kutsumanimi).ToList());
                dgTiedot.DataSource = sortedKutsuma;
                LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Painoi otsikkoa Kutsumanimi DataGridissä. " +
                    DateTime.Now.ToShortDateString() + " klo: " + DateTime.Now.ToShortTimeString();
            }
            if (column.Name == "Sukunimi")
            {
                var sortedKutsuma = new BindingList<Henkilo>(lista.OrderBy(a => a.sukunimi).ToList());
                dgTiedot.DataSource = sortedKutsuma;
                LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Painoi otsikkoa Sukunimi DataGridissä. " +
                    DateTime.Now.ToShortDateString() + " klo: " + DateTime.Now.ToShortTimeString();
            }
            if (column.Name == "Nimike")
            {
                var sortedKutsuma = new BindingList<Henkilo>(lista.OrderBy(a => a.nimike).ToList());
                dgTiedot.DataSource = sortedKutsuma;
                LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Painoi otsikkoa Nimike DataGridissä. " +
                    DateTime.Now.ToShortDateString() + " klo: " + DateTime.Now.ToShortTimeString();
            }


        }
        //Henkilötunnuksen tarkistaminen kun poistutaan Henkilötunnus-tekstiboxista.
        private void tbHetu_Leave(object sender, EventArgs e)
        {
            TarkistaHetu();
            if (HenkTun == false)
                epVirhe.SetError(tbHetu, errorMSG);
        }
        //Siirretään solua klikkaamalla sen rivin tiedot tekstikenttiin muokattavaksi.
        private void dgTiedot_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                DataGridViewRow rw = this.dgTiedot.Rows[e.RowIndex];
                tbEtunimet.Text = rw.Cells[0].Value.ToString();
                tbSukunimi.Text = rw.Cells[1].Value.ToString();
                tbKutsumanimi.Text = rw.Cells[2].Value.ToString();
                tbHetu.Text = rw.Cells[3].Value.ToString();
                tbKotiOsoite.Text = rw.Cells[4].Value.ToString();
                tbPostinum.Text = rw.Cells[5].Value.ToString();
                tbPostitmp.Text = rw.Cells[6].Value.ToString();
                dtpAlkamispv.Value = DateTime.Parse(rw.Cells[7].Value.ToString());
                if (rw.Cells[8].Value.ToString() == "Toimisuhde on toistaiseksi voimassa")
                {
                    dtpPaattymispv.Value = DateTime.Now;
                    rbVoimassaOleva.Checked = true;
                }
                else
                {
                    dtpPaattymispv.Value = DateTime.Parse(rw.Cells[8].Value.ToString());
                    rbVoimassaOleva.Checked = false;
                }
                tbNimike.Text = rw.Cells[9].Value.ToString();
                tbYksikko.Text = rw.Cells[10].Value.ToString();
            }
            LOKI += "\n" + "Käyttäjä: " + Environment.UserName.ToString() + " Klikkasi solua ja siirsi tiedot tekstikenttiin. " +
                    DateTime.Now.ToShortDateString() + " klo: " + DateTime.Now.ToShortTimeString();
        }
    }
}
