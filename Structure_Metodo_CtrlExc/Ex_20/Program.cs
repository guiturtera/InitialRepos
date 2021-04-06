using System;
using System.Reflection.Metadata.Ecma335;

namespace Ex_20
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enunciado
            /* 20.	Sistema Acadêmico
            Faça um programa que solicite os seguintes dados de um aluno: nome, telefone, idade, valor da mensalidade. 
            Ao final do programa, exiba os dados cadastrados. 
            Validações: 
            Nome deve ser preenchido, telefone deve ter exatamente 9 dígitos (contando o “-“)
            O primeiro dígito do celular não pode iniciar com 7,8 ou 9
            Idade deve estar entre 0 e 150 
            mensalidade deve ser >= 0.
            */

            // Este exercício é pedido para usar controle de excecoes, métodos e structure.
            // Era possível simplificá-lo usando classes
            #endregion

            DadosAluno aluno1 = new DadosAluno();
            aluno1.nome = CapturaString("Escreva o nome do aluno: ");
            aluno1.telefone = CapturaTelefone("Escreva o telefone do aluno: ");
            aluno1.idade = CapturaIdade("Escreva a idade do aluno: ");
            aluno1.mensalidade = CapturaMensalidade("Escreva a mensalidade do aluno: ");

            Console.WriteLine("Nome aluno: " + aluno1.nome);
            Console.WriteLine("Telefone aluno: " + aluno1.telefone);
            Console.WriteLine("Idade do aluno: " + aluno1.idade);
            Console.WriteLine("Mensalidade do aluno: " + aluno1.mensalidade);


        }

        // Método para a captura de uma string
        static string CapturaString(string texto)
        {
            string captura = "";
            do
            {
                try
                {
                    Console.Write(texto);
                    captura = Console.ReadLine();
                }
                catch
                {
                    Console.WriteLine("Escreva uma informação válida: ");
                }
            } while (captura == "");
            return captura;
        }

        // Método para a captura de um telefone com hífen
        static string CapturaTelefone(string texto)
        {
            string telefone = "";
            do
            {
                try
                {
                    Console.Write(texto);
                    telefone = Console.ReadLine();
                    if ((telefone[0] != '7' || telefone[0] != '8' || telefone[0] != '9') && telefone[4] == '-' && telefone.Length == 9)
                        break;
                }
                catch
                {
                    Console.WriteLine("Escreva o telefone no formato 0000-0000");
                }
            } while (true);

            return telefone;
        }

        // Método para a captura da idade do aluno
        static int CapturaIdade(string texto)
        {
            int idade = 0;
            do
            {
                try
                {
                    Console.Write(texto);
                    idade = int.Parse(Console.ReadLine());
                    if (idade > 0 && idade < 150)
                        break;
                }
                catch
                {
                    Console.WriteLine("Escreva uma idade válida. ");
                }
            } while (true);
            
            return idade;
        }

        // Método para captura da mensalidade do aluno
        static double CapturaMensalidade(string texto)
        {
            double mensalidade = -1;
            do
            {
                try
                {
                    Console.Write(texto);
                    mensalidade = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Escreva um valor válido. ");
                }
            } while (mensalidade >= 0);
        }
    }

    struct DadosAluno
    {
        public string nome, telefone;
        public int idade;
        public double mensalidade;
    }
}
