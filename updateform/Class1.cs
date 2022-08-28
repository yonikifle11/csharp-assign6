using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace updateform
{
    internal class Class1
    {
        static private List<Class1> items = new List<Class1>();
        public string objectName { get; set; }
        public string InventoryNumber { get; set; }
        public string date { get; set; }
        public string number { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        
        public void save()
        {
            try
            {
                string connString = @"Data Source = localhost; Initial Catalog = CS223labDB; Integrated Security = True";
                SqlConnection connection = new(connString);
                connection.Open();

                string query = "INSERT INTO Product VALUES('" +
                this.number + "', '" +
                this.date + "', '" +
                this.InventoryNumber + "', '" +
                this.objectName + "', '" +
                this.count + "', '" +
                this.price + "')";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                connection.Close();

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static List<Class1> GetAllProducts()
        {
            string connString = @"Data Source = localhost; Initial Catalog = CS223labDB; Integrated Security = True";
            SqlConnection connection = new(connString);
            connection.Open();

            List<Class1> list = new List<Class1>();

            string query = "SELECT * FROM Product";

            try
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();

                var resultSet = cmd.ExecuteReader();
                while (resultSet.Read())
                {
                    Class1 product = new Class1
                    {
                        number = resultSet[0].ToString(),
                        date = resultSet[1].ToString(),
                        InventoryNumber = resultSet[2].ToString(),
                        objectName = resultSet[3].ToString(),
                        count = resultSet[4].ToString(),
                        price = resultSet[5].ToString()
                    };
                    list.Add(product);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            connection.Close();
            return list;
        }
        public static Class1 findOne(string name)
        {
            //ToLower() is used to make case insensative search. 

            return items.Find(items => items.objectName.ToLower() == name.ToLower()); 
            
        }

        private static Class1 Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
