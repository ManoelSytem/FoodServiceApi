using FoodServiceApi.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTestFoodService.InterfaceApi;

namespace XUnitTestFoodService
{
    public class ClienteTest
    {
        private InterfaceClienteApi webApi;
        public ClienteTest()
        {
            webApi = RestService.For<InterfaceClienteApi>("https://localhost:5001");
        }

        
        [Fact]
        public async void Cliente_create_ResultSucesso()
        {

            //Arrage
            var clienteModel = new ClienteModel()
            {
                nome = "Bit Stop",
                descricao = "Seu ponto certo é aqui",
                endereco = "Avenida Pinto de Aguir, 245",
                contato = "8594281221",
                email = "bitstop@gmail.com",
            };
          
            //Act;
            var result = await webApi.CreateClienteAsync(clienteModel);

            //Assert
            Assert.Equal("True", result.Success);
        }
    }
}
