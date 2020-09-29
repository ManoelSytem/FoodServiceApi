using Aplication.Servico;
using BusinessLogic.Servico;
using Dominio;
using FoodServiceApi.Controllers;
using FoodServiceApi.Model;
using Moq;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using XUnitTestFoodService.InterfaceApi;

namespace XUnitTestFoodService
{
    public class CardapioTest
    { 
        private InterfaceApiCardapio webApi;
        public CardapioTest()
        {
             webApi = RestService.For<InterfaceApiCardapio>("https://localhost:5001");
        }
        [Fact]
        public async void Cardapio_CriarCadapio_ResultSucesso()
        {

            //Arrage
            var cardapioModel = new CardapioModel();
            cardapioModel.idUser = "2";
            cardapioModel.titulo = "Divina Picanha";

            //Act
            var result = await webApi.CreateCardapioAsync(cardapioModel);
          
            //Assert
            Assert.Equal("True",result.Success);
        }

        [Fact]
        public async void Cardapio_CreateListaCardapio_ResultSucesso()
        {

            //Arrage
            var listaCardapio = new MenuModel();
            listaCardapio.codigoCardapio = 1;
            listaCardapio.titulo = "Bebidas";
            listaCardapio.descricao = "Bebida alcoólica e referigerantes";
            listaCardapio.ListCodProduto = new List<int>
            {
                1,2,3
            };
            //Act
            var result = await webApi.CreateListaCardapioAsync(listaCardapio);

            //Assert
            Assert.Equal("True", result.Success);
        }
    }
}
