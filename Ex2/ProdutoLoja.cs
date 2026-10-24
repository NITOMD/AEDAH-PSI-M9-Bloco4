using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class ProdutoLoja
    {
       
            // Atributos (Propriedades)
            public string Nome { get; set; }
            public double Preco { get; set; }
            public int QuantidadeEstoque { get; set; }

            // Construtor para inicializar o produto
            public ProdutoLoja(string nome, double preco, int quantidadeEstoque)
            {
                Nome = nome;
                Preco = preco;
                QuantidadeEstoque = quantidadeEstoque;
            }

            // Requisito 1: Método para aumentar a quantidade em armazém
            public void AdicionarEstoque(int qtd)
            {
                if (qtd > 0)
                {
                    QuantidadeEstoque += qtd;
                    Console.WriteLine($"[STOCK] Adicionadas {qtd} unidades de '{Nome}'. Novo stock: {QuantidadeEstoque}.");
                }
            }

            // Requisito 2: Método com retorno que verifica stock, subtrai e devolve o preço total
            public double VenderProduto(int qtd)
            {
                if (qtd <= QuantidadeEstoque)
                {
                    QuantidadeEstoque -= qtd; // Subtrai do stock
                    double precoTotal = qtd * Preco; // Calcula o total a pagar
                    return precoTotal;
                }
                else
                {
                    // Se não houver stock suficiente
                    return 0.0;
                }
            }
        }
    }
