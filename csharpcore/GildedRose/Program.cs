using GildedRose.Models;
using GildedRose.Services.Contracts;
using System;
using System.Collections.Generic;

namespace GildedRoseKata
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");

            IList<GenericItem> ItemsNewVersion = new List<GenericItem>()
            {
                new GenericItem("+5 Dexterity Vest",10,20),
                new AgedBrie(2, 0),
                new GenericItem("Elixir of the Mongoose",5, 7),
                new Sulfuras(0, 80),
                new Sulfuras(-1, 80),
                new BackstagePasses(15, 20),
                new BackstagePasses(10, 49),
                new BackstagePasses(5, 49),
                new Conjured(3, 6),
            };

            IList<Item> Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				// this conjured item does not work properly yet
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            var app = new GildedRose(Items);
            var appNewVersion = new GildedRose(ItemsNewVersion);

            for (int i = 0; i < 31; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                //for (var j = 0; j < Items.Count; j++)
                //{
                //    System.Console.WriteLine(Items[j].Name + ", " + Items[j].SellIn + ", " + Items[j].Quality);
                //}

                for (var j = 0; j < ItemsNewVersion.Count; j++)
                {
                    System.Console.WriteLine(ItemsNewVersion[j].Name + ", " + ItemsNewVersion[j].SellIn + ", " + ItemsNewVersion[j].Quality);
                }

                Console.WriteLine("");
                appNewVersion.UpdateQualityNewVersion();
                //app.UpdateQuality();
            }
        }
    }
}
