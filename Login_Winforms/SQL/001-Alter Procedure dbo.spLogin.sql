USE [LoginDB]
GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 04/05/2023 23:59:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spLogin] 
	-- Add the parameters for the stored procedure here
	@USUARIO VARCHAR(50) ,
	@PASSWORD VARCHAR(50) 
AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @HASH AS VARBINARY(256)
	
	SET @HASH = HASHBYTES('SHA2_256',@PASSWORD)
    
	SELECT COUNT(*) FROM Usuarios WHERE Usuario=@USUARIO AND Password = @HASH
		

END
