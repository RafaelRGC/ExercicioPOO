using POO_Robinson;

Produto produto = new Produto();
produto.Nome = "Camiseta";
produto.Preco = 29.99;
produto.Categoria = "Roupas";
produto.Peso = 0.5;

Cliente cliente = new Cliente();
cliente.Nome = "Rafael";
cliente.Cidade = "Araxá";
cliente.Idade = 24;

Pedido pedido = new Pedido();
pedido.NumeroPedido = 01010010;
pedido.Quantidade = 2;
pedido.DescontoPercentual = 10.0;

Loja loja = new Loja();
loja.nomeloja = "Loja do Rafael";
loja.cidade = "Araxá";
loja.Taxaentrega = 10;

double bruto = produto.Preco * pedido.Quantidade;
double desconto = bruto * (pedido.DescontoPercentual / 100);
double valorFinal = bruto - desconto + loja.Taxaentrega;
double pesototal = produto.Peso * pedido.Quantidade;

if (cliente.Idade < 18)
{
    double descontoextra = valorFinal * 0.05;
    valorFinal -= descontoextra;
}

if (pesototal > 10)
{
    loja.Taxaentrega += 20;
}

Console.WriteLine("Produto: " + produto.Nome);
Console.WriteLine("Cliente: " + cliente.Nome);
Console.WriteLine("Quantidade: " + pedido.Quantidade);

Console.WriteLine("Valor Bruto: R$ " + bruto);
Console.WriteLine("Valor do Desconto: R$ " + desconto);
Console.WriteLine("Valor Final: R$ " + valorFinal);
Console.WriteLine("Peso Total: " + pesototal + " kg");
Console.WriteLine("Taxa de Entrega: R$ " + loja.Taxaentrega);
Console.WriteLine("Valor Total a Pagar: R$ " + (valorFinal + loja.Taxaentrega));
