CREATE TABLE users (
    id INT AUTO_INCREMENT,
    role_id INT,
    name VARCHAR(255),
    people_id VARCHAR(30),
    birth_day DATE,
    email VARCHAR(150),
    password VARCHAR(255),
    phone VARCHAR(150),
    address VARCHAR(500),
    creat_time DATETIME DEFAULT CURRENT_TIMESTAMP,
    avatar VARCHAR(255),
    social_url VARCHAR(500),
    status VARCHAR(50),
	status2 VARCHAR(50),
    PRIMARY KEY (id)
);