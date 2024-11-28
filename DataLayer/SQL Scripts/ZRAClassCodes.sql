USE
[EVO-CHEM]
GO

/** Object:  Table [dbo].[ZRAClassCodes]    Script Date: 24/10/2024 12:16:20 pm **/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ZRAClassCodes]
(
    [
    resultDt] [
    varchar]
(
    14
) NULL,
    [temClsCd] [varchar]
(
    10
) NULL,
    [itemClsNm] [varchar]
(
    200
) NULL,
    [itemClsLvl] [numeric]
(
    18,
    0
) NULL,
    [taxTyCd] [varchar]
(
    5
) NULL,
    [mjrTgYn] [varchar]
(
    1
) NULL,
    [useYn] [varchar]
(
    1
) NULL
    ) ON [PRIMARY]
    GO
    USE [EVO-CHEM]
    GO

DROP PROCEDURE IF EXISTS [dbo].[UpdateZRAClassCodes]
    GO
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO

CREATE PROCEDURE [dbo].[UpdateZRAClassCodes]
    @resultDt varchar(14),
    @temClsCd varchar(10),
    @itemClsNm varchar(200),
    @itemClsLvl numeric(18, 0),
    @taxTyCd varchar(5),
    @mjrTgYn varchar(1),
    @useYn varchar(1)
AS
BEGIN
    -- Check if the record exists
    IF
EXISTS (SELECT 1 FROM ZRAClassCodes WHERE temClsCd = @temClsCd)
BEGIN
        -- Update existing record
UPDATE ZRAClassCodes
SET resultDt   = @resultDt,
    itemClsNm  = @itemClsNm,
    itemClsLvl = @itemClsLvl,
    taxTyCd    = @taxTyCd,
    mjrTgYn    = @mjrTgYn,
    useYn      = @useYn
WHERE temClsCd = @temClsCd;
END
ELSE
BEGIN
        -- Insert new record
INSERT INTO ZRAClassCodes (resultDt, temClsCd, itemClsNm, itemClsLvl, taxTyCd, mjrTgYn, useYn)
VALUES (@resultDt, @temClsCd, @itemClsNm, @itemClsLvl, @taxTyCd, @mjrTgYn, @useYn);
END
END;
GO