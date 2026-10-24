using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Veiculo
    {
        // Propriedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public bool Novo { get; set; }

        // Construtor completo
        public Veiculo(string marca, string modelo, int ano, string cor, bool novo)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
            Novo = novo;
        }

        // Método para calcular a idade
        public int CalcularIdade()
        {
            int anoAtual = DateTime.Now.Year;
            return anoAtual - Ano;
        }

        // Método para exibir dados formatados (idêntico à imagem enviada)
        public string ExibirDados()
        {
            string estado;
            string idade;

            // Verificar se o veículo é novo
            if (Novo == true)
            {
                estado = "Novo";
                idade = "0 anos";
            }
            else
            {
                estado = "Usado";
                idade = $"{CalcularIdade()} anos";
            }

            // Criar o texto final formatado
            string texto = "";
            texto += $"Marca: {Marca}\n";
            texto += $"Modelo: {Modelo}\n";
            texto += $"Ano: {Ano}\n";
            texto += $"Cor: {Cor}\n";
            texto += $"Estado: {estado}\n";
            texto += $"Idade do Veículo: {idade}";

            return texto;
        }
    }
}
