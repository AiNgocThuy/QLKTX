using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_KTX
{
    public class DataBase
    {
        private static DataBase instance; //instance là duy nhất, nên phải đóng gói
        public static DataBase Instance
        {
            get
            {
                if (instance == null) instance = new DataBase();
                return DataBase.instance;
            }

            private set
            {
                DataBase.instance = value;
            }
        } //Singleton
        private DataBase() { }
        private string conn = "Data Source=DESKTOP-8J85HTN;Initial Catalog=QLKTX;Integrated Security=True";
        public DataTable executeQuery(string query, object[] parameter = null) //Trả ra bảng
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(conn)) //using: khi kết thúc câu lệnh sẽ giải phóng connection
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);    //có thể Add n parameter
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            };
            return data;
        }

        public int executeNonQuery(string query, object[] parameter = null) //Trả ra số dòng đc thực thi (insert, delete, update)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(conn)) //using: khi kết thúc câu lệnh sẽ giải phóng connection
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);    //có thể Add n parameter
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            };
            return data;
        }

        public object executeScalar(string query, object[] parameter = null) //Trả về giá trị của row
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(conn)) //using: khi kết thúc câu lệnh sẽ giải phóng connection
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);    //có thể Add n parameter
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();
            };
            return data;
        }

    }
}