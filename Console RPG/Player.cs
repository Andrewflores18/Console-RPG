using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;



namespace Console_RPG
{

class Player : Entity
    {
        public static Player Bread = new Player("Pingus", 350, 750, new Stats(10, 9, 7), 1);

        public static List<Item> Inventory = new List<Item>() { Item.potion1, Item.potion2, Item.potion2, Item.potion3, Item.potion2, Item.potion2, Item.potion3 };
        public static int CoinCount = 0;

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

        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("Type in the number of an Item you want to use");

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
		// figure out how to calculate the damage and subtract from the target's hp
        int damage = this.stats.strength - target.stats.strength;
        int hp = target.currentHP -= damage;
		Console.WriteLine($"{this.name} attacked {target.name} for {damage} amount of damage! {target.name} now has {target.currentHP} amount of Health");
    }

        public override void DoTurn(List<Player> players, List<Enemy> enemies)
        {
            Console.WriteLine("What would you like to do");
            Console.WriteLine("ATTACK | ITEM");
            string choice = Console.ReadLine();

            if (choice == "ATTACK")
            {
                Entity target = ChooseTarget(enemies.Cast<Entity>().ToList());
                Attack(target);
            }
            
            else if (choice == "ITEM")
            {
                Item item = ChooseItem(Inventory);
                Entity target = ChooseTarget(players.Cast<Entity>().ToList());

                item.Use(this, target);
                Inventory.Remove(item);

            }



        }

    }




}

