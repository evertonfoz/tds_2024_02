using System;

namespace EstoqueResidencial.Modelo.Interfaces.Repositorios;

public interface IRepositorioCRUDGenerico<T> where T : class
{
    void Adicionar(T entidade);

    T? ObterPorId(int id);

    IEnumerable<T> ObterTodos();

    void Atualizar(T entidade);

    void Remover(T entidade);
}
