using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CadastroClientes.Entidades
{
    public class Clliente
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Nome { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        public string Cpf { get; set; } = string.Empty;

        public  DateOnly DataNacimento { get; set; }

        public DateTime DataHoraCadastro { get; set; } = DateTime.Now;

        /// <summary>
        /// Método para salvar do dados do cliente em arquivo TXT local.
        /// </summary>
        public void Salvardadosa()
        {
            try
            {
                //Crindo um arquivo na maquina local do usuario:
                //true -> modo append,ou seja, os registros serão salvo no mesmo arquivo
                var sw = new StreamWriter("c:\\temp\\clientes.txt", true);

                //Escrevendo os dados do cliente no arquivo
                sw.WriteLine(Id);
                sw.WriteLine(Nome);
                sw.WriteLine(Email);
                sw.WriteLine(Telefone);
                sw.WriteLine(Cpf);
                sw.WriteLine(DataNacimento);
                sw.WriteLine(DataHoraCadastro);
                sw.WriteLine("*******");

                //fechando o arquivo
                sw.Close();

                Console.WriteLine("\nDados gravados com ducesso");

            }
            catch(Exception ex)
            {
                Console.WriteLine("\falha ao salvar os dados");
            }

        }
    }
}
