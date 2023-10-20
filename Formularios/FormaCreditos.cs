using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz.Formularios
{
    public partial class FormaCreditos : Form
    {
        public FormaCreditos()
        {
            InitializeComponent();
        }

        private void FormaCreditos_Load(object sender, EventArgs e)
        {
            string videorUr2 = "https://drive.google.com/file/d/1OrWcf7qz2UVVJ2OrmLZNePlE9JiREG7I/view?usp=share_link";
            webBrowser1.Navigate(videorUr2);        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
