using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar um produto com 5 unidades em stock inicial
            ProdutoLoja produto = new ProdutoLoja("Portátil Asus", 799.99, 5);

            Console.WriteLine($"--- Produto Inicial: {produto.Nome} ---");
            Console.WriteLine($"Preço Unitário: {produto.Preco}€");
            Console.WriteLine($"Stock Disponível: {produto.QuantidadeEstoque}\n");

            // --- TESTE 1: Venda Bem-Sucedida (Pedir 2 unidades, havendo 5) ---
            Console.WriteLine(">>> Teste 1: Tentando vender 2 unidades...");
            int quantidadeVenda1 = 2;
            double resultado1 = produto.VenderProduto(quantidadeVenda1);

            if (resultado1 > 0.0)
            {
                Console.WriteLine($"SUCESSO! Venda realizada.");
                Console.WriteLine($"Total pago por {quantidadeVenda1} unidades: {resultado1}€");
                Console.WriteLine($"Stock restante: {produto.QuantidadeEstoque}\n");
            }
            else
            {
                Console.WriteLine("FALHA: Não foi possível realizar a venda.\n");
            }

            // --- TESTE 2: Falha por falta de Stock (Tentando vender 4 unidades, restando apenas 3) ---
            Console.WriteLine(">>> Teste 2: Tentando vender 4 unidades...");
            int quantidadeVenda2 = 4;
            double resultado2 = produto.VenderProduto(quantidadeVenda2);

            if (resultado2 > 0.0)
            {
                Console.WriteLine($"SUCESSO! Venda realizada.");
                Console.WriteLine($"Total pago: {resultado2}€\n");
            }
            else
            {
                Console.WriteLine("FALHA: Stock insuficiente para concluir a venda!");
                Console.WriteLine($"Stock atual em armazém: {produto.QuantidadeEstoque}\n");
            }

            // Opcional: Testar o método de adicionar stock novamente
            produto.AdicionarEstoque(10);

            // Mantém a consola aberta para ver os resultados
            Console.WriteLine("\nPressione qualquer tecla para terminar...");
            Console.ReadKey();
        }
    }
}
