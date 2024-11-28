USE
[EVO-CHEM]
GO

/****** Object:  Table [dbo].[DeviceInit]    Script Date: 23/10/2024 12:56:46 pm ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeviceInit]') AND type in (N'U'))
DROP TABLE [dbo].[DeviceInit]
    GO

/****** Object:  Table [dbo].[DeviceInit]    Script Date: 23/10/2024 12:56:46 pm ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO


CREATE TABLE [dbo].[DeviceInit]
(
    [
    resultCd] [
    varchar]
(
    3
) NULL,
    [resultMsg] [varchar]
(
    max
) NULL,
    [resultDt] [varchar]
(
    14
) NULL,
    [tpin] [varchar]
(
    10
) NULL,
    [taxprNm] [varchar]
(
    255
) NULL,
    [bsnsActv] [varchar]
(
    100
) NULL,
    [bhfId] [varchar]
(
    3
) NULL,
    [bhfNm] [varchar]
(
    60
) NULL,
    [bhfOpenDt] [varchar]
(
    8
) NULL,
    [prvncNm] [varchar]
(
    100
) NULL,
    [dstrtNm] [varchar]
(
    100
) NULL,
    [sctrNm] [varchar]
(
    100
) NULL,
    [locDesc] [varchar]
(
    100
) NULL,
    [hqYn] [varchar]
(
    1
) NULL,
    [mgrNm] [varchar]
(
    60
) NULL,
    [mgrTelNo] [varchar]
(
    20
) NULL,
    [mgrEmail] [varchar]
(
    50
) NULL,
    [sdicId] [varchar]
(
    12
) NULL,
    [mrcNo] [varchar]
(
    11
) NULL,
    [lastSaleInvcNo] [numeric]
(
    38,
    0
) NULL,
    [lastPchsInvcNo] [numeric]
(
    38,
    0
) NULL,
    [lastSaleRcptNo] [numeric]
(
    38,
    0
) NULL,
    [lastInvcNo] [numeric]
(
    38,
    0
) NULL,
    [lastTrainInvcNo] [numeric]
(
    38,
    0
) NULL,
    [lastProfrmInvcNo] [numeric]
(
    38,
    0
) NULL,
    [lastCopyInvcNo] [numeric]
(
    38,
    0
) NULL
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
    USE [EVO-CHEM]
    GO

/****** Object:  StoredProcedure [dbo].[UpdateDeviceDetails]    Script Date: 23/10/2024 12:58:36 pm ******/
DROP
PROCEDURE
[dbo].[UpdateDeviceDetails]
GO

/****** Object:  StoredProcedure [dbo].[UpdateDeviceDetails]    Script Date: 23/10/2024 12:58:36 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


DROP PROCEDURE
[dbo].[UpdateDeviceDetails]
GO


CREATE PROCEDURE [dbo].[UpdateDeviceDetails]
    @resultCd varchar(3),
    @resultMsg varchar(max),
    @resultDt varchar(14),
    @tpin varchar(10),
    @taxprNm varchar(255),
    @bsnsActv varchar(100),
    @bhfId varchar(3),
    @bhfNm varchar(60),
    @bhfOpenDt varchar(8),
    @prvncNm varchar(100),
    @dstrtNm varchar(100),
    @sctrNm varchar(100),
    @locDesc varchar(100),
    @hqYn varchar(1),
    @mgrNm varchar(60),
    @mgrTelNo varchar(20),
    @mgrEmail varchar(50),
    @sdicId varchar(12),
    @mrcNo varchar(11),
    @lastSaleInvcNo numeric(38, 0),
    @lastPchsInvcNo numeric(38, 0),
    @lastSaleRcptNo numeric(38, 0),
    @lastInvcNo numeric(38, 0),
    @lastTrainInvcNo numeric(38, 0),
    @lastProfrmInvcNo numeric(38, 0),
    @lastCopyInvcNo numeric(38, 0)
AS
BEGIN
    IF
EXISTS (SELECT 1 FROM DeviceInit WHERE sdicId = @sdicId)
BEGIN
UPDATE DeviceInit
SET resultCd         = @resultCd,
    resultMsg        = @resultMsg,
    resultDt         = @resultDt,
    tpin             = @tpin,
    taxprNm          = @taxprNm,
    bsnsActv         = @bsnsActv,
    bhfId            = @bhfId,
    bhfNm            = @bhfNm,
    bhfOpenDt        = @bhfOpenDt,
    prvncNm          = @prvncNm,
    dstrtNm          = @dstrtNm,
    sctrNm           = @sctrNm,
    locDesc          = @locDesc,
    hqYn             = @hqYn,
    mgrNm            = @mgrNm,
    mgrTelNo         = @mgrTelNo,
    mgrEmail         = @mgrEmail,
    sdicId           = @sdicId,
    mrcNo            = @mrcNo,
    lastSaleInvcNo   = @lastSaleInvcNo,
    lastPchsInvcNo   = @lastPchsInvcNo,
    lastSaleRcptNo   = @lastSaleRcptNo,
    lastInvcNo       = @lastInvcNo,
    lastTrainInvcNo  = @lastTrainInvcNo,
    lastProfrmInvcNo = @lastProfrmInvcNo,
    lastCopyInvcNo   = @lastCopyInvcNo
WHERE sdicId = @sdicId;
END
ELSE
BEGIN
INSERT INTO DeviceInit (resultCd, resultMsg, resultDt, tpin, taxprNm, bsnsActv, bhfId,
                        bhfNm, bhfOpenDt, prvncNm, dstrtNm, sctrNm, locDesc, hqYn, mgrNm, mgrTelNo,
                        mgrEmail, sdicId, mrcNo, lastSaleInvcNo, lastPchsInvcNo, lastSaleRcptNo,
                        lastInvcNo, lastTrainInvcNo, lastProfrmInvcNo, lastCopyInvcNo)
VALUES (@resultCd, @resultMsg, @resultDt, @tpin, @taxprNm, @bsnsActv, @bhfId,
        @bhfNm, @bhfOpenDt, @prvncNm, @dstrtNm, @sctrNm, @locDesc, @hqYn, @mgrNm,
        @mgrTelNo, @mgrEmail, @sdicId, @mrcNo, @lastSaleInvcNo, @lastPchsInvcNo,
        @lastSaleRcptNo, @lastInvcNo, @lastTrainInvcNo, @lastProfrmInvcNo, @lastCopyInvcNo);
END
END;

GO