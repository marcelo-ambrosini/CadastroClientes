/*
 * Aula 01 - C# WebaDeveloper COTI Informática
 * Data: 25/06/26
 */

using CadastroClientes.Entidades;
using System.Threading.Channels;

Console.WriteLine("\n*** CADASTRO DE CLIENTE ***\n");
Console.WriteLine("Entre com os dados do cleinete:");

//Crindo um abjeto para a classe Cliente 
var Cliente = new Clliente();

//Prenchendo os dados do cliente
Console.Write("INFORME O NOME DO CLIENTE....:");
Cliente.Nome = Console.ReadLine();

Console.Write("INFORME O CPF.........");
Cliente.Cpf = Console.ReadLine();

Console.Write("INFORME O TELEFONE........");
Cliente.Telefone = Console.ReadLine();

Console.Write("INFORME O EMAIL.........");
Cliente.Email = Console.ReadLine();

Console.Write("IMFORME A DATA DE NASCIMENYO:");
Cliente.DataNacimento = DateOnly.Parse(Console.ReadLine());

//Imprimindo os dados 
Console.WriteLine("\nDADOS DO CLIENTE:");
Console.WriteLine("\tID..............:" + Cliente.Id);
Console.WriteLine("\tNOME.............:" + Cliente.Nome);
Console.WriteLine("\tCPF...............:" + Cliente.Cpf);
Console.WriteLine("\tTELEFONE...........:" + Cliente.Telefone);
Console.WriteLine("\tEMAIL................:" + Cliente.Email);
Console.WriteLine("\tDATA NASCIMENTO .........." + Cliente.DataNacimento);
Console.WriteLine("\tCADASTRO EM ...." + Cliente.DataHoraCadastro);

//salvar os dados no aequivo
Cliente.Salvardadosa();


Console.WriteLine();
