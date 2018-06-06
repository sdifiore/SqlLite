using System;
using System.IO;
using SQLite;
using Xamarin.Forms;
using HelloWorld.Windows;
using Windows.Storage;

[assembly: Dependency(typeof(SQLiteDb))]

namespace HelloWorld.Windows
{
    public class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
			var documentsPath = ApplicationData.Current.LocalFolder.Path;
        	var path = Path.Combine(documentsPath, "MySQLite.db3");
        	return new SQLiteAsyncConnection(path);
        }
    }
}

