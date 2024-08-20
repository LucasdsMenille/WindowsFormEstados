using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Text = $"Contagem: {todos}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            label12.Text = $"Contagem: {norte}";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            label11.Text = $"Contagem: {nordeste}";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Text = $"Contagem: {centro}";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            label9.Text = $"Contagem: {sudeste}";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = $"Contagem: {sul}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (todos.SelectedItem != null)
            {
                string estadoSelecionado = todos.SelectedItem.ToString();

                foreach (var regiao in estadosPorRegiao)
                {
                    if(!regiao.Value().Contains(estadoSelecionado))
                    {
                        todos.Items.Remove(estadoSelecionado);
                        ObterComboBoxRegiao(regiao.Key).Items.Add(estadoSelecionado);

                    }

                }
            }
        }
    }
}
