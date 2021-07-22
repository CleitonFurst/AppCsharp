using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01
{
    class Jogo
    {
        Monstro validar = new Monstro(" ", 0, 0);
        Heroi heroi;// esta instanciandoo a classe heroi 
        public void iniciar()//cria a classe iniciar 
        {
            Console.WriteLine("Digite o nome para seu personagem :");//faz o input do nome 
            heroi = new(Console.ReadLine());// estancia o contrutor passando o nome como atributo
            Menu();
        }
        void Menu()
        {   
            MostraInfo();            
            Console.WriteLine("Escolha um monstro para atacar !!");
            Console.WriteLine("1-> Orc ");
            Console.WriteLine("2-> Troll");
            Console.WriteLine("3-> Goblin");
            Console.WriteLine("0-> para sair");


            switch (Console.ReadLine().ToUpper())
            {
                
                case "1":
                case "ORC":
                    Console.WriteLine(validar.vida);                  
                        batalhar(new Monstro("Orc",heroi.nivel * 5, heroi.nivel));   
                        break;
                   
                case "2":
                case "TROLL":                    
                        batalhar(new Monstro("Troll", heroi.nivel * 10, heroi.nivel*2));                   
                        break;
                case "3":
                case "GOBLIN":                   
                        batalhar(new Monstro("Goblin", heroi.nivel * 15, heroi.nivel*4));
                        break;  
                case "0":
                case "SAIR":
                    return;
                default:
                    Console.WriteLine("Opção invalida !!!");
                    break;
            }


        }
        void batalhar(Monstro monstro)
        {
            Console.Clear();
            MostraInfo();
            Console.WriteLine($"MOSTRO ENCONTRADO: {monstro.nome} - ATAQUE:{monstro.ataque} VIDA :{monstro.vida} XP :{monstro.xp}");
            Console.WriteLine("Deseja atacar (1) ou fugir (2)?");
            int aux = 0;
            switch (Console.ReadLine().ToUpper())
            {
                case "1":
                case "ATACAR":

                    monstro.vida -= heroi.ataque;
                   
                    Console.WriteLine($"\n\nVocê causou {heroi.ataque} de dano no {monstro.nome}!");
                    Random talvez = new Random();
                    if (talvez.Next(1, 11) % 2 == 0)
                    {

                        heroi.vida -= monstro.ataque;
                        Console.WriteLine($"\n\nVocê recebeu {monstro.ataque} de dano do ataque do {monstro.nome}!");
                    }
                    else
                    {
                        Console.WriteLine("\n\nO MONSTRO ERROU O ATAQUE!");
                    }

                    if (heroi.vida <= 0)
                    {
                        Console.WriteLine("\n\nE morreu...");
                        return;
                    }
                       
                    
                    if (monstro.vida <= 0)
                    {
                        Console.WriteLine($"\n\nVocê derrotou o {monstro.nome} e ganhou {monstro.xp} de xp!");
                        heroi.ganhaXP(monstro.xp);
                        aux = 1;
                    }
                    break;
                case "2":
                case "FUGIR":
                    Console.WriteLine("Você fugiu da batalha! Arregou");
                    aux = 1;
                    return;

            }
            Console.WriteLine("Precione qualquer tecla para continuar ...");
            Console.ReadKey();
            Console.WriteLine("passou aqui ");
            if (aux == 1)
            {

                Menu();
            }
            batalhar(monstro);

        }
        void MostraInfo()
        {
            Console.WriteLine($"Olá {heroi.nome}");
            Console.WriteLine($"Seu nivel é: {heroi.nivel}");
            Console.WriteLine($"Sua experiencia é : {heroi.xp}");
            Console.WriteLine($"Seu ataque é : {heroi.ataque}");
            Console.WriteLine($"Sua vida é : {heroi.vida}");
        }
    }
}

