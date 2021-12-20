using GildedRoseKata;

namespace GildedRose.Services.Contracts
{
    public interface IItemQualityHandler
    {
        public  void CheckQualityMaxValue(ref Item item);

        public void UpdateQuality(ref Item item);

        public void CheckQualityMinValue(ref Item item);

        public void UpdateSellIn(ref Item item);
    }
}
