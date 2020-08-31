using FoodServiceApi.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using XUnitTestFoodService.InterfaceApi;

namespace XUnitTestFoodService
{
    public class ProdutoTest
    {
        private InterfaceProdutoApi webApi;
        public ProdutoTest()
        {
            webApi = RestService.For<InterfaceProdutoApi>("https://localhost:5001");
        }

        [Fact]
        public async void Produto_create_ResultSucesso()
        {

            //Arrage
            var produtoModel = new ProdutoModel();
            produtoModel.nome = "Ceveja Heineken";
            produtoModel.descricao = "Bebida alcoólica";
            produtoModel.valor = 13.50m;

            //Act;
            var result = await webApi.CreateProdutoAsync(produtoModel);

            //Assert
            Assert.Equal("True", result.Success);
        }

    }
}
