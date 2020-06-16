using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Oleo.Persistence
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
