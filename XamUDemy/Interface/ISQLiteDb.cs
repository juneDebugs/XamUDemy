using System;
using SQLite;

namespace XamUDemy.Interface
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
