using fastfood;

Cliente cliente1 = new();
cliente1.Nome = "Rodrigo Santos";
cliente1.Endereco = "R. Palmares, 175";

Pedido lanche1 = new("001");
lanche1.Cliente = cliente1;
lanche1.Valor = 15.90;
lanche1.Itens = "Cheddar, Bacon, Salada";

Pedido lanche2 = new("002");
lanche2.Cliente = cliente1;
lanche2.Valor = 15.90;
lanche2.Itens = "Ovo, Bacon, Salada";

Begin: Console.WriteLine("Pedidos pendentes: 001 / 002");
Console.WriteLine();
Console.WriteLine("Digite o código do pedido para visualizá-lo: ");
string codigoDigitado = Console.ReadLine();
if (codigoDigitado == "001")
    lanche1.ExibirPedido();
else if (codigoDigitado == "002")
    lanche2.ExibirPedido();
else
{
    Console.WriteLine("Pedido não encontrado.");
    Console.WriteLine("Tecle Enter para continuar...");
}

Console.ReadKey();
Console.WriteLine("Para voltar ao início, tecle [s] e Enter. Para sair, tecle outra letra e Enter...");
char entrada = char.Parse(Console.ReadLine());
if (entrada == 's' || entrada == 'S')
{
    Console.Clear();
    goto Begin;
}
