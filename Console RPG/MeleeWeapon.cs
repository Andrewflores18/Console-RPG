namespace Console_RPG
{
   abstract class MeleeWeapon
    {
        public int durability;
        public int meleeDamage;
        public string name;
        public string description;
        public int shopPrice;
        public int maxAmount;
        public int weaponWeight;

        public MeleeWeapon(string name, string description, int meleeDamage, int durability, int shopPrice, int maxAmount, int weaponWeight)
        {
            this.name = name;
            this.description = description;
            this.shopPrice = shopPrice;
            this.maxAmount = maxAmount;
            this.durability = durability;
            this.meleeDamage = meleeDamage;
            this.weaponWeight = weaponWeight;

        }



        public abstract void Use(Entity user, Entity target);








    }








  class Sword : MeleeWeapon
  {
        public int speed;




             public Sword(string name, string description, int meleeDamage, int durability, int shopPrice, int maxAmount, int weaponWeight, int speed) : base(name, description, meleeDamage, durability, shopPrice, maxAmount, weaponWeight)
             {
            
              this.speed = speed;

             }











        public override void Use(Entity user, Entity target)
         {
                    if (durability == 0)
                        return;

                    target.currentHP -= this.meleeDamage;
                        --durability;


         }



  }

       












}
