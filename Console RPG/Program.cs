using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Bread = new Player("Bread", 100000000, 10000000, new Stats(10, 9, 7), 1);
            Enemy slime = new Enemy("slime", 100000000, 100000, new Stats(5, 7, 1), 1);

            HealthPotionItem potion1 = new HealthPotionItem("Quick Revive", "When everything's been draggin' you down, Grabs you by the hair and pulls you to the ground, If you wanna get up, you need a little revive.", 5, 10, 5);
            HealthPotionItem potion2 = new HealthPotionItem("Speed Cola", "Your hands are slow, your movements sluggish, your lack of speed, just brings you anguish. Just take a sip, you will move faster. Just try it now!", 10, 10, 25);
            HealthPotionItem potion3 = new HealthPotionItem("JuggerNog", "When you need some help to get by, Something to make you feel strong. Reach for Juggernog tonight, Sugar seduction delight!", 15, 10, 50);
            HealthPotionItem potion4 = new HealthPotionItem("DoubleTap Root Beer", "Double Tap Rootbeer Jingle: Cowboys can't shoot slow or they'll end up below. When they need some help, they reach for the Root beer shelf (Ye-haa) Cowboys can't shoot slow, or they'll end up below, when they need some help, they reach for the Root beer shelf. YA THIRSTY PARTNER!?", 20, 4, 75);

            ManaPotionItem manapotion1 = new ManaPotionItem("Mini", "This item gives you 25 MP", 5, 10, 25);
            ManaPotionItem manapotion2 = new ManaPotionItem("Big Pot", "This item gives you 50 MP", 10, 10, 50);
            ManaPotionItem manapotion3 = new ManaPotionItem("Slurp Juice", "This item gives you 75 MP", 15, 10, 75);
            ManaPotionItem manapotion4 = new ManaPotionItem("Chug Jug", "This item gives you 100 MP", 20, 10, 100);


            Bread.UseItem(potion1, Bread);

            Console.WriteLine(slime.stats.strength);




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

            Location PalletTown = new Location("Pallet Town", "This sleepy town lies on the shore, and is primarily known for hosting Professor Oaks lab, as well as for being the hometown of a number of notable Pokémon trainers.");

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

            Location Antartica = new Location("Antarctica", "Dang it's so cold here maybe we could go somewhere thats not -71°F next time?");

            Location StarryNight = new Location("Starry Night", "There is a painting of Starry Night by Vincent van Gogh in the VGD Classroom it looks off might you try to touch it?");

            Location SpidermansHouse = new Location("Spiderman's House (Tom Holland's Spiderman) ", "Why is this Spiderman's house here? what about the OG Spidernam");

            Location Sovngarde = new Location("Sovngarde", "How did you even end up here? Sovngarde is the Nordic afterlife created by Shor that exists in Aetherius. Nords who have died valiantly in honorable combat arrive in Sovngarde after death. Fleshly pain and maladies evaporate upon entering its Hall of Valor. Spirits here enjoy mead-drinking and contests of physical prowess.");

            Location Target = new Location("Target", "Target is notable for its focus on upscale, trend-forward merchandise at lower costs. Its stores typically sell general merchandise—including clothing, household goods, electronics, toys, and more");

            Location PizzaHut = new Location("Pizza Hut", "We're the pizza company that lives life unboxed. We have more than 16,000 restaurants and 350,000 team members in more than 100 countries. Whether it's the original Stuffed Crust or putting a pizza in outer space, we never stop driving ourselves to deliver hot pizzas, fast every time – anywhere you want to enjoy it.");

            Location SweatShop = new Location("Temu", "How did we even end up here like the thing's they are doing here are Illeagal we should do something to stop this or we can just turn a blind eye to this so that you can keep getting you things off Temu™️");

            Location MidTown = new Location("MidTown", "Abandoned and eerie, people say something BIG is lurking in MidTown");

       
         
            //Location name = new Location() is how you even set up a location
           

       

            TiltedTowers.SetNearbyLocations(north: AmazonWarehouse, east: McDonalds, south: TheBahamas, west: NukeTown2025);
            KinoDerToten.SetNearbyLocations(north: Terminal, east: NukeTown2025, south: TheSkeld, west: MidTown);
            VGDClassroom.SetNearbyLocations(east: StarryNight, west: GasStation);
            GasStation.SetNearbyLocations(north: Target, east: VGDClassroom, south: WoodlandMansion, west: PostCovidWalmart);
            WoodlandMansion.SetNearbyLocations(north: GasStation);
            PostCovidWalmart.SetNearbyLocations(north: PalletTown, east: GasStation, west: PreCovidWalmart);
            PalletTown.SetNearbyLocations(south: PostCovidWalmart, east: Target, west: StationSquare);
            PreCovidWalmart.SetNearbyLocations(north: StationSquare, east: PostCovidWalmart, south: FreddyFazbearsPizzaria, west: McDonalds);
            Target.SetNearbyLocations(north: PizzaHut);
            MidTown.SetNearbyLocations(east: KinoDerToten);
            TheSkeld.SetNearbyLocations(north: KinoDerToten);
            Terminal.SetNearbyLocations(east: UPSWarehouse, south: KinoDerToten);
            PizzaHut.SetNearbyLocations(south: Target);
            UPSWarehouse.SetNearbyLocations(east: AmazonWarehouse, south: NukeTown2025, west: Terminal);
            AmazonWarehouse.SetNearbyLocations(north: SweatShop, east: FedExWarehouse, south: TiltedTowers, west: UPSWarehouse);
            SweatShop.SetNearbyLocations(south: AmazonWarehouse);
            FedExWarehouse.SetNearbyLocations(east: StationSquare, south: McDonalds, west: AmazonWarehouse);
            NukeTown2025.SetNearbyLocations(north: UPSWarehouse, east: TiltedTowers, south: Antartica, west: KinoDerToten);
            Antartica.SetNearbyLocations(north: NukeTown2025, east: TheBahamas);
            TheBahamas.SetNearbyLocations(north: TiltedTowers, east: TheBatcave, south: TheBackrooms, west: Antartica);
            TheBackrooms.SetNearbyLocations(north: TheBahamas);
            StarryNight.SetNearbyLocations(west: VGDClassroom);
            McDonalds.SetNearbyLocations(north: FedExWarehouse, east: PreCovidWalmart, south: TheBatcave, west: TiltedTowers);
            TheBatcave.SetNearbyLocations(north: McDonalds, east: FreddyFazbearsPizzaria, south: SpidermansHouse, west: TheBahamas);
            SpidermansHouse.SetNearbyLocations(north: TheBatcave);
            FreddyFazbearsPizzaria.SetNearbyLocations(north: PreCovidWalmart, south: TheBatcave);
            StationSquare.SetNearbyLocations(north: HighHarothgar, east: PalletTown, south: PreCovidWalmart, west: FedExWarehouse);
            HighHarothgar.SetNearbyLocations(north: Sovngarde, south: StationSquare);
            Sovngarde.SetNearbyLocations(south:HighHarothgar);




















            StationSquare.Resolve();




            









        }
    }
}
