USE [ErrorDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_StudentInformationReport]    Script Date: 2021/11/04 2:41:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_StudentInformationReport]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT tblUser.UserID, UserName, Surname, COUNT(ErrorDescription) AS Errors_Submitted, COUNT(ProgLanguageDesc) AS Programming_Languages_Taken
	FROM tblError, tblUser, tblProgLanguage
	WHERE (tblUser.UserID = @UserID) AND (tblUser.UserID = tblError.StudentID) AND (tblError.ProgLanguageID = tblProgLanguage.ProgLanguageID) 
	 
	GROUP BY tblUser.UserID, Username, Surname;
END
