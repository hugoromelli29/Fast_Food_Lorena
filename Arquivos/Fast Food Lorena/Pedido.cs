using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastfood
{
    public class Pedido
    {
        public Cliente Cliente { get; set; }
        public string Codigo { get; set; }
        public double Valor { get; set; }
        public string Itens { get; set; }
        public void ExibirPedido()
        {
            Console.WriteLine("O código do pedido é " + Codigo);
            Console.WriteLine("O nome do cliente é " + Cliente.Nome);
            Console.WriteLine("O endereço do cliente é " + Cliente.Endereco);
            Console.WriteLine("O valor é R$ " + Valor);
            Console.WriteLine("Os itens são " + Itens);
            Console.WriteLine();
            Console.WriteLine("Tecle Enter para continuar...");
        }
        public Pedido(string codigo)
        {
            Codigo = codigo;
        }
    }
}