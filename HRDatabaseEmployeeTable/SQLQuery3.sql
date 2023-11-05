CREATE PROCEDURE [dbo].[@Update]
       @pname     NVARCHAR(Max), 
       @paddress  NVARCHAR(Max), 
       @psalary   FLOAT,
       @pid       INT,
       @pgender   CHAR(10),
       @PCID      INT
AS  
   BEGIN  
 
 UPDATE  dbo.Employee SET  Id=@pid, Name = @pname , Salary = @psalary , Gender = @pgender, Address=@paddress Where Id=@PCID
END