using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
          
            Sumap sum = new Sumap();
            sum.num1 = int.Parse(txt1.Text);
            sum.num2 = int.Parse(txt2.Text);

            txt3.Text = sum.suma().ToString();
        }

        private void btnrestar_Click(object sender, EventArgs e)
        {
            Restap rest = new Restap();
            rest.num1 = int.Parse(txt1.Text);
            rest.num2 = int.Parse(txt2.Text);

            txt3.Text = rest.resta().ToString();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            MultiP mcion = new MultiP();
            mcion.num1 = int.Parse(txt1.Text);
            mcion.num2 = int.Parse(txt2.Text);

            txt3.Text = mcion.multi().ToString();
        }

        private void btndivi_Click(object sender, EventArgs e)
        {
            Divip Dcion = new Divip();
            Dcion.num1 = int.Parse(txt1.Text);
            Dcion.num2 = int.Parse(txt2.Text);

            txt3.Text = Dcion.division().ToString();
        }
    }
    }

