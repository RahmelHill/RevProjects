using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Resturant_webapi.Models
{
    #region OrdersInfo

    public class OrdersInfo
    {
        public int order_Id { get; set; }

        public int cust_Id { get; set; }

        public int item_Id { get; set; }

        public string cust_Name { get; set; }

        public string item_Name { get; set; }

        public double item_Cost { get; set; }

        public DateTime order_date { get; set; }


        SqlConnection connect = new SqlConnection("Server=tcp:proj0.database.windows.net,1433;Initial Catalog=Proj1;Persist Security Info=False;User ID=proj0admin;Password=p@yt0nMan;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public string MakeOrder(OrdersInfo newOrder)
        {
            SqlCommand cmd_makeOrder = new SqlCommand("Insert into Orders values(@cust_Id,@item_Id,@order_date)", connect);
            cmd_makeOrder.Parameters.AddWithValue("@cust_Id", newOrder.cust_Id);
            cmd_makeOrder.Parameters.AddWithValue("@item_Id", newOrder.item_Id);
            cmd_makeOrder.Parameters.AddWithValue("@order_date", newOrder.order_date);
            try
            {
                connect.Open();
                cmd_makeOrder.ExecuteNonQuery();
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
            return "Order Completed!";

        }
        


        public List<OrdersInfo> GetOrdersList()
        {
            SqlCommand cmd_allOrders = new SqlCommand("select order_Id,cust_Name, c.cust_Id,item_Name,m.item_Id,item_Cost,order_date from Customers c inner join Orders o on c.cust_Id = o.cust_Id inner join Menu m on m.item_Id = o.item_Id ", connect);
            List<OrdersInfo> ordersList = new List<OrdersInfo>();
            SqlDataReader read_ordersList = null;
            try
            {
                connect.Open();
                read_ordersList = cmd_allOrders.ExecuteReader();

                while (read_ordersList.Read())
                {
                    ordersList.Add(new OrdersInfo()
                    {
                        order_Id = Convert.ToInt32(read_ordersList[0]),
                        cust_Name = read_ordersList[1].ToString(),
                        cust_Id = Convert.ToInt32(read_ordersList[2]),
                        item_Name = read_ordersList[3].ToString(),
                        item_Id = Convert.ToInt32(read_ordersList[4]),
                        item_Cost = Convert.ToDouble(read_ordersList[5]),
                        order_date = Convert.ToDateTime(read_ordersList[6]),
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
                read_ordersList.Close();
                connect.Close();

            }
            return ordersList;



        }
        public List<OrdersInfo> GetOrdersInfo(int cust_Id)
        {
            SqlCommand cmd_lookupById = new SqlCommand("select order_Id,cust_Name, c.cust_Id,item_Name,m.item_Id,item_Cost,order_date from Customers c inner join Orders o on c.cust_Id = o.cust_Id inner join Menu m on m.item_Id = o.item_Id where c.cust_Id= @id", connect);
            cmd_lookupById.Parameters.AddWithValue("@id", cust_Id);
            List<OrdersInfo> orders_Info = new List<OrdersInfo>();
            SqlDataReader read_ordersInfo = null;

            try
            {
                connect.Open();
                read_ordersInfo = cmd_lookupById.ExecuteReader();
                while (read_ordersInfo.Read())
                {
                    orders_Info.Add(new OrdersInfo()
                    {
                        order_Id = Convert.ToInt32(read_ordersInfo[0]),
                        cust_Name = read_ordersInfo[1].ToString(),
                        cust_Id = Convert.ToInt32(read_ordersInfo[2]),
                        item_Name = read_ordersInfo[3].ToString(),
                        item_Id = Convert.ToInt32(read_ordersInfo[4]),
                        item_Cost = Convert.ToDouble(read_ordersInfo[5]),
                        order_date = Convert.ToDateTime(read_ordersInfo[6]),
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
                read_ordersInfo.Close();
                connect.Close();

            }
            return orders_Info;
        }
        #endregion
    }
}


