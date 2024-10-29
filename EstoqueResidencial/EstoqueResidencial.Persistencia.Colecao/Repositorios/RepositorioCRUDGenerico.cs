<<<<<<< HEAD
using System;
using EstoqueResidencial.Modelo.Interfaces.Repositorios;

namespace EstoqueResidencial.Persistencia.Colecao.Repositorios;

public class RepositorioCRUDGenericoColecoes<T>(List<T> repositorio) : IRepositorioCRUDGenerico<T> where T : class
{
    readonly List<T> repositorio = repositorio;

    public void Adicionar(T entidade)
    {
        if (repositorio.Contains(entidade))
            throw new Exception("Violação de chave primária: a entidade já existe na coleção.");
        repositorio.Add(entidade);
    }

    public void Atualizar(T entidade)
    {
        var index = repositorio.FindIndex(e => e.Equals(entidade));
        if (index == -1)
            throw new Exception("Entidade não encontrada para atualização.");
        
        repositorio[index] = entidade;
    }

    public T? ObterPorId(int id)
    {
        return repositorio.FirstOrDefault(e => (e as CategoriaModelo)?.CategoriaID == id);
    }

    public IEnumerable<T> ObterTodos()
    {
        return repositorio;
    }

    public void Remover(T entidade)
    {
        if (!repositorio.Contains(entidade))
            throw new Exception("Objeto inexistente: a entidade não foi encontrada para remoção.");
        
        repositorio.Remove(entidade);
    }
}
=======
using System;
using EstoqueResidencial.Modelo.Interfaces.Repositorios;

namespace EstoqueResidencial.Persistencia.Colecao.Repositorios;

public class RepositorioCRUDGenericoColecoes<T>(List<T> repositorio) : IRepositorioCRUDGenerico<T> where T : class
{
    readonly List<T> repositorio = repositorio;

    public void Adicionar(T entidade)
    {
        if (repositorio.Contains(entidade))
            throw new Exception("Violação de chave primária");
        repositorio.Add(entidade);
    }

    public void Atualizar(T entidade)
    {
        throw new NotImplementedException();
    }

    public T? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> ObterTodos()
    {
        return repositorio;
    }

    public void Remover(T entidade)
    {
        if (!repositorio.Contains(entidade))
            throw new Exception("Objeto inexistente");
        
        repositorio.Remove(entidade);
    }
}
>>>>>>> origin/main
