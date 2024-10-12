using EstoqueResidencial.Modelo.Basicas;
using EstoqueResidencial.Persistencia.EFCore.Database.Contexts;
using EstoqueResidencial.Persistencia.EFCore.Repositorios;

var efDbContext = new SqliteEFCoreContext();

efDbContext.Database.EnsureCreated();
/*
var repositorioEF = new RepositorioCRUDGenericoEFCore<CategoriaModelo>(efDbContext);
repositorioEF.Adicionar(efDbContext.Categorias, new CategoriaModelo(1, "Higiene", "Sabonete"));
foreach (var categoria in repositorioEF.ObterTodos(efDbContext.Categorias))
{
    Console.Write(categoria);
}*/

var repositorioFornecedor = new RepositorioCRUDGenericoEFCore<FornecedorModelo>(efDbContext);

var repositorioUnidade = new RepositorioCRUDGenericoEFCore<UnidadeMedidaModelo>(efDbContext);

repositorioFornecedor.Adicionar(efDbContext.Fornecedores, new FornecedorModelo(1, "Supermercado", "1234-5678", "Rua A, 123"));

repositorioUnidade.Adicionar(efDbContext.UnidadesMedida, new UnidadeMedidaModelo(1, "Quilos", "KG", 20));

foreach (var fornecedor in repositorioFornecedor.ObterTodos(efDbContext.Fornecedores))
{
    Console.Write(fornecedor);
}


foreach (var unidadeMedida in repositorioUnidade.ObterTodos(efDbContext.UnidadesMedida))
{
    Console.Write(unidadeMedida);
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
