SELECT ProductName FROM Products where UnitPrice > (select avg(UnitPrice) from Products)
select ShippedDate,COUNT(*) as noOfProducts from Orders group by ShippedDate order by ShippedDate
select Country,COUNT(*) from Suppliers group by Country having COUNT(*) >1
select MONTH(ShippedDate) as MonthsNumber,Count(*) as orderDelayed from Orders where ShippedDate > RequiredDate group by ShippedDate order by MONTH(ShippedDate)
select OrderID,Discount from [Order Details] where Discount!=0 order by OrderID
select ShipCity,COUNT(*) from Orders where ShipCountry='USA' And YEAR(ShippedDate)=1997 group by ShipCity 
select ShipCountry,count(*) as order_delayed from Orders where RequiredDate<ShippedDate group by ShipCountry
select OrderID,Discount,UnitPrice from [Order Details] where Discount!=0;
select ShipRegion,ShipCity,COUNT(*) as orders from Orders where ShipRegion is not null group by ShipRegion,ShipCity;