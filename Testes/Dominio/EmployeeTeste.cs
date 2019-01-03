namespace Testes
{
    public class EmployeeTeste
    {
        //public EmployeeTeste()
        //{            
            
        //}

        //[Fact]
        //public void AnalizandoValorDoTroco_Correto()
        //{
        //    var venda = new Employee
        //    {
        //        Id = 1
        //    };

        //}

        //[Fact]
        //public void AnalizandoDescricaoDoTrocoDuasNotas_Correto()
        //{
        //    var venda = new Employee
        //    {
        //        Id = 1
        //    };
            
        //}

        //[Fact]
        //public void AnalizandoDescricaoDoTroco_Correto()
        //{
        //    var venda = new Venda(80, 100)
        //    {
        //        Id = Guid.NewGuid()
        //    };

        //    var valor = Valores.FirstOrDefault(x => x.ValorMonetario == 20);
        //    var idTroco = Guid.NewGuid();

        //    venda.AdicionarTroco(
        //        valor.Id,
        //        1,
        //        valor);

        //    Assert.Equal("Entregar 1 nota de R$20,00.", venda.DescricaoTroco());
        //}

        //[Fact]
        //public void AnalizandoValorInsuficiente()
        //{
        //    var venda = new Venda(100, 90)
        //    {
        //        Id = Guid.NewGuid()
        //    };
                        
        //    Assert.Equal("Valor recebido insuficiente.", venda.DescricaoTroco());
        //}

        //[Fact]
        //public void AnalizandoValorTotaleRecebidoIguais()
        //{
        //    var venda = new Venda(100, 100)
        //    {
        //        Id = Guid.NewGuid()
        //    };

        //    Assert.Equal("Não há troco.", venda.DescricaoTroco());
        //}
        
        //[Fact]
        //public void ExecutandoVendaFactory()
        //{
        //    var valorTotal = 110;
        //    var valorRecebido = 150;

        //    var vendaFactory = new EmployeeFactory(valorTotal, valorRecebido);
        //    var venda = vendaFactory.Criar();

        //    Assert.Equal(valorTotal, venda.ValorTotal);
        //    Assert.Equal(valorRecebido, venda.ValorRecebido);
        //    Assert.Equal((valorRecebido - valorTotal), venda.ValorDoTroco);
        //}

        //[Fact]
        //public void ExecutandoVendaFactoryErroValorInsuficiente()
        //{
        //    var vendaFactory = new EmployeeFactory(110, 100);

        //    try
        //    {
        //        var venda = vendaFactory.Criar();
        //        Assert.Null(venda);
        //    }catch(Exception e)
        //    {
        //        Assert.Equal("Valor recebido insuficiente.", e.Message);
        //    }
        //}

        //[Fact]
        //public void AlterarVenda()
        //{
        //    var valorTotal = 110;
        //    var valorRecebido = 150;

        //    var vendaFactory = new EmployeeFactory(valorTotal, valorRecebido);
        //    var venda = vendaFactory.Criar();
        //    Assert.Equal(40, venda.ValorDoTroco);

        //    venda.AlterarValores(170, 250);
        //    Assert.Equal(80, venda.ValorDoTroco);
        //}        
    }
}
