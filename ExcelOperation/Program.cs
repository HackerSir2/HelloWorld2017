using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "装备信息.xls";
            string connectionString= "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 12..0;HDR=YES;IMEX=1\"";
            //创建连接到数据源的对象
            OleDbConnection connection = new OleDbConnection(connectionString);
            connection.Open();

            //将数据放至dataSet中
            string sql = "select *from[sheet1$]";
            DataSet dataSet=new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sql,connection);
            adapter.Fill(dataSet);

            connection.Close();//释放连接资源

            //获取excel中所有表的集合
            DataTableCollection  tableCollection= dataSet.Tables;
            DataTable table = tableCollection[0];
            DataRowCollection rowCollection = table.Rows;
            //DataColumnCollection columnCollection=table.Columns;
            foreach (DataRow row in rowCollection)
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(row[i] + "  ");
                }
                Console.WriteLine();
            }

            //foreach (DataColumn column in columnCollection)
            //{
            //    for (int i = 0; i <8 ; i++)
            //    {
            //        Console.Write(column[i]+" ");
            //    }

            //    Console.ReadLine();
            //}

            Console.ReadKey();
        }
    }
}
