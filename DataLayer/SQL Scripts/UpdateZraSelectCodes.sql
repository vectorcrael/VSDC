USE
[EVO-CHEM]
GO

DROP PROCEDURE
[dbo].[UpdateZRAStandardCodes]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[UpdateZRAStandardCodes]

    @resultDt varchar(14) ,
	@cdCls varchar(2) ,
	@cdClsNm varchar(60) ,
	@cd varchar(5) ,
	@cdNm varchar(60) ,
	@userDfnNm1 varchar(60) 

   
AS
BEGIN
UPDATE ZRAStandardCodes
SET resultDt=@resultDt,
    cdCls= @cdCls,
    cdClsNm= @cdClsNm,
    cd= @cd,
    cdNm= @cdNm,
    userDfnNm1= @userDfnNm1

WHERE cd = @cd;
END;


GO