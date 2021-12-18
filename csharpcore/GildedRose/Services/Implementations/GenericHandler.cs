
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
        public virtual void CheckQualityMaxValue(ref Item item)
        {
            if (item.Quality > 50) item.Quality = 50;
        }


        public virtual void UpdateQuality(ref Item item)
        {
            item.Quality = item.Quality - QualityFactor;

        }
    }
}
