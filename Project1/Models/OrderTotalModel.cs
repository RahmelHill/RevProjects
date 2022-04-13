using System;
using System.Data.SqlClient;
namespace Resturant_webapi.Models
{
    #region Order
    public class OrderTotalModel
    {
        public double total_Cost { get; set; }

        SqlConnection connect = new SqlConnection("Server=tcp:proj0.database.windows.net,1433;Initial Catalog=Proj1;Persist Security Info=False;User ID=proj0admin;Password=p@yt0nMan;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");


        public OrderTotalModel GetOrdersTotal(int cust_Id)
        {
            SqlCommand cmd_lookupById = new SqlCommand("select sum (Menu.item_Cost)as total_Cost from menu join Orders on Orders.item_Id=Menu.item_Id where cust_Id= @id", connect);
            cmd_lookupById.Parameters.AddWithValue("@id", cust_Id);
            SqlDataReader read_orderTotal = null;
            OrderTotalModel Orders_Total = new OrderTotalModel();
            try
            {
                connect.Open();
                read_orderTotal = cmd_lookupById.ExecuteReader();
                if (read_orderTotal.Read())
                {
                    Orders_Total.total_Cost = Convert.ToDouble(read_orderTotal[0]);
                }
                else
                {
                    throw new Exception("Bill Not Found");
                }
            }
            catch (Exception es)
            {
                throw new Exception(es.Message);
            }
            finally
            {
                read_orderTotal.Close();
                connect.Close();

            }
            return Orders_Total;

            {

                #endregion

            }
        }
    }
}