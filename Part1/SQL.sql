Select * from Customer Where Name like 'Joe%'

Select p.Name from Product p 
	join OrderProduct op on p.ProductID=op.ProductID 
	join Order o on op.OrderID=o.OrderID 
	join Customer c on c.CustomerID=o.CustomerID 
	Where c.Name = 'Joe'
	
Select sum(p.Price) from Product p 
	join OrderProduct op on p.ProductID=op.ProductID 
	join Order o on op.OrderID=o.OrderID 
	join Customer c on c.CustomerID=o.CustomerID 
	Where c.Name = 'Joe'

Select c.CustomerID,c.Name,Count(o.OrderID) from Product p 
	join OrderProduct op on p.ProductID=op.ProductID 
	join Order o on op.OrderID=o.OrderID 
	join Customer c on c.CustomerID=o.CustomerID 
	group by c.CustomerID,c.Name
	having Count(op.ProductID)>1