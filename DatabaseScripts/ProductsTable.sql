USE LegacyEcommerce;
GO

CREATE TABLE Products(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	CategoryId INT,
	Name NVARCHAR(20) NOT NULL,
	ImageUrl NVARCHAR(100),
	Description NVARCHAR(100),
	Price Decimal(10,1) NOT NULL,
	Popular BIT DEFAULT 0
);
GO