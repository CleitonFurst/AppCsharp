using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01
{
    class Heroi
    {
        public string  nome { get; set; }
        public int xp { get; set; }
        public int nivel { get; set; }
        public int vida { get; set; }
        public int ataque { get; set; }
        public int ataque_base { get; set; }

        public Heroi (string nome ){
            Random poder = new Random();
            this.nome = nome;
            this.xp = 0;
            this.nivel = 1;
            this.vida = 10;
            
            this.ataque_base = poder.Next(1, 11);
            this.ataque = this.ataque_base;
            
            

        }
        public void ganhaXP(int xp)
        {
           
            xp += xp;
            int novo_nivel = (xp / 10) + 1;
            if (novo_nivel > nivel)
            {
                Console.WriteLine("Você aumentou de nível!");
                vida = novo_nivel * 10;
            }
            nivel = novo_nivel;
            ataque = ataque_base + nivel;
           
        }

    }
}
