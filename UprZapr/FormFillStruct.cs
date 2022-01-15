using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UprZapr
{
    public partial class FormFillStruct : Form
    {
        public FormFillStruct(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        public string getValue()
        {
            return textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                this.DialogResult = DialogResult.OK;
            } 
        }
    }
}
