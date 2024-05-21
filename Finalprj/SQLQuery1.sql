CREATE TABLE Users (
    id INT PRIMARY KEY IDENTITY(1,1),
    name VARCHAR(255),
    email NVARCHAR(255),
    password NVARCHAR(255),
    confirmpassword VARCHAR(255)
);

CREATE TABLE BookingInfo (
    BookingID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(255),
    RoomType VARCHAR(50),
    TotalMembers INT,
    BookingDate DATE,
    BookingTime TIME,
    ArrivalDate DATE,
    DepartureTime TIME,
    EmailID NVARCHAR(255),
    PhoneNumber NVARCHAR(15),
    FileUpload VARBINARY(MAX),
    Message TEXT
);

INSERT INTO BookingInfo (Name, RoomType, TotalMembers, BookingDate, BookingTime, ArrivalDate, DepartureTime, EmailID, PhoneNumber, FileUpload, Message)
VALUES
    ('John Doe', 'Single', 1, '2023-12-06', '12:00:00', '2023-12-07', '10:00:00', 'john.doe@example.com', '1234567890', NULL, 'This is a test booking.'),
    ('Jane Smith', 'Double', 2, '2023-12-07', '14:30:00', '2023-12-10', '12:00:00', 'jane.smith@example.com', '9876543210', NULL, 'Another test booking.');


CREATE TABLE CustomerInfo (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    BookingID INT FOREIGN KEY REFERENCES BookingInfo(BookingID),
    Name NVARCHAR(255),
    RoomType NVARCHAR(50),
    TotalMembers INT,
    BookingDate DATE,
    BookingTime TIME,
    ArrivalDate DATE,
    DepartureTime TIME,
    EmailID VARCHAR(255),
    PhoneNumber VARCHAR(15),
    FileUpload VARBINARY(MAX),
    Message TEXT
);

CREATE TABLE Room (
    RoomNumber INT PRIMARY KEY,
    RoomType NVARCHAR(50),
    AC_NonAC NVARCHAR(5), -- Assuming AC or NON-AC
    Food NVARCHAR(50),
    CancellationCharges DECIMAL(10, 2),
    Rent DECIMAL(10, 2),
    PhoneNumber NVARCHAR(15),
    FileUpload VARBINARY(MAX),
    Message TEXT
);

CREATE TABLE Staff (
    StaffID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    UserName NVARCHAR(50),
    EmailID NVARCHAR(255),
    Password NVARCHAR(255), -- You may want to consider secure storage methods for passwords
    ConfirmPassword NVARCHAR(255),
    JoiningDate DATE,
    PhoneNumber NVARCHAR(15),
    Role NVARCHAR(50)
);


select * from Users

select * from BookingInfo