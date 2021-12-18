using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;

namespace GildedRose.Models
{
    public class BackstagePasses : Item, IItem<BackstagePasses>
    {
        private readonly BackstagePassesHandler _handler;

        public BackstagePasses(int sellIn, int quality)
        {
            _handler = new BackstagePassesHandler();
            Name = "Backstage passes to a TAFKAL80ETC concert";
            Quality = quality;
            SellIn = sellIn;
        }

        //return the object for unit testing purposes
        public BackstagePasses UpdateItem(BackstagePasses item)
        {
            _handler.UpdateQuality(ref item);
            _handler.CheckQualityMaxValue(ref item);
            item.CheckQualityMinValue();
            item.UpdateSellIn();
            return item;
        }

    }
}
