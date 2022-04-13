using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HotelApp{

                class AvialableRooms{

                public int rId { get; set; }    
                public string hName { get; set; }

                public string rDetails { get; set; }

                public int rBeds { get; set; }

                public int rPrice { get; set; }

                public int hId { get; set; }

                public string hAddress { get; set; }

                public string hCity { get; set; }

                public string hState {get; set; }

                public string hPhoneNumber { get; set; }

                public bool rBooked { get; set; }

                public string rInDate { get; set; }
                
                public string rOutDate { get; set; }
                public string gState { get; set; }

                public string gName { get; set; }

                public string gAddress {get; set; }

                public string gPhonenumber  { get; set; }

                public string gEmail { get; set; }


            SqlConnection connect = new SqlConnection(@"Server=tcp:proj0.database.windows.net,1433;Initial Catalog=Proj0DB;Persist Security Info=False;User ID=proj0admin;Password=p@yt0nMan;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"); 

            public string CreateReservation(AvialableRooms bookRoom)
            {
                SqlCommand cmd_update = new SqlCommand("update AvialableRooms set rBooked = @newrBooked,rInDate=@newrInDate,rOutDate = @newrOutDate,gName=@newgName,gAddress =@newgAddress,gState = @newgState,gPhoneNumber=@newgPhoneNumber,gemail=@newgEmail where rId = @rId",connect);
             cmd_update.Parameters.AddWithValue("@newrBooked",bookRoom.rBooked);
             cmd_update.Parameters.AddWithValue("@newrInDate",bookRoom.rInDate);
             cmd_update.Parameters.AddWithValue("@newrOutDate",bookRoom.rOutDate);
             cmd_update.Parameters.AddWithValue("@rId",bookRoom.rId);
             cmd_update.Parameters.AddWithValue("@newgName",bookRoom.gName);                   
             cmd_update.Parameters.AddWithValue("@newgAddress",bookRoom.gAddress);
             cmd_update.Parameters.AddWithValue("@newgState",bookRoom.gState);   
             cmd_update.Parameters.AddWithValue("@newgPhoneNumber",bookRoom.gPhonenumber);   
             cmd_update.Parameters.AddWithValue("@newgEmail",bookRoom.gEmail);                         
                              
             try{
                 connect.Open();
                 cmd_update.ExecuteNonQuery();
             }
             catch(System.Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 connect.Close();
             }
             return "Reservation Created!";
                
                }

            public List<AvialableRooms> GetRoomList(int id)
            {
               SqlCommand cmd_allRooms = new SqlCommand("select * from AvialableRooms where rBooked = 0 and hId = @hId",connect);
               cmd_allRooms.Parameters.AddWithValue("@hId", id);
               SqlDataReader listRooms = null;
               List<AvialableRooms> list_RoomsFromDB = new List<AvialableRooms>();

                try
                {
                   connect.Open();
                   listRooms = cmd_allRooms.ExecuteReader();
                   while(listRooms.Read())
                {
                  list_RoomsFromDB.Add(new AvialableRooms()
                {
                    hId = Convert.ToInt32(listRooms[8]),
                    rPrice =Convert.ToInt32(listRooms[7]),
                    hName =Convert.ToString(listRooms[4]),
                    rDetails =Convert.ToString(listRooms[5]),
                    rBeds =Convert.ToInt32(listRooms[6]),
                    hAddress =Convert.ToString(listRooms[9]),
                    hCity =Convert.ToString(listRooms[10]),
                    hState =Convert.ToString(listRooms[11]),
                    hPhoneNumber =Convert.ToString(listRooms[12]),
                    rId=Convert.ToInt32(listRooms[0])
                });
                }

               }
                catch(SqlException se)
                {
                    throw new Exception(se.Message);

                }
                finally
                {
                    listRooms.Close();
                    connect.Close();
                }
                return list_RoomsFromDB;
                }
                 public string CancelReservation(AvialableRooms ubookRoom)
            {
                SqlCommand cmd_update = new SqlCommand("update AvialableRooms set rBooked = @newrBooked,rInDate=@newrInDate,rOutDate = @newrOutDate,gName=@newgName,gAddress =@newgAddress,gState = @newgState,gPhoneNumber=@newgPhoneNumber,gemail=@newgEmail where rId = @rId",connect);
             cmd_update.Parameters.AddWithValue("@newrBooked",ubookRoom.rBooked);
             cmd_update.Parameters.AddWithValue("@newrInDate",ubookRoom.rInDate);
             cmd_update.Parameters.AddWithValue("@newrOutDate",ubookRoom.rOutDate);
             cmd_update.Parameters.AddWithValue("@rId",ubookRoom.rId);
             cmd_update.Parameters.AddWithValue("@newgName",ubookRoom.gName);                   
             cmd_update.Parameters.AddWithValue("@newgAddress",ubookRoom.gAddress);
             cmd_update.Parameters.AddWithValue("@newgState",ubookRoom.gState);   
             cmd_update.Parameters.AddWithValue("@newgPhoneNumber",ubookRoom.gPhonenumber);   
             cmd_update.Parameters.AddWithValue("@newgEmail",ubookRoom.gEmail);

             try{
                 connect.Open();
                 cmd_update.ExecuteNonQuery();
             }
             catch(System.Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 connect.Close();
             }
             return "Your Reservation is Canceled";
                
                }
                public string UpDateReservation(AvialableRooms upbookRoom)
            {
                SqlCommand cmd_update = new SqlCommand("update AvialableRooms set rBooked = @newrBooked,rInDate=@newrInDate,rOutDate = @newrOutDate,gName=@newgName,gAddress =@newgAddress,gState = @newgState,gPhoneNumber=@newgPhoneNumber,gemail=@newgEmail where rId = @rId",connect);
             cmd_update.Parameters.AddWithValue("@newrBooked",upbookRoom.rBooked);
             cmd_update.Parameters.AddWithValue("@newrInDate",upbookRoom.rInDate);
             cmd_update.Parameters.AddWithValue("@newrOutDate",upbookRoom.rOutDate);
             cmd_update.Parameters.AddWithValue("@rId",upbookRoom.rId);
             cmd_update.Parameters.AddWithValue("@newgName",upbookRoom.gName);                   
             cmd_update.Parameters.AddWithValue("@newgAddress",upbookRoom.gAddress);
             cmd_update.Parameters.AddWithValue("@newgState",upbookRoom.gState);   
             cmd_update.Parameters.AddWithValue("@newgPhoneNumber",upbookRoom.gPhonenumber);   
             cmd_update.Parameters.AddWithValue("@newgEmail",upbookRoom.gEmail);

             try{
                 connect.Open();
                 cmd_update.ExecuteNonQuery();
             }
             catch(System.Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }
             finally
             {
                 connect.Close();
             }
             return "Reservation Updated!";
                
                }
                
        
        }
}
 

