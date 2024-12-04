-- Create Customers Table
CREATE TABLE car_management.Customer (
    CustomerId int NOT NULL,
    Name varchar(255) NOT NULL,
	PRIMARY KEY(CustomerId)
);
-- Create Buyers Table
CREATE TABLE car_management.Buyer (
    BuyerId int NOT NULL,
    Name varchar(255) NOT NULL,
	PRIMARY KEY(BuyerId)
);
-- Create Admins Table
CREATE TABLE car_management.Admin (
    AdminId int NOT NULL,
    Name varchar(255) NOT NULL,
	PRIMARY KEY(AdminId)
);

-- Create a table to store models, retrieve all models, and allow customers to select one.
CREATE TABLE car_management.Model (
    ModelId int NOT NULL,
    Name varchar(255) NOT NULL,
    PRIMARY KEY(ModelId)
);

-- Create a submodels table, retrieve all submodels based on the selected model, and allow the customer to choose one.
CREATE TABLE car_management.Submodel (
    SubmodelId int NOT NULL,
	ModelId int NOT NULL,
    Name varchar(255) NOT NULL,
    PRIMARY KEY(SubmodelId),
    FOREIGN KEY (ModelId) REFERENCES Model(ModelId)
);

-- Create a locations table, retrieve all locations, and assign a location to a car upon creation.
CREATE TABLE car_management.Location (
    LocationId int NOT NULL,
    Zipcode varchar(5) NOT NULL,
    PRIMARY KEY(LocationId)
);

-- Create a cars table and allow customers to add entries.
CREATE TABLE car_management.Car (
    CarId int NOT NULL,
    Make varchar(255) NOT NULL,
    Year int NOT NULL,
    CustomerId int NOT NULL,
    SubmodelId int NOT NULL,
    LocationId int NOT NULL,
    -- Assign CustomerId using the token and allow the customer to add a car.
    FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId),
    -- Allow the customer to select the Submodel.
    FOREIGN KEY (SubmodelId) REFERENCES Submodel(SubmodelId),
    -- Allow the customer to select the Location.
    FOREIGN KEY (LocationId) REFERENCES Location(LocationId),
    PRIMARY KEY(CarId)
);

-- Create Offers Table, add by Buyer.
CREATE TABLE car_management.Offer (
    OfferId int NOT NULL,
    PaidMark bit DEFAULT FALSE,
    Amount DECIMAL(18, 2) NOT NULL,
    BuyerId int NOT NULL,
	CarId int NOT NULL,
    -- Assign the BuyerId using the token.
	FOREIGN KEY (BuyerId) REFERENCES Buyer(BuyerId),
    -- Allow the buyer to select the Car.
	FOREIGN KEY (CarId) REFERENCES Car(CarId),
    PRIMARY KEY(OfferId)
);

-- Create a CarHistory table and allow the admin to add entries based on actions taken.
CREATE TABLE car_management.CarHistory(
    CarHistoryId int NOT NULL,
    Status varchar(10) NOT NULL,
    CreationDate DATE NOT NULL,
    AdminId int NOT NULL,
	CarId int NOT NULL,
    -- Assign AdminId using the token.
	FOREIGN KEY (AdminId) REFERENCES Admin(AdminId),
    -- Record the CarId for which the status has changed.
	FOREIGN KEY (CarId) REFERENCES Car(CarId),
    PRIMARY KEY(CarHistoryId)
);
