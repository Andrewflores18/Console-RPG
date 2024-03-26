using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {

            public static Location KinoDerToten = new Location("Kino Der Toten", "Run down Theater full of undead", new Battle(new List<Enemy>() { Enemy.Undead1, Enemy.Undead2, Enemy.Undead3, Enemy.Undead4, Enemy.Undead5, Enemy.Undead6 }));

            public static Location TiltedTowers = new Location("Tilted Towers", "Busy shopping District try not to get boxed in and 250 pumped but you should try to get me a Durr Burger", new Battle(new List<Enemy>() { Enemy.FortniteTryhard, Enemy.FortniteNoob }));

        public static Location Terminal = new Location("Terminal", "An empty Airport seems like a tragedy happened here that was a setup to frame the U.S.");

            public static Location FreddyFazbearsPizzaria = new Location("Freddy Fazbear's Pizzaria", "It's a Pizzaria where some kids went missing some say that the Animatronics smell like rotting flesh so they closed this place a day ago anyways i don't mind more pizza for me", new Battle(new List<Enemy>() { Enemy.FreddyFazBear, Enemy.TheBlind }));

        public static Location McDonalds = new Location("McDonalds", "McDonald's is the world's largest fast food restaurant chain, serving over 69 million customers daily in over 100 countries in more than 40,000 outlets, maybe you could get me a Happy Meal?");

            public static Location NukeTown2025 = new Location("NukeTown 2025", "A 1960s retro-futuristic Mid-Century modern style meant to represent the Home of the Future for 2025.", new Battle(new List<Enemy>() { Enemy.Undead7, Enemy.Undead8, Enemy.Undead9, Enemy.Undead10 }));

            public static Location WoodlandMansion = new Location("Woodland Mansion", "A Mansion hidden in the deep dark forest some say that it is just a myth and does not exist while others say they have seen it, they say that when they peered into the windows they felt something stare back.", new Battle(new List<Enemy>() { Enemy.Evokers, Enemy.Vexes, Enemy.Vindicator }));

            public static Location PreCovidWalmart = new Location("Pre-Covid Walmart", "Open 24/7");

            public static Location StationSquare = new Location("Station Square", "It is a heavily populated city famous for its many attractions including an amusement park, a hotel/restaurant, and a casino district.");

            public static Location GasStation = new Location("7/11", "This 7/11 is in the middle of Nowhere and for some reason the time never changes here is always midnight there might be something affecting time around who knows");

            public static Location PalletTown = new Location("Pallet Town", "This sleepy town lies on the shore, and is primarily known for hosting Professor Oaks lab, as well as for being the hometown of a number of notable Pokémon trainers.");

            public static Location HighHarothgar = new Location("High Hrothgar", "High Hrothgar is a small settlement roughly halfway up the Throat of the World, It is a major landmark and home to the reclusive Greybeards, who are masters of The Voice.");

            public static Location TheSkeld = new Location("The Skeld", "The Skeld is a huge spaceship painted in a bluish-gray color. The ship has several rooms, each with its own functions and is moved by two combustion engines");

            public static Location VGDClassroom = new Location("VGD Classroom", "Seems like the students here are learing on how to make games");

            public static Location TheBahamas = new Location("The Bahamas", "The Bahamas consists of 700 tropical islands. Only about 30 of them are inhabited by people. New Providence – one of the largest islands and the location of Nassau, the capital city – is home to 70 percent of the country's population.");

            public static Location TheBackrooms = new Location("The Backrooms", "Some say The Backrooms is an urban legend and creepypasta originating from a post on 4chan while other say its not and that it is part of the world which is an incredibly vast maze of empty yellow rooms. The Backrooms is characterized by its yellow wallpaper, the smell of moist carpet, and loud buzzing lights");

            public static Location PostCovidWalmart = new Location("Post-Covid Walmart", "Self-Checkout Machines, not open 24/7 what else have they taken from us");

            public static Location AmazonWarehouse = new Location("Amazon Warehouse", "It's an Amazon Warehouse that's pretty much it, you could try to drive a Forklift but I don't think you are ForkLift Certified");

            public static Location FedExWarehouse = new Location("FedEx Warehouse", "It's a FedEx Warehouse, ForkLift Maybe?");

            public static Location UPSWarehouse = new Location("UPS Warehouse", "Once again it's another warehouse but this time it's for UPS let's hope you can find your package before a UPS Delivery Driver mishandles it");

            public static Location TheBatcave = new Location("The Batcave", "Whoa So we Have Batman's Batcave™ in this weird Multiverse you should check to see if Alfred Pennyworth is around and say Hi to him for me");

            public static Location Antarctica = new Location("Antarctica", "Dang it's so cold here maybe we could go somewhere thats not -71°F next time?");

            public static Location StarryNight = new Location("Starry Night", "There is a painting of Starry Night by Vincent van Gogh in the VGD Classroom it looks off might you try to touch it?");

            public static Location SpidermansHouse = new Location("Spiderman's House (Tom Holland's Spiderman) ", "Why is this Spiderman's house here? what about Tobey maguire's Spiderman");

            public static Location Sovngarde = new Location("Sovngarde", "How did you even end up here? Sovngarde is the Nordic afterlife created by Shor that exists in Aetherius. Nords who have died valiantly in honorable combat arrive in Sovngarde after death. Fleshly pain and maladies evaporate upon entering its Hall of Valor. Spirits here enjoy mead-drinking and contests of physical prowess.");

            public static Location Target = new Location("Target", "Target is notable for its focus on upscale, trend-forward merchandise at lower costs. Its stores typically sell general merchandise—including clothing, household goods, electronics, toys, and more");

            public static Location PizzaHut = new Location("Pizza Hut", "We're the pizza company that lives life unboxed. We have more than 16,000 restaurants and 350,000 team members in more than 100 countries. Whether it's the original Stuffed Crust or putting a pizza in outer space, we never stop driving ourselves to deliver hot pizzas, fast every time – anywhere you want to enjoy it.");

            public static Location SweatShop = new Location("Temu", "How did we even end up here like the things they are doing here are Illeagal we should do something to stop this or we can just turn a blind eye to this so that you can keep getting you things off Temu™", new Shop("Temu™ Employee", "Temu™", new List<Item>() { Item.potion1, Item.potion1, Item.potion1, Item.potion2, Item.potion2, Item.potion2, Item.potion3, Item.potion3, }));

            public static Location MidTown = new Location("MidTown", "Abandoned and eerie, people say something BIG is lurking in MidTown", new Battle(new List<Enemy>() { Enemy.LeonFerris, Enemy.Grunt1, Enemy.Grunt2})); 

        






        public string name;
        public string description;
        public LocationPOI interaction;

        public Location north, east, south, west;

        public Location(string name, string description, LocationPOI interaction = null)
        {
            this.name = name;
            this.description = description;
            this.interaction = interaction;
        }

        public void SetNearbyLocations(Location north = null, Location east = null, Location south = null, Location west = null)
        {
            this.north = north;
            this.east = east;
            this.south = south;
            this.west = west;

            if (!(north is null))
            north.south = this;

            if (!(east is null))
            east.west = this;

            if (!(south is null))
            south.north = this;

            if (!(west is null))
            west.east = this;



        }

        public void Resolve(List<Player> players)
        {
            Console.WriteLine("You find yourself in " + this.name + ".");
            Console.WriteLine(this.description);



            if (!(north is null))
                Console.WriteLine("North: " + this.north.name);


            if (!(east is null))
                Console.WriteLine("East: " + this.east.name);



            if (!(south is null))
                Console.WriteLine("South: " + this.south.name);



            if (!(west is null))
                Console.WriteLine("West: " + this.west.name);



            string direction = Console.ReadLine();
            Location nextLocation = null;

            // What happens if user dosen't give a proper input?

            if (direction == "North")
                nextLocation = this.north;

            if (direction == "East")
                nextLocation = this.east;

            if (direction == "South")
                nextLocation = this.south;

            if (direction == "West")
                nextLocation = this.west;


            nextLocation.Resolve(players);









        }

    }



























}
