using LiteDB;
using System;
using System.IO;

namespace TheTvTracker.Data.Access
{
  public sealed class DbHandler
  {
    private static readonly Lazy<DbHandler> lazy = new Lazy<DbHandler>(() => new DbHandler());
    public static DbHandler Instance
    {
      get => lazy.Value;
    }

    private string basePath = $".{Path.DirectorySeparatorChar}Data{Path.DirectorySeparatorChar}Data.db";

    private LiteDatabase _db;
    public LiteDatabase Db
    {
      get
      {
        if (_db == null)
        {
          _db = new LiteDatabase(@Path.GetFullPath(basePath));
        }
        return _db;
      }
    }

    private DbHandler()
    {
      if (!Directory.Exists("Data"))
      {
        Directory.CreateDirectory("Data");
      }
    }
  }
}
