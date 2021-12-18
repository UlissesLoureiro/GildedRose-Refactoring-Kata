using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class GenericItem : Item, IItem
    {
        private readonly GenericHandler _handler;

        public GenericItem(string name, int sellIn, int quality)
        {
            _handler = new GenericHandler();
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }


        public Item UpdateItem(Item item)
        {
            _handler.UpdateQuality(ref item);
            _handler.CheckQualityMaxValue(ref item);
            item.CheckQualityMinValue();
            item.UpdateSellIn();
            return item;
        }
    }
}
