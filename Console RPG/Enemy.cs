using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
class Enemy : Entity
    {
        public static Enemy Undead1 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy Undead2 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy Undead3 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy Undead4 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy Undead5 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy Undead6 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy Undead7 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy Undead8 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy Undead9 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy Undead10 = new Enemy("Undead", 100, 100000, new Stats(10, 5, 10), 1);
        public static Enemy TheBlind = new Enemy("The Blind", 250, 100000, new Stats(15, 10, 5), 1);
        public static Enemy TwoHead = new Enemy("Two Head", 500, 100000, new Stats(15, 10, 1), 4);
        public static Enemy LeonFerris = new Enemy("Subject Alpha (Leon Farris)", 750, 100000, new Stats(15, 10, 2), 1);
        public static Enemy Grunt1 = new Enemy("Grunt", 75, 100000, new Stats(10, 5, 1), 1);
        public static Enemy Grunt2 = new Enemy("Grunt", 75, 100000, new Stats(10, 5, 1), 1);
        public static Enemy Grunt3 = new Enemy("Grunt", 75, 100000, new Stats(10, 5, 1), 1);
        public static Enemy Vindicator = new Enemy("vindicator", 75, 100000, new Stats(25, 5, 5), 1);
        public static Enemy Evokers = new Enemy("evokers", 75, 100000, new Stats(25, 5, 5), 1);
        public static Enemy Vexes = new Enemy("Vexes", 75, 100000, new Stats(30, 5, 10), 1);








        public static Enemy Slime = new Enemy("Slime", 100000000, 100000, new Stats(5, 6, 1), 1);



        public int experienceDroppedOnDeath;

		public Enemy(string name, int hp, int mana, Stats stats, int experienceDroppedOnDeath) : base(name, hp, mana, stats)
		{
			this.experienceDroppedOnDeath = experienceDroppedOnDeath;
        }

    public override Entity ChooseTarget(List<Entity> targets)
    {
		Random random = new Random();
		return targets[random.Next(targets.Count)];
    }


	public override void Attack(Entity target)
	{
		Console.WriteLine(this.name + " attacked " + target.name + " ! ");
	}

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);


        }
    }

}
