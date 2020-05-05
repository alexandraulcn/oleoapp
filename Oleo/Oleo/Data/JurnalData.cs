using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using Oleo.Models;

namespace Oleo.Data
{
    public class JurnalData
    {
        readonly SQLiteAsyncConnection _database;
        public JurnalData(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Jurnal>().Wait();
        }

        public Task<List<Jurnal>> GetBlendsAsync()
        {
            return _database.Table<Jurnal>().ToListAsync();
        }

        public Task<Jurnal> GetBlendAsync(int id)
        {
            return _database.Table<Jurnal>()
                .Where(i => i.ID == id)
                .FirstOrDefaultAsync();
        }

        public Task<int> SaveBlendAsync(Jurnal blend)
        {
            if (blend.ID != 0)
            {
                return _database.UpdateAsync(blend);
            }
            else
            {
                return _database.InsertAsync(blend);
            }
        }

        public Task<int> DeleteBlendAsync(Jurnal blend)
        {
            return _database.DeleteAsync(blend);
        }
    }
}
