class Bag
{
    private List<Item> _items;
    public int MaxWeidth { get; private set; }
    public void AddItem(string name, int count)
    {
        int currentWeidth = _items.Sum(item => item.Count);
        Item targetItem = _items.FirstOrDefault(item => item.Name == name);

        if (targetItem == null)
            throw new InvalidOperationException();

        if (currentWeidth + count > MaxWeidth)
            throw new InvalidOperationException();

        targetItem.Count += count;
    }

    public IEnumerable<IItem> GetItems() => _items;
}
interface IItem
{
    int GetCount();
    string GetName();
}
class Item : IItem
{
    public int Count;
    public string Name;

    public int GetCount() => Count;

    public string GetName() => Name;
}