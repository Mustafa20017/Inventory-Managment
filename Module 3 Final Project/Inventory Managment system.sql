Create Table LoginUser(
	id			int,
	UserName	varchar(50),
	Password	varchar(50),
	Email		varchar(50),
	PhoneNo		varchar(25)
)
Create Table Customer(
	id			int,
	Name		varchar(50),
	Address		varchar(500),
	PhoneNo		varchar(25),

)
Create Table Categories(
	id				int,
	CategoriesName	varchar(50)
)
Create Table Product(
	id					int,
	ProductName			varchar(50),
	ProductQty			varchar(20),
	ProductPrice		int,
	ProductDescription	varchar(500),
	Categoryid			int
)
Create Table Orders(
	id				int,
	Customerid		int,
	CustomerName	varchar(50),
	OrderDate		datetime,
	TotalAmount		int
)