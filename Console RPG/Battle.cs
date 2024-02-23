﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Console_RPG
{
    class Battle
    {
        public List<Enemy> enemies;
        public bool isresolved;

        public Battle(List<Enemy> enemies)
        {
            this.enemies = enemies;
            this.isresolved = false;
        }




        public void Resolve(List<Player> players)
        {
            while (true)
            {
                foreach (var item in players)
                {
                    Console.WriteLine("It's " + item.name + "'s turn.");
                    item.DoTurn(players, enemies);
                }


                foreach (var item in enemies)
                {
                    Console.WriteLine("It's " + item.name + "'s turn.");
                    item.DoTurn(players, enemies);

                }


                if (players.TrueForAll(player => player.currentHP <=0))
                {
                    Console.WriteLine("");
                    break;
                }

                if (enemies.TrueForAll(enemy => enemy.currentHP <= 0))
                {
                    Console.WriteLine("");
                    //Other enemies stuff like drops, ect.
                    break;
                }



            }

            //Anything that happens no matter who wins

        }




    }
}