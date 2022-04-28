
---------------------------------------------------------------------------------------
--update Size 
--set clothing_size = 'Small'
--where Pk_size_ID = 1;

-- for inserting constant size in DB
insert into Size Values ('Small');
insert into Size values('Meduim');
insert into Size values ('Large');
--select * from Size
--------------------------------------------------------------------------------------
-- inserting constant values to size_suit
insert into Size_suit values('30 Long');
insert into Size_suit values('31 Long');
insert into Size_suit values('32 Long');
insert into Size_suit values('33 Long');
insert into Size_suit values('34 Long');

insert into Size_suit values('30 Slim');
insert into Size_suit values('31 Slim');
insert into Size_suit values('32 Slim');
insert into Size_suit values('33 Slim');
insert into Size_suit values('34 Slim');

insert into Size_suit values('30 short');
insert into Size_suit values('31 short');
insert into Size_suit values('32 short');
insert into Size_suit values('33 short');
insert into Size_suit values('34 short');

insert into Size_suit values('30 Regular');
insert into Size_suit values('31 Regular');
insert into Size_suit values('32 Regular');
insert into Size_suit values('33 Regular');
insert into Size_suit values('34 Regular');

--Select * from Size_Suit;

------------------------------------------------------------------------------------------
 -- inserting city values
insert into City values('New York City');
insert into City values('Houston');
insert into City values('Jacksonville');
insert into City values('Atlanta');
insert into City values('Chicago');
insert into City values('Detroit');
insert into City values ('Los Angeles');
 
-- select * from city;

 -------------------------------------------------------------------------------------------------------
 --inserting values for city

 insert into State values('New York');
 
 insert into State values('Texas');
 
 insert into State values('Florida');
 
 insert into State values('Georgia');
 
 insert into State values('Illinois');
 
 insert into State values('California');
 
 insert into State values('Michigan');

 --select * from state;
 --select * from city;

 ---------------------------------------------------------------------------------------------
 -- insert into country values
 
 insert into Country values ('MURICA');
 --select * FROM Country;

 --------------------------------------------------------------------------------------------------------
 -- insert condition values
 
 insert into Condition values ('New');
insert into Condition values ('Good');
insert into Condition values ('Fair');
insert into Condition values ('Recycleable');
insert into Condition values ('Why bother');

--select * from Condition;

------------------------------------------------------------------------------------------------------

-- inserting data to the shoe_size table
insert into shoe_size values('10.5 Men / 12 Women');
insert into shoe_size values('10 Men / 11.5 Women');
insert into shoe_size values('9.5 Men / 11 Women');
insert into shoe_size values('9 Men / 10.5 Women');
insert into shoe_size values('8.5 Men / 10 Women');

--select * from shoe_size;
--===============================================================================================
--===================================================================================================

insert into Store_Location values ('REDJay1','123 main st',2,2,1);

--select store_Name, store_Address, City.city_name, State.State_Name,Country.country_name from Store_location 
--inner join City on Store_Location.FK_city_ID = City.PK_city_ID
--inner join State on Store_Location.FK_state_ID = State.PK_state_ID
--inner join Country on Store_Location.FK_country_ID = Country.PK_country_ID;


---------------------------------------------------------------------------------------------------------------------------------
--JEANS data.
insert into Jeans values ('Boot cut','Wrangler', 2,1);
insert into Jeans values ('Straight fit','Levi', 3,1);
insert into Jeans values ('Skinny','True Religion', 1,1);

--select jean_Style, jean_Brand,S.clothing_size from Jeans J 
--inner join Size S  on S.PK_size_ID =J.FK_size_ID
--;
--select * from Jeans;
--update Jeans  set InStock = 1 
--where PK_jeans_ID = 1

--alter table pants NOCHECK constraint all
--delete from Jeans
--alter table Pants check constraint all

-------------------------------------------------------------------------------------------------------------------------

--Sweats DAta

insert into Sweats values ('Joggers','Adidas',1,0);
insert into Sweats values ('Lounge','Nike',2,1);
insert into Sweats values ('Elastic cuff','Champion',1,1);


--select sweats_Style, sweats_Brand,S.clothing_size instock from Sweats SW
--inner join Size S on S.PK_size_ID = SW.FK_size_ID
--where Instock = 1 ;

--select * from Sweats;

--alter table customers NOCHECK constraint all
--delete from User_P
--alter table customers check constraint all

--drop user_upload
--------------------------------------------------------------------------------------------------------------------------

--Shorts data

insert into Shorts values('Booty Shorts','Adidas',1,1);
insert into Shorts values('BasketBall Shorts','Nike',2,0);
insert into Shorts values('Jean Shorts','Champion',3,1);
insert into Shorts values ('Cargo shorts','Dockers',2,1);

--select shorts_style , shorts_Brand, S.clothing_size from Shorts SH
--inner join Size S on S.PK_size_ID = SH.FK_size_ID
--where inStock =1;

-- to delete tables with restraints
--alter table pants NOCHECK constraint all
--delete from Shorts
--alter table Pants check constraint all

------------------------------------------------------------------------------------------------------------
--GOT RID OF ENTIRELY --


--Pants (Erased from DB no NEED)
--insert into Pants values (2,11,3);

--insert into Pants values (2,3,1);
--insert into Pants values (3,1,2);




--select * from Pants;

--delete from Pants;

---- select Shorts.shorts_Style, Shorts.shorts_Brand ,Size.clothing_size, Jeans.jean_Brand,Jeans.jean_Style
---- from Pants
---- inner join Shorts on Shorts.PK_shorts_ID = Pants.FK_shorts_ID	
----inner join Jeans on Jeans.PK_jeans_ID = Pants.FK_jeans_ID
---- --inner join Sweats on Sweats.PK_sweats_ID = Pants.FK_sweats_ID
---- inner join Size  on Size.PK_size_ID = Shorts.FK_size_ID 
------ AND size.PK_size_ID =Sweats.FK_size_ID 
---- and Size.PK_size_ID =Jeans.FK_size_ID

---- --inner join Size s on s.PK_size_ID = Sweats.FK_size_ID
---- --inner join Size Si  on Si.PK_size_ID =Jeans.FK_size_ID
-- ;
-- select Jeans.jean_Brand ,Jeans.jean_Style, Size.clothing_size
-- from Pants
-- inner join Jeans on Jeans.PK_jeans_ID = Pants.FK_jeans_ID
--  inner join Size  on Size.PK_size_ID =Jeans.FK_size_ID

--  select Shorts.shorts_Style, Shorts.shorts_Brand ,Size.clothing_size
--  from Pants
--  inner join Shorts on Shorts.PK_shorts_ID = Pants.FK_shorts_ID
-- inner join Size  on Size.PK_size_ID = Shorts.FK_size_ID 

--   select Sweats.sweats_Style, Sweats.sweats_Brand ,Size.clothing_size
--  from Pants
--  inner join Sweats on Sweats.PK_sweats_ID = Pants.FK_sweats_ID
-- inner join Size  on Size.PK_size_ID = Sweats.FK_size_ID 

 --=========================================================================================================

 --SHOESS
 --Sandals--
 --select * from Shoe_Size

 insert into Sandals values ('Flip-flop','adidas',1, 2)
 insert into Sandals values ('Slides' , 'Jordans', 0, 3)
 insert into Sandals values ('tatami Sandals','Target',1,7)

 --select Sandal_name , brand_Name, s.shoe_Size 
 --from Sandals
 --inner join Shoe_Size s on s.PK_shoe_Size_ID = Sandals.FK_shoe_Size_ID;



 ------------------------------------------------------------------------------------------------------------
 insert into Boots values ('Work Boots','Timberlands', 1,4)
 insert into Boots values ('Duck Boots','POLO',1,6)






 select* from Boots,Sandals

 insert into Password values ('testpassword')
 select * from password
 
 insert into username values ('test',1,0,getdate(),getdate())
 
 select * from username
 
 select customer_first_Name,U.username,customer_last_name,customer_Address , 
 c.city_name, s.state_Name, CO.country_name
 from customers
inner join city C on C.PK_city_ID = customers.FK_city_ID
inner join state s on s.PK_state_ID = customers.FK_state_ID
inner join country CO on CO.PK_country_ID = customers.FK_country_ID
inner join username U on U.PK_user_ID = customers.FK_username_ID

 insert into customers values ('John','Jay','123 main st',1,1,1,1)
 select * from user_upload
 select * from city
 drop table customers 


 drop table username

--alter table customers NOCHECK constraint all
--alter table password NOCHECK constraint all
--alter table username NOCHECK constraint all
--alter table user_upload NOCHECK constraint all

drop table username
alter table customers check constraint all