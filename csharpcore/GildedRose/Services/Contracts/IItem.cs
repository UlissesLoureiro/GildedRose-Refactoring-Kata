using GildedRoseKata;


namespace GildedRose.Services.Contracts
{
    public interface IItem<T> where T : Item
    {
        public T UpdateItem(T item);
    }
}
