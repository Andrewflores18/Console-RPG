using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    { 
        
        public string name;
        public string description;
        public int shopPrice;
        public int sellprice;
        public int maxAmount;
        

        public Item(string name, string description, int shopPrice, int sellPrice, int maxAmount)
        {
            this.name = name;
            this.description = description;
            this.shopPrice = shopPrice;
            this.sellprice = sellPrice;
            this.maxAmount = maxAmount;
            
        }



        public abstract void Use(Entity user, Entity target);

















    }


    class HealthPotionItem : Item
    {
        public int healAmount;

        public HealthPotionItem(string name, string description, int shopPrice, int sellPrice, int maxAmount, int healAmount) : base(name, description, shopPrice, sellPrice, maxAmount)
        {
            this.healAmount = healAmount;



        }

        public override void Use(Entity user, Entity target)
        {
            user.currentHP += this.healAmount;

        }


    }



    class ExplosiveRepeater : Item
    {
        public int damage;
        public int ammo;


        public ExplosiveRepeater(string name, string description, int shopPrice, int sellPrice, int maxAmount, int damage, int ammo) : base(name, description, shopPrice, sellPrice, maxAmount)
        {
            this.damage = damage;
            this.ammo = ammo;



        }

        public override void Use(Entity user, Entity target)
        {
            if (ammo == 0)
                return;

            target.currentHP -= this.damage;
            --ammo;

        }









    }





















}
