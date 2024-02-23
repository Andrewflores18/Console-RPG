using System;
using System.Collections.Generic;
using System.Linq;
namespace Console_RPG
{

class Player : Entity
    {

		public int Level;

		public Player(string name, int hp, int mana, Stats stats, int Level) : base(name, hp, mana, stats)
        {
			this.Level = Level;
        }

    public override Entity ChooseTarget(List<Entity> choices)
    {
            Console.WriteLine("Type in the number of an enemy you want to target");

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {choices[i].name}");


            }
            //Let the user pick a choice
            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];

    }

    public override void Attack(Entity target)
    {
		// figure out how to calculate the damage and subtract from the target's hp//
		Console.WriteLine(this.name + " attacked " + target.name + " ! ");
    }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
            Attack(target);


        }

    }




}

