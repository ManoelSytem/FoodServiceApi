using Aplication.Servico;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplication.Negocio
{
    public class ProdutoNegocio
    {
        public ProdutoNegocio()
        {
            
        }

        public void VerificaListaDeProdutoExiste(List<int> listProduto)
        {
            int codProduto = 0;
            try
            {
                ProdutoService produtodoService =  new ProdutoService();
                foreach(int codProd in listProduto)
                {
                    codProduto = codProd;
                    produtodoService.ObterProdutoPorId(codProd);
                }
                
            }
            catch (Exception e) 
            {
                throw new NotImplementedException("Produto não encontrado, código: "+codProduto);
            }
        }

    }
}
