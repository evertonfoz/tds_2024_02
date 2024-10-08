using EstoqueResidencial.Modelo.Basicas;
using EstoqueResidencial.Persistencia.EFCore.Database.Contexts;
using EstoqueResidencial.Persistencia.EFCore.Repositorios;

var efDbContext = new SqliteEFCoreContext();
efDbContext.Database.EnsureCreated();//garante que o banco de dados foi criado de forma correta
var repositorioEF = new RepositorioCRUDGenericoEFCore<CategoriaModelo>(efDbContext);
var repositorioEFUnidMed = new RepositorioCRUDGenericoEFCore<UnidadeMedidaModelo>(efDbContext);

repositorioEF.Adicionar(efDbContext.Categorias, new CategoriaModelo(1, "Higiene", "Sabonete"));
repositorioEFUnidMed.Adicionar(efDbContext.UnidadesMedida, new UnidadeMedidaModelo(1, "Quantidade", 20));

foreach (var categoria in repositorioEF.ObterTodos(efDbContext.Categorias))
{
    Console.Write(categoria);
}

Console.WriteLine();

foreach (var unidade in repositorioEFUnidMed.ObterTodos(efDbContext.UnidadesMedida))
{
    Console.Write(unidade);
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
