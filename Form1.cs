using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2NET2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEnterData.Enabled = true; 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResult;
            dlgResult = MessageBox.Show(
                "Do you want to exit?",
                "Quit",
                MessageBoxButtons.YesNo);
            if (dlgResult == DialogResult.No)
            { e.Cancel = true; }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Form2 frmbrowse = new Form2();
            frmbrowse.ShowDialog();
        }

        private void btnEnterData_Click(object sender, EventArgs e)
        {
            Form3 frmbrowse = new Form3();
            frmbrowse.ShowDialog();

        }
    }
}
