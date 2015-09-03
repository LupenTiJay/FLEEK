using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Fleek : Form
    {
        public String gameTitle;
        public String gameType;
        public String location;
        public String description;
        public int playersRequired;
        public int numberOfPlayers;
        public Fleek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Enabled = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Fleek_Load(object sender, EventArgs e)
        {

        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            playersRequired = int.Parse(tb.Text);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            gameTitle = tb.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            gameType = tb.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            location = tb.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            numberOfPlayers = int.Parse(tb.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            description = rtb.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
