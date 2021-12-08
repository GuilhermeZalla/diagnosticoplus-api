using APITCC2021.Data;
using APITCC2021.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITCC2021.Repositories
{
    public class DiagnosticosRepo
    {
        private readonly Context _context;
        public DiagnosticosRepo(Context context)
        {
            _context = context;
        }

        public async Task<List<string>> GetResults(List<int> sintomasList)
        {
            //Buscar as associacoes dos sintoma
            var query = from item in _context.AssociacaoDoencasSintomas
                        where sintomasList.Contains(item.SintomaId)
                        select item;

            var resp = await query.ToListAsync();

            //incluir as doencas de cada associacao
            var doencas = new List<dynamic>();
            foreach (var associacao in resp)
            {
                string nome;
                if (associacao.DoencaId == 1)
                {
                    nome = "Febre Amarela";
                }
                else if (associacao.DoencaId == 2)
                {
                    nome = "Covid-19";
                }
                else if (associacao.DoencaId == 3)
                {
                    nome = "H1N1";
                }
                else if (associacao.DoencaId == 4)
                {
                    nome = "Gripe";
                }
                else
                {
                    nome = "Dengue";
                }

                doencas.Add(nome);
            }

            //Quantidade total da lista de doencas
            var total = doencas.Count();

            //ver quantas vezes cada doenca aparece na lista
            var vezesPorDoenca = new List<string>();
            foreach (var doenca in doencas)
            {
                var count = doencas.Where(x => x.Equals(doenca)).Count();
                var porcentagem = (count * 100) / total;
                vezesPorDoenca.Add(doenca + ":" + porcentagem);
            }

            //Gerar lista sem dados repetidos
            List<string> uniqueList = vezesPorDoenca.Distinct().ToList();
            return uniqueList;
        }

        public async Task<bool> SaveResults(List<string> results, int userId)
        {
            var diagnostico = new Diagnostico(String.Join(", ", results.ToArray()), DateTime.Now.Date, userId);
            await _context.Diagnosticos.AddAsync(diagnostico);
            _context.SaveChanges();

            return true;
        }

        public async Task<List<Diagnostico>> GetHistory(int userId)
        {
            var resp = await _context.Diagnosticos.Where(x => x.UsuarioId == userId).ToListAsync();
            return resp;
        }

        public async Task<bool> Delete(int diagnosticoId, int userId)
        {
            var resp = await _context.Diagnosticos.FindAsync(diagnosticoId);
            if (resp.UsuarioId != userId)
            {
                throw new System.ArgumentException("Não Autorizado.");
            }

            _context.Diagnosticos.Remove(resp);
            _context.SaveChanges();

            return true;
        }
    }
}
