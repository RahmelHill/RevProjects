using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Resturant_webapi.Models
{
    #region MenuInfo
    public class MenuInfo
    {
        public int item_Id { get; set; }

        public string item_Name { get; set; }

        public string item_Details { get; set; }

        public double item_Cost { get; set; }

       


        SqlConnection connect = new SqlConnection("Server=tcp:proj0.database.windows.net,1433;Initial Catalog=Proj1;Persist Security Info=False;User ID=proj0admin;Password=p@yt0nMan;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public List<MenuInfo> GetMenuList()
            {
                SqlCommand cmd_allmenuInfo = new SqlCommand("select * from Menu", connect);
                List<MenuInfo> menuList = new List<MenuInfo>();
                SqlDataReader read_menuList = null;
                try
                {
                    connect.Open();
                    read_menuList = cmd_allmenuInfo.ExecuteReader();

                    while (read_menuList.Read())
                    {
                        menuList.Add(new MenuInfo()
                        {
                            item_Id = Convert.ToInt32(read_menuList[0]),
                            item_Name = read_menuList[1].ToString(),
                            item_Details = read_menuList[2].ToString(),
                            item_Cost = Convert.ToDouble (read_menuList[3]),


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
                    read_menuList.Close();
                    connect.Close();

                }
                return menuList;

            }
        }
#endregion
}
