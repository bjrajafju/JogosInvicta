﻿using System;
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
       
        static public List<List<string>> retrieveStrings(string strProvider, string tabela,string colunas = "*", string? where = null)
        {
            List<List<string>> list = new List<List<string>>();

            OleDbConnection bd = new OleDbConnection(strProvider);
            OleDbCommand cmd = bd.CreateCommand();
                cmd.CommandText = "SELECT " + colunas + " FROM " + tabela;

                if (where != null)
                {
                    cmd.CommandText += " WHERE " + where;
                }
                if (colunas != "*")
                {
                    cmd.CommandText += " ORDER BY " + colunas;
                }

                try
                {
                    bd.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();   
                    while (dr.Read())
                    {
                        List<string> strings = new List<string>();
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            strings.Add(dr.GetValue(i).ToString());
                        }
                        list.Add(strings);
                    }
                    dr.Close();
                    bd.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            return list;
        }

        static public List<string>? retrieveSingleColumn(string strProvider, string tabela, string coluna, string? where = null)
        {
            List<string> list = new List<string>();

            OleDbConnection bd = new OleDbConnection(strProvider);
            OleDbCommand cmd = bd.CreateCommand();
                cmd.CommandText = "SELECT " + coluna + " FROM " + tabela;
                if (where != null)
                {
                    cmd.CommandText += " WHERE " + where;
                }
                cmd.CommandText += " ORDER BY " + coluna;
                try
                {
                    bd.Open();
                    OleDbDataReader dr = cmd.ExecuteReader();
            
                    while (dr.Read())
                    {
                        list.Add(dr.GetValue(0).ToString());
                    }
                    dr.Close();
                    bd.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            

            return list;
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
                if (values[i][0] != '#')
                {
                    cmd.CommandText += ("'" + values[i].ToString() + "'");
                   
                } else
                {
                    cmd.CommandText += values[i].ToString();
                }

                if (i == values.Count - 1)
                {
                    cmd.CommandText += ")";
                }
                else
                {
                    cmd.CommandText += ',';
                }
            }

            //MessageBox.Show(cmd.CommandText);

            try
            {
                bd.Open();
                cmd.ExecuteNonQuery();
                bd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GlobalVars.dbError;
            }

            return GlobalVars.aOk;
        }

        static public int updateDatabase(string strProvider, string tabela, List<string> colunas, List<string> values)
        {
            //First Value is always the Index of the position to Update
            if ((colunas?.Count != values.Count && colunas?.Count != 0) || values.Count == 0)
            {
                return GlobalVars.formatError;
            }


            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;

            OleDbCommand cmd = bd.CreateCommand();

            List<List<string>> list = new List<List<string>>();
            cmd.CommandText = "UPDATE " + tabela + " SET ";

            for(int i = 1; i < colunas.Count; i++)
            {
                cmd.CommandText += colunas[i] + " = '" + values[i] +"' ";
                if (i != colunas.Count - 1)
                {
                    cmd.CommandText += ", ";
                }
            }

            cmd.CommandText += "WHERE " + colunas[0] + " = " + values[0];

            //MessageBox.Show(cmd.CommandText);

            try
            {
                bd.Open();
                cmd.ExecuteNonQuery();
                bd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GlobalVars.dbError;
            }

            return GlobalVars.aOk;
        }

        static public int removeFromDatabase(string strProvider, string tabela, string where)
        {
            //First Value is always the Index of the position to Update

            OleDbConnection bd = new OleDbConnection();
            bd.ConnectionString = strProvider;

            OleDbCommand cmd = bd.CreateCommand();

            List<List<string>> list = new List<List<string>>();
            cmd.CommandText = "DELETE FROM " + tabela ;

            cmd.CommandText += " WHERE " + where;

            //MessageBox.Show(cmd.CommandText);

            try
            {
                bd.Open();
                cmd.ExecuteNonQuery();
                bd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return GlobalVars.dbError;
            }

            return GlobalVars.aOk;
        }

        static public int RowsCount(string strProvider, string tabela)
        {
            OleDbConnection bd = new OleDbConnection(strProvider);
            OleDbCommand cmd = bd.CreateCommand();
            cmd.CommandText = "SELECT Count(*) FROM " + tabela;
            try
            {
                bd.Open();
                OleDbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                return dr.GetInt32(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return -400;
            }
        }
    }
}
