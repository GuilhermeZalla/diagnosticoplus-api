using APITCC2021.Data;
using APITCC2021.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITCC2021.Repositories
{
    public class SintomasRepo
    {
        private readonly Context _context;
        public SintomasRepo(Context context)
        {
            _context = context;
        }

        public async Task<List<Sintoma>> GetSintomas()
        {
            var resp = await _context.Sintomas.ToListAsync();
            return resp;
        }

        public async Task<Sintoma> GetSintomaById(int sintomaId)
        {
            var resp = await _context.Sintomas.Where(c => c.Id == sintomaId).FirstOrDefaultAsync();
            return resp;
        }
    }
}
