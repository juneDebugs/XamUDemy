using System;
using SQLite;
namespace XamUDemy.Pages
{
    public class ISQLiteDb
    {
        public ISQLiteDb()
        {
            SQLiteAsyncConnection GetConnection();
        }
    }
}
