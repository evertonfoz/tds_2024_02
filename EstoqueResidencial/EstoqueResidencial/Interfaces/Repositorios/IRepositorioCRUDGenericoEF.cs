<<<<<<< HEAD
using System;

namespace EstoqueResidencial.Modelo.Interfaces.Repositorios;

public interface IRepositorioCRUDGenericoEF<T> where T : class
{
    void Adicionar(object tabela, T entidade);

    T? ObterPorId(int id);

    IEnumerable<T> ObterTodos(object tabela);

    void Atualizar(T entidade);

    void Remover(T entidade);
}
=======
using System;

namespace EstoqueResidencial.Modelo.Interfaces.Repositorios;

public interface IRepositorioCRUDGenericoEF<T> where T : class
{
    void Adicionar(object tabela, T entidade);

    T? ObterPorId(int id);

    IEnumerable<T> ObterTodos(object tabela);

    void Atualizar(T entidade);

    void Remover(T entidade);
}
>>>>>>> origin/main
