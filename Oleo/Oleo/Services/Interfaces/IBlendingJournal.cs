using Oleo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oleo.Services
{
    public interface IBlendingJournal
    {
        Task<IEnumerable<Blend>> GetBlendsAsync();
        Task<Blend> GetBlend(int id);
        Task AddBlend(Blend blend);
        Task UpdateBlend(Blend blend);
        Task DeleteBlend(Blend blend);
    }
}
