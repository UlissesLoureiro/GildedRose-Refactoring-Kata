using GildedRose.Services.Contracts;
using GildedRose.Services.Implementations;
using GildedRoseKata;
using System;

namespace GildedRose.Models
{
    public class Conjured : GenericItem
    {
        public Conjured(int sellIn, int quality)
            : base("Conjured", sellIn, quality)
        {
            _handler = new ConjuredHandler();
        }
    }
}
