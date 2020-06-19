using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Oleo.Data
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
