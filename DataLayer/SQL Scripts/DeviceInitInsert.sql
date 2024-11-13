INSERT INTO DeviceInit (
    resultCd,
    resultMsg,
    resultDt,
    tpin,
    taxprNm,
    bsnsActv,
    bhfId,
    bhfNm,
    bhfOpenDt,
    prvncNm,
    dstrtNm,
    sctrNm,
    locDesc,
    hqYn,
    mgrNm,
    mgrTelNo,
    mgrEmail,
    sdicId,
    mrcNo,
    lastSaleInvcNo,
    lastPchsInvcNo,
    lastSaleRcptNo,
    lastInvcNo,
    lastTrainInvcNo,
    lastProfrmInvcNo,
    lastCopyInvcNo
) VALUES (
    '000', -- resultCd
    'It is succeeded', -- resultMsg
    '20241020103106', -- resultDt
    '1001660976', -- Assuming tpin is not provided
    'CHC COMMODITIES LIMITED',
    NULL, -- bsnsActv is null
    '000',
    'Headquarter',
    '20240927',
    'LUSAKA PROVINCE',
    NULL, -- dstrtNm is null
    'Lusaka',
    '12600, Mwembeshi, Industrial Area',
    'Y',
    'CHC COMMODITIES LIMITED',
    '0960283606',
    'accounts@chc.com.zm',
    'SDC0010001655',
    'WIS00002498',
    0, -- lastSaleInvcNo
    0, -- lastPchsInvcNo
    0, -- lastSaleRcptNo
    NULL, -- lastInvcNo is null
    NULL, -- lastTrainInvcNo is null
    NULL, -- lastProfrmInvcNo is null
    NULL  -- lastCopyInvcNo is null
);


SELECT * FROM DeviceInit