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
    public partial class User : Form
    {
        StreamWriter ListeSchreiben;
        StreamReader ListeLesen;
        bool bUserExists = false;


        public User(string wer)
        {
            InitializeComponent();

            try
            {
                ListeLesen = new StreamReader("Users.txt");

                while (!ListeLesen.EndOfStream)
                {
                    comboBox1.Items.Add(ListeLesen.ReadLine());
                }

                ListeLesen.Close();
            }
            catch
            {

            }

            textBox1.Text = wer;
            comboBox1.SelectedItem = wer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string s in comboBox1.Items)
            {
                if (s == textBox1.Text) bUserExists = true;
            }
            if (!bUserExists)
            {
                comboBox1.Items.Add(textBox1.Text);

                try
                {
                    ListeSchreiben = new StreamWriter("Users.txt", false);

                    foreach (string s in comboBox1.Items)
                    {
                        ListeSchreiben.WriteLine(s);
                    }
                    ListeSchreiben.Close();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }

        public string getWer()
        {
            
                return textBox1.Text;
            
  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
        }
    }
}
