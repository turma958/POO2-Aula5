interface IBaseRepository<T, TKey>
{
    void Add(T objeto);
    void Remove(TKey id);
    T? Get(TKey id);
    IEnumerable<T> List();
}

abstract class BaseModel<TKey>
{
    public TKey Id { get; set; }
}

class BaseRepository<T, TKey> : IBaseRepository<T, TKey> where T : BaseModel<TKey>
{
    private List<T> list = new List<T>();

    public void Add(T objeto)
    {
        list.Add(objeto);
    }

    public T? Get(TKey id)
    {
        return list.FirstOrDefault(x => x.Id.Equals(id));
    }

    public IEnumerable<T> List()
    {
        return list;
    }

    public void Remove(TKey id)
    {
        var objeto = Get(id);

        if (objeto != null)
            list.Remove(objeto);
    }
}