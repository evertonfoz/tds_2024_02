<<<<<<< HEAD
using EstoqueResidencial.Modelo.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace EstoqueResidencial.Persistencia.EFCore.Repositorios;

public class RepositorioCRUDGenericoEFCore<T>(DbContext repositorio) : IRepositorioCRUDGenericoEF<T> where T : class
{
    public void Adicionar(object tabela, T entidade)
    {
        (tabela as DbSet<T>)!.Add(entidade);
        repositorio.SaveChangesAsync();
    }

    public void Atualizar(T entidade)
    {
        DbSet<T>? dbsetTabela = tabela as DbSet<T>;
        dbsetTabela!.Update(entidade);
        repositorio.SaveChanges();
    }

    public T? ObterPorId(int id)
    {
        DbSet<T>? dbsetTabela = tabela as DbSet<T>;
        return dbsetTabela!.Find(id);
    }

    public IEnumerable<T> ObterTodos(object tabela)
    {
        DbSet<T>? dbsetTabela = tabela as DbSet<T>;
        return dbsetTabela!.ToList();
    }

    public void Remover(T entidade)
    {
        DbSet<T>? dbsetTabela = tabela as DbSet<T>;
        dbsetTabela!.Remove(entidade);
        repositorio.SaveChanges();
    }
}
=======
using EstoqueResidencial.Modelo.Interfaces.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace EstoqueResidencial.Persistencia.EFCore.Repositorios;

public class RepositorioCRUDGenericoEFCore<T>(DbContext repositorio) : IRepositorioCRUDGenericoEF<T> where T : class
{
    public void Adicionar(object tabela, T entidade)
    {
        (tabela as DbSet<T>)!.Add(entidade);
        repositorio.SaveChangesAsync();
    }

    public void Atualizar(T entidade)
    {
        throw new NotImplementedException();
    }

    public T? ObterPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> ObterTodos(object tabela)
    {
        DbSet<T>? dbsetTabela = tabela as DbSet<T>;
        return dbsetTabela!.ToList();
    }

    public void Remover(T entidade)
    {
        throw new NotImplementedException();
    }
}
>>>>>>> origin/main
