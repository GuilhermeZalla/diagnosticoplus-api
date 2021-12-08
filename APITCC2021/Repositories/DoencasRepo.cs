using APITCC2021.Data;
using APITCC2021.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITCC2021.Repositories
{
    public class DoencasRepo
    {
        private readonly Context _context;
        public DoencasRepo(Context context)
        {
            _context = context;
        }

        public async Task<List<Doenca>> GetDoencas()
        {
            var resp = await _context.Doencas.ToListAsync();
            return resp;
        }

        public async Task<Doenca> GetDoencaById(int doencaId)
        {
            var resp = await _context.Doencas.Where(c => c.Id == doencaId).FirstOrDefaultAsync();
            return resp;
        }
    }
}
