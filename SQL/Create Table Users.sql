CREATE TABLE warehousecms.roles (
    id INT AUTO_INCREMENT,
    role_name VARCHAR(255),
    role_desc VARCHAR(500),
    PRIMARY KEY (id)
);

CREATE TABLE warehousecms.users (
    id INT AUTO_INCREMENT,
    role_id INT,
    name VARCHAR(255),
    people_id VARCHAR(30),
    birth_day DATE,
    email VARCHAR(150),
    user_name VARCHAR(150),
    password VARCHAR(500),
    salt  VARCHAR(500),
    phone VARCHAR(150),
    address VARCHAR(500),
    creat_time DATETIME DEFAULT CURRENT_TIMESTAMP,
    avatar VARCHAR(255),
    social_url VARCHAR(500),
    status VARCHAR(50),
    PRIMARY KEY (id),
    CONSTRAINT fk_user_role
    FOREIGN KEY (role_id) 
        REFERENCES roles(id)
);