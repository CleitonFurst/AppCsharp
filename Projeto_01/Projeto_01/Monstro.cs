﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_01
{
    class Monstro
    {
        public string nome { get; set; }
        public int vida { get; set; }
        public int xp { get; set; }
        public int ataque { get; set; }

        public Monstro(string nome, int vida  ,  int ataque )
        {
            this.nome = nome;
            this.vida = vida;
            this.xp = vida + ataque;
            this.ataque = ataque;

        }
    }
}