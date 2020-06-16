using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using Oleo.iOS.Persistence;
using Oleo.Persistence;
using SQLite;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]
namespace Oleo.iOS.Persistence
{
    class SQLiteDb : ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, "Oleo.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}