-- DML = data manipulation language
use StoreApplicationDB;
go

-- INSERT
insert into Customer.Customer
  ([Name])
values
  ('fred'),
  ('Tyler'),
  ('Cory');
 go

insert into Store.Product([Name], Price)
values ('iPad', 399), ('Mac', 1300), ('iPhone X', 799), ('iWatch', 499);
go

insert into Store.Store
  ([Name])
values
  (Best Buy'),
  ('Micro Center');

-- UPDATE
update Customer.Customer
set Name = "derf"
where [Name] = "fred";

-- DELETE
delete Customer.Customer
where Name = "derf";

-- SELECT
--- Order of Execution
--- from
--- where
--- group by
--- having
--- select
--- order by

-- get the product quantity from store

-- create report on all current customers
select [Name]
from Customer.Customer
where Active = 1;

-- create report on most sold products (at least 100)
--ProductOrder(count(productid))
select ProductId
from Store.OrderProduct
group by ProductId
having count(ProductId) > 99;

-- SET

-- JOIN = ability to relate/compose 2 or more tballe based on indexes/keys

-- UNION = ability to relate/compose 2 or more tabble based on datatypes