using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Animes_mit_David_2
{
    public partial class Form1 : Form
    {
        StreamWriter ListeSchreiben, NameSchreiben, ChronikSchreiben;
        StreamReader ListeLesen, NameLesen, ChronikLesen;
        List<string> AnimeList, AnimeLink, Chronik;
        List<int> AnimeFolge;
        List<DateTime> AnimeDate;
        List<int> AnimeEpAnz;
        bool changed = false;
        DialogResult result;
        int x;
        string wer = "";
        int heutegeschaut = 0;
        Random cGen;

        public Form1()
        {
            InitializeComponent();
            AnimeList = new List<string>();
            AnimeFolge = new List<int>();
            AnimeDate = new List<DateTime>();
            AnimeLink = new List<string>();
            AnimeEpAnz = new List<int>();
            Chronik = new List<string>();
            cGen = new Random();

            try
            {
                NameLesen = new StreamReader("Name.txt");

                wer = NameLesen.ReadLine();

                NameLesen.Close();
            }
            catch
            {
                wer = "unbekannt";
            }


            label2.Text = "Animes mit " + wer;

            ListeAbrufen();
            zuletztGeschaut();


        }


        private void button7_Click(object sender, EventArgs e)
        {
            //zufall

            int n = cGen.Next(0, AnimeList.Count);
            listBox1.SelectedIndex = n;

            DialogResult dialogResult = MessageBox.Show(AnimeList[n] + Environment.NewLine + "schauen ?", "Zufälliger Anime", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AnimeSchauen();
            }


        }


        private void zuletztGeschaut()
        {
            lbZuletzt.Text = "";
            if (Chronik.Count > 0)
            {
                int z = Chronik.Count - 1;
                int eint = 0;

                while (z >= 0 && eint < 5)
                {
                    lbZuletzt.Text += Chronik[z] + Environment.NewLine;
                    z--;
                    eint++;
                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelAktualisieren();
        }

        private void labelAktualisieren()
        {
            x = listBox1.SelectedIndex;
            if (x >= 0)
            {
                label1.Text = "nächste Folge " + AnimeFolge[x].ToString() + " / " + EpAnz() + Environment.NewLine
                    + "zuletzt geschaut am " + AnimeDate[x].ToShortDateString();

                //  lbZuletzt
            }
            else label1.Text = "";

            label3.Text = "Heute geschaut: " + heutegeschaut + " Folgen";


        }

        private string EpAnz()
        {
            if (AnimeEpAnz[x] != 0) return AnimeEpAnz[x].ToString();
            else return "?";
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            AnimeSchauen();
        }

        private void AnimeSchauen()
        {
            AnimeDate[x] = DateTime.Now;
            if (AnimeLink[x] != "Link einfügen")

            {
                if (AnimeLink[x].Contains("http"))
                {
                    string[] link = AnimeLink[x].Split(new char[] { 'ü' });

                    System.Diagnostics.Process.Start(link[0] + AnimeFolge[x].ToString() + link[1]);
                }
                //else if (AnimeLink.Contains("@"))

                //{
                //    System.Diagnostics.Process.Start(@"D:\\Darelle\\nice to have\\videos\\anwalts-spiel amv.mov");
                //    AnimeFolge[x] = AnimeFolge[x] - 1;
                //}
            }
            else 
            { 
                MessageBox.Show("Die Episodennummer wird aktualisiert."
                + Environment.NewLine + "Es ist kein Link hinterlegt.");
            }

            AnimeFolge[x] = AnimeFolge[x] + 1;

            heutegeschaut++;
            labelAktualisieren();

        
           
            //http


            string zul = AnimeList[x];
            while (zul.Length < 20) zul += " ";
            Chronik.Add(zul + " " + DateTime.Today.ToShortDateString() + "    " + DateTime.Now.ToShortTimeString());
           


            zuletztGeschaut();


            changed = true;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            AddAnime addAnime = new AddAnime();
            addAnime.ShowDialog();
            if (addAnime.getAdd())
            {
                AnimeList.Add(addAnime.getAnimeName());
                AnimeFolge.Add(addAnime.getFolge());
                AnimeDate.Add(DateTime.Today);
                AnimeLink.Add(addAnime.getAnimeLink());
                AnimeEpAnz.Add(addAnime.getTotalEpisodes());
                listBox1.Items.Add(addAnime.getAnimeName());
                changed = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int y = listBox1.SelectedIndex;

            try
            {
                ListeSchreiben = new StreamWriter(wer + "_abgeschlossene Animes.csv", true);


                string nextAn = AnimeList[y] + ";" + DateTime.Today.ToShortDateString();
                ListeSchreiben.WriteLine(nextAn);

                ListeSchreiben.Close();
                AnimeList.RemoveAt(y);
                AnimeFolge.RemoveAt(y);
                AnimeDate.RemoveAt(y);
                AnimeLink.RemoveAt(y);
                listBox1.Items.Remove(listBox1.SelectedItem);

                changed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            speichern();
        }
        private void speichern()
        {
            try
            {
                ListeSchreiben = new StreamWriter(wer + "_aktuelleListe.csv", false);
                foreach (string anime in AnimeList)
                {
                    x = AnimeList.IndexOf(anime);
                    string nextAn = AnimeList[x] + ";" + AnimeFolge[x].ToString() + ";" + AnimeDate[x].ToString() + ";" + AnimeLink[x] + ";" + AnimeEpAnz[x];
                    ListeSchreiben.WriteLine(nextAn);

                }

                ListeSchreiben.Close();
                changed = false;
                MessageBox.Show("Speichern erfolgreich");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                ChronikSchreiben = new StreamWriter(wer + "_Chronik.txt", false);
                foreach (string chr in Chronik)
                {
                    ChronikSchreiben.WriteLine(chr);

                }

                ChronikSchreiben.Close();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SpeicherFrage();
        }

      

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SpeicherFrage();
            User user = new User(wer);
            user.ShowDialog();
            if (user.getWer() != "" && user.getWer() != wer)
            {
                wer = user.getWer();
                listBox1.Items.Clear();
                AnimeList.Clear();
                AnimeFolge.Clear();
                AnimeDate.Clear();
                AnimeLink.Clear();
                AnimeEpAnz.Clear();
                heutegeschaut = 0;

                try
                {
                    NameSchreiben = new StreamWriter("Name.txt", false);
                    NameSchreiben.Write(wer);
                    NameSchreiben.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                label2.Text = "Animes mit " + wer;

                Chronik.Clear();
                ListeAbrufen();
                zuletztGeschaut();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Abgeschlossene_Animes Chronik = new Abgeschlossene_Animes(wer);
            Chronik.ShowDialog();
        }

        private void ListeAbrufen()
        {
            string s;

            try
            {
                ListeLesen = new StreamReader(wer + "_aktuelleListe.csv");
                while (!ListeLesen.EndOfStream)
                {
                    s = ListeLesen.ReadLine();
                    // listBox1.Items.Add(s);
                    string[] eintrag = s.Split(new char[] { ';' });
                    AnimeList.Add(eintrag[0]);
                    listBox1.Items.Add(eintrag[0]);
                    AnimeFolge.Add(Convert.ToInt32(eintrag[1]));
                    AnimeDate.Add(Convert.ToDateTime(eintrag[2]));
                    AnimeLink.Add(eintrag[3]);
                    if (eintrag.Length == 5) AnimeEpAnz.Add(Convert.ToInt32(eintrag[4]));
                    else AnimeEpAnz.Add(0);
                }
                ListeLesen.Close();
                changed = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                ChronikLesen = new StreamReader(wer + "_Chronik.txt");
                while (!ChronikLesen.EndOfStream)
                {
                    s = ChronikLesen.ReadLine();
                    
                    Chronik.Add(s);
                   
                }
                ChronikLesen.Close();

              
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void SpeicherFrage()
        {
            if (changed)
            {
                result = MessageBox.Show("Liste speichern?", "Speichern", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    speichern();
                }
            }
        }

    }
}
