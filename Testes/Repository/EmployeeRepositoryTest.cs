using Domain.Employees;
using Infra.Context;
using Infra.Repository;
using Infra;
using System;
using Xunit;
using Domain;
using System.Linq;

namespace Test.Infra
{
    public class EmployeeRepositoryTest : TestBase, IDisposable
    {
        private IEmployeeRepository _repository;
        private readonly IUnitOfWork _uow;

        public EmployeeRepositoryTest()
        {
            Setup();
            _repository = new EmployeeRepository(Context);
            _uow = new UnitOfWork(Context);
        }

        [Fact(DisplayName = "Gravar, listar e excluir dois funcionários com sucesso")]
        public void SaveRemoveEmployee()
        {
            #region Teste de insert e retornar 1 objeto
            var employee1 = new Employee
            {
                Name = "Teste1",
                Email = "teste1@icatu.com.br",
                Department = "DGI"
            };

            _repository.Gravar(employee1);
            _uow.Commit();

            var _employees1 = _repository.ObterTodos();
            Assert.Single(_employees1);

            #endregion

            #region retornar 2 objetos
            var employee2 = new Employee {
                Name = "Teste2",
                Email = "teste2@icatu.com.br",
                Department = "INFO"
            };
            
            _repository.Gravar(employee2);
            _uow.Commit();

            var _employees2 = _repository.ObterTodos();

            Assert.Equal(2, _employees2.Count);

            var _employeesRemove = _repository.ObterTodos();
            _employeesRemove.ForEach(e => _repository.Excluir(e));
            _uow.Commit();

            var _employeesEmpty = _repository.ObterTodos();
            Assert.Empty(_employeesEmpty);

            #endregion
        }

        [Fact(DisplayName = "Alterar funcionário com sucesso")]
        public void UpdateEmployee()
        {
            var employee1 = new Employee
            {
                Name = "Teste1",
                Email = "teste1@icatu.com.br",
                Department = "DGI"
            };

            _repository.Gravar(employee1);
            _uow.Commit();

            var _employees1 = _repository.ObterTodos();
            Assert.Single(_employees1);

            var employee = _employees1.FirstOrDefault();

            employee.Name = "TesteAlterado";
            employee.Email = "testealterado@icatu.com.br";
            employee.Department = "TESTE";

            _repository.Atualizar(employee);
            _uow.Commit();

            var employeeAlterado = _repository.ObterPorId(employee.Id);
            Assert.Equal("TesteAlterado", employeeAlterado.Name);
            Assert.Equal("testealterado@icatu.com.br", employeeAlterado.Email);
            Assert.Equal("TESTE", employeeAlterado.Department);
        }

        [Fact(DisplayName = "Alterar funcionário inexistente - Falha")]
        public void UpdateFailEmployee()
        {
            try {
                var employee = _repository.ObterPorId(0);
            }catch(Exception e)
            {
                Assert.Equal("Employee not found!", e.Message);
            }
        }

        [Fact(DisplayName = "Excluir funcionário inexistente - Falha")]
        public void RemoveFailEmployee()
        {
            try
            {
                var employee = _repository.ObterPorId(0);
            }
            catch (Exception e)
            {
                Assert.Equal("Employee not found!", e.Message);
            }
        }

        public void Dispose()
        {
            var employees = _repository.ObterTodos();
            foreach (var e in employees)
                Context.Remove(e);

            Context.SaveChanges();
        }
    }
}
