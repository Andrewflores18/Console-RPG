namespace Console_RPG
{
    class ManaPotionItem : Item
    {
        public int manaUpAmount;

        public ManaPotionItem(string name, string description, int shopPrice, int sellprice, int maxAmount, int manaUpAmount) : base(name, description, shopPrice, sellprice, maxAmount)
        {
            this.manaUpAmount = manaUpAmount;



        }

        public override void Use(Entity user, Entity target)
        {
            user.currentMana += this.manaUpAmount;

        }


    }





















}
