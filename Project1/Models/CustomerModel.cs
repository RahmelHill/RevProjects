using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Resturant_webapi.Models
{
    #region CustomerINfo
    public class CustomerInfo
    {
        public int cust_Id { get; set; }

        public string cust_Name { get; set; }


        SqlConnection connect = new SqlConnection("Server=tcp:proj0.database.windows.net,1433;Initial Catalog=Proj1;Persist Security Info=False;User ID=proj0admin;Password=p@yt0nMan;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public string AddCustomer(CustomerInfo newCustomer)
        {
            SqlCommand cmd_addCustomer = new SqlCommand("Insert into Customers values(@cust_Name)", connect);
            cmd_addCustomer.Parameters.AddWithValue("@cust_Name", newCustomer.cust_Name);

            try
            {
                connect.Open();
                cmd_addCustomer.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);
            }
            finally
            {
                connect.Close();
            }
            return "Customer Added Successfully";

        }
      
       
        public List<CustomerInfo> GetCustomerList()
        {
            SqlCommand cmd_allCustInfo = new SqlCommand("select * from Customers", connect);
            List<CustomerInfo> custList = new List<CustomerInfo>();
            SqlDataReader read_custList = null;
            try
            {
                connect.Open();
                read_custList = cmd_allCustInfo.ExecuteReader();

                while (read_custList.Read())
                {
                    custList.Add(new CustomerInfo()
                    {
                        cust_Id = Convert.ToInt32(read_custList[0]),
                        cust_Name = read_custList[1].ToString(),
                        

                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);
            }
            finally
            {
                read_custList.Close();
                connect.Close();

            }
            return custList;



        }
        public CustomerInfo GetCustomerInfo(int cust_Id)
        {
            SqlCommand cmd_lookupById = new SqlCommand("select * from Customers where cust_Id=@id", connect);
            cmd_lookupById.Parameters.AddWithValue("@id", cust_Id);
            SqlDataReader read_Info = null;
            CustomerInfo cust_Info = new CustomerInfo();
            try
            {
                connect.Open();
                read_Info = cmd_lookupById.ExecuteReader();
                if (read_Info.Read())
                {
                    cust_Info.cust_Id = Convert.ToInt32(read_Info[0]);
                    cust_Info.cust_Name = read_Info[1].ToString();
                }
                else
                {
                    throw new Exception("Customer Not Found");
                }
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);
            }
            finally
            {
                read_Info.Close();
                connect.Close();

            }
            return cust_Info;
        }
#endregion
    }
}

