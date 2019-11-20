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
create table CUSTOMERS
(
   CUST_ID              int not null  comment '',
   CUST_NAME            varchar(100)  comment '',
   CUST_TAX             varchar(20)  comment '',
   CUST_ADDRESS         varchar(100)  comment '',
   CUST_PHONE_NUMBER    varchar(20)  comment '',
   CUST_EMAIL           varchar(50)  comment '',
   primary key (CUST_ID)
);

/*==============================================================*/
/* Table: PRODUCTS                                              */
/*==============================================================*/
create table PRODUCTS
(
   PROD_ID              int not null  comment 'ma san pham',
   PROD_NAME            varchar(100)  comment '',
   PROD_DESC            varchar(100)  comment '',
   PROD_UNIT        varchar(100)  comment 'don vi tinh',
   PROD_UNIT_PRICE  bigint  comment 'don gia',
   PROD_AMOUNT          int  comment 'so luong',
   primary key (PROD_ID)
);

/*==============================================================*/
/* Table: PRODUCTS_HIST                                         */
/*==============================================================*/
create table PRODUCTS_HIST
(
   HIST_ID              int not null  comment '',
   PROD_ID              int  comment '',
   PROD_NAME            varchar(100)  comment '',
   PROD_DESC            varchar(100)  comment '',
   PROD_QUANTITY_PRICE  bigint  comment '',
   PROD_AMOUNT          int  comment '',
   HIST_USER            varchar(100)  comment '',
   HIST_ACTION          varchar(100)  comment '',
   HIST_TIMESTAMP       timestamp  comment '',
   primary key (HIST_ID)
);

/*==============================================================*/
/* Table: ROLES                                                 */
/*==============================================================*/
create table ROLES
(
   ROLE_ID              int not null  comment '',
   ROLE_NAME            varchar(100)  comment '',
   ROLE_DESC            varchar(100)  comment '',
   primary key (ROLE_ID)
);

/*==============================================================*/
/* Table: TRANSCATIONS                                          */
/*==============================================================*/
create table TRANSCATIONS
(
   TAX_ID               varchar(20) not null  comment '',
   PROD_ID              int not null  comment '',
   CUST_ID              int not null  comment '',
   USER_ID              int not null  comment '',
   TIMESTAMP            timestamp not null  comment '',
   UNIT_PRICE           int  comment 'don gia',
   UNIT_AMOUNT          bigint  comment 'so luong',
   UNIT_PAY             bigint  comment 'thanh toan',
   TRANSACTION          varchar(20)  comment 'loai giao dich, nhap/xuat',
   TRANSACTION_DESC     varchar(100)  comment 'dien giai giao dich',
   primary key (TAX_ID, PROD_ID, CUST_ID, USER_ID, TIMESTAMP)
);

/*==============================================================*/
/* Table: USERS                                                 */
/*==============================================================*/
create table USERS
(
   USER_ID              int not null  comment '',
   ROLE_ID              int  comment '',
   USER_NAME            varchar(100)  comment '',
   USER_PEOPLE_ID       varchar(100)  comment '',
   USER_BRITH_DATE      date  comment '',
   USER_PASSWORD        varchar(255)  comment '',
   USER_PHONE           varchar(100)  comment '',
   USER_ADDRESS         varchar(100)  comment '',
   USER_CREATE_TIME     varchar(100)  comment '',
   USER_AVATAR          varchar(100)  comment '',
   USER_SOCIAL_URL      varchar(100)  comment '',
   USER_STATUS          varchar(100)  comment '',
   primary key (USER_ID)
);

alter table PRODUCTS_HIST add constraint FK_PRODUCTS_REFERENCE_PRODUCTS foreign key (PROD_ID)
      references PRODUCTS (PROD_ID) on delete restrict on update restrict;

alter table TRANSCATIONS add constraint FK_TRANSCAT_REFERENCE_PRODUCTS foreign key (PROD_ID)
      references PRODUCTS (PROD_ID) on delete restrict on update restrict;

alter table TRANSCATIONS add constraint FK_TRANSCAT_REFERENCE_CUSTOMER foreign key (CUST_ID)
      references CUSTOMERS (CUST_ID) on delete restrict on update restrict;

alter table TRANSCATIONS add constraint FK_TRANSCAT_REFERENCE_USERS foreign key (USER_ID)
      references USERS (USER_ID) on delete restrict on update restrict;

alter table USERS add constraint FK_USERS_REFERENCE_ROLES foreign key (ROLE_ID)
      references ROLES (ROLE_ID) on delete restrict on update restrict;
