
CREATE PROCEDURE storedata
       @pname     NVARCHAR(Max), 
       @psalary    float
               
AS 
BEGIN 
  INSERT INTO dbo.Employee( Name ,Salary) VALUES ( @pname , @psalary )
  End