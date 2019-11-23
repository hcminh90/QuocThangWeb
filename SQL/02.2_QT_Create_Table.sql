use qt;

/*==============================================================*/
/* DBMS name:      MySQL 5.0                                    */
/* Created on:     2019-11-18 22:22:29                          */
/*==============================================================*/

/*==============================================================*/
/* Table: CUSTOMERS                                             */
/*==============================================================*/
create table CUSTOMERS
(
   CUST_ID              int not null auto_increment comment '',
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
   PROD_ID              int not null auto_increment comment 'ma san pham',
   PROD_NAME            varchar(100)  comment '',
   PROD_DESC            varchar(100)  comment '',
   PROD_UNIT        varchar(100)  comment 'don vi tinh',
   PROD_UNIT_PRICE  bigint default 0  comment 'don gia',
   PROD_AMOUNT          int default 0  comment 'so luong',
   PROD_LAST_USER_CHANGED	int	not null comment '',
   PROD_LAST_TIME_CHANGED	timestamp comment '',
   primary key (PROD_ID)
);

/*==============================================================*/
/* Table: PRODUCTS_HIST                                         */
/*==============================================================*/
create table PRODUCTS_HIST
(
   HIST_ID              int not null auto_increment comment '',
   PROD_ID              int  comment '',
   PROD_NAME            varchar(100)  comment '',
   PROD_DESC            varchar(100)  comment '',
   PROD_UNIT        varchar(100)  comment 'don vi tinh',
   PROD_UNIT_PRICE  bigint default 0  comment 'don gia',
   PROD_AMOUNT          int default 0  comment 'so luong',
   HIST_USER            varchar(100)  comment '',
   HIST_ACTION          varchar(100)  comment '',
   HIST_TIMESTAMP       timestamp default current_timestamp comment '',
   primary key (HIST_ID)
);

/*==============================================================*/
/* Table: ROLES                                                 */
/*==============================================================*/
create table ROLES
(
   ROLE_ID              int not null auto_increment comment '',
   ROLE_NAME            varchar(100)  comment '',
   ROLE_DESC            varchar(100)  comment '',
   primary key (ROLE_ID)
);

/*==============================================================*/
/* Table: TRANSCATIONS                                          */
/*==============================================================*/
create table TRANSACTIONS
(
   TAX_ID               varchar(20) not null  comment '',
   PROD_ID              int not null  comment '',
   CUST_ID              int not null  comment '',
   USER_ID              int not null  comment '',
   TIMESTAMP            timestamp not null  comment '',
   PROD_UNIT_PRICE  	bigint comment 'don gia goc',
   UNIT_PRICE           bigint  comment 'don gia ban',
   UNIT_AMOUNT          int  comment 'so luong',
   UNIT_PAY             bigint  comment 'thanh toan',
   TRANSACTION          varchar(20)  comment 'loai giao dich, sell/buy',
   TRANSACTION_DESC     varchar(100)  comment 'dien giai giao dich',
   primary key (TAX_ID, PROD_ID, CUST_ID, USER_ID, TIMESTAMP)
);

/*==============================================================*/
/* Table: USERS                                                 */
/*==============================================================*/
create table USERS
(
   USER_ID              int not null auto_increment comment '',
   ROLE_ID              int  comment '',
   USER_NAME            varchar(100)  comment '',
   USER_PEOPLE_ID       varchar(100)  comment '',
   USER_BRITH_DATE      date  comment '',
   USER_PASSWORD        varchar(255)  comment '',
   PWD_SALT             varchar(255)  comment 'encrypter pwd',
   USER_PHONE           varchar(100)  comment '',
   USER_ADDRESS         varchar(100)  comment '',
   USER_CREATE_TIME     varchar(100)  comment '',
   USER_AVATAR          varchar(100)  comment '',
   USER_SOCIAL_URL      varchar(100)  comment '',
   USER_STATUS          varchar(100)  comment '',
   primary key (USER_ID)
);

alter table PRODUCTS add constraint FK_PRODUCTS_REFERENCE_USERS foreign key (PROD_LAST_USER_CHANGED)
      references USERS (USER_ID) on delete restrict on update restrict;

alter table PRODUCTS_HIST add constraint FK_PRODUCTS_REFERENCE_PRODUCTS foreign key (PROD_ID)
      references PRODUCTS (PROD_ID) on delete restrict on update restrict;

alter table TRANSACTIONS add constraint FK_TRANSACT_REFERENCE_PRODUCTS foreign key (PROD_ID)
      references PRODUCTS (PROD_ID) on delete restrict on update restrict;

alter table TRANSACTIONS add constraint FK_TRANSACT_REFERENCE_CUSTOMER foreign key (CUST_ID)
      references CUSTOMERS (CUST_ID) on delete restrict on update restrict;

alter table TRANSACTIONS add constraint FK_TRANSACT_REFERENCE_USERS foreign key (USER_ID)
      references USERS (USER_ID) on delete restrict on update restrict;

alter table USERS add constraint FK_USERS_REFERENCE_ROLES foreign key (ROLE_ID)
      references ROLES (ROLE_ID) on delete restrict on update restrict;