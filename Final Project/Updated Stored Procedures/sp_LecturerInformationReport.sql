USE [ErrorDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_LecturerInformationReport]    Script Date: 2021/10/30 2:30:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE  [dbo].[sp_LecturerInformationReport]
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT UserID, Username, Surname, COUNT(SolutionID) AS Solutions_Submitted
	FROM tblUser, tblSolution
	WHERE (tblUser.UserID = @UserID) AND (tblUser.UserID = tblSolution.LectureID) 
	GROUP BY UserID, Username, Surname;
END
