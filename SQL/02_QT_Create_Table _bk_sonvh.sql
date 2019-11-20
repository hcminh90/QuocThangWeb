use qt;

/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2019-11-18 22:22:29                          */
/*==============================================================*/


alter table PRODUCTS_HIST 
   drop foreign key FK_PRODUCTS_REFERENCE_PRODUCTS;

alter table TRANSCATIONS 
   drop foreign key FK_TRANSCAT_REFERENCE_PRODUCTS;

alter table TRANSCATIONS 
   drop foreign key FK_TRANSCAT_REFERENCE_CUSTOMER;

alter table TRANSCATIONS 
   drop foreign key FK_TRANSCAT_REFERENCE_USERS;

alter table USERS 
   drop foreign key FK_USERS_REFERENCE_ROLES;

drop table if exists CUSTOMERS;

drop table if exists PRODUCTS;


alter table PRODUCTS_HIST 
   drop foreign key FK_PRODUCTS_REFERENCE_PRODUCTS;

drop table if exists PRODUCTS_HIST;

drop table if exists ROLES;


alter table TRANSCATIONS 
   drop foreign key FK_TRANSCAT_REFERENCE_PRODUCTS;

alter table TRANSCATIONS 
   drop foreign key FK_TRANSCAT_REFERENCE_CUSTOMER;

alter table TRANSCATIONS 
   drop foreign key FK_TRANSCAT_REFERENCE_USERS;

drop table if exists TRANSCATIONS;


alter table USERS 
   drop foreign key FK_USERS_REFERENCE_ROLES;

drop table if exists USERS;

/*==============================================================*/
/* Table: CUSTOMERS                                             */
/*==============================================================*/
CREATE TABLE `customers` (
  `CUST_ID` int(11) NOT NULL,
  `CUST_NAME` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `CUST_TAX` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `CUST_ADDRESS` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `CUST_PHONE_NUMBER` varchar(20) COLLATE utf8_bin DEFAULT NULL,
  `CUST_EMAIL` varchar(50) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`CUST_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin
;

/*==============================================================*/
/* Table: PRODUCTS                                              */
/*==============================================================*/
CREATE TABLE `products` (
  `PROD_ID` int(11) NOT NULL COMMENT 'ma san pham',
  `PROD_NAME` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `PROD_DESC` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `PROD_UNIT` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT 'don vi tinh',
  `PROD_QUANTITY_PRICE` bigint(20) DEFAULT NULL COMMENT 'don gia',
  `PROD_AMOUNT` int(11) DEFAULT NULL COMMENT 'so luong',
  PRIMARY KEY (`PROD_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin
;

/*==============================================================*/
/* Table: PRODUCTS_HIST                                         */
/*==============================================================*/
CREATE TABLE `products_hist` (
  `HIST_ID` int(11) NOT NULL,
  `PROD_ID` int(11) DEFAULT NULL,
  `PROD_NAME` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `PROD_DESC` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `PROD_QUANTITY_PRICE` bigint(20) DEFAULT NULL,
  `PROD_AMOUNT` int(11) DEFAULT NULL,
  `HIST_USER` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `HIST_ACTION` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `HIST_TIMESTAMP` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`HIST_ID`),
  KEY `FK_PRODUCTS_REFERENCE_PRODUCTS` (`PROD_ID`),
  CONSTRAINT `FK_PRODUCTS_REFERENCE_PRODUCTS` FOREIGN KEY (`PROD_ID`) REFERENCES `products` (`PROD_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin
;

/*==============================================================*/
/* Table: ROLES                                                 */
/*==============================================================*/
CREATE TABLE `roles` (
  `ROLE_ID` int(11) NOT NULL,
  `ROLE_NAME` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `ROLE_DESC` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`ROLE_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin

/*==============================================================*/
/* Table: TRANSCATIONS                                          */
/*==============================================================*/
CREATE TABLE `transcations` (
  `TAX_ID` varchar(20) COLLATE utf8_bin NOT NULL,
  `PROD_ID` int(11) NOT NULL,
  `CUST_ID` int(11) NOT NULL,
  `USER_ID` int(11) NOT NULL,
  `TIMESTAMP` timestamp NOT NULL,
  `UNIT_PRICE` int(11) DEFAULT NULL COMMENT 'don gia',
  `UNIT_AMOUNT` bigint(20) DEFAULT NULL COMMENT 'so luong',
  `UNIT_PAY` bigint(20) DEFAULT NULL COMMENT 'thanh toan',
  `TRANSACTION` varchar(20) COLLATE utf8_bin DEFAULT NULL COMMENT 'loai giao dich, nhap/xuat',
  `TRANSACTION_DESC` varchar(100) COLLATE utf8_bin DEFAULT NULL COMMENT 'dien giai giao dich',
  PRIMARY KEY (`TAX_ID`,`PROD_ID`,`CUST_ID`,`USER_ID`,`TIMESTAMP`),
  KEY `FK_TRANSCAT_REFERENCE_PRODUCTS` (`PROD_ID`),
  KEY `FK_TRANSCAT_REFERENCE_CUSTOMER` (`CUST_ID`),
  KEY `FK_TRANSCAT_REFERENCE_USERS` (`USER_ID`),
  CONSTRAINT `FK_TRANSCAT_REFERENCE_CUSTOMER` FOREIGN KEY (`CUST_ID`) REFERENCES `customers` (`CUST_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_TRANSCAT_REFERENCE_PRODUCTS` FOREIGN KEY (`PROD_ID`) REFERENCES `products` (`PROD_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `FK_TRANSCAT_REFERENCE_USERS` FOREIGN KEY (`USER_ID`) REFERENCES `users` (`USER_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin
;

/*==============================================================*/
/* Table: USERS                                                 */
/*==============================================================*/
CREATE TABLE `users` (
  `USER_ID` int(11) NOT NULL,
  `ROLE_ID` int(11) DEFAULT NULL,
  `USER_NAME` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `USER_PEOPLE_ID` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `USER_BRITH_DATE` date DEFAULT NULL,
  `USER_PASSWORD` varchar(255) COLLATE utf8_bin DEFAULT NULL,
  `USER_PHONE` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `USER_ADDRESS` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `USER_CREATE_TIME` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `USER_AVATAR` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `USER_SOCIAL_URL` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  `USER_STATUS` varchar(100) COLLATE utf8_bin DEFAULT NULL,
  PRIMARY KEY (`USER_ID`),
  KEY `FK_USERS_REFERENCE_ROLES` (`ROLE_ID`),
  CONSTRAINT `FK_USERS_REFERENCE_ROLES` FOREIGN KEY (`ROLE_ID`) REFERENCES `roles` (`ROLE_ID`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin
;
