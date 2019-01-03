using Domain.Employees;
using Infra.Context;
using Infra.Repository;
using Infra;
using System;
using Xunit;
using Domain;

namespace Testes.Infra
{
    public class EmployeeRepositoryTest : TesteBase, IDisposable
    {
        private IEmployeeRepository _repository;
        private readonly IUnitOfWork _uow;

        public EmployeeRepositoryTest()
        {
            //Setup();
            //_repository = new EmployeeRepository(EmployeeContext);
            //_uow = new UnitOfWork(EmployeeContext);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //[Fact]
        //public void Gravar_Venda()
        //{
        //    #region Teste de insert e retornar 1 objeto
        //    var vendaFactory = new EmployeeFactory(110, 120);
        //    var venda = new Ve vendaFactory.Criar();

        //    _repository.Gravar(venda);
        //    _uow.Commit();

        //    var _vendas = _repository.ObterTodos();
        //    Assert.Single(_vendas);

        //    #endregion

        //    #region retornar 2 objetos
        //    var vendaFactory2 = new EmployeeFactory(50, 90);
        //    var venda2 = vendaFactory.Criar();

        //    _repository.Gravar(venda2);
        //    _uow.Commit();

        //    var _vendas2 = _repository.ObterTodos();

        //    Assert.Equal(2, _vendas2.Count);
        //    #endregion
        //}

        //public void Dispose()
        //{
        //    var vendas = _repository.ObterTodos();
        //    foreach(var v in vendas)
        //        Context.Remove<Venda>(v);

        //    Context.SaveChanges();

        //    TearDown();
        //}
    }
}
