-- Active: 1729772099477@@127.0.0.1@1433@EVO-CHEM
create view ZRASTockAdjustments as
select 
case when s.Module='AR' then (select c.Tax_Number from Client c where c.Account=s.Account)
else
case when s.Module='AP' then (select c.Tax_Number from Vendor c where c.Account=s.Account)
else null end end as 'custTpin',
case when s.Module='AR' then (select c.Name from Client c where c.Account=s.Account)
else
case when s.Module='AP' then (select c.Name from Vendor c where c.Account=s.Account)
else null end end as 'custNm',
case when s.Module='AP' then (select c.ulAPSmart from Vendor c where c.Account=s.Account)
else 'M' end as 'regTyCd',
case when s.Module not in ('AP','AR') and QtyIn>0 then '06' else '16' end as 'sarTyCd',
'totItemCnt'=1,
case when iCurrencyID<>0 then (fForeignDebit+fForeignCredit-fForeignTax) else 
(Debit+Credit-Tax_Amount) end as 'totTaxblAmt',
case when iCurrencyID<>0 then fForeignTax else Tax_Amount end as 'totTaxAmt',
case when iCurrencyID<>0 then (fForeignDebit+fForeignCredit) 
else 
(Debit+Credit) end as 'totAmt',
format(cast (TxDate as date ), 'yyyyMMdd') as 'ocrnDt',
'itemSeq'=1,
(select t.Code from StkItem t where t.StockLink=s.AccountLink) as 'itemCd',
(select coalesce(t.ucIIUNSPSC,'1017160000') from StkItem t where t.StockLink=s.AccountLink) as 'itemClsCd',
(select t.Description_1 from StkItem t where t.StockLink=s.AccountLink) as 'itemNm',
(select coalesce(t.ulIIQuantityUnitCode,'EA') from StkItem t where t.StockLink=s.AccountLink) as 'pkgUnitCd',
'pkg'=0,
(select coalesce(t.ulIIQuantityUnitCode,'EA') from StkItem t where t.StockLink=s.AccountLink) as 'qtyUnitCd', Quantity  as 'qty',
 (case when iCurrencyID<>0 then (fForeignDebit+fForeignCredit) else (Debit+Credit) end)/nullif(Quantity,0) as 'prc',
(case when iCurrencyID<>0 then (fForeignDebit+fForeignCredit) else 
(Debit+Credit) end) as 'splyAmt',
'totDcAmt'=0,
case when iCurrencyID<>0 then (fForeignDebit+fForeignCredit-fForeignTax) else (Debit+Credit-Tax_Amount) end as 'taxblAmt',
case when Tax_Amount>0 then 'A' else 'D' end as 'vatCatCd',
case when iCurrencyID<>0 then fForeignTax else Tax_Amount end as 'taxAmt'
/*,
case when iCurrencyID<>0 then (fForeignDebit+fForeignCredit) 
else 
(Debit+Credit) end as
'totAmt'*/
 from _bvSTTransactionsFull s where s.Module not in('AP','AR')