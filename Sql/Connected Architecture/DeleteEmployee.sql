USE [EmployeeDepartmentDB]
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 24-11-2021 15:26:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[DeleteEmployee]
	-- Add the parameters for the stored procedure here
	(@empno int)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Employee where empno=@empno
END
