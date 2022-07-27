using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DERSDEVAM
{
    public partial class PDF : Form
    {
        public PDF()
        {
            InitializeComponent();
        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void PDF_Load(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "PDF|*.pdf";
            if(of.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.LoadFile(of.FileName);
            }
        }
    }
}
