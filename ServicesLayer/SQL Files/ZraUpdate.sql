/****** Object:  StoredProcedure dbo.UpdateZRAClassCodes    Script Date: 29/10/2024 4:25:24 pm ******/
SET
ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE dbo.UpdateZRAImports @taskCd varchar(50),
      @dclDe varchar(8),
      @itemSeq numeric(10,0),
      @dclNo varchar(50),
      @hsCd varchar(17),
      @itemNm varchar(500),
      @orgnNatCd varchar(5),
      @exptNatCd varchar(5),
      @pkg numeric(13,2),
      @pkgUnitCd varchar(5),
      @qty numeric(13,2),
      @qtyUnitCd varchar(5),
      @totWt numeric(13,2),
      @netWt numeric(13,2),
      @spplrNm varchar(500),
      @agntNm varchar(500),
      @invcFcurAmt numeric(18,4),
      @invcFcurCd varchar(5),
      @invcFcurExcrt numeric(18,4),
      @dclRefNum varchar(100)
AS
BEGIN
    -- Check if the record exists
    IF
EXISTS (SELECT 1 FROM ZRAImportData WHERE dclNo = @dclNo)
BEGIN
        -- Update existing record
UPDATE ZRAImportData
SET taskCd        = @taskCd
  , dclDe         = @dclDe
  , itemSeq       = @itemSeq
  , dclNo         = @dclNo
  , hsCd          = @hsCd
  , itemNm        = @itemNm
  , orgnNatCd     = @orgnNatCd
  , exptNatCd     = @exptNatCd
  , pkg           = @pkg
  , pkgUnitCd     = @pkgUnitCd
  , qty           = @qty
  , qtyUnitCd     = @qtyUnitCd
  , totWt         = @totWt
  , netWt         = @netWt
  , spplrNm       = @spplrNm
  , agntNm        = @agntNm
  , invcFcurAmt   = @invcFcurAmt
  , invcFcurCd    = @invcFcurCd
  , invcFcurExcrt = @invcFcurExcrt
  , dclRefNum     = @dclRefNum

WHERE dclNo = @dclNo;
END
ELSE
BEGIN
        -- Insert new record
INSERT INTO dbo.ZRAImportData
( taskCd
, dclDe
, itemSeq
, dclNo
, hsCd
, itemNm
, orgnNatCd
, exptNatCd
, pkg
, pkgUnitCd
, qty
, qtyUnitCd
, totWt
, netWt
, spplrNm
, agntNm
, invcFcurAmt
, invcFcurCd
, invcFcurExcrt
, dclRefNum)
VALUES ( @taskCd
       , @dclDe
       , @itemSeq
       , @dclNo
       , @hsCd
       , @itemNm
       , @orgnNatCd
       , @exptNatCd
       , @pkg
       , @pkgUnitCd
       , @qty
       , @qtyUnitCd
       , @totWt
       , @netWt
       , @spplrNm
       , @agntNm
       , @invcFcurAmt
       , @invcFcurCd
       , @invcFcurExcrt
       , @dclRefNum)
;
END
END;

GO

