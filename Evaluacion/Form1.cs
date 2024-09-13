using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] names = new string[25];
        public int count = 0;

        private void tbnames_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbnames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter )
            {
                if (count < 26) {
                    while (tbnames.Text.Trim().Length > 24)
                    {
                        names[count] = tbnames.Text;
                        lbnames.Items.Add(tbnames.Text);
                        count++;
                        tbnames.Clear();
                        tbnames.Focus();
                    }
                }
                
            }
           

        
           
        }
    }
}
