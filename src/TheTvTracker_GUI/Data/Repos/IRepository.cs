using LiteDB;
using System.Collections.Generic;

namespace TheTvTracker.Data.Repos
{
  public interface IRepository<T>
  {
    public void Add(T obj);
    public void Update(T obj);
    public void Remove(T obj);
    public bool Exists(T obj);
    public void AddWithCheck(T obj);
    public int Count();
    public IList<T> GetAll();
    public void RefreshIndexes();
    public ILiteCollection<T> GetCollection();
  }
}
