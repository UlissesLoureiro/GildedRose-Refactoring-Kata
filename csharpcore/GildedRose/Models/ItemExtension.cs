

using GildedRoseKata;

namespace GildedRose.Models
{
    public static class ItemExtension
    {

        public static void CheckQualityMinValue(this Item item)
        {
            // The Quality of an item is never negative
            if (item.Quality < 0) item.Quality = 0;
        }

        public static void UpdateSellIn(this Item item)
        {
            item.SellIn = item.SellIn - 1;

        }
    }
}
