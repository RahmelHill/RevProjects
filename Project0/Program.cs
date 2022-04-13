using System;
using System.Collections.Generic;


namespace HotelApp {

class Program{


static void Main(string[] args){
    AvialableRooms avRooms = new AvialableRooms();
                #region Login
         bool run = true;
        bool onLine = false;
        Console.Clear();
        if(onLine == false)
        {
            Console.WriteLine("Enter UserName");
            string username = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            Login log = new Login();

            bool logged = log.Logon(username,password);
            if (logged == false)
            {
                Console.WriteLine("Either the username or password is incorrect, please try again");
            }
            else
            {
                    
              onLine = true;
              #endregion
                #region Menu
           while(run){
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~Welcome to Booking Assistant~~~~~~~~~~~");
            Console.WriteLine("1. Search Hotels for Avialable Rooms");
            Console.WriteLine("2. Make Reservation");
            Console.WriteLine("3. Update a Reservation");
            Console.WriteLine("4. Cancel a Reservation");
            Console.WriteLine("5. Leave Booking Assistant");

               int systemOn = Convert.ToInt32(Console.ReadLine());
                #endregion
                #region Search Hotel/Room   
               switch(systemOn){  
                   case 1:
                   
                   bool opp2 = true;
                    
                    do{
                   Console.WriteLine("Enter Hotel Id# to search Availiable Rooms");
                   Console.WriteLine("H Id# for NY = 2, MA = 4, RI = 6, 8 = Florida");
                   int id2 = Convert.ToInt32(Console.ReadLine());
                   List<AvialableRooms> ar = avRooms.GetRoomList(id2);
                   foreach(var obj in ar){
                   Console.WriteLine("----------------------------------------------");
                   Console.WriteLine("Avialable Rooms");
                   Console.WriteLine("Room Price per Night:  " + obj.rPrice);
                   Console.WriteLine("Hotel Name:  " + obj.hName);
                   Console.WriteLine("Room Details:  " + obj.rDetails);
                   Console.WriteLine("Number of Beds:  " + obj.rBeds);
                   Console.WriteLine("Hotel Address:  " + obj.hAddress);
                   Console.WriteLine("Hotel City:  " + obj.hCity);
                   Console.WriteLine("Hotel State:  " + obj.hState);
                   Console.WriteLine("Hotel Phone Number:  " + obj.hPhoneNumber);
                   Console.WriteLine("Room Id:  " + obj.rId);
                   Console.WriteLine("");   
                   }            
                   Console.WriteLine("Remember The Room Id# as You'll Need That to Book a Room");
                   Console.WriteLine("Are you Done Searing Rooms?  y/n ");
                    char uChoice1 = Convert.ToChar(Console.ReadLine());
                    if (uChoice1 == 'n'){
                        opp2 = true;
                        Console.Clear();
                    }
                    else
                    {
                        opp2 = false;
                   }
                    }while(opp2);
                   break;
                #endregion
                #region Make Reservation
                   case 2:
                   Console.Clear();
                   Console.WriteLine("You'll need the Room Id# To Book");
                   Console.WriteLine("If you don't have the Room Id#");
                   Console.WriteLine("You can go back to the Hotel search to get one.");
                   Console.WriteLine("Are you ready to Proceed with Booking Assistant? y/n");
                   char uChoice2 = Convert.ToChar(Console.ReadLine());
                   if (uChoice2 == 'y'){

                    bool opp1 = true;
                    
                    do{
                    Console.WriteLine("Please Enter your Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter your Address:");
                    string address = Console.ReadLine();

                    Console.WriteLine("Enter your State:");
                    string state = Console.ReadLine();

                    Console.WriteLine("Enter your Phone Number:");
                    string phoneNumber = Console.ReadLine();

                    Console.WriteLine("Please Enter your Email Address:");
                    string email = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Please Enter a Check-in Date and Time");  
                    Console.WriteLine("You can Check-in and Out Anytime between 10am an 10pm");
                    Console.WriteLine("");
                    Console.WriteLine("ex. 4/1/2022 - 10:50 am");  
                    string checkIN = Console.ReadLine(); 

                    Console.WriteLine("Please Enter a Check-Out Date and Time"); 
                    Console.WriteLine("");
                    Console.WriteLine("ex. 4/5/2022 - 2:30pm ");

                    string checkOut = Console.ReadLine(); 
                    AvialableRooms gBookRm = new AvialableRooms();
                    Console.WriteLine("Please Enter Room Id#");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    bool rmBooked = true; 
                    gBookRm.rId = id3;
                    gBookRm.rBooked = rmBooked;
                    gBookRm.rInDate = checkIN;
                    gBookRm.rOutDate = checkOut;
                    gBookRm.gName = name;
                    gBookRm.gAddress = address;                     
                    gBookRm.gState = state;                                       
                    gBookRm.gPhonenumber = phoneNumber;
                    gBookRm.gEmail = email;

                    
                    
                    Console.WriteLine("Name:  " + name);
                    Console.WriteLine("Address:  " + address + "State:" + state);
                    Console.WriteLine("Phone Number:  " + phoneNumber);
                    Console.WriteLine("Email:  " + email);
                    Console.WriteLine("Is the above Infromation Correct?  y/n ");
                    char uChoice1 = Convert.ToChar(Console.ReadLine());
                    if (uChoice1 == 'n'){
                        opp1 = true;
                    }
                    else
                    {
                    Console.WriteLine(avRooms.CreateReservation(gBookRm));
                        opp1 = false;
                    }
                    }while(opp1);
                   }
                   else
                   {
                   Console.WriteLine("Returning to Menu");
                   }
                  
                   break;
                #endregion 
                #region Update Reservation
                   case 3:
                   Console.Clear();
                   Console.WriteLine("You'll need the Room Id# To Update your Reservation");
                   Console.WriteLine("Are you ready to Proceed with Booking Assistant? y/n");
                   char uChoice4 = Convert.ToChar(Console.ReadLine());
                   if (uChoice4 == 'y'){

                   bool opp1 = true;
                    
                    do{
                    Console.WriteLine("Please Enter your Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter your Address:");
                    string address = Console.ReadLine();

                    Console.WriteLine("Enter your State:");
                    string state = Console.ReadLine();

                    Console.WriteLine("Enter your Phone Number:");
                    string phoneNumber = Console.ReadLine();

                    Console.WriteLine("Please Enter your Email Address:");
                    string email = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Please Enter a Check-in Date and Time");  
                    Console.WriteLine("You can Check-in and Out Anytime between 10am an 10pm");
                    Console.WriteLine("");
                    Console.WriteLine("ex. 4/1/2022 - 10:50 am");  
                    string checkIN = Console.ReadLine(); 

                    Console.WriteLine("Please Enter a Check-Out Date and Time"); 
                    Console.WriteLine("");
                    Console.WriteLine("ex. 4/5/2022 - 2:30pm ");

                    string checkOut = Console.ReadLine(); 
                    AvialableRooms gBookRm = new AvialableRooms();
                    Console.WriteLine("Please Enter Room Id#");
                    int id3 = Convert.ToInt32(Console.ReadLine());

                    bool rmBooked = true; 
                    gBookRm.rId = id3;
                    gBookRm.rBooked = rmBooked;
                    gBookRm.rInDate = checkIN;
                    gBookRm.rOutDate = checkOut;
                    gBookRm.gName = name;
                    gBookRm.gAddress = address;                     
                    gBookRm.gState = state;                                       
                    gBookRm.gPhonenumber = phoneNumber;
                    gBookRm.gEmail = email;

                    Console.Clear();
                    
                    Console.WriteLine("Name:  " + name);
                    Console.WriteLine("Check in:  " + checkIN);
                    Console.WriteLine("Check out:  " + checkOut);
                    Console.WriteLine("Address:  " + address + "State:" + state);
                    Console.WriteLine("Phone Number:  " + phoneNumber);
                    Console.WriteLine("Email:  " + email);
                    Console.WriteLine("Is the above Infromation Correct?  y/n ");
                    char uChoice1 = Convert.ToChar(Console.ReadLine());
                    if (uChoice1 == 'n'){
                        opp1 = true;
                    }
                    else
                    {
                    Console.WriteLine(avRooms.UpDateReservation(gBookRm));
                        opp1 = false;
                    }
                    }while(opp1);
                   }
                   else
                   {
                   Console.WriteLine("Returning to Menu");
                   }
                  
                   
                   break;
                #endregion
                #region Cancel Reservation
                   case 4:
                   Console.Clear();
                     Console.WriteLine("You'll need the Room Id# To unBook");
                   Console.WriteLine("Are you ready to Proceed with Booking Assistant? y/n");
                   char uChoice3 = Convert.ToChar(Console.ReadLine());
                   if (uChoice3 == 'y'){
                    AvialableRooms gBookRm = new AvialableRooms();
                    Console.WriteLine("Please Enter Room Id#");
                    int id3 = Convert.ToInt32(Console.ReadLine());
                    bool rmUNBooked = false; 
                    

                    gBookRm.rId = id3;
                    gBookRm.rBooked = rmUNBooked;
                    gBookRm.rInDate = "";
                    gBookRm.rOutDate = "";
                    gBookRm.rId = id3;
                    gBookRm.gName = "";
                    gBookRm.gAddress = "";                     
                    gBookRm.gState = "";                                       
                    gBookRm.gPhonenumber = "";
                    gBookRm.gEmail = "";

                    Console.WriteLine(avRooms.CancelReservation(gBookRm));
                   }
                   else
                   {
                   Console.WriteLine("Returning to Menu");
                   }
                   
                   break;
                #endregion
                #region LogOff
                   case 5:
                   Console.WriteLine("You have decided to leave Booking Assistant is this Correct? y/n");
                   
                   char uChoice = Convert.ToChar(Console.ReadLine());
                   
                   if (uChoice.Equals('y')){
                       Console.WriteLine("You have successfully logged out of booking Assistant");
                       run = false;
                       onLine = false;
                   }
                else if (uChoice.Equals('n')){

                    Console.WriteLine("\n \n Press enter to continue");
                    Console.ReadLine();
                }
                else {
                    Console.WriteLine("not an option press 'enter' to return to Mainmenu");
                    Console.ReadLine();
                }
                   break;

                   default:
                   Console.WriteLine("not an option press 'enter' to return to Mainmenu");
                   Console.ReadLine();
                   break;
                #endregion

               }
           }
}
}
}
}
}

