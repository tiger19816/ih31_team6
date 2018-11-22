using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace sugukuru.Utility
{
    public class Customer
    {
        private DataRow select;

        //返り値用DataRowのSet
        public void setDataRow(DataRow select){
            this.select = select;
        }
        //返り値用DataRowのGet
        public DataRow getDataRow()
        {
            return this.select;
        }
        //顧客IDに紐づいている顧客情報の取得(DataRow)
        public static DataRow ChainCustomerId(String id)
        {
            String conStr = ConfigurationManager.AppSettings["DbConKey"];
            //SQL
            String SQL = "SELECT * " +
                         "FROM client " +
                         "INNER JOIN employee ON client.sales_rep = employee.id "+
                         "WHERE client.id = '" + id + "'";
            MySqlConnection con = new MySqlConnection(conStr);
            //顧客情報用のDataTable
            DataTable chain = new DataTable();
            con.Open();
            MySqlDataAdapter mAdp = new MySqlDataAdapter(SQL, con);
            mAdp.Fill(chain);
            //顧客情報(DataRow)
            DataRow chainRow = chain.Rows[0];

            return chainRow;
        }
        //社員IDに紐づいている顧客情報の取得(DataRow)
        public static DataRow ChainEmployeeId(String id)
        {
            String conStr = ConfigurationManager.AppSettings["DbConKey"];
            //SQL
            String SQL = "SELECT * " +
                         "FROM employee " +
                         "WHERE id = '" + id + "'";
            MySqlConnection con = new MySqlConnection(conStr);
            //顧客情報用のDataTable
            DataTable chain = new DataTable();
            con.Open();
            MySqlDataAdapter mAdp = new MySqlDataAdapter(SQL, con);
            mAdp.Fill(chain);
            //顧客情報(DataRow)
            DataRow chainRow = chain.Rows[0];

            return chainRow;
        }
        //受注IDに紐づいているオークション履歴情報の取得(DataRow)
        public static DataTable ChainOrderId(String id)
        {
            String conStr = ConfigurationManager.AppSettings["DbConKey"];
            //SQL
            String SQL = "SELECT * " +
                         "FROM bid " +
                         "INNER JOIN auction_hall ON auction_hall_id = auction_hall.id " +
                         "WHERE order_id = '" + id + "'";
            MySqlConnection con = new MySqlConnection(conStr);
            //顧客情報用のDataTable
            DataTable chain = new DataTable();
            con.Open();
            MySqlDataAdapter mAdp = new MySqlDataAdapter(SQL, con);
            mAdp.Fill(chain);
            //顧客情報(DataRow);

            return chain;
        }

    }

}
