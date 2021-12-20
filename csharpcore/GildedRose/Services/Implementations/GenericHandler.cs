
using GildedRose.Services.Contracts;
using GildedRoseKata;

namespace GildedRose.Services.Implementations
{
    /// <summary>
    /// Base handler to item quality update.
    /// </summary>
    public class GenericHandler : IItemQualityHandler
    {
        /// <summary>
        /// A factor used to increase or decrease item quality.
        /// </summary>
        protected int QualityFactor { get; set; }

        protected int QualityMaxValue { get; set; }

        public GenericHandler(int qualityFactor = 1)
        {
            QualityFactor = qualityFactor;
            QualityMaxValue = 50;
        }
        public virtual void CheckQualityMaxValue(ref Item item) 
        {
            if (item.Quality > QualityMaxValue) item.Quality = QualityMaxValue;
        }

        public virtual void UpdateQuality(ref Item item)
        {
            item.Quality = item.Quality - QualityFactor;
        }

        public virtual void CheckQualityMinValue(ref Item item) 
        {
            // The Quality of an item is never negative
            if (item.Quality < 0) item.Quality = 0;
        }

        public virtual void UpdateSellIn(ref Item item)
        {
            item.SellIn = item.SellIn - 1;
        }
    }
}
