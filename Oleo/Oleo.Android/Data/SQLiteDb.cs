using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Oleo.Droid;
using Oleo.Data;
using SQLite;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(SQLiteDb))]
namespace Oleo.Droid
{
    public class SQLiteDb :ISQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
           
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, "Oleo.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}