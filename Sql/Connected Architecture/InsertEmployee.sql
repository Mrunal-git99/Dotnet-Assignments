USE [EmployeeDepartmentDB]
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployee]    Script Date: 24-11-2021 15:31:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[InsertEmployee]
	-- Add the parameters for the stored procedure here
	(@empno int,
	@empname varchar(50),
	@designation varchar(50),
	@salary float,
	@deptno int)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Employee (empno,empname,designation,salary,deptno)
		values(@empno,@empname,@designation,@salary,@deptno)

END
