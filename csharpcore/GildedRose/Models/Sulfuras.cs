using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class Sulfuras : Item, IItem
    {
        private readonly SulfurasHandler _handler;

        public Sulfuras(int sellIn, int quality)
        {
            _handler = new SulfurasHandler();
            Name = "Sulfuras, Hand of Ragnaros";
            Quality = quality;
            SellIn = sellIn;
        }


        public Item UpdateItem(Item item)
        {
            return item;
        }
    }
}
