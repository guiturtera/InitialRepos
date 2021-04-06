using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Diagnostics;

namespace JogoSuperQuizz
{
    class Program
    {
        /// <summary>
        /// Esse struct armazena os dados de cada questão
        /// </summary>
        struct DadosQuestao
        {
            public string pergunta;
            public string tema;
            public string resposta;
            public string alternativa1, alternativa2, alternativa3, alternativa4;
        }

        static void Main(string[] args)
        {
            // Caso o usuário não possua o arquivo .txt com as perguntas 
            // ou esteja errado, o programa irá ser encerrado.
            if (File.Exists("QUIZ.txt") == false)
            {
                Console.WriteLine("Você não possui o arquivo texto do QUIZZ. Por favor, o baixe para jogar! ");
                Environment.Exit(0);
            }
            DadosQuestao[] questao = DevolveDadosQuestao();

            string respostas, gabarito;
            int escolhaMenuInicial, escolhaTema, escolhaQntPerguntas;
            int qntTemas = 1, acertos;
            string[] tema = DevolveTemas(out qntTemas, questao);

            // O jogo irá rodar dentro deste DO-WHILE
            do
            {
                escolhaMenuInicial = LeEscolhaInicial();
                switch (escolhaMenuInicial)
                {
                    case 1:
                        escolhaTema = LeTema(qntTemas, tema);

                        escolhaQntPerguntas = DevolveQntPerguntas(questao, tema, escolhaTema);

                        MostraLobby(escolhaTema, tema);

                        int[] perguntasAleatorias = DevolvePerguntasAleatorias(questao, tema, escolhaTema, escolhaQntPerguntas);

                        gabarito = DevolveGabarito(questao, perguntasAleatorias);
                        respostas = LeRespostasUsuario(questao, perguntasAleatorias);
                        acertos = DevolveNumeroAcertos(respostas, gabarito);

                        MostraRevisao(questao, perguntasAleatorias, acertos, gabarito, respostas);

                        break;
                    
                    case 2:
                        MostraRegras();
                        break;
                    
                    case 3:
                        MostraDadosGrupo();
                        break;
                    
                    case 4:
                        EscreveTextoColorido(ConsoleColor.Green, ConsoleColor.Black, "Obrigado por jogar nosso QUIZ :)\n\n");
                        break;
                }
            } while (escolhaMenuInicial != 4);
            
        }

        /// <summary>
        /// Esse método captura os dados do arquivo texto e o armazena em um vetor de DadosQuestao
        /// </summary>
        /// <returns>Retorna o vetor de DadosQuestao referente ao arquivo QUIZZ.txt</returns>
        static DadosQuestao[] DevolveDadosQuestao()
        {
            string[] texto = File.ReadAllLines("QUIZ.txt");
            int qntLinhas = File.ReadLines("QUIZ.txt").Count();
            if (qntLinhas > 100)
                qntLinhas = 100;
            //Com o intuito de remover colunas em branco remanescentes do final
            foreach (string aux in texto)
            {
                if (aux == "")
                    qntLinhas--;
            }

            DadosQuestao[] questao = new DadosQuestao[qntLinhas];
            try
            {
                for (int i = 0; i < qntLinhas; i++)
                {
                    questao[i].pergunta = texto[i].Split('|')[0].Trim();
                    questao[i].tema = texto[i].Split('|')[1].Trim();
                    questao[i].resposta = texto[i].Split('|')[2].Trim();
                    questao[i].alternativa1 = texto[i].Split('|')[3].Trim();
                    questao[i].alternativa2 = texto[i].Split('|')[4].Trim();
                    questao[i].alternativa3 = texto[i].Split('|')[5].Trim();
                    questao[i].alternativa4 = texto[i].Split('|')[6].Trim();
                }
            }
            catch
            {
                Console.WriteLine("Seu arquivo texto não está nos padrões!! Baixe o certo e tente novamente. ");
                Environment.Exit(0);
            }

            return questao;
        }

        /// <summary>
        /// O método captura a partir do vetor questao,
        /// os temas possíveis, não podendo ultrapassar 
        /// 10 temas diferentes
        /// </summary>
        /// <param name="qntTemas"></param>
        /// <param name="questao"></param>
        /// <returns>Retorna um int de quantidade de temas e um vetor de string com os temas</returns>
        static string[] DevolveTemas(out int qntTemas, DadosQuestao[] questao)
        {
            qntTemas = 1;
            string[] temaStr = new string[10];
            for (int i = 0; i < questao.Length; i++)
            {
                if (qntTemas == 10)
                {
                    Console.WriteLine("Seu arquivo texto excedeu o número de temas possíveis. \n" +
                        "serão apenas mostrados 10 temas diferentes. ");
                    break;
                }
                if (i == 0)
                    temaStr[0] = questao[0].tema.Trim();
                else
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if ((questao[i].tema).ToUpper().Trim() == (questao[j].tema).ToUpper().Trim())
                        {
                            break;
                        }
                        if (j == 0)
                        {
                            temaStr[qntTemas] = (questao[i].tema).Trim();
                            qntTemas++;
                        }
                    }
                }
            }

            return temaStr;
        }

        /// <summary>
        /// Captura um inteiro
        /// </summary>
        /// <returns>Retorna um inteiro escrito pelo usuário.</returns>
        static int LeInteiro()
        {
            int num = -1;
            do
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Write("Escolha uma opção válida: ");
                }
            } while (num == -1);

            return num;
        }

        /// <summary>
        /// Este método captura a quantidade de questões que o usuário quer.
        /// </summary>
        /// <param name="questao"></param>
        /// <param name="temaStr"></param>
        /// <param name="escolhaTema"></param>
        /// <returns>Retorna a quantidade de questões que o usuário quer</returns>
        static int DevolveQntPerguntas(DadosQuestao[] questao, string[] temaStr, int escolhaTema)
        {
            int qntPerguntas = DevolveQntPerguntasTema(questao, temaStr, escolhaTema);
            int escolhaQntPerguntas;
           
            Console.Write("Seu tema é: {0}\n" +
                "Este tema tem {1} perguntas.\n" +
                "Escolha quantas deseja responder: ", temaStr[escolhaTema],qntPerguntas, Console.ForegroundColor = ConsoleColor.DarkBlue);
            Console.ResetColor();
            do
            {
                escolhaQntPerguntas = LeInteiro();
                if (escolhaQntPerguntas <= 0 || escolhaQntPerguntas > qntPerguntas)
                    Console.Write("Escreva um número inteiro entre 1 e {0}", qntPerguntas);

            } while (escolhaQntPerguntas <= 0 || escolhaQntPerguntas > qntPerguntas);

            Console.Clear();

            return escolhaQntPerguntas;
        }

        /// <summary>
        /// Este método escreve um texto, com cored de fundo e da letra especificados
        /// </summary>
        /// <param name="corLetra"></param>
        /// <param name="corFundo"></param>
        /// <param name="texto"></param>
        static void EscreveTextoColorido(ConsoleColor corFundo, ConsoleColor corLetra, string texto)
        {
            Console.BackgroundColor = corFundo;
            Console.ForegroundColor = corLetra;
            Console.Write(texto);
            Console.ResetColor();
        }

        /// <summary>
        /// Este método serve como um menu inicial ao usuário.
        /// </summary>
        /// <returns>Retorna a opção em que o usuário quer fazer.</returns>
        static int LeEscolhaInicial()
        {
            int escolha;
            EscreveTextoColorido(ConsoleColor.Black, ConsoleColor.Red, "Bem Vindo ao QUIZZ CULTURAL FTT!!\n");
            EscreveTextoColorido(ConsoleColor.Black, ConsoleColor.Blue, "Digite:\n1 - Começar\n2 - Regras\n3 - Integrantes do grupo\n4 - Sair\n\n");
            do
            {
                escolha = LeInteiro();
                Console.Write("Escreva uma opção válida: ");
            } while (escolha < 1 || escolha > 4);

            Console.Clear();
            return escolha;
        }

        /// <summary>
        /// Este método retorna as regras do jogo
        /// </summary>
        static void MostraRegras()
        {
            Console.WriteLine("1° Mandamento - Escolher o tema");
            Console.WriteLine("2° Mandamento - Digitar a letra da resposta correspondente");
            Console.WriteLine("3° Mandamento - Para de enrolar e vai jogar!\n");
            Console.WriteLine("Clique em qualquer tecla para continuar. ");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Este método mostra os integrantes do grupo que fez o trabalho
        /// </summary>
        static void MostraDadosGrupo()
        {
            EscreveTextoColorido(ConsoleColor.Black, ConsoleColor.Red, "Nathan Vilela de Souza RA: 081200028\n");
            EscreveTextoColorido(ConsoleColor.Black, ConsoleColor.Red, "Guilherme Dias Lima Turtera RA: 081200007\n\n");
            Console.WriteLine("Clique em qualquer tecla para continuar. ");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Este método recebe a quantidade de temas e seus respectivos temas,
        /// e devolve as opções de temas para o usuário escolher.
        /// </summary>
        /// <param name="qntTemas"></param>
        /// <param name="temas"></param>
        /// <returns>Retorna a escolha do usuário em um inteiro</returns>
        static int LeTema(int qntTemas, string[] temas)
        {
            int escolha;
            Random aleatorio = new Random();
            
            
            EscreveTextoColorido(ConsoleColor.Black, ConsoleColor.Red, "Escolha seu tema:\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < qntTemas; i++)
            {
                Console.WriteLine("{0} - {1}", i + 1, temas[i]);
            }
            Console.WriteLine("{0} - Tema aleatório", qntTemas + 1);
            Console.ResetColor();

            do
            {
                escolha = LeInteiro();
                if (escolha < 1 || escolha > qntTemas + 1) 
                    Console.Write("Escreva uma opção válida: ");
            } while (escolha < 1 || escolha > qntTemas + 1);
            
            if (escolha == qntTemas + 1)
                escolha = aleatorio.Next(1, qntTemas + 1);

            Console.Clear();

            return escolha - 1; // Transforma para a linguagem da máquina (0, como se fosse 1)
        }

        /// <summary>
        /// Este método é um menu de espera para o jogo começar
        /// </summary>
        /// <param name="escolha"></param>
        /// <param name="temas"></param>
        static void MostraLobby(int escolha, string[] temas)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("O seu tema é - {0}", temas[escolha], Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("\nPrepare-se! Seu QUIZ irá começar em " + i + "...", Console.ForegroundColor = ConsoleColor.Yellow);
                Console.ResetColor();

                Console.Beep(1000 - i * 50, 800);
                Console.Clear();

            }
        }

        /// <summary>
        /// Esse método, varre quantas perguntar um determinado tema possui
        /// </summary>
        /// <param name="questao"></param>
        /// <param name="temaStr"></param>
        /// <param name="escolhaTema"></param>
        /// <returns>Quantidade de questões</returns>
        static int DevolveQntPerguntasTema(DadosQuestao[] questao, string[] temaStr, int escolhaTema)
        {
            // Capturando quantas perguntas de um tema o programa possui
            int qntPerguntas = 0;
            for (int i = 0; i < questao.Length; i++)
            {
                if (temaStr[escolhaTema] == questao[i].tema)
                {
                    qntPerguntas++;
                }
            }

            return qntPerguntas;
        }

        /// <summary>
        /// Este método sorteia todas as perguntas do tema escolhido, e retorna a posicao no Struct desses números
        /// </summary>
        /// <param name="questao"></param>
        /// <param name="temaStr"></param>
        /// <param name="escolhaTema"></param>
        /// <param name="escolhaQntPerguntas"></param>
        /// <returns>Vetor inteiro com perguntas do tema escolhido sorteadas</returns>
        static int[] DevolvePerguntasAleatorias(DadosQuestao[] questao, string[] temaStr, int escolhaTema, int escolhaQntPerguntas)
        {
            int qntPerguntas = DevolveQntPerguntasTema(questao, temaStr, escolhaTema);

            // Capturando as posicoes dessas perguntas
            int[] posicaoPergunta = new int[qntPerguntas];
            int cont = 0;
            for (int i = 0; i < questao.Length; i++)
            {
                if (questao[i].tema == temaStr[escolhaTema])
                {
                    posicaoPergunta[cont] = i;
                    cont++;
                }
            }

            // Sorteando os números
            int aux;
            int[] perguntasAleatorias = new int[escolhaQntPerguntas];
            Random numAleatorio = new Random();

            for (int i = 0; i < escolhaQntPerguntas; i++)
            {
                if (i == 0)
                {
                    aux = numAleatorio.Next(0, posicaoPergunta.Length);
                    perguntasAleatorias[i] = posicaoPergunta[aux];
                }
                else
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (j == i - 1)
                        {
                            aux = numAleatorio.Next(0, posicaoPergunta.Length);
                            perguntasAleatorias[i] = posicaoPergunta[aux];
                        }

                        if (perguntasAleatorias[i] == perguntasAleatorias[j])
                        {
                            j = i;
                        }
                    }
                }
            }

            return perguntasAleatorias;
        }

        /// <summary>
        /// Este método captura as respostas certas das perguntas
        /// </summary>
        /// <returns>retorna uma string com as respostas das perguntas</returns>
        static string DevolveGabarito(DadosQuestao[] questao, int[] perguntasAleatorias)
        {
            string gabarito = "";
            foreach (int aux in perguntasAleatorias)
            {
                if (questao[aux].alternativa1 == questao[aux].resposta)
                    gabarito += 'A';
                else if (questao[aux].alternativa2 == questao[aux].resposta)
                    gabarito += 'B';
                else if (questao[aux].alternativa3 == questao[aux].resposta)
                    gabarito += 'C';
                else if (questao[aux].alternativa4 == questao[aux].resposta)
                    gabarito += 'D';
                else
                {
                    Console.WriteLine("Seu arquivo texto não está certo. ");
                    Environment.Exit(0);
                }
            }

            return gabarito;
        }

        /// <summary>
        /// Este método mostra uma pergunta específica ao usuário
        /// </summary>
        /// <param name="questao"></param>
        /// <param name="perguntasAleatorias"></param>
        /// <param name="i"></param>
        static void MostraPerguntas(DadosQuestao[] questao, int[] perguntasAleatorias, int i)
        {
            Console.WriteLine("Pergunta {0}:", i + 1);
            Console.WriteLine(questao[perguntasAleatorias[i]].pergunta + "\n");
            Console.WriteLine("a - " + questao[perguntasAleatorias[i]].alternativa1);
            Console.WriteLine("b - " + questao[perguntasAleatorias[i]].alternativa2);
            Console.WriteLine("c - " + questao[perguntasAleatorias[i]].alternativa3);
            Console.WriteLine("d - " + questao[perguntasAleatorias[i]].alternativa4 + "\n");


        }

        /// <summary>
        /// Este método lê e mostra a alternativa ao usuário
        /// </summary>
        /// <returns>alternativa do usuário</returns>
        static char LeAlternativa()
        {
            
            char alternativa;
            int tempoDecorrido = 0;
            Stopwatch tempo = Stopwatch.StartNew();
            do
            { 
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo digito = (Console.ReadKey(true));
                    if (char.ToUpper(digito.KeyChar) == 'A' || char.ToUpper(digito.KeyChar) == 'B' || char.ToUpper(digito.KeyChar) == 'C'
                        || char.ToUpper(digito.KeyChar) == 'D' || char.ToUpper(digito.KeyChar) == 'E')
                    {
                        alternativa = char.ToUpper(digito.KeyChar);
                        break;
                    }
                    else
                        continue;
                }
                
                Console.Write("Sua resposta é:  ------------->     ");
                tempoDecorrido = Convert.ToInt32(tempo.Elapsed.TotalSeconds);
                EscreveTextoColorido(ConsoleColor.Yellow, ConsoleColor.Red, $"Faltam {50 - tempoDecorrido} segundos");
                if (tempoDecorrido == 50)
                {
                    alternativa = 'N';
                    break;
                }
                Thread.Sleep(1000);
                LimpaLinhaCursor();
            } while (true);

            return alternativa;
        }
        
        /// <summary>
        /// Este método limpa a linha em que o cursor está
        /// </summary>
        static void LimpaLinhaCursor()
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
        
        /// <summary>
        /// Este método lê as respostas do usuário, a partir da das perguntas e da alternativa em que escolheu
        /// </summary>
        /// <param name="questao"></param>
        /// <param name="perguntasAleatorias"></param>
        /// <returns>String com as respostas do usuário</returns>
        static string LeRespostasUsuario(DadosQuestao[] questao, int[] perguntasAleatorias)
        {
            string respostasUsuario = "";
            for (int i = 0; i < perguntasAleatorias.Length; i++)
            {
                MostraPerguntas(questao, perguntasAleatorias, i);
                respostasUsuario += LeAlternativa();                
                Console.Clear();
            }

            return respostasUsuario;
        }

        /// <summary>
        /// Este método bate as respostas do usuário com seu gabarito e conta o numero de acertos
        /// </summary>
        /// <param name="respostas"></param>
        /// <param name="gabarito"></param>
        /// <returns>Retorna um inteiro numeros de acertos do usuario</returns>
        static int DevolveNumeroAcertos(string respostas, string gabarito)
        {
            int nota = 0;
            for (int i = 0; i < respostas.Length; i++)
                if (respostas[i] == gabarito[i])
                    nota++;

            return nota;
        }

        /// <summary>
        /// Mostra as perguntas, comparadas com seu gabarito, 
        /// respostas do usuário e seus acertos
        /// </summary>
        /// <param name="questao"></param>
        /// <param name="perguntasAleatorias"></param>
        /// <param name="acertos"></param>
        /// <param name="gabarito"></param>
        /// <param name="respostas"></param>
        static void MostraRevisao(DadosQuestao[] questao, int[] perguntasAleatorias, int acertos, string gabarito, string respostas)
        {
            for (int i = 0; i < perguntasAleatorias.Length; i++)
            {
                Console.WriteLine("Sua nota foi de: {0}/{1}", acertos, perguntasAleatorias.Length);
                MostraPerguntas(questao, perguntasAleatorias, i);
                EscreveTextoColorido(ConsoleColor.Black, ConsoleColor.Green, "\nResposta certa --> " + char.ToLower(gabarito[i]) + "\n");
                if (respostas[i] == 'N')
                    EscreveTextoColorido(ConsoleColor.Black, ConsoleColor.Red, "Não houve resposta para esta pergunta. \n");
                else
                    EscreveTextoColorido(ConsoleColor.Black, ConsoleColor.Red, "Sua resposta --> " + char.ToLower(respostas[i]) + "\n");

                Console.WriteLine("Pressione qualquer tecla para continuar. ");
                Console.ReadKey();

                Console.Clear();
            }
        }
    }
}
