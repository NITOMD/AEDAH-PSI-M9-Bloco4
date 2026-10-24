using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Configuração opcional de cores por código (Recomendações de estilo do enunciado)
        private void ConfigurarEstiloVisual()
        {
            this.Text = "Dados do Veículo";
            this.BackColor = ColorTranslator.FromHtml("#EAF0F5"); // Fundo geral azul-claro

            btnCriarExibir.BackColor = ColorTranslator.FromHtml("#0078D7"); // Botão moderno azul
            btnCriarExibir.ForeColor = Color.White;
            btnCriarExibir.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            lblResultado.BackColor = ColorTranslator.FromHtml("#DDE6EE"); // Fundo cinzento-claro da label
            lblResultado.Font = new Font("Segoe UI", 10);
        }

        private void btnCriarExibir_Click(object sender, EventArgs e)
        {
            // Validação simples para evitar campos vazios ou erros de conversão no Ano
            if (string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtModelo.Text) ||
                !int.TryParse(txtAno.Text, out int anoIns))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string cor = txtCor.Text;
            bool eNovo = chkNovo.Checked;

            // 1. Criar o objeto Veiculo usando o construtor
            Veiculo meuVeiculo = new Veiculo(marca, modelo, anoIns, cor, eNovo);

            // 2. Exibir as informações formatadas na Label
            lblResultado.Text = meuVeiculo.ExibirDados();

            // 3. Mudar a imagem conforme o estado (Certifique-se de adicionar as imagens aos Resources do projeto)
            if (meuVeiculo.Novo)
            {
                // Altere 'carro_novo' para o nome exato da sua imagem nos Resources
                pictureBoxCarro.Image = Properties.Resources.carro_novo;
            }
            else
            {
                // Altere 'carro_usado' para o nome exato da sua imagem nos Resources
                pictureBoxCarro.Image = Properties.Resources.carro_usado;
            }

            // Garante que a imagem se ajusta ao tamanho da PictureBox
            pictureBoxCarro.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
