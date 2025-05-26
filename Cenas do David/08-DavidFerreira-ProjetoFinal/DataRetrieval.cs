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
    static class DataRetrieval
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

                    //IdProduto->Nome->IdProdutor->unitPreco->descricao->desconto->stock->Idcat->avaliação->Franchise->Foto
 
                    currentProduct.NomeProduto = dr.GetString(1);
                    currentProduct.IdProd = dr.GetInt32(2);
                    currentProduct.PrecoUnit = dr.GetDouble(3);
                    currentProduct.Descricao = dr.GetString(4);
                    currentProduct.Desconto = dr.GetDouble(5);
                    currentProduct.Stock = dr.GetInt16(6);
                    currentProduct.IdCategoria = dr.GetInt16(7);
                    currentProduct.AvalProd = dr.GetByte(8);
                    string? imagePath = dr.GetValue(10).ToString();

                    currentProduct.Foto = Image.FromFile(".\\..\\..\\..\\..\\..\\ProductImages\\" + imagePath);

                    arrayProdutos[arrayProdutos.Length - 1] = currentProduct;
                }
                dr.Close();
                bd.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return arrayProdutos;
            }


            return arrayProdutos;
        }

        static public string retrieveCategoriaFromIdx(string strProvider, int idxCat)
        {

            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;

            OleDbCommand cmd = bd.CreateCommand();
            OleDbDataReader dr;

            cmd.CommandText = "SELECT categoriaProduto FROM Categoria WHERE IdCategoria="+idxCat;
            try
            {
                bd.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                string str = dr.GetString(0);
                dr.Close();
                bd.Close();
                return str;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        static public string retrieveProdutorFromIdx(string strProvider, int idxProd)
        {

            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;

            OleDbCommand cmd = bd.CreateCommand();
            OleDbDataReader dr;

            cmd.CommandText = "SELECT nomeProdutor FROM Produtor WHERE IdProdutor=" + idxProd;
            try
            {
                bd.Open();
                dr = cmd.ExecuteReader();
                dr.Read();
                string str = dr.GetString(0);
                dr.Close();
                bd.Close();
                return str;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }

        static public Category[] retrieveCategorias(string strProvider)
        {
            Category[] arrayCategorias = new Category[0];

            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;

            OleDbCommand cmd = bd.CreateCommand();
            OleDbDataReader dr;

            cmd.CommandText = "SELECT * FROM Categoria ORDER BY categoriaProduto;";

            try
            {
                bd.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Array.Resize(ref arrayCategorias, arrayCategorias.Length + 1);
                    Category currentCat = new Category();

                    //IdProduto->Nome->IdProdutor->unitPreco->descricao->desconto->stock->Idcat->avaliação->Franchise->Foto

                    currentCat.IdCar = dr.GetInt16(0);
                    currentCat.StrCategory = dr.GetString(1);
                    arrayCategorias[arrayCategorias.Length-1] = currentCat;
                }
                dr.Close();
                bd.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return arrayCategorias;
            }

            return arrayCategorias;
        }

        static public Produtor[] retrieveProdutores(string strProvider)
        {
            Produtor[] arrayProdutores = new Produtor[0];

            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;

            OleDbCommand cmd = bd.CreateCommand();
            OleDbDataReader dr;

            cmd.CommandText = "SELECT * FROM Produtor ORDER BY nomeProdutor;";

            try
            {
                bd.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Array.Resize(ref arrayProdutores, arrayProdutores.Length + 1);
                    Produtor currentPD = new Produtor();

                    //IdProduto->Nome->IdProdutor->unitPreco->descricao->desconto->stock->Idcat->avaliação->Franchise->Foto

                    currentPD.IdProd = dr.GetInt32(0);
                    currentPD.StrProdutor = dr.GetString(1);
                    arrayProdutores[arrayProdutores.Length - 1] = currentPD;
                }
                dr.Close();
                bd.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return arrayProdutores;
            }

            return arrayProdutores;
        }
    }

    public class Category
    {
        string strCategory = "";
        int idCar = 0;
        public Category() { }

        public string StrCategory { get { return strCategory; } set { strCategory = value; } }
        public int IdCar { get { return idCar; } set { idCar = value; } }
    }

    public class Produtor
    {
        string strProdutor= "";
        int idProd = 0;
        public Produtor() { }

        public string StrProdutor { get { return strProdutor; } set { strProdutor = value; } }
        public int IdProd { get { return idProd; } set { idProd = value; } }
    }
}
