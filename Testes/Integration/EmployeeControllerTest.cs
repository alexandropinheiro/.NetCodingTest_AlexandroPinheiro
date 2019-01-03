using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Testes.Env;
using Xunit;

namespace Testes.Integration
{
    public class EmployeeControllerTest
    {
        public EmployeeControllerTest()
        {
            Environment.CriarServidor();
        }

        [Fact(DisplayName = "Employee registrado com sucesso")]
        [Trait("Category", "Testes de integração API")]
        public async Task EmployeeController_GravarEmployee_RetornarComSucesso()
        {
            var employeeViewModel = new EmployeeViewModel
            {
                Name = "Teste",
                Email = "teste@teste.com.br",
                Department = "TESTE"
            };

            // Act
            var response = await Environment.Server
                .CreateRequest("api/employee")
                .And(
                    request =>
                        request.Content =
                            new StringContent(JsonConvert.SerializeObject(employeeViewModel), Encoding.UTF8, "application/json"))
                .PostAsync();

            var employeeResult = JsonConvert.DeserializeObject<EmployeeReturnDTO>(await response.Content.ReadAsStringAsync());

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal("Teste", employeeResult.Name);
            Assert.Equal("teste@teste.com.br", employeeResult.Email);
            Assert.Equal("TESTE", employeeResult.Department);
        }
    }
}
