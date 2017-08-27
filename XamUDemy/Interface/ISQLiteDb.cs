using System;
using SQLite;

namespace XamUDemy.Pages
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
