CREATE TABLE Guest(
	Id int identity(1,1) PRIMARY KEY,
	[Name] varchar(100) NOT NULL,
	[LastName] varchar(100) NOT NULL,
	[MiddleName] varchar(100) NULL,
	[Phone] varchar(11) NOT NULL,
	[PassportSeria] varchar(4) NOT NULL,
	[PassportNamber] varchar(6) NOT NULL,
	[Email] varchar(50) NULL
	)
CREATE TABLE TypeNumber(
Id int identity(1,1) PRIMARY KEY,
[Name] varchar(100) NOT NULL,
[Amount] int NULL,
[AmountOfFree] int NULL,
[AmountOfGuets] int NULL,
[Food] bit NOT NULL
)
CREATE TABLE RoomNumber(
[Number]  int PRIMARY KEY,
[Floor] int NOT NULL,
[Type] int NOT NULL REFERENCES TypeNumber(Id),
[Free] bit NULL,
[CountPerDay] int NOT NULL,
IsClear bit NULL
)
CREATE TABLE Offer(
Id int identity(1,1) PRIMARY KEY,
[Name] varchar(100) NOT NULL,
[Discount] int NOT NULL,
[Start] DATE NULL,
[Finish] DATE NULL
)
CREATE TABLE Booking(
Id int identity(1,1) PRIMARY KEY,
Guest int NOT NULL REFERENCES Guest(Id),
[Number] int NOT NULL REFERENCES RoomNumber(Number),
AmountOfGuest int NOT NULL,
SettleDate DATE NOT NULL,
AmoungOfDays int NOT NULL,
Offer int NULL REFERENCES Offer(Id),
[Count] int NOT NULL
)
CREATE TABLE Additional(
Id int identity(1,1) PRIMARY KEY,
[Name] varchar(100) NOT NULL,
Price int NOT NULL
)
CREATE TABLE AddForBooking(
Booking int REFERENCES Booking(Id),
[Add] int REFERENCES Additional(Id),
)
CREATE TABLE Settling(
Id int identity(1,1) PRIMARY KEY,
Guest int NOT NULL REFERENCES Guest(Id),
[Number] int NOT NULL REFERENCES RoomNumber(Number),
AmountOfGuest int NOT NULL,
SettleDate DATE NOT NULL,
UnsettleDate DATE NOT NULL,
Booking int REFERENCES Booking(Id),
[Count] int NOT NULL
)
CREATE TABLE TypeEquipment(
Id int identity(1,1) PRIMARY KEY,
[Name] varchar(100) NOT NULL
)
CREATE TABLE Furniture(
Id int identity(1,1) PRIMARY KEY,
[Type] int NOT NULL REFERENCES TypeEquipment(Id),
[Description] varchar(255) NOT NULL,
Amount int NULL,
Price int NOT NULL
)
CREATE TABLE NumberEquipment(
Number int NOT NULL REFERENCES RoomNumber(Number),
Furniture int NOT NULL REFERENCES Furniture(Id),
Amount int NOT NULL
)
CREATE TABLE DestroyEquipment(
Settle int REFERENCES Settling(Id),
Furniture int NOT NULL REFERENCES Furniture(Id),
Fine int NULL
)