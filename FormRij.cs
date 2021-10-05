using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericQueue
{
    public partial class FormRij : Form
    {
        Rij<int> rij = new Rij<int>();
        Rij<string> stringRij = new Rij<string>();  
        Rij<TestClass> testRij = new Rij<TestClass>();
        int Volgnummer { get { _volgnummer++; return _volgnummer; }
                         set { _volgnummer = value; } }
        int _volgnummer = 0;

        public FormRij()
        {
            InitializeComponent();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            rij.InRij(int.Parse(tbInOut.Text));
        }
        private void btOut_Click(object sender, EventArgs e)
        {
            int? result = rij.UitRij();
            tbInOut.Text = result.HasValue ? result.Value.ToString() : "Lege Rij";
        }
        private void btStringIn_Click(object sender, EventArgs e)
        {
            stringRij.InRij(tbInOut.Text);
        }
        private void btStringOut_Click(object sender, EventArgs e)
        {
            tbInOut.Text = stringRij.UitRij();
        }

        private void btTestClassIn_Click(object sender, EventArgs e)
        {
            testRij.InRij(new TestClass(Volgnummer, tbInOut.Text));
        }

        private void btTestOut_Click(object sender, EventArgs e)
        {
            tbInOut.Text = testRij.UitRij().ToString();
        }
    }
}
