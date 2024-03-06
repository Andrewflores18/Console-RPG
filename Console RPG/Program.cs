using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
          









            




            Location.TiltedTowers.SetNearbyLocations(north: Location.AmazonWarehouse, east: Location.McDonalds, south: Location.TheBahamas, west: Location.NukeTown2025);
            Location.KinoDerToten.SetNearbyLocations(north: Location.Terminal, east: Location.NukeTown2025, south: Location.TheSkeld, west: Location.MidTown);
            Location.VGDClassroom.SetNearbyLocations(east: Location.StarryNight, west: Location.GasStation);
            Location.GasStation.SetNearbyLocations(north: Location.Target, east: Location.VGDClassroom, south: Location.WoodlandMansion, west: Location.PostCovidWalmart);
            Location.WoodlandMansion.SetNearbyLocations(north: Location.GasStation);
            Location.PostCovidWalmart.SetNearbyLocations(north: Location.PalletTown, east: Location.GasStation, west: Location.PreCovidWalmart);
            Location.PalletTown.SetNearbyLocations(south: Location.PostCovidWalmart, east: Location.Target, west: Location.StationSquare);
            Location.PreCovidWalmart.SetNearbyLocations(north: Location.StationSquare, east: Location.PostCovidWalmart, south: Location.FreddyFazbearsPizzaria, west: Location.McDonalds);
            Location.Target.SetNearbyLocations(north: Location.PizzaHut);
            Location.MidTown.SetNearbyLocations(east: Location.KinoDerToten);
            Location.TheSkeld.SetNearbyLocations(north: Location.KinoDerToten);
            Location.Terminal.SetNearbyLocations(east: Location.UPSWarehouse, south: Location.KinoDerToten);
            Location.PizzaHut.SetNearbyLocations(south: Location.Target);
            Location.UPSWarehouse.SetNearbyLocations(east: Location.AmazonWarehouse, south: Location.NukeTown2025, west: Location.Terminal);
            Location.AmazonWarehouse.SetNearbyLocations(north: Location.SweatShop, east: Location.FedExWarehouse, south: Location.TiltedTowers, west: Location.UPSWarehouse);
            Location.SweatShop.SetNearbyLocations(south: Location.AmazonWarehouse);
            Location.FedExWarehouse.SetNearbyLocations(east: Location.StationSquare, south: Location.McDonalds, west: Location.AmazonWarehouse);
            Location.NukeTown2025.SetNearbyLocations(north: Location.UPSWarehouse, east: Location.TiltedTowers, south: Location.Antartica, west: Location.KinoDerToten);
            Location.Antartica.SetNearbyLocations(north: Location.NukeTown2025, east: Location.TheBahamas);
            Location.TheBahamas.SetNearbyLocations(north: Location.TiltedTowers, east: Location.TheBatcave, south: Location.TheBackrooms, west: Location.Antartica);
            Location.TheBackrooms.SetNearbyLocations(north: Location.TheBahamas);
            Location.StarryNight.SetNearbyLocations(west: Location.VGDClassroom);
            Location.McDonalds.SetNearbyLocations(north: Location.FedExWarehouse, east: Location.PreCovidWalmart, south: Location.TheBatcave, west: Location.TiltedTowers);
            Location.TheBatcave.SetNearbyLocations(north: Location.McDonalds, east: Location.FreddyFazbearsPizzaria, south: Location.SpidermansHouse, west: Location.TheBahamas);
            Location.SpidermansHouse.SetNearbyLocations(north: Location.TheBatcave);
            Location.FreddyFazbearsPizzaria.SetNearbyLocations(north: Location.PreCovidWalmart, south: Location.TheBatcave);
            Location.StationSquare.SetNearbyLocations(north: Location.HighHarothgar, east: Location.PalletTown, south: Location.PreCovidWalmart, west: Location.FedExWarehouse);
            Location.HighHarothgar.SetNearbyLocations(north: Location.Sovngarde, south: Location.StationSquare);
            Location.Sovngarde.SetNearbyLocations(south: Location.HighHarothgar);






            Location.StationSquare.Resolve();




            









        }
    }
}
