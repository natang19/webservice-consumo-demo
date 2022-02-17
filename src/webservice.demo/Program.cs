// See https://aka.ms/new-console-template for more information
using soap.demo;

var soapCliente = new SOAPDemoSoapClient();
int numero1;
int numero2;

Console.WriteLine("Consumindo o serviço soap que soma 2 números inteiros...\n");

Console.Write("Digite o primeiro número: ");
int.TryParse(Console.ReadLine(), out numero1);

Console.Write("Digite o segundo número: ");
int.TryParse(Console.ReadLine(), out numero2);

var resultadoSoma = await soapCliente.AddIntegerAsync(numero1, numero2);

Console.Write("Resultado da soma: " + resultadoSoma);

Console.WriteLine("\n\n");

Console.WriteLine("Consumindo o serviço soap que divide 2 números inteiros...\n");

Console.Write("Digite o primeiro número: ");
int.TryParse(Console.ReadLine(), out numero1);

Console.Write("Digite o segundo número: ");
int.TryParse(Console.ReadLine(), out numero2);

var resultadoDivisao = await soapCliente.DivideIntegerAsync(numero1, numero2);

Console.Write("Resultado da divisão: " + resultadoDivisao);

Console.WriteLine("\n\n");

Console.WriteLine("Consumindo o serviço soap que pesquisa pessoas do nome informado...\n");

Console.Write("Digite o nome a ser buscado: ");
var nome = Console.ReadLine();

var resultadoBusca = await soapCliente.GetListByNameAsync(nome);

if (resultadoBusca is not null)
{
    Console.Write("\nNomes encontrados\n");

    foreach (var pessoa in resultadoBusca)
    {
        Console.Write($"{pessoa.Name}\n");
    }
}
else
{
    Console.Write("Não foram encontrado pessoas com o nome informado\n");
}