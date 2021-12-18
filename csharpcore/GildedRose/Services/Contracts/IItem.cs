using GildedRoseKata;


namespace GildedRose.Services.Contracts
{
    public interface IItem
    {
        public T UpdateItem<T>(T item) where T : Item;
    }
}
