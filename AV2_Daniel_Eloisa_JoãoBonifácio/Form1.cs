using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AV2_Daniel_Eloisa_JoãoBonifácio
{
    public partial class Form1 : Form
    {
        public int Dano;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ataque = (int) numericUpDown1.Value;

            if(comboBox1.Text == "Eletricidade" && comboBox2.Text == "Fogo")
            {
                 ataque = 2 * ataque;
            }

            if(comboBox1.Text == "Fogo" && comboBox2.Text == "Gelo")
            {
                ataque = 2 * ataque;
            }

            if(comboBox1.Text == "Gelo" && comboBox2.Text == "Eletricidade")
            {
                ataque = 2 * ataque;
            }

            int defesa = (int) numericUpDown2.Value;

            if (comboBox1.Text == "Fogo" && comboBox2.Text == "Eletricidade")
            {
                defesa = 2 * defesa;
            }
            if (comboBox1.Text == "Gelo" && comboBox2.Text == "Fogo")
            {
                defesa = 2 * defesa;
            }
            if (comboBox1.Text == "Eletricidade" && comboBox2.Text == "Gelo")
            {
                defesa = 2 * defesa;
            }



            Dano = ataque - defesa;

            if(ataque < defesa)
            {
                Dano = 0;
            }

            label1.Text = Dano.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
                   
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
