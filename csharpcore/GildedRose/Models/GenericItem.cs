using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class GenericItem : Item, IItem
    {
        protected GenericHandler _handler { get; set; }

        public GenericItem(string name, int sellIn, int quality)
        {
            _handler = new GenericHandler();
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }



        public virtual T UpdateItem<T>(T item) where T : Item
        {
            _handler.UpdateQuality(ref item);
            _handler.CheckQualityMaxValue(ref item);
            item.CheckQualityMinValue();
            item.UpdateSellIn();
            return item;
        }
    }
}
