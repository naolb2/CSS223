using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assgmt3
{
    public partial class main_container : Form
    {
        public main_container()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                active.Close();
            }
            Form1 form = new Form1("ADMIN");
            form.MdiParent = this;
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
