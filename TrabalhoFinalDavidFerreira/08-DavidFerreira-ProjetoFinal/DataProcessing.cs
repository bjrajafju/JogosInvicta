using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_DavidFerreira_ProjetoFinal
{
    public static class DataProcessing
    {
        static public Cliente retrieveSingleClient(int idCliente)
        {
            List<List<string>> clients = DataManagement.retrieveStrings(GlobalVars.strProvider, "Cliente", "*", "IdCliente = " + idCliente);

            Cliente returnClient = new Cliente(Convert.ToInt32(clients[0][0]));
            returnClient.NomeCliente = clients[0][1];
            returnClient.Telefone = clients[0][2];
            returnClient.Email = clients[0][3];
            returnClient.Address = clients[0][4];
            returnClient.CodPostal = clients[0][5];
            returnClient.Cidade = clients[0][6];
            returnClient.Pais = new Pais(Convert.ToInt32(clients[0][7]), DataManagement.retrieveSingleColumn(GlobalVars.strProvider, "Paises", "Pais", "IdPais = " + Convert.ToInt32(clients[0][7]))[0]);
            returnClient.Password = clients[0][8];
            return returnClient;
        }

        static public List<Compra> retrieveCompras(Cliente cliente)
        {
            List<Compra> list = new List<Compra> ();

            List<List<string>> strs = DataManagement.retrieveStrings(GlobalVars.strProvider,"Compra","*","IdCliente = "+cliente.Id);

            for (int i = 0; i < strs.Count; i++)
            {
                Compra novaCompra = new Compra(Convert.ToInt32(strs[i][0]),cliente, Convert.ToDateTime(strs[i][1]),new Estado(Convert.ToInt32(strs[i][2]),DataManagement.retrieveSingleColumn(GlobalVars.strProvider, "Estado", "estadoCompra", "IdEstado ="+strs[i][2])[0]));
                list.Add(novaCompra);   
            }
            return list;
        }


        static public List<LinhasDoCarrinho> retrieveShoppingLines(int idCliente = -1)
        {
            List<List<string>> strs = DataManagement.retrieveStrings(GlobalVars.strProvider, "LinhasCarrinho", "*", (idCliente != -1?"IdCliente = " + idCliente:null));

            List<LinhasDoCarrinho> lines = new List<LinhasDoCarrinho> ();

            for (int i = 0; i < strs.Count; i++)
            {
                lines.Add(new LinhasDoCarrinho(retrieveProducts(Convert.ToInt32(strs[i][1]))[0], Convert.ToInt32(strs[i][2])));
            }
            return lines;
        }

        static public List<CompraProduto> retrieveCompraProduto(int idCompra = -1)
        {
            List<List<string>> strs = DataManagement.retrieveStrings(GlobalVars.strProvider, "CompraProduto", "*", (idCompra != -1 ? "IdCompra = " + idCompra : null));

            List<CompraProduto> lines = new List<CompraProduto>();

            for (int i = 0; i < strs.Count; i++)
            {
                lines.Add(new CompraProduto(retrieveProducts(Convert.ToInt32(strs[i][1]))[0], Convert.ToInt32(strs[i][2])));
            }
            return lines;
        }

        static public List<Produto> retrieveProducts(int idProduto = -1)
        {
            List<List<string>> strs = DataManagement.retrieveStrings(GlobalVars.strProvider, "Produto", "*", ((idProduto!=-1 ? "IdProduto = "+ idProduto.ToString() : null)));

            List<Produto> products = new List<Produto>();

            for (int i = 0; i < strs.Count; i++)
            {
                Produto currentProduct = new Produto();

                //IdProduto->Nome->IdProdutor->unitPreco->descricao->desconto->stock->Idcat->avaliação->Franchise->Foto
                currentProduct.Id = Convert.ToInt32(strs[i][0]);
                currentProduct.NomeProduto = strs[i][1];
                currentProduct.Produtor = new Produtor(Convert.ToInt32(strs[i][2]), DataManagement.retrieveSingleColumn(GlobalVars.strProvider, "Produtor", "nomeProdutor", "IdProdutor = " + Convert.ToInt32(strs[i][2]))[0]);
                currentProduct.PrecoUnit = Convert.ToDouble(strs[i][3]);
                currentProduct.Descricao = strs[i][4];
                currentProduct.Desconto = Convert.ToDouble(strs[i][5]);
                currentProduct.Stock = Convert.ToInt16(strs[i][6]); 
                currentProduct.Categoria = new Categoria(Convert.ToInt16(strs[i][7]), DataManagement.retrieveSingleColumn(GlobalVars.strProvider, "Categoria", "categoriaProduto", "IdCategoria = " + Convert.ToInt16(strs[i][7]))[0]);
                currentProduct.AvalProd = Convert.ToByte(strs[i][8]);
                currentProduct.Franchise = new Franchise(Convert.ToInt32(strs[i][9]), DataManagement.retrieveSingleColumn(GlobalVars.strProvider, "Franchise", "NomeFranchise", "IdFranchise= " + Convert.ToInt32(strs[i][9]))[0]);
                string? imagePath = strs[i][10];

                currentProduct.Foto = Image.FromFile(".\\..\\..\\..\\..\\..\\ProductImages\\" + imagePath);

                products.Add(currentProduct);
            }
            return products;
        }

    }
}
