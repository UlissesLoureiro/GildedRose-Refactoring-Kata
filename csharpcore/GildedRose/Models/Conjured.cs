using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;
using System;

namespace GildedRose.Models
{
    public class Conjured : Item, IItem<Conjured>
    {
        private readonly GenericHandler _handler;

        public Conjured(string name, int sellIn, int quality)
        {
            _handler = new GenericHandler();
            Name = name;
            Quality = quality;
            SellIn = sellIn;
        }


        public Conjured UpdateItem(Conjured item)
        {
            _handler.UpdateQuality(ref item);
            _handler.CheckQualityMaxValue(ref item);
            item.CheckQualityMinValue();
            item.UpdateSellIn();
            return item;
        }
    }
}
