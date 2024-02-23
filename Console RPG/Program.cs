using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Bread = new Player("Bread", 100000000, 10000000, new Stats(10, 9, 7), 1);
            Enemy slime = new Enemy("slime", 100000000, 100000, new Stats(5, 7, 1), 1);

            HealthPotionItem potion1 = new HealthPotionItem("Quick Revive", "When everything's been draggin' you down, Grabs you by the hair and pulls you to the ground, If you wanna get up, you need a little revive.", 10, 4, 5);
            HealthPotionItem potion2 = new HealthPotionItem("Speed Cola", "", 10, 4, 25);
            HealthPotionItem potion3 = new HealthPotionItem("JuggerNog", "When you need some help to get by, Something to make you feel strong. Reach for Juggernog tonight, Sugar seduction delight!", 10, 4, 50);
            HealthPotionItem potion4 = new HealthPotionItem("DoubleTap Root Beer", "", 10, 4, 75);




            Bread.UseItem(potion1, Bread);


            Console.WriteLine(slime.stats.strength);


            Location MidTown = new Location("MidTown", "Abandoned and eerie, people say something BIG is lurking in MidTown");

            Location KinoDerToten = new Location("Kino Det Toten", "Run down Theater full of undead");

            Location TiltedTowers = new Location("Tilted Towers", "Busy shopping District try not to get boxed in and 250 pumped but you should try to get me a Durr Burger");

            Location Terminal = new Location("Terminal", "An empty Airport seems like a tragady happend here that was a setup to frame the U.S.");

            Location FreddyFazbearsPizzaria = new Location("Freddy Fazbear's Pizzaria", "It's a Pizzaria where some kids went missing some say that the Animatronics smell like rotting flesh so they closed this place a day ago anyways i don't mind more pizza for me");
            
            Location McDonalds = new Location("McDonalds", "McDonald's is the world's largest fast food restaurant chain, serving over 69 million customers daily in over 100 countries in more than 40,000 outlets, maybe you could get me a Happy Meal?");
            
            Location NukeTown2025 = new Location("NukeTown 2025", "A 1960s retro-futuristic Mid-Century modern style meant to represent the Home of the Future for 2025.");
            
            Location WoodlandMansion = new Location("Woodland Mansion", "A Mansion hidden in the deep dark forest some say that it is just a myth and does not exist while others say they have seen it, they say that when they peered into the windows they felt something stare back.");
            
            Location PreCovidWalmart = new Location("Pre-Covid Walmart", "Open 24/7");
            
            Location StationSquare = new Location("Station Square", "It is a heavily populated city famous for its many attractions including an amusement park, a hotel/restaurant, and a casino district.");
            
            Location GasStation = new Location("7/11", "This 7/11 is in the middle of Nowhere and for some reason the time never changes here is always midnight there might be something affecting time around who knows");
            
            Location PalletTown = new Location("Pallet town", "This sleepy town lies on the shore, and is primarily known for hosting Professor Oaks lab, as well as for being the hometown of a number of notable Pokémon trainers.");
            
            Location HighHarothgar = new Location("High Hrothgar", "High Hrothgar is a small settlement roughly halfway up the Throat of the World, It is a major landmark and home to the reclusive Greybeards, who are masters of The Voice.");
            
            Location TheSkeld = new Location("The Skeld", "The Skeld is a huge spaceship painted in a bluish-gray color. The ship has several rooms, each with its own functions and is moved by two combustion engines");
            
            Location VGDClassroom = new Location("VGD Classroom", "Seem's like the students here are learing on how to make games");
            
            Location TheBahamas = new Location("The Bahamas", "The Bahamas consists of 700 tropical islands. Only about 30 of them are inhabited by people. New Providence – one of the largest islands and the location of Nassau, the capital city – is home to 70 percent of the country's population.");
            
            Location TheBackrooms = new Location("The Backrooms", "Some say The Backrooms is an urban legend and creepypasta originating from a post on 4chan while other say its not and that it is part of the world which is an incredibly vast maze of empty yellow rooms. The Backrooms is characterized by its yellow wallpaper, the smell of moist carpet, and loud buzzing lights");
            
            Location PostCovidWalmart = new Location("Post-Covid Walmart", "Self-Checkout Machines, not open 24/7 what else have they taken from us");
            
            Location AmazonWarehouse = new Location("Amazon Warehouse", "It's an Amazon Warehouse that's pretty much it, you could try to drive a Forklift but I don't think you are ForkLift Certified");
            
            Location FedExWarehouse = new Location("FedEx Warehouse", "It's a FedEx Warehouse, ForkLift Maybe?");
            
            Location UPSWarehouse = new Location("UPS Warehouse", "Once again it's another warehouse but this time it's for UPS let's hope you can find your package before a UPS Delevery Drive mishandles it");

            Location TheBatcave = new Location("The Batcave", "Whoa So we Have Batman's Batcave™ in this weird Multiverse you should check to see if Alfred Pennyworth is around and say Hi to him for me");

            Location Antartica = new Location("Antarctica", "Dang it's so cold here my pants are SoB, What is that? you say well it means standing on buisness, anyways it's not the ones im wearing just the ones that were wet from the previous location why did you have to go into the water and is that another pair of pants SoB, y he snowboarding tho?");

            TiltedTowers.SetNearbyLocations();
            KinoDerToten.SetNearbyLocations(north: Terminal, east: NukeTown2025, south: TheSkeld);









            KinoDerToten.Resolve();




            









        }
    }
}
