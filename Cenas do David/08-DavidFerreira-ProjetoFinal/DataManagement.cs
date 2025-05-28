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
    static class DataManagement
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
                    currentProduct.IdFranchise = dr.GetInt32(9);
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

        static public List<List<string>> retrieveStrings(string strProvider, string tabela,string colunas = "*", string? where = null)
        {
            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;

            OleDbCommand cmd = bd.CreateCommand();
            OleDbDataReader dr;
            List<List<string>> list = new List<List<string>>();
            cmd.CommandText = "SELECT "+colunas+" FROM " + tabela;

            if (where != null)
            {
                cmd.CommandText += " WHERE " + where;
            }
            if (colunas != "*")
            {
                cmd.CommandText += " GROUP BY " + colunas;
            }
            try
            {
                bd.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    List<string> strings = new List<string>();
                    for (int i = 0; i < dr.FieldCount; i++) {
                        strings.Add(dr.GetValue(i).ToString());
                    }
                    list.Add(strings);
                }
                
                dr.Close();
                bd.Close();
                
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return list;
            }
        }

        static public List<string>? mergeListListString(List<List<string>> list)
        {
            if (list == null) return null;
            if (list[0].Count != 1) return null;

            List<string> strs = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                strs.Add(list[i][0]);
            }
            return strs;
        }

        static public int insertIntoDatabase(string strProvider, string tabela, List<string>? colunas, List<string> values)
        {
            if((colunas?.Count != values.Count && colunas?.Count!=0) || values.Count==0)
            {
                return GlobalVars.formatError;
            }


            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;

            OleDbCommand cmd = bd.CreateCommand();

            List<List<string>> list = new List<List<string>>();
            cmd.CommandText = "INSERT INTO " + tabela+" ";
            if (colunas.Count != 0)
            {
                cmd.CommandText += "(";
            }
            for (int i = 0; i < colunas.Count; i++)
            {
                cmd.CommandText+= colunas[i].ToString();
                if (i != colunas.Count - 1)
                {
                    cmd.CommandText += ",";
                } else
                {
                    cmd.CommandText += ") ";
                }
            }
            cmd.CommandText += "VALUES(";
            for(int i=0; i < values.Count; i++)
            {
                cmd.CommandText+=("'"+values[i].ToString()+"'");
                if(i == values.Count - 1)
                {
                    cmd.CommandText += ")";
                } else
                {
                    cmd.CommandText += ',';
                }
            }

            MessageBox.Show(cmd.CommandText);

            try
            {
                bd.Open();
                cmd.ExecuteNonQuery();
                bd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return GlobalVars.dbError;
            }

            return GlobalVars.aOk;
        }
    }
}
