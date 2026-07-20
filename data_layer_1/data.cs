using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClsPerson_namspace;

namespace data_layer_1
{

    public class ClsData
    {
        public static string connection_string = "Server=localhost;Database=DVLD;Integrated Security=True;TrustServerCertificate=True";
        
        public static List<ClsPerson> list_all()
        {
            List<ClsPerson> list = new List<ClsPerson>();
            //DataTable dt = new DataTable();
            using(SqlConnection cnct=new SqlConnection(connection_string))
            {
                using(SqlCommand cmd=new SqlCommand("sp_list_people",cnct))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cnct.Open();
                    using(SqlDataReader reader=cmd.ExecuteReader())
                    {
                        //if (reader.HasRows)
                        //    dt.Load(reader);
                        while (reader.Read())
                        {
                            list.Add(new ClsPerson(
                                        reader.GetInt32(reader.GetOrdinal("PersonID")),
                                        reader.GetString(reader.GetOrdinal("NationalNo")),
                                        reader.GetString(reader.GetOrdinal("FirstName")),
                                        reader.GetString(reader.GetOrdinal("SecondName")),
                                        reader.GetString(reader.GetOrdinal("ThirdName")),
                                        reader.GetString(reader.GetOrdinal("LastName")),
                                        reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                        reader.GetByte(reader.GetOrdinal("Gendor")), // تأكد من الاسم في الداتابيز Gendor أو Gender
                                        reader.GetString(reader.GetOrdinal("Address")),
                                        reader.GetString(reader.GetOrdinal("Phone")),
                                        reader.GetString(reader.GetOrdinal("Email")),
                                        reader.GetString(reader.GetOrdinal("CountryName"))
                                    ));
                        }
                    }
                }
            }
            return list;
        }

        public static int is_exist(int id)
        {
            using(SqlConnection cnct=new SqlConnection(connection_string))
            {
                using(SqlCommand cmd=new SqlCommand("select dbo.IfExist(@id)",cnct))
                {
                    cnct.Open();
                    string x = "kkk";
                    x.Reverse();
                }
            }
        }
    }
}
