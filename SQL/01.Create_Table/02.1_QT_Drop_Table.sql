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