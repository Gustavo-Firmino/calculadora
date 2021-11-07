using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{    
    public partial class frmCalc : Form    
    {
        //variaveis globais (nao crie muitas, pois quando inicia o programa as variaveis sao alocadas na memoria)
        string rcbResult;
        double c = 0, m = 0;
        public frmCalc()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn0.Text;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn1.Text;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn2.Text;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn3.Text;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn4.Text;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn5.Text;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn6.Text;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn7.Text;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn8.Text;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn9.Text;
        }
        //operacoes
        private void btnAdi_Click(object sender, EventArgs e)
        {        
            rcbResult = txtResult.Text;
            m = Convert.ToDouble(rcbResult);//convert para cajo haja operações com decimais
            lblhist.Text = rcbResult + " + ";
            txtResult.Clear();
            c = 1;
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            rcbResult = txtResult.Text;
            m  = Convert.ToDouble(rcbResult);
            lblhist.Text = rcbResult + " - ";
            txtResult.Clear();
            c = 2;
        }
        private void btnMult_Click(object sender, EventArgs e)
        {
            rcbResult = txtResult.Text;
            m = Convert.ToDouble(rcbResult);            
            lblhist.Text = rcbResult + " * ";
            txtResult.Clear();
            c = 3;
        }
        private void btnDivi_Click(object sender, EventArgs e)
        {
            rcbResult = txtResult.Text;
            m = Convert.ToDouble(rcbResult);
            lblhist.Text = rcbResult + " / ";
            txtResult.Clear();
            c = 4; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            double n1 = Convert.ToInt32(m), n2 = Convert.ToInt32(txtResult.Text), result=0;
            switch (c) {
                case 1:
                    result = n1 + n2;
                    break;
                case 2:
                    result = n1 - n2;
                    break;
                case 3:
                    result = n1 * n2;
                    break;
                case 4:
                    result = n1 / n2;
                    break;

            }
                
            lblhist.Text += txtResult.Text;
            txtResult.Text = Convert.ToString(result); 
            lblhist.Text += " = " + Convert.ToString(result);
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";//outra forma de 0:  txtResult.Clear;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            c = 0;// escolha da operação
            m = 0; 
            txtResult.Clear();
            lblhist.Text = "";
            rcbResult= " ";
        }
    }
}