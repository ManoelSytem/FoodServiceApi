using Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Negocio
{
    public class CardapoNegocio
    {
        public CardapoNegocio()
        {
                
        }

        public List<ListaItemProduto> MontarListaMenuCardapio(int idCardapio, string titulo, string descricao, List<int> listCodProduto)
        {
            List<ListaItemProduto> novaLista = new List<ListaItemProduto>();

            foreach(int idProduto in listCodProduto)
            {
                var listModel = new ListaItemProduto
                {
                    codigoCardapio = idCardapio,
                    titulo = titulo,
                    descricao = descricao,
                    codProduto = idProduto
                };
                novaLista.Add(listModel);
            }

            return novaLista;
        }
    }
}
