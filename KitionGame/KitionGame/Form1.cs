using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitionGame
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            Label barco1 = new Label();
            barco1.Text = "lol";
            barco1.Text = A1.Tag.ToString();
            barco1.Tag = A1;
            Label teste = new Label();
            teste = (Label)barco1.Tag;
            richTextBox1.Text = teste.Text; 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
