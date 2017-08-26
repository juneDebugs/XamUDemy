using System;
using XamUDemy.Pages;
using SQLite;
using Xamarin.Forms;
using XamUDemy.iOS.Persistence;
using System.IO;

[assembly: Dependency(typeof(SQLiteDb))]

namespace XamUDemy.iOS.Persistence
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "MySQLite.db3");

            return new SQLiteAsyncConnection(path);
                                           
        }
    }
}
