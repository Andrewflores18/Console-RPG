using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Shop : LocationPOI
    {
        public string ownerName;
        public string shopName;
        public List<Item> items;

        public Shop(string ownerName, string shopName, List<Item> items) : base(false)
        {
            this.ownerName = ownerName;
            this.shopName = shopName;
            this.items = items;
     
        
        }


        public override void Resolve(List<Player> players)
        {
            Console.WriteLine($"Welcome to {ownerName}'s shop");
            
            while (true)
            {
            Console.WriteLine("What would you want to do");
            Console.WriteLine("Buy | Sell | Talk | Leave");
            string userInput = Console.ReadLine();
                if (userInput == "Buy")
                {

                    Item item = ChooseItem(this.items);
                    Player.CoinCount -= item.shopPrice;
                    Player.Inventory.Add(item);

                    Console.WriteLine($"You Bought a {item.name}!");

                }
                else if (userInput == "Sell")
                {
                    Item item = ChooseItem(Player.Inventory);
                    Player.CoinCount += item.shopPrice;
                    Player.Inventory.Remove(item);

                    Console.WriteLine($"You Sold a {item.name}!");
                }

                else if (userInput == "Talk")
                {
                    Console.WriteLine("I've been stuck in this shop for eternity and you been stuck in this endless loop of killing enemies and selling things to me i hope you can find a way out of the loop");


                }

                else if (userInput == "Leave")
                {

                    break;

                }

            }


            Console.WriteLine("Have a Good rest of your");






        }

        public Item ChooseItem(List<Item> choices)
        {
            Console.WriteLine("Type in the number of an Item you want to buy");

            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {choices[i].name} {choices[i].name} (${choices[i].shopPrice}");


            }
            //Let the user pick a choice
            int index = Convert.ToInt32(Console.ReadLine());
            return choices[index - 1];

        }


    }


}
