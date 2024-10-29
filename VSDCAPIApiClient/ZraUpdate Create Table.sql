USE [EVO-CHEM]
GO

/****** Object:  Table [dbo].[ZRAImportData]    Script Date: 29/10/2024 4:55:16 pm ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ZRAImportData](
[taskCd] [varchar](50) NULL,
[dclDe] [varchar](8) NULL,
[itemSeq] [numeric](10, 0) NULL,
[dclNo] [varchar](50) NULL,
[hsCd] [varchar](17) NULL,
[itemNm] [varchar](500) NULL,
[orgnNatCd] [varchar](5) NULL,
[exptNatCd] [varchar](5) NULL,
[pkg] [numeric](13, 2) NULL,
[pkgUnitCd] [varchar](5) NULL,
[qty] [numeric](13, 2) NULL,
[qtyUnitCd] [varchar](5) NULL,
[totWt] [numeric](13, 2) NULL,
[netWt] [numeric](13, 2) NULL,
[spplrNm] [varchar](500) NULL,
[agntNm] [varchar](500) NULL,
[invcFcurAmt] [numeric](18, 4) NULL,
[invcFcurCd] [varchar](5) NULL,
[invcFcurExcrt] [numeric](18, 4) NULL,
[dclRefNum] [varchar](100) NULL
) ON [PRIMARY]
GO


