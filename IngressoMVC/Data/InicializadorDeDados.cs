using IngressoMVC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IngressoMVC.Data
{
    public class InicializadorDeDados
    {
        public static void Inicializar(IApplicationBuilder builder)
        {
            using(var serviceScope = builder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<IngressoDbContext>();
                context.Database.EnsureCreated();

                if (!context.Cinemas.Any())
                {
                    context.Cinemas.Add(new Cinema("Cinemark", "Texto descrição", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYYXgHaspYJSeCEqQY4aQO77SQaCfmrSNuATl6la4MazI63Jk7gkr4W9ruPKEsDL_KtV4&usqp=CAU"));
                    context.SaveChanges();
                }
                if (!context.Atores.Any())
                {
                    context.Atores.AddRange(new List<Ator>() {
                        new Ator("Robert Downey Jr.", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/5qHNjhtjMD4YWH3UP0rm4tKwxCL.jpg", "Texto descritivo"),
                        new Ator("Johnny Depp", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/ilPBHd3r3ahlipNQtjr4E3G04jJ.jpg", "Texto descritivo"),
                        new Ator("Cillian Murphy", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/i8dOTC0w6V274ev5iAAvo4Ahhpr.jpg", "Texto descritivo"),
                        new Ator("Annabelle Wallis", "https://www.themoviedb.org/t/p/w300_and_h450_bestv2/b6PltW1e18BdmRz3nKZ7ID9uZ24.jpg", "Texto descritivo")

                });
                    context.SaveChanges();
                }
                if (!context.Produtores.Any())
                {
                    context.AddRange(new List<Produtor>()
                    {
                        new Produtor("Martin Scorsese" ,"https://www.themoviedb.org/t/p/w300_and_h450_bestv2/9U9Y5GQuWX3EZy39B8nkk4NY01S.jpg","Texto descritivo"),
                        new Produtor("Tim Burton","https://www.themoviedb.org/t/p/w300_and_h450_bestv2/gRM4lGpiBINAyiXaxEeJFDKzmge.jpg","Texto descritivo")
                    });
                    context.SaveChanges();
                }
                if (!context.Categorias.Any())
                {
                    context.AddRange(new List<Categoria>()
                    {
                        new Categoria("Terror"),
                        new Categoria("Comédia"),
                        new Categoria("Ficção"),
                        new Categoria("Ação"),
                        new Categoria("Romance")
                    });
                    context.SaveChanges();
                }
                if (!context.Filmes.Any())
                {
                    context.AddRange(new List<Filme>()
                    {
                        new Filme("Peaky Blinders","Texto descritivo",30 ,"https://www.themoviedb.org/t/p/w300_and_h450_bestv2/i0uajcHH9yogXMfDHpOXexIukG9.jpg", 1, 1),
                        new Filme("Piratas do Caribe","Texto descritivo",45 ,"https://www.themoviedb.org/t/p/w300_and_h450_bestv2/rdOc15GIOGJMqgsQXHUNeVHvVzM.jpg",1 , 1 ),
                        new Filme("Homem de Ferro","Texto descritivo",20 ,"https://www.themoviedb.org/t/p/w300_and_h450_bestv2/adSJ0DpgOsMwrpUH78cZpLGOOAk.jpg",1,1),
                        new Filme("Vingadores","Texto descritivo",55 ,"https://www.themoviedb.org/t/p/w300_and_h450_bestv2/q6725aR8Zs4IwGMXzZT8aC8lh41.jpg",1,1)
                    });
                    context.SaveChanges();
                }
                if (!context.FilmesCategorias.Any())
                {
                    context.FilmesCategorias.AddRange(new List<FilmeCategoria>()
                    {
                        new FilmeCategoria(1, 4),
                        new FilmeCategoria(2, 4),
                        new FilmeCategoria(3, 3),
                        new FilmeCategoria(4, 3),
                        new FilmeCategoria(4, 2),
                        new FilmeCategoria(1, 1)
                    });
                    context.SaveChanges();
                }
                if (!context.AtoresFilmes.Any())
                {
                    context.AtoresFilmes.AddRange(new List<AtorFilme>()
                    {
                        new AtorFilme(1 ,4),
                        new AtorFilme(1, 3),
                        new AtorFilme(2, 2),
                        new AtorFilme(3, 1),
                        new AtorFilme(4, 1)
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
