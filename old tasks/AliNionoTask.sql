--Create database AliNinoDb2






create table Categories(
	Id int identity primary key,
	Title nvarchar(40),
	ParentId int references Categories(Id), --nullable
	IsDeleted bit
	)

create table PublishingHouses(
	Id int identity primary key,
	Title nvarchar(20),
	IsDeleted bit
)

create table Book(
	Id int identity primary key,
	Title nvarchar(40) not null,
	Discription nvarchar(250),
	ActualPrice float not null,
	DiscountPrice float, --null
	PublishingHouseId int references PublishingHouses(Id),
	StockCount int,
	ArticleCode int,
	BindingId nvarchar(15), --book cover type
	Pages int,
	CategoryId int foreign key references Categories(Id),
	IsDeleted bit,
	CHECK (DiscountPrice <= ActualPrice)
)


Create table Authors(
	Id int identity primary key,
	Name nvarchar(20),
	Surname nvarchar(20),
	IsDeleted bit
)
create table BooksAuthors(
	Id int identity primary key,
	BookId int foreign key references Book(Id),
	AuthorId int foreign key references Authors(Id),
	IsDeleted bit
)

Create table Genres(
	Id int identity primary key,
	Title nvarchar(25),
	IsDeleted bit
)
Create table BookGenres(
	Id int identity primary key,
	BookId int foreign key references Book(Id),
	GenresId int foreign key references Genres(Id),
	IsDeleted bit
)


Create table Binding(
	Id int identity primary key,
	CoverType nvarchar(20),
	IsDeleted bit
)

create table Languages(
	Id int identity primary key,
	Title nvarchar(30),
	IsDeleted bit
)
create table BooksLanguages(
	Id int identity primary key,
	BookId int foreign key references Book(Id),
	LanguageId int foreign key references Languages(Id),
	IsDeleted bit
)

create table Comment(
	Id int identity primary key,
	Description nvarchar(400),
	BookId int foreign key references Book(Id),
	IsDeleted bit,
	Rate int check(Rate between 0 and 5),
	Username nvarchar(30) not null,
	Email nvarchar(50) not null,
	ImageUrl nvarchar(2000)
)


Create procedure Category
	@Title nvarchar(40),
	--ParentId int references Categories(Id), --nullable
	@IsDeleted bit
	as 
	go

	Category 
	@Title = 'Title', 
	@IsDeleted = 0




Create procedure CreateBook 
	@Title nvarchar(40),
	@Discription nvarchar(250),
	@ActualPrice float,
	@DiscountPrice float,
	@PublishingHouseId int,
	@StockCount int,
	@ArticleCode int,
	--@BindingId nvarchar(15), --book cover type
	@Pages int,
	--@CategoryId int,
	@IsDeleted bit
	as
	go 





	drop procedure CreateBook
	













