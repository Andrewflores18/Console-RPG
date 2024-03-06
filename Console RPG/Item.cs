using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class Item
    {

        public static HealthPotionItem potion1 = new HealthPotionItem("Quick Revive", "When everything's been draggin' you down, Grabs you by the hair and pulls you to the ground, If you wanna get up, you need a little revive.", 5, 5, 10, 5);
        public static HealthPotionItem potion2 = new HealthPotionItem("Speed Cola", "Your hands are slow, your movements sluggish, your lack of speed, just brings you anguish. Just take a sip, you will move faster. Just try it now!", 10, 10, 8, 25);
        public static HealthPotionItem potion3 = new HealthPotionItem("JuggerNog", "When you need some help to get by, Something to make you feel strong. Reach for Juggernog tonight, Sugar seduction delight!", 15, 15, 6, 50);
        public static HealthPotionItem potion4 = new HealthPotionItem("DoubleTap Root Beer", "Double Tap Rootbeer Jingle: Cowboys can't shoot slow or they'll end up below. When they need some help, they reach for the Root beer shelf (Ye-haa) Cowboys can't shoot slow, or they'll end up below, when they need some help, they reach for the Root beer shelf. YA THIRSTY PARTNER!?", 20, 15, 4, 75);

        public static ManaPotionItem manapotion1 = new ManaPotionItem("Mini", "This item gives you 25 MP", 5, 10, 10, 25);
        public static ManaPotionItem manapotion2 = new ManaPotionItem("Big Pot", "This item gives you 50 MP", 10, 10, 8, 50);
        public static ManaPotionItem manapotion3 = new ManaPotionItem("Slurp Juice", "This item gives you 75 MP", 15, 10, 6, 75);
        public static ManaPotionItem manapotion4 = new ManaPotionItem("Chug Jug", "This item gives you 100 MP", 20, 15, 4, 100);


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
