using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("server=dell-3900;"+"trusted_connection=yes;" + "database=stn;");
            int f= 1;
            string name, clas;
            int rollno, age;
            int ch;



            try
            {
                con.Open();
                SqlCommand x = new SqlCommand();
                SqlDataReader dr;
                x.Connection = con;
                while (f == 1)
                {
                    Console.WriteLine("\t 1----->> insert");
                    Console.WriteLine("\t 2----->> Display");
                    Console.WriteLine("\t 3----->> Delete");
                    Console.WriteLine("\t 4----->> quit");
                    ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            {
                                Console.WriteLine("entr no");
                                
                                rollno = int.Parse(Console.ReadLine());
                                
              

                                    Console.WriteLine("enr name");
                                name = Console.ReadLine();
                                Console.WriteLine("ent clas");
                                clas = Console.ReadLine();

                                Console.WriteLine("entr age");
                                age = int.Parse(Console.ReadLine());
                                x.CommandText = "Insert into Table_1 Values(" + rollno + ",'" + name + "','" + clas + "'," + age + ")";
                               dr=x.ExecuteReader();
                                Console.WriteLine("data added");
                                
                                break;
                            }
                        case 2:
                            {
                                x.CommandText = "Select * FROM Table_1";
                                dr = x.ExecuteReader();
                                Console.WriteLine("Rol no \t Name \t Class \t Age");
                                while (dr.Read())
                                {
                                    Console.WriteLine("roll=" + dr.GetValue(0));
                                    Console.WriteLine("name=" + dr.GetValue(1));
                                    Console.WriteLine("class=" + dr.GetValue(2));
                                    Console.WriteLine("age=" + dr.GetValue(3));
                                }

                                Console.ReadKey();
                                dr.Close();
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Enter roll no to delete");
                                string re = Console.ReadLine();
                                x.CommandText = "delete from table_1 where rollno='" + re + "'";
                                dr = x.ExecuteReader();
                                Console.WriteLine("data deleted");
                                dr.Close();
                                break;
                            }

                        default:
                            f = 0;
                            break;
                    }
                }
            }

            catch (Exception p)
            {
                Console.WriteLine("an unknown erroe" + p);
            }
            Console.ReadKey();
                    }
                }
            }
            
           


                    
                   
                


           
