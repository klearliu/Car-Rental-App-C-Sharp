use Project291;


drop table RentalTransactions;
drop table Employees;
drop table CARS;
drop table CarTypes;
drop table Branches;
drop table Customers;




CREATE TABLE Branches(
Branch_ID nchar(2) primary key,
BranchName nchar(20) not null,
street_name nchar(20) not null,
street_number nchar(25) not null,
apt_number nchar(4) null,
postal_number nchar(7) not null,
City nchar(15) not null,
Province nchar(2) not null,
Country nchar(6) not null,
Phone nchar(12) not null
);


CREATE TABLE CarTypes(
CarTypeID nchar(5) primary key,
DailyRate nchar(6) not null,
WeeklyRate nchar(3) not null,
MonthlyRate nchar(4) not null,
ChangeBranchFee nchar(3) not null,
LateFee nchar(3) not null
);

CREATE TABLE Customers( 
Cust_ID nchar(5) primary key,
FirstName nchar(12) not null,
LastName nchar(12) not null,
street_name nchar(20) not null,
street_number nchar(5) not null,
apt_number nchar(4) null,
postal_code nchar(7) not null,
City nchar(15) not null,
Province nchar(2) not null,
Country nchar(6) not null,
Email nchar(43) not null,
MembershipStatus nchar(1) not null,
CardOnFile nchar(16) not null,
Phone nchar(14) not null
);

CREATE TABLE CARS(
Car_ID nchar(5) primary key,
PlateNo nchar(8) not null,
Make nchar(15) not null,
Model nchar(15) not null,
Price nchar(6) not null,
Mileage nchar(6) not null,
Rating numeric(2,1) null,
Colour nchar(6) not null,
[Year] nchar(4) not null,
BodyType nchar(6) not null,
TransmissionType nchar(9) not null,
FuelType nchar(8) not null,
SeatCapacity nchar(3) not null,
CarTypeID nchar(5) not null FOREIGN KEY REFERENCES CarTypes(CarTypeID),
Branch_ID nchar(2) not null FOREIGN KEY REFERENCES Branches(Branch_ID)
);

CREATE TABLE Employees(
Emp_ID nchar(6) primary key,
FirstName nchar(12) not null,
LastName nchar(12) not null,
Sex nchar(2) not null,
DateStarted nchar(10) not null,
Phone nchar(12) not null,
TotalEarnings nchar(10) not null,
Branch_ID nchar(2) FOREIGN KEY REFERENCES Branches(Branch_ID)
);

CREATE TABLE RentalTransactions(
Transaction_ID nchar(5) primary key,
RequestedCarType nchar(6) not null,
ActualCarType nchar(6) null,
PickupBranchID nchar(2) not null,
ReturnBranchID nchar(2) null,
Price nchar(6) not null,
LateFee nchar(6) null,
TotalFees nchar(8) null,
date_from DATE not null,
date_to DATE not null,
date_returned DATE null,
isMember nchar(2) null,
Emp_ID nchar(6) FOREIGN KEY REFERENCES Employees(Emp_ID),
Cust_ID nchar(5) FOREIGN KEY REFERENCES Customers(Cust_ID),
Car_ID nchar(5) FOREIGN KEY REFERENCES CARS(Car_ID)
);

