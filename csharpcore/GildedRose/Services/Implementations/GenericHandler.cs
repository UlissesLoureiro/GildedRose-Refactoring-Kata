
using GildedRoseKata;

namespace GildedRose.Services.Implementations
{
    public class GenericHandler
    {
        protected int QualityFactor { get; set; }

        public GenericHandler(int qualityFactor = 1)
        {
            QualityFactor = qualityFactor;
        }
        public virtual void CheckQualityMaxValue<T>(ref T item) where T : Item
        {
            if (item.Quality > 50) item.Quality = 50;
        }


        public virtual void UpdateQuality<T>(ref T item) where T : Item
        {
            item.Quality = item.Quality - QualityFactor;
        }
    }
}
