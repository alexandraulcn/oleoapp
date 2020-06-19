using Oleo.Models;
using Oleo.Services;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oleo.Data
{
    class SQLiteBlendingJournal : IBlendingJournal
    {

        private SQLiteAsyncConnection _connection;
        public SQLiteBlendingJournal(ISQLiteDb db)
        {
            _connection = db.GetConnection();
            _connection.CreateTableAsync<Blend>();
        }
        public async Task AddBlend(Blend blend)
        {
            await _connection.InsertAsync(blend);
        }

        public async Task DeleteBlend(Blend blend)
        {
            await _connection.DeleteAsync(blend);
        }

        public async Task<Blend> GetBlend(int id)
        {
            return await _connection.FindAsync<Blend>(id);
        }

        public async Task<IEnumerable<Blend>> GetBlendsAsync()
        {
            return await _connection.Table<Blend>().ToListAsync();
        }

        public async Task UpdateBlend(Blend blend)
        {
            await _connection.UpdateAsync(blend);
        }
    }
}
