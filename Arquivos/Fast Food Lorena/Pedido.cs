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
        private double valor;
        public double Valor
        {
            get { return valor; }
            set
            {
                if (value <= 0) return;
                else valor = value;
            }
        }
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