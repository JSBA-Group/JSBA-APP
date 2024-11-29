create database mydb;
use mydb;

CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email VARCHAR(100) NOT NULL,
	accountType VARCHAR(10) NOT NULL,
    username VARCHAR(50) NOT NULL,             
    password VARCHAR(255) NOT NULL,            
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

SELECT COUNT(1) FROM users WHERE username = "ccc" AND password = "ccc";

CREATE TABLE Event (
    event_id INT PRIMARY KEY AUTO_INCREMENT,    
    name VARCHAR(255) NOT NULL,                 
    type VARCHAR(100) NOT NULL,                  
    user_id INT,                                
    FOREIGN KEY (user_id) REFERENCES users(id) 
);

CREATE TABLE Purchase (
    purchase_id INT PRIMARY KEY AUTO_INCREMENT, 
    event_id INT,                               -
    type VARCHAR(100) NOT NULL,                
    price DECIMAL(10, 2) NOT NULL,            
    FOREIGN KEY (event_id) REFERENCES Event(event_id)
);

INSERT INTO users (first_name, last_name, email, accountType, username, password) 
VALUES ('John', 'Doe', 'john.doe@example.com', 'Admin', 'johndoe', 'hashedpassword123'),
       ('Jane', 'Smith', 'jane.smith@example.com', 'User', 'janesmith', 'hashedpassword456');

INSERT INTO Event (name, type, user_id) 
VALUES ('Music Festival', 'Concert', 1),   -- Event created by user with id 1 (John Doe)
       ('Tech Conference', 'Conference', 2); -- Event created by user with id 2 (Jane Smith)

INSERT INTO Purchase (event_id, type, price) 
VALUES (1, 'VIP', 150.00), 
       (1, 'General Admission', 50.00), 
       (2, 'Early Bird', 100.00), 
       (2, 'Regular', 150.00);

CREATE TABLE CasaTransactionRequest (
    TransactionID INT PRIMARY KEY AUTO_INCREMENT, -- Optional: Unique identifier for each transaction
    StudentID VARCHAR(50) NOT NULL,
    LastName VARCHAR(100) NOT NULL,
    FirstName VARCHAR(100) NOT NULL,
    ContactEmail VARCHAR(255),
    ContactPhoneNumber VARCHAR(20),
    DateOfSubmission DATE NOT NULL,
    DateOfReceipt DATE,
    TransactionAmount DECIMAL(10, 2),
    TransactionDescription TEXT
);

INSERT INTO CasaTransactionRequest (StudentID, LastName, FirstName, ContactEmail, ContactPhoneNumber, DateOfSubmission, DateOfReceipt, TransactionAmount, TransactionDescription)
VALUES 
    ('S12345', 'Doe', 'John', 'john.doe@example.com', '555-1234', '2024-11-01', '2024-11-03', 150.75, 'Payment for student housing deposit'),
    ('S67890', 'Smith', 'Jane', 'jane.smith@example.com', '555-5678', '2024-11-02', '2024-11-05', 200.00, 'Tuition fee payment for Fall semester'),
    ('S11223', 'Brown', 'Alice', 'alice.brown@example.com', '555-9876', '2024-11-03', '2024-11-06', 1200.50, 'Room rental payment for the month of November'),
    ('S44556', 'Johnson', 'Emily', 'emily.johnson@example.com', '555-6543', '2024-11-04', '2024-11-07', 75.25, 'Payment for application fee'),
    ('S77889', 'Lee', 'Michael', 'michael.lee@example.com', '555-1122', '2024-11-05', '2024-11-08', 350.00, 'Student meal plan payment for the semester');

ALTER TABLE CasaTransactionRequest
ADD Status VARCHAR(50) DEFAULT 'Pending';