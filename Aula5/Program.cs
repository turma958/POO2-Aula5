var repo = new BaseRepository<Aluno, Guid>();

var id = Guid.NewGuid();
await repo.Add(new Aluno
{
    Id = id,
    Nome = "Davi"
});

var getAluno = await repo.Get(id);
var listAluno = await repo.List();

Console.ReadLine();

class Aluno : BaseModel<Guid>
{
    public string Nome { get; set; }
}

interface IBaseRepository<T, TKey>
{
    Task Add(T objeto);
    Task Remove(TKey id);
    Task<T?> Get(TKey id);
    Task<IEnumerable<T>> List();
}

abstract class BaseModel<TKey>
{
    public TKey Id { get; set; }
}

class BaseRepository<T, TKey> : IBaseRepository<T, TKey> where T : BaseModel<TKey>
{
    private List<T> list = new List<T>();

    public async Task Add(T objeto)
    {
        await Task.Delay(100);
        list.Add(objeto);
    }

    public async Task<T?> Get(TKey id)
    {
        await Task.Delay(100);
        return list.FirstOrDefault(x => x.Id.Equals(id));
    }

    public async Task<IEnumerable<T>> List()
    {
        await Task.Delay(100);
        return list;
    }

    public async Task Remove(TKey id)
    {
        var objeto = await Get(id);

        if (objeto != null)
            list.Remove(objeto);
    }
}