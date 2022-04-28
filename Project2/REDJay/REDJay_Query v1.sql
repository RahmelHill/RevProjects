
---------------------------------------------------------------------------------------
--update Size 
--set clothing_size = 'Small'
--where Pk_size_ID = 1;

-- for inserting constant size in DB
insert into Size Values ('Small');
insert into Size values('Meduim');
insert into Size values ('Large');
select * from Size
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

Select * from Size_Suit;

------------------------------------------------------------------------------------------
 -- inserting city values
insert into City values('New York City');
insert into City values('Houston');
insert into City values('Jacksonville');
insert into City values('Atlanta');
insert into City values('Chicago');
insert into City values('Detroit');
insert into City values ('Los Angeles');
 
 select * from city;

 -------------------------------------------------------------------------------------------------------
 --inserting values for city

 insert into State values('New York');
 
 insert into State values('Texas');
 
 insert into State values('Florida');
 
 insert into State values('Georgia');
 
 insert into State values('Illinois');
 
 insert into State values('California');
 
 insert into State values('Michigan');

 select * from state;
 select * from city;

 ---------------------------------------------------------------------------------------------
 -- insert into country values
 
 insert into Country values ('MURICA');
 select * FROM Country;

 --------------------------------------------------------------------------------------------------------
 -- insert condition values
 
 insert into Condition values ('New');
insert into Condition values ('Good');
insert into Condition values ('Fair');
insert into Condition values ('Recycleable');
insert into Condition values ('Why bother');

select * from Condition;

------------------------------------------------------------------------------------------------------

-- inserting data to the shoe_size table
insert into shoe_size values('10.5 Men / 12 Women');
insert into shoe_size values('10 Men / 11.5 Women');
insert into shoe_size values('9.5 Men / 11 Women');
insert into shoe_size values('9 Men / 10.5 Women');
insert into shoe_size values('8.5 Men / 10 Women');

select * from shoe_size;
--===============================================================================================
--===================================================================================================

insert into Store_Location values ('REDJay1','123 main st',2,2,1);

select store_Name, store_Address, City.city_name, State.State_Name,Country.country_name from Store_location 
inner join City on Store_Location.FK_city_ID = City.PK_city_ID
inner join State on Store_Location.FK_state_ID = State.PK_state_ID
inner join Country on Store_Location.FK_country_ID = Country.PK_country_ID
;


