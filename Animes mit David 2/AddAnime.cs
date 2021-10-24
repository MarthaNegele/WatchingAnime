using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animes_mit_David_2
{
    public partial class AddAnime : Form
    {
        bool bAdd = false;
        bool ü = false;
        int üCount = 0;

        public AddAnime()
        {
            InitializeComponent();
        }

        private void btAbbr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            üCount = 0;
            if (tbLink.Text == "") tbLink.Text = "Link einfügen";
            
            foreach (char c in tbLink.Text)
            {
                if (c == 'ü')
                {
                    ü = true;
                    üCount = üCount + 1;
                }
            }
            if (ü && üCount == 1 && tbxName.Text != "")
            {
                bAdd = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Angaben entsprechen nicht den Anforderungen!");
            }
        }

        public bool getAdd()
        {
            return bAdd;
        }

        public string getAnimeName()
        {
            return tbxName.Text;
        }

        public string getAnimeLink()
        {
            return tbLink.Text;
        }

        public int getFolge()
        {
            return Convert.ToInt32(nudFolge.Value);
        }

        public int getTotalEpisodes()
        {
            return Convert.ToInt32(nudEpAnz.Value);
        }

        private void nudFolge_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
