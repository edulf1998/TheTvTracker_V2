using LiteDB;
using System;
using TheTvTracker.Data.Access;
using TheTvTracker.Data.Model;

namespace TheTvTracker.Data.Repos
{
  public sealed class UserRepo : IRepository<User>
  {
    private static readonly Lazy<UserRepo> lazy = new Lazy<UserRepo>(() => new UserRepo());
    public static UserRepo Instance
    {
      get => lazy.Value;
    }

    public void Add(User obj)
    {
      GetCollection().Insert(obj);
      RefreshIndexes();
    }

    public void AddWithCheck(User obj)
    {
      if(!Exists(obj))
      {
        Add(obj);
      }
    }

    public int Count()
    {
      return GetCollection().Count();
    }

    public bool Exists(User obj)
    {
      return GetCollection().Query().Where(u => u.Username == obj.Username).FirstOrDefault() != null;
    }

    public ILiteCollection<User> GetCollection()
    {
      return DbHandler.Instance.Db.GetCollection<User>("Users"); 
    }

    public void RefreshIndexes()
    {
      GetCollection().EnsureIndex(u => u.Username);
    }

    public void Remove(User obj)
    {
      GetCollection().DeleteMany(Query.EQ("Username", obj.Username));
      RefreshIndexes();
    }
  }
}
