USE [ErrorDB]
GO
/****** Object:  StoredProcedure [dbo].[sp_ProgLangMostQuest]    Script Date: 2021/11/04 2:00:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_ProgLangMostQuest]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ProgLanguageDesc, COUNT(ErrorID)AS Error_Solved
	FROM tblProgLanguage, tblError
	WHERE (tblError.ProgLanguageID = tblProgLanguage.ProgLanguageID)
	GROUP BY ProgLanguageDesc;
END
