using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class Sulfuras : Item, IItem<Sulfuras>
    {
        private readonly SulfurasHandler _handler;

        public Sulfuras(int sellIn, int quality)
        {
            _handler = new SulfurasHandler();
            Name = "Sulfuras, Hand of Ragnaros";
            Quality = quality;
            SellIn = sellIn;
        }


        public Sulfuras UpdateItem(Sulfuras item)
        {
            return item;
        }
    }
}
