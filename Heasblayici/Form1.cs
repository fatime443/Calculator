using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heasblayici
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double netice = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Rakamolay(object sender, EventArgs e)
        {
            if (txtNetice.Text == "0" || optDurum)
                txtNetice.Clear();
            optDurum = false;

            Button btn = (Button)sender;
            txtNetice.Text += btn.Text;


        }

        private void OptHesab(object sender, EventArgs e)
        {
            optDurum = true;
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;

            lbNetice.Text = lbNetice.Text + "" + txtNetice.Text + "" + yeniOpt;


            switch(opt)
            {
                case "+":txtNetice.Text = (netice + Double.Parse(txtNetice.Text)).ToString();break;
                case "-": txtNetice.Text = (netice - Double.Parse(txtNetice.Text)).ToString(); break;
                case "*": txtNetice.Text = (netice * Double.Parse(txtNetice.Text)).ToString(); break;
                case "/": txtNetice.Text = (netice / Double.Parse(txtNetice.Text)).ToString(); break;
            }
            netice = Double.Parse(txtNetice.Text);
            txtNetice.Text = netice.ToString();
            opt = yeniOpt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtNetice.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNetice.Text = "0";
            lbNetice.Text = "";
            opt = "";
            netice = 0;
            optDurum = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lbNetice.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txtNetice.Text = (netice + Double.Parse(txtNetice.Text)).ToString(); break;
                case "-": txtNetice.Text = (netice - Double.Parse(txtNetice.Text)).ToString(); break;
                case "*": txtNetice.Text = (netice * Double.Parse(txtNetice.Text)).ToString(); break;
                case "/": txtNetice.Text = (netice / Double.Parse(txtNetice.Text)).ToString(); break;
                  
            }
            netice = Double.Parse(txtNetice.Text);
            txtNetice.Text = netice.ToString();
            opt = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
           
            if(txtNetice.Text=="0")
            {
                txtNetice.Text = "0";
            }
            else if(optDurum)
            {
                txtNetice.Text = "0";
            }
            if(txtNetice.Text.Contains(","))
            {
                txtNetice.Text += ",";
            }
            optDurum = false;

        }
    }
}
