
CREATE TABLE Size
(
  PK_size_ID    INT      NOT NULL   Identity,
  clothing_size VARCHAR (6) NOT NULL,
  PRIMARY KEY (PK_size_ID)
);

CREATE TABLE Size_Suit
(
  PK_suit_Size_ID INT          NOT NULL   Identity,
  suit_Size       VARCHAR (10) NOT NULL,
  PRIMARY KEY (PK_suit_Size_ID)
);
     
	 
CREATE TABLE Categories
(
  PK_clothing_ID INT NOT NULL  Identity,
  PRIMARY KEY (PK_clothing_ID)
);


CREATE TABLE City
(
  PK_city_ID INT          NOT NULL  Identity,
  city_Name  VARCHAR (50) NOT NULL,
  PRIMARY KEY (PK_city_ID)
);



CREATE TABLE Condition
(
  PK_condition_ID INT NOT NULL  Identity,
  item_Condition  VARCHAR (10) NOT NULL,
  PRIMARY KEY (PK_condition_ID)
);

CREATE TABLE Country
(
  PK_country_ID INT          NOT NULL  Identity,
  country_Name  VARCHAR (50) NOT NULL,
  PRIMARY KEY (PK_country_ID)
);
CREATE TABLE Shoe_Size
(
  PK_shoe_Size_ID INT     NOT NULL   Identity,
  shoe_Size       VARCHAR(30) NOT NULL,
  PRIMARY KEY (PK_shoe_Size_ID)
);



CREATE TABLE State
(
  PK_state_ID INT          NOT NULL   Identity,
  state_Name  VARCHAR (50) NOT NULL,
  PRIMARY KEY (PK_state_ID)
);
CREATE TABLE User_P
(
  PK_user_ID    INT          NOT NULL   Identity,
  user_Name     VARCHAR (50) NOT NULL   UNIQUE,
  user_Password VARCHAR (50) NOT NULL   UNIQUE,
  PRIMARY KEY (PK_user_ID)
);

-------------------------------------------------------------------------------------------------------------------------------------




--CREATE TABLE Clothing
--(
--  PK_clothing_ID INT NOT NULL PRIMARY KEY Identity,
--  clothing_ID INT NULL Foreign Key REFERENCES Size(PK_shoe_Size_ID),
--  );
CREATE TABLE Store_Location
(
  PK_Store_Location_ID int          NOT NULL   Identity,
  store_Name           VARCHAR (50) NOT NULL,
  store_Address        VARCHAR (50) NOT NULL,
   FK_city_ID          INT          NOT NULL foreign KeY REFERENCES City(PK_City_ID),
  FK_state_ID         INT          NOT NULL foreign KeY REFERENCES State(PK_State_ID),
  FK_country_ID       INT          NOT NULL foreign KeY REFERENCES Country(PK_Country_ID),
  PRIMARY KEY (PK_Store_Location_ID)
);

CREATE TABLE Customers
(
  customer_First_Name VARCHAR (50) NOT NULL,
  customer_Last_Name  VARCHAR (50) NOT NULL,
  customer_Address    VARCHAR (50) NOT NULL,
  FK_city_ID          INT          NOT NULL foreign KeY REFERENCES City(PK_City_ID),
  FK_state_ID         INT          NOT NULL foreign KeY REFERENCES State(PK_State_ID),
  FK_country_ID       INT          NOT NULL foreign KeY REFERENCES Country(PK_Country_ID),
  PK_customer_ID      INT          NOT NULL   Identity,
  PRIMARY KEY (PK_customer_ID)
);

CREATE TABLE User_Upload
(
  PK_cart_ID      INT             NOT NULL DEFAULT Identity,
  FK_customer_ID  INT             NOT NULL DEFAULT Foreign Key,
  upload_Category VARCHAR (50)    NOT NULL,
  upload_Style    VARCHAR (50)    NOT NULL,
  upload_Brand    VARCHAR (50)    NOT NULL,
  item_Image      VARBINARY (MAX) NOT NULL,
  upload_Size     VARCHAR (50)    NOT NULL,
  PRIMARY KEY (PK_cart_ID)
);



CREATE TABLE Jackets_Coats
(
  PK_jacket_coat_ID INT NOT NULL   Primary Key  Identity,
  FK_size_ID        INT NOT NULL   Foreign KeY REFERENCES Size( PK_Size_ID)
  
 
);




CREATE TABLE Jeans
(
  PK_jeans_ID INT PRIMARY KEY     NOT NULL   Identity,
  jean_Style  VARCHAR (50) NOT NULL,
  jean_Brand  VARCHAR (50) NOT NULL,
  FK_size_ID  INT          NOT NULL   Foreign KeY REFERENCES Size( PK_Size_ID),
 
);


CREATE TABLE Sweats
(
  PK_sweats_ID INT PRIMARY KEY NOT NULL   Identity,
  sweats_Style VARCHAR (50) NOT NULL,
  sweats_Brand VARCHAR (50) NOT NULL,
  FK_size_ID   INT          NOT NULL   Foreign Key REFERENCES Size( PK_Size_ID)
);


CREATE TABLE Shorts
(
  PK_shorts_ID INT PRIMARY KEY NOT NULL   Identity,
  shorts_Style VARCHAR (50) NOT NULL,
  shorts_Brand VARCHAR (50) NOT NULL,
  FK_size_ID   INT          NOT NULL   Foreign Key REFERENCES Size( PK_Size_ID)
);


CREATE TABLE Pants
(
  PK_pants_ID  INT NOT NULL   Primary Key Identity,
  FK_shorts_ID INT NOT NULL   Foreign Key references Shorts( PK_shorts_ID),
  FK_jeans_ID  INT NOT NULL   Foreign Key references Jeans(PK_jeans_ID),
  FK_sweats_ID INT NOT NULL   Foreign Key references Sweats(PK_sweats_ID)
  
);




CREATE TABLE Sandals
(
  PK_sandals_ID   INT          NOT NULL   Identity,
  sandal_Name     VARCHAR (50) NOT NULL,
  brand_Name      VARCHAR (50) NOT NULL,
  in_Stock        BIT          NOT NULL,
  FK_shoe_Size_ID INT          NOT NULL foreign KeY REFERENCES Shoe_Size(PK_shoe_Size_ID),
  PRIMARY KEY (PK_sandals_ID)
);

CREATE TABLE Boots
(
  PK_boots_ID     INT          NOT NULL  Identity,
  boot_Name       VARCHAR (50) NOT NULL,
  brand_Name      VARCHAR (50) NOT NULL,
  In_Stock        BIT          NOT NULL,
  FK_shoe_Size_ID INT          NOT NULL foreign KeY REFERENCES Shoe_Size(PK_shoe_Size_ID),
  PRIMARY KEY (PK_boots_ID)
);


CREATE TABLE Sneakers
(
  PK_sneaker_ID   INT          NOT NULL   Identity,
  sneaker_Name    VARCHAR (50) NOT NULL,
  brand_Name      VARCHAR (50) NOT NULL,
  in_Stock        BIT          NOT NULL,
  FK_shoe_Size_ID INT          NOT NULL foreign KeY REFERENCES Shoe_Size(PK_shoe_Size_ID),
  PRIMARY KEY (PK_sneaker_ID)
);

CREATE TABLE Shoes
(
  PK_shoe_ID    INT NOT NULL   Identity,
  FK_sneaker_ID INT NOT NULL foreign KeY REFERENCES Sneakers(PK_sneaker_ID),
  FK_sandals_ID INT NOT NULL foreign KeY REFERENCES Sandals(PK_sandals_ID),
  FK_boots_ID   INT NOT NULL foreign KeY REFERENCES Boots(PK_boots_ID),
  PRIMARY KEY (PK_shoe_ID)
);

CREATE TABLE Full_Piece_Suit
(
  PK_full_Suit    INT          NOT NULL   Identity,
  style_Name      VARCHAR (50) NOT NULL,
  brand_Name      VARCHAR (50) NOT NULL,
  FK_suit_Size_ID INT     NOT NULL  Foreign KeY REFERENCES Size_Suit( PK_suit_Size_ID),
  PRIMARY KEY (PK_full_Suit)
);

CREATE TABLE Suit_Bottom
(
  PK_suit_Bottom  INT          NOT NULL   Identity,
  style_Name      VARCHAR (50) NOT NULL,
  brand_Name      VARCHAR (50) NOT NULL,
  FK_suit_Size_ID INT          NOT NULL Foreign KeY REFERENCES Size_Suit( PK_suit_Size_ID),
  PRIMARY KEY (PK_suit_Bottom)
);

CREATE TABLE Suit_Top
(
  PK_suit_Top     INT          NOT NULL   Identity,
  style_Name      VARCHAR (50) NOT NULL,
  brand_Name      VARCHAR (50) NOT NULL,
  FK_suit_Size_ID INT          NOT NULL Foreign KeY REFERENCES Size_Suit( PK_suit_Size_ID),
  PRIMARY KEY (PK_suit_Top)
);

CREATE TABLE Suits
(
  PK_suit_ID     INT NOT NULL   Identity,
  FK_full_Suit   INT NOT NULL foreign key references Full_Piece_Suit(PK_full_Suit) ,
  FK_suit_Bottom INT NOT NULL foreign key references Suit_Bottom(PK_suit_Bottom),
  FK_suit_Top    INT NOT NULL foreign key references Suit_Top(PK_suit_Top),
  PRIMARY KEY (PK_suit_ID)
);





CREATE TABLE T_Shirts
(
  PK_t_shirt_ID INT NOT NULL   Identity,
  FK_size_ID    INT NOT NULL Foreign Key REFERENCES Size( PK_Size_ID),
  PRIMARY KEY (PK_t_shirt_ID)
);

CREATE TABLE Tank_Tops
(
  PK_tank_top_ID INT NOT NULL   Identity,
  FK_size_ID     INT NOT NULL Foreign Key REFERENCES Size( PK_Size_ID),
  PRIMARY KEY (PK_tank_top_ID)
);

CREATE TABLE Shirts
(
  PK_shirts_ID   INT NOT NULL   Identity,
  FK_t_shirt_ID  INT NOT NULL Foreign key references T_Shirts(PK_t_shirt_ID),
  FK_tank_top_ID INT NOT NULL Foreign key references Tank_Tops(PK_tank_top_ID),
  PRIMARY KEY (PK_shirts_ID)
);
--CREATE TABLE Toys
--(
--  PK_toy_ID INT NOT NULL   Primary Key iDENTITY
--);
--CREATE TABLE Electronics
--(
--  PK_electronics_ID INT NOT NULL   Primary Key Identity
  
--);
--CREATE TABLE System Logs
--
--/);
--CREATE TABLE Pending_Approval
--(
--  PK_pending_ID INT NOT NULL   Identity,
--  _approval     BIT NOT NULL,
--  PRIMARY KEY (PK_pending_ID)
--);
--CREATE TABLE Login
--(
--  FK_customer_ID     INT      NOT NULL,
--  login_Date_Created DATE     NOT NULL,
--  login_Date_Logged  DATETIME NOT NULL,
--  FK_user_ID         INT      NOT NULL
--);

--CREATE TABLE User_Upload
--(
--  PK_cart_ID     INT PRIMARY KEY NOT NULL   Identity,
--  item_Image     VARBINARY (MAX) NOT NULL,
--  FK_customer_ID INT             NOT NULL   Foreign Key
--);
