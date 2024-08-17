Scaffold-DbContext "Server=DESKTOP-5OI88MG;Database= ContactDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir ModelsINSERT INTO Customers (FirstName, LastName, DateRegistration, Address, Email, Nif, Birthdate, CityId, PlanId)
--insert table RSGYM
--Customers


INSERT INTO Customer (FirstName, LastName, DateRegistration, Address, Email, Nif, Birthdate, CityId, PlanId)
VALUES
('John', 'Doe', '2023-01-10', '123 Main Street', 'johndoe@example.com', '123456789', '1990-05-15', 1, 2),
('Jane', 'Smith', '2023-02-12', '456 Oak Avenue', 'janesmith@example.com', '987654321', '1985-08-22', 2, 3),
('Alice', 'Johnson', '2023-03-15', '789 Pine Road', 'alicejohnson@example.com', '456789123', '1993-12-05', NULL, 1),
('Bob', 'Williams', '2023-04-20', '135 Maple Street', 'bobwilliams@example.com', '321654987', '1988-07-19', 3, NULL),
('Maria', 'Garcia', '2023-05-22', '246 Birch Lane', 'mariagarcia@example.com', '159753486', '1995-10-11', 4, 2);


--city

INSERT INTO Cities (Name, CountryId)
VALUES
('New York', 1),
('Fortaleza', 2),
('Porto', 3),
('Lisboa', 3),
('Braga', 3);

INSERT INTO Country(CountryName)
VALUES
('EUA'),
('Brasil'),
('Portugal'),
('Espanha'),
('Canada');


--plan
INSERT INTO [Plan] (PlanName)
VALUES
('Basic Plan'),
('Premium Plan'),
('Family Plan'),
('Student Plan');

--services
INSERT INTO Services (ServiceName, PaymentDate, Value, PaymentTerm, ExpiryDate, EndDate, PlanId, StatusId)
VALUES
('Gym Access', '2024-01-10', 49.99, 'Monthly', '2024-12-31', NULL, 1, 1),
('Personal Training', '2024-02-12', 199.99, 'One-time', '2024-03-31', NULL, 2, 2),
('Nutrition Plan', '2024-03-15', 99.99, 'One-time', '2024-04-30', NULL, 3, 3),
('Swimming Pool Access', '2024-04-20', 29.99, 'Monthly', '2024-12-31', NULL, 1, 1),
('Yoga Classes', '2024-05-22', 49.99, 'Monthly', '2024-12-31', NULL, 2, 1);


--status
INSERT INTO Status (StatusName)
VALUES
('Active'),
('Inactive'),
('Pending'),
('Cancelled');

--payment
INSERT INTO Payments (PaymentDate, AmountPaid, PaymentMethod, CustomerId, ServiceId)
VALUES
('2024-01-15', 49.99, 'Credit Card', 2, 2),
('2024-02-20', 199.99, 'Credit Card', 2, 3),
('2024-03-10', 99.99, 'PayPal', 3, 3),
('2024-04-12', 29.99, 'Bank Transfer', 4, 4),
('2024-05-05', 49.99, 'Debit Card', 5, 5);

