using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class AgedBrie : Item, IItem<AgedBrie>
    {
        private readonly AgedBrieHandler _handler;

        public AgedBrie(int sellIn, int quality)
        {
            _handler = new AgedBrieHandler();
            Name = "Aged Brie";
            Quality = quality;
            SellIn = sellIn;
        }

        //return the object for unit testing purposes
        public AgedBrie UpdateItem(AgedBrie item)
        {
            _handler.UpdateQuality(ref item);
            _handler.CheckQualityMaxValue(ref item);
            item.CheckQualityMinValue();
            item.UpdateSellIn();
            return item;
        }


    }
}
