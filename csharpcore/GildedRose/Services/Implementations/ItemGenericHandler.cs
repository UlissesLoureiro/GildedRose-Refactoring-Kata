
using GildedRose.Models;
using GildedRoseKata;

namespace GildedRose.Services.Implementations
{
    public class ItemGenericHandler
    {
        public virtual void CheckQualityMaxValue(ref Item item)
        {
            if (item.Quality > 50) item.Quality = 50;
        }

        public virtual void UpdateItem(ref Item item)
        {

            UpdateQuality(ref item);
            CheckQualityMaxValue(ref item);
            item.CheckQualityMinValue();
            item.UpdateSellIn();
        }


        protected virtual void UpdateQuality(ref Item item)
        {
            if (item.SellIn <= 0)
            {
                item.Quality = item.Quality - 2;
                return;
            }
            else if (item.SellIn <= 5)
            {
                item.Quality = item.Quality + 3;
                return;
            }
            else if (item.SellIn <= 10)
            {
                item.Quality = item.Quality + 2;
                return;
            }

            item.Quality = item.Quality + 1;

        }
    }
}
