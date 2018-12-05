/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: Menu
------------------------------------------------------------*/
CREATE TABLE Menu(
	ID     INT IDENTITY (1,1) NOT NULL ,
	Name   VARCHAR (255) NOT NULL  ,
	CONSTRAINT Menu_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: RoundTable
------------------------------------------------------------*/
CREATE TABLE RoundTable(
	ID         INT IDENTITY (1,1) NOT NULL ,
	Number     INT  NOT NULL ,
	Quantity   INT  NOT NULL  ,
	CONSTRAINT RoundTable_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: Customer
------------------------------------------------------------*/
CREATE TABLE Customer(
	ID              INT IDENTITY (1,1) NOT NULL ,
	Name            VARCHAR (255) NOT NULL ,
	Waiting         INT  NOT NULL ,
	Reservation     bit  NOT NULL ,
	ID_RoundTable   INT    ,
	CONSTRAINT Customer_PK PRIMARY KEY (ID)

	,CONSTRAINT Customer_RoundTable_FK FOREIGN KEY (ID_RoundTable) REFERENCES RoundTable(ID)
);


/*------------------------------------------------------------
-- Table: Dishes
------------------------------------------------------------*/
CREATE TABLE Dishes(
	ID              INT IDENTITY (1,1) NOT NULL ,
	Name            VARCHAR (255) NOT NULL ,
	Wash_Duration   INT  NOT NULL ,
	Stock           INT  NOT NULL ,
	Category        VARCHAR (255) NOT NULL  ,
	CONSTRAINT Dishes_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: Recipe
------------------------------------------------------------*/
CREATE TABLE Recipe(
	ID         INT IDENTITY (1,1) NOT NULL ,
	Name       VARCHAR (255) NOT NULL ,
	Category   VARCHAR (255) NOT NULL ,
	Price      INT  NOT NULL  ,
	CONSTRAINT Recipe_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: Ingredient
------------------------------------------------------------*/
CREATE TABLE Ingredient(
	ID        INT IDENTITY (1,1) NOT NULL ,
	Name      VARCHAR (255) NOT NULL ,
	Stock     INT  NOT NULL ,
	Season    VARCHAR (255) NOT NULL ,
	Refresh   VARCHAR (255) NOT NULL  ,
	CONSTRAINT Ingredient_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: Utensil
------------------------------------------------------------*/
CREATE TABLE Utensil(
	ID             INT IDENTITY (1,1) NOT NULL ,
	Name           VARCHAR (255) NOT NULL ,
	Stock          INT  NOT NULL ,
	Washing_Time   INT  NOT NULL  ,
	CONSTRAINT Utensil_PK PRIMARY KEY (ID)
);


/*------------------------------------------------------------
-- Table: Command
------------------------------------------------------------*/
CREATE TABLE Command(
	ID        INT  NOT NULL ,
	ID_Menu   INT  NOT NULL  ,
	CONSTRAINT Command_PK PRIMARY KEY (ID,ID_Menu)

	,CONSTRAINT Command_Customer_FK FOREIGN KEY (ID) REFERENCES Customer(ID)
	,CONSTRAINT Command_Menu0_FK FOREIGN KEY (ID_Menu) REFERENCES Menu(ID)
);


/*------------------------------------------------------------
-- Table: Include
------------------------------------------------------------*/
CREATE TABLE Include(
	ID        INT  NOT NULL ,
	ID_Menu   INT  NOT NULL  ,
	CONSTRAINT Include_PK PRIMARY KEY (ID,ID_Menu)

	,CONSTRAINT Include_Recipe_FK FOREIGN KEY (ID) REFERENCES Recipe(ID)
	,CONSTRAINT Include_Menu0_FK FOREIGN KEY (ID_Menu) REFERENCES Menu(ID)
);


/*------------------------------------------------------------
-- Table: Using
------------------------------------------------------------*/
CREATE TABLE Using(
	ID          INT  NOT NULL ,
	ID_Dishes   INT  NOT NULL  ,
	CONSTRAINT Using_PK PRIMARY KEY (ID,ID_Dishes)

	,CONSTRAINT Using_RoundTable_FK FOREIGN KEY (ID) REFERENCES RoundTable(ID)
	,CONSTRAINT Using_Dishes0_FK FOREIGN KEY (ID_Dishes) REFERENCES Dishes(ID)
);


/*------------------------------------------------------------
-- Table: Step
------------------------------------------------------------*/
CREATE TABLE Step(
	ID              INT  NOT NULL ,
	ID_Ingredient   INT  NOT NULL ,
	ID_Recipe       INT  NOT NULL ,
	Time            INT  NOT NULL  ,
	CONSTRAINT Step_PK PRIMARY KEY (ID,ID_Ingredient,ID_Recipe)

	,CONSTRAINT Step_Utensil_FK FOREIGN KEY (ID) REFERENCES Utensil(ID)
	,CONSTRAINT Step_Ingredient0_FK FOREIGN KEY (ID_Ingredient) REFERENCES Ingredient(ID)
	,CONSTRAINT Step_Recipe1_FK FOREIGN KEY (ID_Recipe) REFERENCES Recipe(ID)
);



