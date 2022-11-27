using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;

namespace HelloApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

             
            void PrintMenu()
            {
                Console.WriteLine("Choose option:");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.All products");
                Console.WriteLine("2.All names");
                Console.WriteLine("3.All colors");
                Console.WriteLine("4.Max calories");
                Console.WriteLine("5.Min calories");
                Console.WriteLine("6.Avg calories");

            }


            int choice;

            do
            {
                PrintMenu();

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        string connectionString = "Server=ARTEMMELNYC5FB8\\SQLEXPRESS ;Database = Fruits and vegetables;Trusted_Connection=True;";

                        string sqlExpression = "SELECT * FROM GOODSS";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            await connection.OpenAsync();

                            SqlCommand z = new SqlCommand(sqlExpression, connection);
                            using (SqlDataReader reader = await z.ExecuteReaderAsync())
                            {
                                if (reader.HasRows) // если есть данные
                                {
                                    // выводим названия столбцов
                                    string columnName1 = reader.GetName(0);
                                    string columnName2 = reader.GetName(1);
                                    string columnName3 = reader.GetName(2);
                                    string columnName4 = reader.GetName(3);
                                    string columnName5 = reader.GetName(4);

                                    Console.WriteLine($"{columnName1}\t{columnName2}\t{columnName3}\t{columnName4}\t{columnName5}");

                                    while (await reader.ReadAsync()) // построчно считываем данные
                                    {
                                        object id = reader.GetValue(0);
                                        object name = reader.GetValue(1);
                                        object type = reader.GetValue(2);
                                        object color = reader.GetValue(3);
                                        object calories = reader.GetValue(4);

                                        Console.WriteLine($"{id} \t{name} \t{type} \t{color} \t{calories}");
                                    }
                                }


                            }
                        }
                        
                        break;

                    case 2:
                        connectionString = "Server=ARTEMMELNYC5FB8\\SQLEXPRESS ;Database = Fruits and vegetables;Trusted_Connection=True;";

                        sqlExpression = "SELECT [Name]  FROM GOODSS";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            await connection.OpenAsync();
                            SqlCommand command = new SqlCommand(sqlExpression, connection);

                            using (SqlDataReader reader = await command.ExecuteReaderAsync())
                            {
                                if (reader.HasRows) // если есть данные
                                {
                                    // выводим названия столбцов
                                    string columnName2 = reader.GetName(0);



                                    Console.WriteLine($"{columnName2}");

                                    while (await reader.ReadAsync()) // построчно считываем данные
                                    {
                                        object name = reader.GetValue(0);



                                        Console.WriteLine($"{name}  ");
                                    }
                                }
                            }
                        }
                       
                        break;

                    case 3:
                        connectionString = "Server=ARTEMMELNYC5FB8\\SQLEXPRESS ;Database = Fruits and vegetables;Trusted_Connection=True;";


                        sqlExpression = "SELECT [Color]  FROM GOODSS";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            await connection.OpenAsync();
                            SqlCommand command = new SqlCommand(sqlExpression, connection);

                            using (SqlDataReader reader = await command.ExecuteReaderAsync())
                            {
                                if (reader.HasRows) // если есть данные
                                {
                                    // выводим названия столбцов
                                    string columnName3 = reader.GetName(0);



                                    Console.WriteLine($"{columnName3}");

                                    while (await reader.ReadAsync()) // построчно считываем данные
                                    {
                                        object color = reader.GetValue(0);
                                        Console.WriteLine($"{color}  ");
                                    }
                                }
                            }
                        }
                        break;

                    case 4:
                        connectionString = "Server=ARTEMMELNYC5FB8\\SQLEXPRESS ;Database = Fruits and vegetables;Trusted_Connection=True;";


                        sqlExpression = "SELECT MAX (CaloricContent) [CaloricContent] FROM GOODSS";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            await connection.OpenAsync();
                            SqlCommand command = new SqlCommand(sqlExpression, connection);

                            using (SqlDataReader reader = await command.ExecuteReaderAsync())
                            {
                                if (reader.HasRows) // если есть данные
                                {
                                    // выводим названия столбцов
                                    string columnName5 = reader.GetName(0);



                                    Console.WriteLine($"{columnName5}");

                                    while (await reader.ReadAsync()) // построчно считываем данные
                                    {
                                        object maxcal = reader.GetValue(0);
                                        Console.WriteLine($"{maxcal}");
                                    }
                                }
                            }
                        }
                        break;

                    case 5:
                        connectionString = "Server=ARTEMMELNYC5FB8\\SQLEXPRESS ;Database = Fruits and vegetables;Trusted_Connection=True;";


                        sqlExpression = "SELECT MIN (CaloricContent) [CaloricContent] FROM GOODSS";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            await connection.OpenAsync();
                            SqlCommand command = new SqlCommand(sqlExpression, connection);

                            using (SqlDataReader reader = await command.ExecuteReaderAsync())
                            {
                                if (reader.HasRows) // если есть данные
                                {
                                    // выводим названия столбцов
                                    string columnName5 = reader.GetName(0);



                                    Console.WriteLine($"{columnName5}");

                                    while (await reader.ReadAsync()) // построчно считываем данные
                                    {
                                        object mincal = reader.GetValue(0);
                                        Console.WriteLine($"{mincal}");
                                    }
                                }
                            }
                        }
                        break;

                    case 6:
                        connectionString = "Server=ARTEMMELNYC5FB8\\SQLEXPRESS ;Database = Fruits and vegetables;Trusted_Connection=True;";


                        sqlExpression = "SELECT AVG (CaloricContent) [CaloricContent] FROM GOODSS";
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            await connection.OpenAsync();
                            SqlCommand command = new SqlCommand(sqlExpression, connection);

                            using (SqlDataReader reader = await command.ExecuteReaderAsync())
                            {
                                if (reader.HasRows) // если есть данные
                                {
                                    // выводим названия столбцов
                                    string columnName5 = reader.GetName(0);



                                    Console.WriteLine($"{columnName5}");

                                    while (await reader.ReadAsync()) // построчно считываем данные
                                    {
                                        object avgcal = reader.GetValue(0);
                                        Console.WriteLine($"{avgcal}");
                                    }
                                }
                            }
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;


                }
                
            } while (choice != 0);
            Console.Read();
        }
      
    }
    
}