using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;


namespace _08_DavidFerreira_ProjetoFinal
{
    static class ProdutosRetrieval
    {
        static public Produto[] retrieveProducts(string strProvider)
        {
            Produto[] arrayProdutos = new Produto[0];

            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;

            OleDbCommand cmd = bd.CreateCommand();
            OleDbDataReader dr;

            cmd.CommandText = "SELECT * FROM Produto;";

            try
            {
                bd.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Array.Resize(ref arrayProdutos, arrayProdutos.Length + 1);
                    Produto currentProduct = new Produto();

                    //IdProduto->Nome->IdProdutor->unitPreco->descricao->desconto->stock->Idcat->avaliação
                    // NÃO TE ESQUEÇAS DE ADCIONAR FOTO E FRANCHISE
                    currentProduct.NomeProduto = dr.GetString(1);
                    currentProduct.IdProd = dr.GetInt16(2);
                    currentProduct.PrecoUnit = dr.GetDouble(3);
                    currentProduct.Descricao = dr.GetString(4);
                    currentProduct.Desconto = dr.GetDouble(5);
                    currentProduct.Stock = dr.GetInt16(6);
                    currentProduct.IdCategoria = dr.GetInt16(7);
                    currentProduct.AvalProd = dr.GetByte(8);

                    arrayProdutos[arrayProdutos.Length - 1] = currentProduct;
                }
                dr.Close();
                bd.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }


            return arrayProdutos;
        }
    }
}
