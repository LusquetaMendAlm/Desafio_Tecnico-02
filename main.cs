using System;
using System.Threading;
class HelloWorld
{
    static void Main()
    {
        while (true)
        {
            string nome = "Garchomp";
            string resposta, resposta2;
            string comprar;
            int potions, preco = 25;
            Console.Write($"Nossa um {nome} normalmente é intimidador e bem imponente, mas o seu parece diferente...\r\n");
            Thread.Sleep(2000);
            Console.WriteLine($"O seu {nome} está machucado(Digite sim ou não)?");
            resposta = Console.ReadLine();
            if (resposta == "sim")
            {
                Console.WriteLine("Você deseja curá-lo(Digite sim ou não)?");
                resposta2 = Console.ReadLine();
                switch (resposta2)
                {
                    case "sim":
                        Console.WriteLine("Ok, o seu pokémon está sendo encarregado para o healer no centro pokémon de kanto.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Um centro pokémon é um base focada especialmente para o cuidado pokémon. \r\nAlém disso, o healer é uma estação em que são colocadas as pokébolas e cura os pokémons dentro delas. ");
                        Console.WriteLine("Espere alguns instantes...");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(".");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine($"Prontinho, agora o {nome} está curado.");
                        Console.WriteLine("Aqui está a sua pokébola.");
                        Console.WriteLine("Deseja comprar algumas poções de cura?");

                        do
                        {
                            comprar = Console.ReadLine();
                            if (comprar == "sim")
                            {
                                Console.WriteLine("Ok, quantas?");
                                potions = int.Parse(Console.ReadLine());
                                Console.WriteLine($"OK, as {potions} poções ficaram {preco * potions} dinheiros.");
                                Console.WriteLine("Obrigado e volte sempre!");
                                Thread.Sleep(2000);
                                Console.WriteLine("Um tempo se passa...");
                                for (int x = 0; x < 5; x++)
                                {
                                    Console.WriteLine(".");
                                    Thread.Sleep(1000);
                                }
                            }
                            else if (comprar == "não")
                            {
                                Console.WriteLine("Tudo bem jovem treinador, tenha uma ótima jornada!");
                                Thread.Sleep(2000);
                                Console.WriteLine("Um tempo se passa...");
                                for (int x = 0; x < 5; x++)
                                {
                                    Console.WriteLine(".");
                                    Thread.Sleep(1000);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Não entendo o que você quer dizer com isso. Por favor digite uma reposta sim ou não.");
                            }
                        } while (comprar != "sim" && comprar != "não");
                        break;
                    case "não":
                        Console.WriteLine("Tudo bem jovem treinador, mas tenha cuidado para não exceder os limites dele e tenha uma ótima jornada!");
                        Thread.Sleep(2000);
                        Console.WriteLine("Um tempo se passa...");
                        for (int x = 0; x < 5; x++)
                        {
                            Console.WriteLine(".");
                            Thread.Sleep(1000);
                        }
                        break;
                    default:
                        Console.WriteLine("Não entendi o seu linguajar. Por favor se dirija para outra província.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Um tempo se passa...");
                        for (int x = 0; x < 5; x++)
                        {
                            Console.WriteLine(".");
                            Thread.Sleep(1000);
                        }
                        break;
                }
            }
            else if ((resposta == "não"))
            {
                Console.WriteLine("Que bom! Continue com sua boa viagem.");
                Console.WriteLine("Um tempo se passa...");
                for (int x = 0; x < 5; x++)
                {
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                }
            }
        }
    }
}