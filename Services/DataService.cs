using System.Reflection;

namespace Services;

public class DataService<T> : IDataService<T>
{
    private List<T> items;

    public DataService(List<T> initialItems)
    {
        items = initialItems ?? new List<T>();
    }

    public List<T> GetAll()
    {
        return items;
    }

    public T GetById(int id)
    {
        return items.FirstOrDefault(i => i.GetType().GetProperty("Id")?.GetValue(i, null) as int? == id);
    }
    public void Add(T item)
    {
        items.Add(item);
    }

    public void Delete(int id)
    {
        var itemToDelete = items.FirstOrDefault(i => i.GetType().GetProperty("Id")?.GetValue(i, null) as int? == id);
        items.Remove(itemToDelete);
    }

    public void Update(T item)
    {
        PropertyInfo idProperty = typeof(T).GetProperty("Id");
        int? itemId = item.GetType().GetProperty("Id")?.GetValue(item, null) as int?;

        int index = items.FindIndex(i => (int?)idProperty.GetValue(i, null) == itemId);

        items[index] = item;
    }
}
