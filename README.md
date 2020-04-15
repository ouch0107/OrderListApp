# OrderListApp
Deal with order lists

# First time to use
* You should maybe migrate the local DB of SQL Server. 
* Check the connecting string in Web.config assure that it connect properly. 
* Type comment "updata-database" on PM console in Visual Studio. 

# Insert test data
* I manually insert some test data by SQL. 

# SQL Comments
'''
INSERT INTO Customer(Name)
VALUES ('Dennis')

INSERT INTO Customers(Name)
VALUES ('Jacj')

INSERT INTO Products(Name, UnitPrice, UnitCost, QuanityPerUnit)
VALUES ('Apple', 150, 120, '3 per bag')

INSERT INTO Products(Name, UnitPrice, UnitCost, QuanityPerUnit)
VALUES ('Iphone', 20000, 2000, '1 per box')

INSERT INTO Orders(CustomerId, ProductId, Quantity, Status)
VALUES (1, 1, 3, 2)

INSERT INTO Orders(CustomerId, ProductId, Quantity, Status)
VALUES (1, 2, 1, 1)
'''

# Develop Environment:
1. OS: Windows10
2. IDE: Visual Studio 2019
3. Version: .Net Framework 4.7.2
