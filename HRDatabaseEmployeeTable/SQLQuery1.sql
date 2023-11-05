CREATE PROCEDURE [dbo].[@Delete]
       @pid     INT
      
AS  
   BEGIN  
 
 Delete From Employee where Id=@pid;
END