using LiteDB;

namespace TheTvTracker.Data.Repos
{
  public interface IRepository<T>
  {
    public void Add(T obj);
    public void AddWithCheck(T obj);
    public void Remove(T obj);
    public bool Exists(T obj);
    public int Count();
    public void RefreshIndexes();
    public ILiteCollection<T> GetCollection();
  }
}
