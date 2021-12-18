using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class GenericItem : Item, IItem<GenericItem>
    {
        private readonly GenericHandler _handler;

        public GenericItem(string name, int sellIn, int quality)
        {
            _handler = new GenericHandler();
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }


        public GenericItem UpdateItem(GenericItem item)
        {
            _handler.UpdateQuality(ref item);
            _handler.CheckQualityMaxValue(ref item);
            item.CheckQualityMinValue();
            item.UpdateSellIn();
            return item;
        }
    }
}
