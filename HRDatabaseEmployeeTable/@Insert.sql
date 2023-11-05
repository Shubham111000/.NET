CREATE PROCEDURE [dbo].[@Insert]
       @pname     NVARCHAR(Max), 
       @paddress  NVARCHAR(Max), 
       @psalary   FLOAT,
       @pid       INT,
       @pgender   CHAR(10)
AS  
   BEGIN  
 
 INSERT INTO dbo.Employee(Id, Name ,Salary,Gender,Address) VALUES ( @pid,@pname,@psalary,@pgender, @paddress )
END