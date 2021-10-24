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
    public partial class Abgeschlossene_Animes : Form
    {
        List<string> AnimeList;
        
        List<DateTime> AnimeDate;
       
        int x=-1;

        public Abgeschlossene_Animes(string wer)
        {
            StreamReader ListeLesen;
            AnimeList = new List<string>();
           
            AnimeDate = new List<DateTime>();
           

            InitializeComponent();

            try
            {
                ListeLesen = new StreamReader(wer + "_abgeschlossene Animes.csv");
                while (!ListeLesen.EndOfStream)
                {
                    string s = ListeLesen.ReadLine();
                    // listBox1.Items.Add(s);
                    string[] eintrag = s.Split(new char[] { ';' });
                    AnimeList.Add(eintrag[0]);
                    listBox1.Items.Add(eintrag[0]);
                    
                    AnimeDate.Add(Convert.ToDateTime(eintrag[1]));
                    

                }
                ListeLesen.Close();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            x = listBox1.SelectedIndex;
            if (x >= 0)
            {
                label1.Text =  "abgeschlossen am " + AnimeDate[x].ToShortDateString();
            }
            else label1.Text = "";
        }
    }
}
