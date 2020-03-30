using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> RusWords = new Dictionary<string, string>();
        Dictionary<string, string> EnWords = new Dictionary<string, string>();
        Dictionary<string, string> UkWords = new Dictionary<string, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            RusWords.Add("Новичок", "Новичок");
            RusWords.Add("Любитель", "Любитель");
            RusWords.Add("Профи", "Профи");

            EnWords.Add("Новичок", "Newbie");
            EnWords.Add("Любитель", "Amateur");
            EnWords.Add("Профи", "Pro");

            UkWords.Add("Новичок", "Новачок");
            UkWords.Add("Любитель", "Люба");
            UkWords.Add("Профи", "Начальника");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            button1.Text = RusWords["Новичок"];
            button2.Text = RusWords["Любитель"];
            button3.Text = RusWords["Профи"];
         //   label1.Text = RusWords["Выберите язык"];
          //  label2.Text = RusWords["Выберите язык"];
          //  label3.Text = RusWords["Выберите сложность"];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button1.Text = UkWords["Новичок"];
            button2.Text = UkWords["Любитель"];
            button3.Text = UkWords["Профи"];
            label1.Text = UkWords["Viberite yazik"];
            label2.Text = UkWords["Viberite yazik"];
            label3.Text = UkWords["Viberite slojnost"];
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            button1.Text = EnWords["Новичок"];
            button2.Text = EnWords["Любитель"];
            button3.Text = EnWords["Профи"];
          //  label1.Text = EnWords["Viberite yazik"];
          //  label2.Text = EnWords["Viberite yazik"];
           // label3.Text = EnWords["Viberite slojnost"];
        }

        private void label1_Click(object sender, EventArgs e)
        {
          // label1.Text = RusWords["Профи"];
       }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
