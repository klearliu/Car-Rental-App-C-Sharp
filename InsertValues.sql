use Project291;

DELETE FROM RentalTransactions;
DELETE FROM CARS;
DELETE FROM Employees;
DELETE FROM Branches;
DELETE FROM CarTypes;
DELETE FROM Customers;


--Customers
insert into Customers values('0', 'Blurry', 'Uil', 'Grantst', '120', null, 'T1Z2F5', 'Edmonton', 'AB', 'Canada', 'blurryuil@gmail.com', 'Y', '1234567890101112', '7805550184')
insert into Customers values('1', 'Blart', 'Miller', '82st', '118', null, 'T2W5H5', 'Calgary', 'AB', 'Canada', 'blartmiller@gmail.com', 'Y', '4485186509367598', '7807145386')
insert into Customers values('2', 'Huda', 'Gibson', 'BroadSt', '118', null, 'T9G3G7', 'Edmonton', 'AB', 'Canada', 'hudagibson@gmail.com', 'N', '4485186509367598', '7809379576')
insert into Customers values('3', 'Callie', 'Gutierrez', 'AshurstLn', '122', null, 'L4G 0R6', 'Toronto', 'ON', 'Canada', 'calliegutierrez@gmail.com', 'Y', '5329459664892651', '4160302817')
insert into Customers values('4', 'Teagan', 'Rennie', 'LyntonLn', '155', null, 'N4B 6J0', 'Ottawa', 'ON', 'Canada', 'teaganrennie@gmail.com', 'Y', '5508469873630381', '6136428135')
insert into Customers values('5', 'Dannielle', 'Watson', 'CaerkaverockRd', '109', null, 'N4K 2H3', 'Toronto', 'ON', 'Canada', 'danniellewatson@gmail.com', 'Y', '4024007100173540', '4167737473')
insert into Customers values('6', 'Devonte', 'Castro', 'BrockhamptonSt', '107', null, 'V3H0K4', 'Vancouver', 'BC', 'Canada', 'devontecastro@gmail.com', 'N', '5361919949062338', '3605609512')
insert into Customers values('7', 'Sandra', 'Vazquez', 'PatrickbankCr', '199', null, 'V0L6H2', 'Vancouver', 'BC', 'Canada', 'sandravazquez@gmail.com', 'N', '6011020210461432', '3600342639')
insert into Customers values('8', 'Taran', 'Bean', 'MapleRd', '100', null, 'M6C2K1', 'Ottawa', 'ON', 'Canada', 'taranbean@gmail.com', 'Y', '4556084849398932', '6138336704')
insert into Customers values('9', 'Rebeca', 'Cooke', 'CandlerockRd', '101', null, 'V9L7N4', 'Vancouver', 'BC', 'Canada', 'rebecacooke@gmail.com', 'N', '5327786997245716', '3602941021')

insert into Customers values('10', 'Sawcon', 'Tease', 'Newts', '88', null, 'T5B8P9', 'Edmonton', 'AB', 'Canada', 'sawcontease98@gmail.com', 'N', '8886495702134578', '7806435885')
insert into Customers values('11', 'Sugma', 'Nux', 'Alma', '12', null, 'V9K8K3', 'Calgary', 'AB', 'Canada', 'sugmanux@hotmail.com', 'N', '8466495794134578', '5876456885')
insert into Customers values('12', 'Sandra', 'Tax', 'Emeraisle', '60', 11, 'N5B1P9', 'Vancouver', 'BC', 'Canada', 'Staxdra@gmail.com', 'Y', '6432495704834578', '7806446181')
insert into Customers values('13', 'Laxa', 'Tik', 'Knox', '18', null, 'T5C1P9', 'Edmonton', 'AB', 'Canada', 'skateboarddog@gmail.com', 'N', '8886491322134578', '7806435885')
insert into Customers values('14', 'Naruto', 'Uzumaki', 'Leaf', '13', null, 'T5B7P9', 'Edmonton', 'AB', 'Canada', 'narusasu12@gmail.com', 'N', '3364982663184579', '7806956285')
insert into Customers values('15', 'Light', 'Yagami', 'Opa', '23', 5, 'V8B2P9', 'Ottawa', 'ON', 'Canada', 'delightfulL123@gmail.com', 'N', '8848495762534578', '5876466862')
insert into Customers values('16', 'Gingka', 'Haganae', 'Metal', '66', null, 'A6K8L9', 'Toronto', 'ON', 'Canada', 'stormpegasus@beyblade.com', 'Y', '8886155702169378', '7806166895')
insert into Customers values('17', 'Tanjiro', 'Kamado', 'Demon', '12', 36, 'T3E7P5', 'Edmonton', 'AB', 'Canada', 'nezu5imper@slayer.com', 'N', '8886413202164978', '7809995785')
insert into Customers values('18', 'Dio', 'Brando', 'Jojo', '52', null, 'RB83P9', 'Calgary', 'AB', 'Canada', 'diobrando@siwa.com', 'N', '8786413602179578', '7804436975')
insert into Customers values('19', 'Ichigo', 'Kurosaki', 'Bleach', '44', null, 'W5K8P4', 'Toronto', 'ON', 'Canada', 'bootlegninja122@gmail.com', 'N', '8883334502134578', '5876435132')
insert into Customers values('20', 'Nezuko', 'Kamado', 'Bamboo', '63', null, 'R5M2L9', 'Calgary', 'AB', 'Canada', 'nezukoeatsbamboo@demon.com', 'Y', '8332655702134578', '5498562346')


insert into Customers values('21', 'Mark', 'Spot', 'Golden Way', '40', null, 'T4S9H6', 'Calgary', 'AB', 'Canada', 'Markg@gmail.com', 'N', '3353045370387259', '7805556666')
insert into Customers values('22', 'Steve', 'Pe', 'Rose', '60', null, 'T7S7L1', 'Vancouver', 'BC', 'Canada', 'SteveePeeze@gmail.com', 'Y', '6465801653309301', '7805435766')
insert into Customers values('23', 'Jo', 'Usama', 'Apple', '10', null, 'T5F6B9', 'Vancouver', 'BC', 'Canada', 'Jojo10@gmail.com', 'Y', '3771043715852735', '55588887777')
insert into Customers values('24', 'Isabella', 'Rada', 'Woods', '99', null, 'B5H3S6', 'Edmonton', 'AB', 'Canada', 'izzy9@gmail.com', 'N', '1317334687077612', '7806665555')
insert into Customers values('25', 'Audhild', 'Festus', 'Misteltoe Drive', '07', null, 'Y5H7S2', 'Edmonton', 'AB', 'Canada', 'festus5@gmail.com', 'N', '5523507236863237', '7802139855')
insert into Customers values('26', 'Lynsey', 'Aslaug', 'Loch Road', '78', null, 'P5P5P5', 'Toronto', 'ON', 'Canada', 'lochaslaug@hotmail.com', 'N', '1168311661927026', '6662221111')
insert into Customers values('27', 'Derby', 'Bianka', 'Thorncliff Place', '44', null, 'H6Y8H6', 'Ottawa', 'ON', 'Canada', 'bDerby@shaw.ca', 'Y', '4166607258620526', '9874563210')
insert into Customers values('28', 'Vitalianus', 'Ela', 'Springfield Plaza', '65', null, 'E3E4A4', 'Toronto', 'ON', 'Canada', 'VelaV5@gmail.com', 'N', '9968421985531221', '1023654789')
insert into Customers values('29', 'Debbie', 'Arleen', 'Melody Drive', '25', null, 'L1L7C9', 'Ottawa', 'ON', 'Canada', 'DebbsA4@gmail.com', 'Y', '4522843293185887', '5225448963')
insert into Customers values('30', 'Ljuba', 'Avaline', 'Silver Way', '19', null, 'T5L7C5', 'Calgary', 'AB', 'Canada', 'jubajuba3@gmail.com', 'N', '9467350843063099', '3836547898')

insert into Customers values('31', 'Schlomo', 'Gooberdapple', 'MacLaren', '1452', null, 'K8H7C8', 'Edmonton', 'AB', 'Canada', 'sgooberdapple@gmail.com', 'Y', '6755369592493649', '7806567430')
insert into Customers values('32', 'Johnny', 'Oxhandler', 'Quayside', '3068', null, 'G4W3V3', 'Vancouver', 'BC', 'Canada', 'joxhandler@gmail.com', 'N', '2670187302071268', '6049229375')
insert into Customers values('33', 'Joe', 'Jenkins', 'Reserve', '601', null, 'E4E7X4', 'Edmonton', 'AB', 'Canada', 'jjenkins@gmail.com', 'N', '7817752925982611', '7801132258')
insert into Customers values('34', 'Hugo', 'Hensley', 'Toy', '4155', null, 'T7V3A1', 'Calgary', 'AB', 'Canada', 'hhensley@gmail.com', 'Y', '8208150415935930', '4036496475')
insert into Customers values('35', 'Cyrus', 'Aguilar', 'Wascana', '4002', null, 'P2B6G1', 'Edmonton', 'AB', 'Canada', 'caguilar@gmail.com', 'Y', '4191302302868903', '7805906890')
insert into Customers values('36', 'Jewell', 'Mccarthy', 'Eglinton', '524', null, 'L4G1N8', 'Calgary', 'AB', 'Canada', 'jmccarthy@gmail.com', 'N', '3413558773083526', '4031471353')
insert into Customers values('37', 'Darwin', 'Bautista', 'Bank', '4520', null, 'K8H7C8', 'Ottawa', 'AB', 'Canada', 'dbautista@gmail.com', 'N', '8103288587091979', '6135521478')
insert into Customers values('38', 'Connie', 'Evans', 'Dundas', '2575', null, 'G3G0V0', 'Toronto', 'AB', 'Canada', 'cevans@gmail.com', 'N', '5931463373097065', '4167768323')
insert into Customers values('39', 'Pam', 'Cordova', 'Robson', '272', null, 'B4P3J4', 'Toronto', 'AB', 'Canada', 'pcordova@gmail.com', 'N', '1568362598078806', '4161175767')
insert into Customers values('40', 'Hollis', 'Larson', 'Islington', '1707', null, 'H8R7L1', 'Vancouver', 'AB', 'Canada', 'hlarson@gmail.com', 'Y', '3193930708944170', '6045317089')


--CarTypes
insert into CarTypes values('1', '15', '98', '390', '200', '200');

insert into CarTypes values('2', '17', '112', '450', '220', '200');

insert into CarTypes values('3', '18', '119', '480', '230', '200');

insert into CarTypes values('4', '25', '168', '690', '300', '200');

insert into CarTypes values('5', '40', '273', '1140', '450', '200');

--Branches
insert into Branches values ('1', 'Edmonton', '10016', '106St', null, 'T5J1G1', 'Edmonton', 'AB', 'Canada', '7804482001');

insert into Branches values ('2', 'Vancouver', '5140', 'GrantMcConachieWay', null, 'V7B1V1', 'Vancouver', 'BC', 'Canada', '6046687000');

insert into Branches values ('3', 'Calgary',  '3328', '26St', null, 'T1Y4T7', 'Calgary', 'AB', 'Canada', '4032261550');

insert into Branches values ('4', 'Toronto', '2401', 'DundasSt', null, 'M6P1X2', 'Toronto', 'ON', 'Canada', '4165334126');

insert into Branches values ('5', 'Ottawa',	 '345', 'SlaterSt', null, 'K1R7X7', 'Ottawa', 'ON', 'Canada', '6132882498');


--Employees
insert into Employees values('101', 'John', 'Doe', 'M', '2020-08-19', '780-800-8513', '10000', '1');

insert into Employees values('102', 'Ashley', 'Johnson', 'F', '2020-02-08', '780-333-1010', '12232', '1');

insert into Employees values('201', 'Jason', 'Lee', 'M', '2018-06-09', '780-120-4443', '80010', '2');

insert into Employees values('202', 'Sven', 'Smith', 'M', '2019-02-07', '780-900-8723', '30000', '2');

insert into Employees values('203', 'Bella', 'Morella', 'F', '2021-07-12', '780-111-2213', '2000', '2');

insert into Employees values('301', 'Rajiv', 'Naidu', 'M', '2016-12-02', '780-111-1111', '1000000', '3');

insert into Employees values('302', 'Clear', 'Liu', 'M', '2016-11-01', '780-222-2222', '90000', '3');

insert into Employees values('401', 'Riley', 'lastname', 'M', '2016-02-12', '780-333-3333', '90000', '4');

insert into Employees values('402', 'Carson', 'Kirwer', 'M', '2016-01-10', '780-444-4444', '90000', '4');

insert into Employees values('501', 'Underpaid', 'worker', 'M', '2010-01-12', '780-000-0001', '100000000', '5');


--CARS
insert into CARS values('1000', '111-1111', 'Toyota', 'Corolla', '20000', '31922', 1.2, 'Blue', '2010', 'car', 'automatic', 'gasoline', '5', '1', '1'); 

insert into CARS values('1002', '333-3333', 'Chrysler', 'Pacifica', '30000', '12345', 1.2, 'Green', '2015', 'van', 'automatic', 'gasoline', '7', '2', '1');

insert into CARS values('1003', '444-4444', 'Honda', 'Odyssey', '40000', '54321', 1.5, 'Black', '2009', 'van', 'automatic', 'gasoline', '7', '2', '1');

insert into CARS values('1001', '222-2222', 'Hyundai', 'Corolla', '20000', '31922', 1.2, 'Red', '1992', 'car', 'automatic', 'gasoline', '5', '1', '1'); 

insert into CARS values('2650', '976-8000', 'Honda', 'Odyssey', '47200', '56321', 3.4, 'white', '2010', 'van', 'automatic', 'gasoline', '7', '1', '1');

insert into CARS values('2651', '976-0001', 'Honda', 'Civic', '33265', '56321', 3.4, 'white', '2010', 'car', 'automatic', 'gasoline', '7', '2', '2');

insert into CARS values('2677', '976-0002', 'Honda', 'Civic', '19555', '53321', 4.6, 'red', '2013', 'car', 'automatic', 'gasoline', '7', '3', '3');

insert into CARS values('2651', '976-0003', 'Honda', 'Accord', '35984', '4536', 2.6, 'green', '2013', 'car', 'automatic', 'hybrid', '7', '2', '3');

insert into CARS values('2652', '976-0004', 'Honda', 'Accord', '13469', '4536', 2.6, 'green', '2013', 'car', 'automatic', 'hybrid', '7', '5', '3');

insert into CARS values('2653', '976-0005', 'Honda', 'Civic', '11236', '1855', 3.2, 'white', '2012', 'car', 'automatic', 'hybrid', '7', '4', '3');

insert into CARS values('2654', '976-0006', 'Honda', 'Accord', '63638', '6636', 2.3, 'black', '2013', 'car', 'automatic', 'hybrid', '7', '5', '5');

insert into CARS values('2655', '976-0007', 'Toyota', 'Camry', '46333', '3398', 2.2, 'gray', '2018', 'car', 'automatic', 'gasoline', '7', '4', '5');

insert into CARS values('2656', '976-0008', 'Toyota', 'Corolla', '77638', '9326', 2.9, 'other', '2015', 'car', 'manual', 'gasoline', '7', '5', '2');

insert into CARS values('2657', '976-0009', 'Toyota', 'Corolla', '77638', '9964', 2.9, 'other', '2015', 'car', 'manual', 'gasoline', '7', '5', '2');

insert into CARS values('2658', '976-0010', 'Ford', 'Focus', '72638', '9363', 2.6, 'red', '2016', 'car', 'manual', 'gasoline', '7', '5', '3');

insert into CARS values('2659', '976-0011', 'Ford', 'Focus', '73638', '9977', 2.9, 'blue', '2017', 'car', 'automatic', 'gasoline', '7', '5', '1');

insert into CARS values('2660', '976-0012', 'Ford', 'Fusion', '73369', '9922', 3.5, 'blue', '2015', 'car', 'manual', 'hybrid', '7', '1', '1');

insert into CARS values('2661', '976-0013', 'Toyota', 'Prius', '55638', '9136', 4.2, 'red', '2020', 'car', 'automatic', 'gasoline', '7', '5', '2');

insert into CARS values('2662', '976-0014', 'Dodge', 'Caravan', '73643', '9936', 2.8, 'black', '2016', 'van', 'manual', 'gasoline', '7', '5', '3');

insert into CARS values('2663', '976-0015', 'Ford', 'F-150', '79933', '1236', 3.6, 'red', '2013', 'truck', 'automatic', 'gasoline', '7', '5', '3');

insert into CARS values('2664', '976-0016', 'Ford', 'F-150', '76645', '1699', 4.6, 'blue', '2018', 'truck', 'automatic', 'gasoline', '7', '5', '4');

insert into CARS values('2665', '976-0017', 'Ford', 'F-150', '78669', '1776', 4.9, 'red', '2016', 'truck', 'automatic', 'gasoline', '7', '1', '5');

insert into CARS values('2666', '976-0018', 'Ford', 'F-150', '78666', '1693', 4.8, 'blue', '2019', 'truck', 'automatic', 'gasoline', '7', '2', '5');

insert into CARS values('2667', '976-0019', 'Ford', 'F-150', '76633', '1466', 4.9, 'black', '2014', 'truck', 'automatic', 'gasoline', '7', '2', '3');


--RentalTransactions
insert into RentalTransactions values('1', 'car', 'car', '1', '1', '20000', 'Y', '435', '2021-04-12', '2021-05-15', '2021-05-21', 'N', '101', '33', '1004');
insert into RentalTransactions values('10', 'car', 'car', '1', null, '20000', null, null, '2022-08-20', '2022-08-23', null, 'N', '101', '0', '1000');
----Transactions at different branches
----With members/non-memebrs
----Free upgrade
----Late Fee
--insert into RentalTransactions values('11', 'car', 'van', '1', '1', '', 'Y', '411', '2022-06-01', '2022-06-15', '2022-06-16', 'Y', '102', '2', 'asdaasd' );
--insert into RentalTransactions values('12', 'car', 'car', '3', '1', 'asdasd', 'N', 'as', '2022-05-01', '2022-06-12', '2022-06-12', 'N', '301', '1', 'asdads' );

--insert into RentalTransactions values('13', 'van', 'van', '5', '4', 'asdasd', null, 'asd', '2022-06-18', '2022-07-05', null,'N', '401', '37', 'asd' );
--insert into RentalTransactions values('14', 'van', 'van', '3', '3', 'asdasd', '');
--insert into RentalTransactions values('15', 'van', 'van', '2', '3', 'asdfg', 'Y', '435', '2022-04-12', '2022-06-13', '2022-06-21', 'N', '302', '11', 'asdfa');
--insert into RentalTransactions values('16', 'van', 'suv', '3', '3', 'asdaf', 'N', 'asd', '2022-06-02', '2022-06-20', '2022-06-20', 'Y', '301', '36', 'asdf');

--insert into RentalTransactions values('17', 'suv', 'suv', '2', '2', 'asdf', 'Y', 'asd', '2022-05-01', '2022-06-12', '2022-06-15', 'Y', '201', '23', 'asdf');
--insert into RentalTransactions values('18', 'suv', 'truck', '2','2', 'asdf', 'N', 'asd', '2022-06-01', '2022-06-11', '2022-06-11', 'N', '202', '9', 'asdf');
--insert into RentalTransactions values('19', 'suv', 'truck', '3', '3', 'asdf', 'N', 'asd', '2022-05-29', '2022-06-10', '2022-06-10','Y', '301', '34', 'asdf');
--insert into RentalTransactions values('20', 'suv', 'truck', '1', '2', 'asdf', 'Y', 'asd', '2022-05-20', '2022-06-05', '2022-06-07', 'Y', '204', '12', 'asdf');

--insert into RentalTransactions values('21', 'truck', 'truck', '1', '1', 'asdf', null, 'asd', '2022-06-20', '2022-06-25', null, 'N', '101', '14', 'asdf');
--insert into RentalTransactions values('22', 'truck', 'luxury', '2', '1', 'asd', 'Y', 'asd', '2022-06-01', '2022-06-12', '2022-06-13', 'Y', '102','35', 'asdf');
--insert into RentalTransactions values('22', 'truck', 'truck', '3', '4', 'asdf', null, 'asd', '2022-05-28', '2022-07-20', null, 'Y', '401', '16', 'asdf');



