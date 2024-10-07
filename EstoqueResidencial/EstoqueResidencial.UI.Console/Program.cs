using EstoqueResidencial.Modelo.Basicas;
using EstoqueResidencial.Persistencia.EFCore.Database.Contexts;
using EstoqueResidencial.Persistencia.EFCore.Repositorios;

var efDbContext = new SqliteEFCoreContext();
efDbContext.Database.EnsureCreated();
var repositorioEF = new RepositorioCRUDGenericoEFCore<CategoriaModelo>(efDbContext);
var repositorioLocalizacao = new RepositorioCRUDGenericoEFCore<LocalizacaoArmazenamento>(efDbContext);

repositorioLocalizacao.Adicionar(efDbContext.Localizacoes, new LocalizacaoArmazenamento(1, "Geladeira"));
repositorioEF.Adicionar(efDbContext.Categorias, new CategoriaModelo(1, "Higiene", "Sabonete"));

foreach (var categoria in repositorioEF.ObterTodos(efDbContext.Categorias))
{
    Console.Write(categoria);
}

foreach (var localizacao in repositorioLocalizacao.ObterTodos(efDbContext.Localizacoes))
{
    Console.WriteLine(localizacao);
}

// var repositorioColecao = new RepositorioCRUDGenericoColecoes<CategoriaModelo>([]);
// repositorioColecao.Adicionar(new CategoriaModelo(1, "Higiene", "Sabonete"));
// try
// {
//     repositorioColecao.Adicionar(new CategoriaModelo(2, "Higiene", "Sabonete"));
// }
// catch (Exception e)
// {
    
//     Console.WriteLine(e.Message);
// }

// foreach (var categoria in repositorioColecao.ObterTodos())
// {
//     Console.Write(categoria);
// }

// repositorioColecao.Remover(new CategoriaModelo(3, "Higiene", "Sabonete"));
// foreach (var categoria in repositorioColecao.ObterTodos())
// {
//     Console.Write(categoria);
// }


// // CategoriaModelo sabonete1 = new (1, "Higiene", "Sabonete");

// // Console.Write(sabonete.Equals(sabonete1));