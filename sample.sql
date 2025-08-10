create table users(
    Id int primary key auto_increment,
    UserName varchar(40) unique,
    Email varchar(100) unique,
    Password varchar(100)
);

create table equipments(
    Id int primary key auto_increment,
    EquipmentName varchar(100),
    Category varchar(100),
    Description varchar(1000),
    Stock int,
    Price float

);

create table orders(
    OrderId int primary key auto_increment,
    EquipmentId int,
    UserId int,
    Quantity int,
    foreign key (EquipmentId) references equipments(Id),
    foreign key (UserId) references users(Id),
    TotalPrice float
);

