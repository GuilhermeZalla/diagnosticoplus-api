using APITCC2021.Models;
using System.Collections.Generic;
using System.Linq;

namespace APITCC2021.Data
{
    public class Seeds
    {
        private readonly Context _context;

        public Seeds(Context context)
        {
            _context = context;
        }

        public void SeedTables()
        {
            if (!_context.Doencas.Any())
            {
                var doencas = new List<Doenca>();
                doencas.Add(new Doenca("Febre Amarela", "A febre amarela é transmitida por mosquitos a pessoas não vacinadas em áreas de mata. A vacinação está disponível nos postos de saúde de todo o país e é recomendada para pessoas que habitam ou visitam áreas com risco da doença. Uma dose apenas garante imunidade por toda a vida. Os sintomas se apresentam em uma janela de tempo que vai de 3 a 6 dias após a picada do mosquito.Por isso, é importante observar se você se lembra de ter sido picado por um quando apresentar sintomas como os listados acima."));
                doencas.Add(new Doenca("Covid-19", "A Covid-19 é uma infecção respiratória aguda causada pelo coronavírus SARS-CoV-2, potencialmente grave, de elevada transmissibilidade e de distribuição global. Os coronavírus são uma grande família de vírus comuns em muitas espécies diferentes de animais, incluindo o homem, camelos, gado, gatos e morcegos.Raramente os coronavírus de animais podem infectar pessoas e depois se espalhar entre seres humanos como já ocorreu com o MERS - CoV e o SARS - CoV - 2.Até o momento, não foi definido o reservatório silvestre do SARS - CoV - 2."));
                doencas.Add(new Doenca("H1N1", "Infecção respiratória em humanos causada por uma cepa de influenza que surgiu pela primeira vez nos porcos. A gripe suína foi reconhecida pela primeira vez na pandemia de 1919 e ainda circula como um vírus da gripe sazonal.A gripe suína é causada pela cepa de vírus H1N1, que começou em porcos. Os sintomas incluem febre, tosse, dor de garganta, calafrios e dores no corpo. O tratamento típico inclui repouso, analgésicos e líquidos."));
                doencas.Add(new Doenca("Gripe", "Uma infecção viral comum que pode ser fatal, especialmente em grupos de alto risco. A gripe ataca os pulmões, o nariz e a garganta.Crianças pequenas, idosos, gestantes e pessoas com doenças crônicas ou imunidade baixa correm alto risco. Os sintomas incluem febre, calafrios, dores musculares, tosse, congestão, coriza, dores de cabeça e fadiga. A gripe é tratada principalmente com repouso e ingestão de líquidos para permitir que o corpo combata a infecção por conta própria.Analgésicos anti - inflamatórios vendidos sem prescrição médica podem ajudar com os sintomas."));
                doencas.Add(new Doenca("Dengue", " Doença viral transmitida por mosquitos que ocorre em áreas tropicais e subtropicais. Pessoas infectadas com o vírus pela segunda vez têm um risco significativamente maior de desenvolver doença grave. Os sintomas são febre alta, erupções cutâneas e dores musculares e articulares.Em casos graves, há hemorragia intensa e choque hemorrágico(quando uma pessoa perde mais de 20 % do sangue ou fluido corporal), o que pode ser fatal. O tratamento inclui ingestão de líquidos e analgésicos. Os casos graves exigem cuidados hospitalares."));

                _context.Doencas.AddRange(doencas);
                _context.SaveChanges();
            }

            if (!_context.Sintomas.Any())
            {
                var sintomas = new List<Sintoma>();
                sintomas.Add(new Sintoma("Febre"));
                sintomas.Add(new Sintoma("Dor de cabeça"));
                sintomas.Add(new Sintoma("Dores musculares"));
                sintomas.Add(new Sintoma("Dor nas articulações"));
                sintomas.Add(new Sintoma("Dor de garganta"));
                sintomas.Add(new Sintoma("Dor no peito"));
                sintomas.Add(new Sintoma("Dor/irritação nos olhos"));
                sintomas.Add(new Sintoma("Vômitos"));
                sintomas.Add(new Sintoma("Manchas/erupções na pele"));
                sintomas.Add(new Sintoma("Cansaço"));
                sintomas.Add(new Sintoma("Tosse"));
                sintomas.Add(new Sintoma("Diarreia"));
                sintomas.Add(new Sintoma("Calafrios"));
                sintomas.Add(new Sintoma("Icterícia"));
                sintomas.Add(new Sintoma("Comprometimento do fígado"));
                sintomas.Add(new Sintoma("Sangramentos"));
                sintomas.Add(new Sintoma("Urina avermelhada"));
                sintomas.Add(new Sintoma("Perda de paladar"));
                sintomas.Add(new Sintoma("Dificuldade de respirar"));
                sintomas.Add(new Sintoma("Perda de movimentos"));
                sintomas.Add(new Sintoma("Falta de apetite"));
                sintomas.Add(new Sintoma("Coriza"));

                _context.Sintomas.AddRange(sintomas);
                _context.SaveChanges();
            }

            if (!_context.AssociacaoDoencasSintomas.Any())
            {
                var associacoes = new List<AssociacaoDoencaSintoma>();
                associacoes.Add(new AssociacaoDoencaSintoma(1, 17));
                associacoes.Add(new AssociacaoDoencaSintoma(2, 17));
                associacoes.Add(new AssociacaoDoencaSintoma(3, 17));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 17));
                associacoes.Add(new AssociacaoDoencaSintoma(5, 17));

                associacoes.Add(new AssociacaoDoencaSintoma(1, 18));
                associacoes.Add(new AssociacaoDoencaSintoma(2, 18));
                associacoes.Add(new AssociacaoDoencaSintoma(3, 18));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 18));
                associacoes.Add(new AssociacaoDoencaSintoma(5, 18));

                associacoes.Add(new AssociacaoDoencaSintoma(1, 19));
                associacoes.Add(new AssociacaoDoencaSintoma(2, 19));
                associacoes.Add(new AssociacaoDoencaSintoma(3, 19));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 19));
                associacoes.Add(new AssociacaoDoencaSintoma(5, 19));

                associacoes.Add(new AssociacaoDoencaSintoma(2, 1));
                associacoes.Add(new AssociacaoDoencaSintoma(3, 1));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 1));

                associacoes.Add(new AssociacaoDoencaSintoma(3, 14));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 14));
                associacoes.Add(new AssociacaoDoencaSintoma(5, 14));

                associacoes.Add(new AssociacaoDoencaSintoma(3, 15));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 15));
                associacoes.Add(new AssociacaoDoencaSintoma(5, 15));

                associacoes.Add(new AssociacaoDoencaSintoma(1, 13));
                associacoes.Add(new AssociacaoDoencaSintoma(2, 13));
                associacoes.Add(new AssociacaoDoencaSintoma(5, 13));

                associacoes.Add(new AssociacaoDoencaSintoma(2, 12));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 12));
                associacoes.Add(new AssociacaoDoencaSintoma(5, 12));

                associacoes.Add(new AssociacaoDoencaSintoma(2, 11));
                associacoes.Add(new AssociacaoDoencaSintoma(3, 11));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 11));

                associacoes.Add(new AssociacaoDoencaSintoma(2, 10));
                associacoes.Add(new AssociacaoDoencaSintoma(3, 10));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 10));

                associacoes.Add(new AssociacaoDoencaSintoma(3, 9));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 9));

                associacoes.Add(new AssociacaoDoencaSintoma(3, 21));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 21));

                associacoes.Add(new AssociacaoDoencaSintoma(3, 22));
                associacoes.Add(new AssociacaoDoencaSintoma(4, 22));

                associacoes.Add(new AssociacaoDoencaSintoma(5, 20));

                associacoes.Add(new AssociacaoDoencaSintoma(2, 16));

                associacoes.Add(new AssociacaoDoencaSintoma(1, 8));

                associacoes.Add(new AssociacaoDoencaSintoma(1, 7));

                associacoes.Add(new AssociacaoDoencaSintoma(5, 6));

                associacoes.Add(new AssociacaoDoencaSintoma(5, 5));

                associacoes.Add(new AssociacaoDoencaSintoma(2, 4));

                associacoes.Add(new AssociacaoDoencaSintoma(2, 3));

                associacoes.Add(new AssociacaoDoencaSintoma(2, 2));

                _context.AssociacaoDoencasSintomas.AddRange(associacoes);
                _context.SaveChanges();
            }
        }
    }
}
