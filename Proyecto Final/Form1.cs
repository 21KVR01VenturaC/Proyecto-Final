namespace Proyecto_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a;
        double b, c, d,f,g;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void conocerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 14;
            label1.Visible = true;
            label1.Text = "Condensador 1";
            label2.Visible = true;
            label2.Text = "Condensador 2";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            a = 17;
            label1.Visible = true;
            label1.Text = "Velocidad";
            label2.Visible = true;
            label2.Text = "Tiempo";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioDeUnC�rculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 1;
            label1.Visible = true;
            label1.Text = " Perimetro de la circunferencia";
            label2.Visible = false;
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerLaHipotenusaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 2;
            label1.Visible = true;
            label1.Text = "Opuesto";
            label2.Visible = true;
            label2.Text = "Adyacente";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerElOpuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 3;
            label1.Visible = true;
            label1.Text = "Hipotenusa";
            label2.Visible = true;
            label2.Text = "Adyacente";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerElAdyacenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 4;
            label1.Visible = true;
            label1.Text = "Hipotenusa";
            label2.Visible = true;
            label2.Text = "Opuesto";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerAlfaConBetaYGammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 5;
            label1.Visible = true;
            label1.Text = "Beta";
            label2.Visible = true;
            label2.Text = "Gamma";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerBetaConAlfaYGammaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 6;
            label1.Visible = true;
            label1.Text = "Alfa";
            label2.Visible = true;
            label2.Text = "Gamma";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerGammaConAlfaYBe5taToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 7;
            label1.Visible = true;
            label1.Text = "Alfa";
            label2.Visible = true;
            label2.Text = "Beta";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerLaHipotenusaConToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 8;
            label1.Visible = true;
            label1.Text = "Voltaje";
            label2.Visible = true;
            label2.Text = "Resistencia";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerElOpuestoConBetaGammaYElAdyacenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 9;
            label1.Visible = true;
            label1.Text = "Corriente";
            label2.Visible = true;
            label2.Text = "Resistencia";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerElAdyacenteConAlfaGammaYElOpuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 10;
            label1.Visible = true;
            label1.Text = "Corriente";
            label2.Visible = true;
            label2.Text = "Voltaje";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerGammaConAlfaElOpuestoYLaHipotenusaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 11;
            label1.Visible = true;
            label1.Text = "Resistor 1";
            label2.Visible = true;
            label2.Text = "Resistor 2";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerAlfaConGamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 12;
            label1.Visible = true;
            label1.Text = "Resistor 1";
            label2.Visible = true;
            label2.Text = "Resistor 2";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerBetaConGammaLaHipotenusaYElAdyacenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 13;
            label1.Visible = true;
            label1.Text = "Condensador 1";
            label2.Visible = true;
            label2.Text = "Condensador 2";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerLaVelocidadConDistanciaYTiempoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 15;
            label1.Visible = true;
            label1.Text = "Distancia";
            label2.Visible = true;
            label2.Text = "Tiempo";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerElTiempoConDistanciaYLaVelocidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 16;
            label1.Visible = true;
            label1.Text = "Distancia";
            label2.Visible = true;
            label2.Text = "Velocidad";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerElVolumenConDensidadYMasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 18;
            label1.Visible = true;
            label1.Text = "Densidad";
            label2.Visible = true;
            label2.Text = "Masa";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void conocerLaMasaConVolumenYDensidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 19;
            label1.Visible = true;
            label1.Text = "Volumen";
            label2.Visible = true;
            label2.Text = "Densidad";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void m�ltiplosYPrefijosDeUnidadesM�tricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = 20;
            label1.Visible = true;
            label1.Text = "Masa";
            label2.Visible = true;
            label2.Text = "Volumen";
            label3.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = false;
            textBox4.Visible = true;
            button1.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = Convert.ToInt32(textBox1.Text);
            if (a == 1)
            {
                c = (b) / (2 * Math.PI);
                textBox4.Text = "" + c;
            }
            if (a == 2)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = Math.Sqrt((b * b) + (c * c));
                textBox4.Text = "" + d;
            }
            if (a == 3)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = Math.Sqrt((b * b) - (c * c));
                textBox4.Text = "" + d;
            }
            if(a == 4)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = Math.Sqrt((b * b) - (c * c));
                textBox4.Text = "" + d;
            }
            if (a == 5)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = -(b + c) + 180;
                textBox4.Text = "" + d;
            }
            if (a == 6){
                c = Convert.ToInt32(textBox2.Text);
                d = -(b + c) + 180;
                textBox4.Text = "" + d;
            }
            if (a == 7)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = -(b + c) + 180;
                textBox4.Text = "" + d;
            }
            if(a == 8){
                c= Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
            if (a == 9)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b * c;
                textBox4.Text = "" + d;
            }
            if (a == 10)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = c / b;
                textBox4.Text = "" + d;
            }
            if (a == 11)
            {
                c= Convert.ToInt32(textBox2.Text);
                d = b + c;
                textBox4.Text = "" + d;
            }
            if (a == 12){
                c= Convert.ToInt32(textBox2.Text);
                d = 1 / ((1 / b) + (1 / c));
                textBox4.Text = "" + d;
            }
            if (a == 13)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = 1 / ((1 / b) + (1 / c));
                textBox4.Text = "" + d;
            }
            if (a == 14)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b + c;
                textBox4.Text = "" + d;
            }
            if (a == 15)
            {
                c=Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
            if (a == 16)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
            if (a == 17)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b * c;
                textBox4.Text = "" + d;
            }
            if (a == 18)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
            if (a == 19) 
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b * c;
                textBox4.Text = "" + d;
            }
            if (a == 20)
            {
                c = Convert.ToInt32(textBox2.Text);
                d = b / c;
                textBox4.Text = "" + d;
            }
        }
    }
}
