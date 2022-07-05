﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class Sysdefault
    {
        public string Company { get; set; }
        public string Address { get; set; }
        public string PhysicalAddress { get; set; }
        public string Town { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string GlInventoryAccount { get; set; }
        public string GlCustomerAccount { get; set; }
        public string GlSupplierAccount { get; set; }
        public string GlInvAdjustmentAccount { get; set; }
        public string GlSalesAccount { get; set; }
        public string GlPurchasesAccount { get; set; }
        public string GlVatAccount { get; set; }
        public string GlCashBookDiscountAccount { get; set; }
        public string GlCostOfSalesAccount { get; set; }
        public string GlMiscAccount { get; set; }
        public string GlGoodsInTransitAccount { get; set; }
        public bool AdminFormInUse { get; set; }
        public string Pinno { get; set; }
        public string Vatno { get; set; }
        public string BackupPath { get; set; }
        public string PastelGlpath { get; set; }
        public string PastelDatapath { get; set; }
        public short? Expiryperiod { get; set; }
        public short? Periodcount { get; set; }
        public bool Noreminder { get; set; }
        public bool Yesreorder { get; set; }
        public bool Registered { get; set; }
        public string GlGitAccount { get; set; }
        public string GlShortlandedgoodsacct { get; set; }
        public string GlInsuranceprovisionacct { get; set; }
        public string GlSuppjournalcontraacct { get; set; }
        public string GlCusjournalcontraacct { get; set; }
        public bool Allowexistingstock { get; set; }
        public string GlForexacct { get; set; }
        public bool SuppPrice { get; set; }
        public bool Fifo { get; set; }
        public bool Zerolevel { get; set; }
        public bool Monitorexpiry { get; set; }
        public int? Expirydays { get; set; }
        public bool AlertOnPaymentsdue { get; set; }
        public double? Defaultcashdiscount { get; set; }
        public bool Holding { get; set; }
        public bool Creddiscounts { get; set; }
        public bool SinvNotmorethanSorder { get; set; }
        public bool SinvWSorder { get; set; }
        public bool? SinvWTransporter { get; set; }
        public int C1Default { get; set; }
        public int C2Default { get; set; }
        public int C3Default { get; set; }
        public int C4Default { get; set; }
        public int C5Default { get; set; }
        public int C6Default { get; set; }
        public int C7Default { get; set; }
        public int C8Default { get; set; }
        public bool? Pharmacy { get; set; }
        public string CashBankAcct { get; set; }
        public string InvoiceMsg { get; set; }
        public bool? IgnoreExpiry { get; set; }
        public DateTime? DefaultExpiry { get; set; }
        public bool? IgnoreMail { get; set; }
        public string SalescodeDefaultcsale { get; set; }
        public string SalescodeDefaultinvoice { get; set; }
        public string CsaleComment { get; set; }
        public bool? Importer { get; set; }
        public string AdminPassword { get; set; }
        public int? MaxPostRecords { get; set; }
        public int? EntryType { get; set; }
        public bool? Usesupplierprice { get; set; }
        public bool? Openitem { get; set; }
        public bool? Blockpartallocation { get; set; }
        public int? CurrentMonth { get; set; }
        public int? CurrentYear { get; set; }
        public string CurrentPeriod { get; set; }
        public DateTime? CurrentStartdate { get; set; }
        public DateTime? CurrentEnddate { get; set; }
        public bool? Salescodefromcuscode { get; set; }
        public string Companybarcode { get; set; }
        public bool? Stocksonly { get; set; }
        public bool? EnforceTerms { get; set; }
        public bool? UseDelivery { get; set; }
        public bool? GetOrderlocation { get; set; }
        public bool? UseTechgel { get; set; }
        public bool? IgnoreItempricerounding { get; set; }
        public bool? IgnoreAudit { get; set; }
        public bool? OptimiseSalesentry { get; set; }
        public bool? IgnoreSalesitemselection { get; set; }
        public bool? IssueOnbatch { get; set; }
        public bool? UseCdate { get; set; }
        public string SysDateformat { get; set; }
        public int? CsaleOffset { get; set; }
        public bool? GrnProvisions { get; set; }
        public bool? UsePreferredprice { get; set; }
        public bool? UseRetailprice { get; set; }
        public bool? UpdateRetailpriceonsale { get; set; }
        public int? NextCsalenum { get; set; }
        public int? NextInvoicenum { get; set; }
        public bool? UpdateAvgcost { get; set; }
        public bool? SalestransactionlevelPosting { get; set; }
        public bool? PrintinvoicePersalescode { get; set; }
        public short? CustomerIndex { get; set; }
        public bool? CursordefaultItemcode { get; set; }
        public string DefaultTaxcode { get; set; }
        public bool? DisplayMaxitemdiscount { get; set; }
        public bool? HideOrdercreditinfo { get; set; }
        public bool? MonitorPrintcopy { get; set; }
        public bool? BonusAvgcost { get; set; }
        public string DefLoc { get; set; }
        public bool? DiscountCashsalebal { get; set; }
        public bool? ReorderBysales { get; set; }
        public double? ReorderMax { get; set; }
        public double? ReorderMin { get; set; }
        public int? ReorderDuration { get; set; }
        public bool? GlPostdirect { get; set; }
        public bool? GlIntegratestocks { get; set; }
        public int? FinPrdstart { get; set; }
        public int? FinPrdend { get; set; }
        public string StatementMessage { get; set; }
        public bool? AutoallocateCnote { get; set; }
        public bool? RoundupPrice { get; set; }
        public DateTime? StockStartdate { get; set; }
        public DateTime? StockEnddate { get; set; }
        public DateTime? StatementToday { get; set; }
        public DateTime? StatementEnddate { get; set; }
        public DateTime? StatementStartdate { get; set; }
        public DateTime? SupstatementStartdate { get; set; }
        public DateTime? SupstatementEnddate { get; set; }
        public DateTime? SupstatementToday { get; set; }
        public bool StockBalFromTrans { get; set; }
        public bool? LockCashsalecustomer { get; set; }
        public bool? InvoiceCrystal { get; set; }
        public bool? CashSaleCrystal { get; set; }
        public bool? AllowBankposting { get; set; }
        public bool? UseChequedate { get; set; }
        public short? AgeingStart { get; set; }
        public short? AgeingEnd { get; set; }
        public short? UseAgeingperiod { get; set; }
        public short? FinyearStartmonth { get; set; }
        public short? ReceiptsCrystal { get; set; }
        public bool? StatementCrystal { get; set; }
        public bool? CnoteUseformula { get; set; }
        public bool? IncrementRctref { get; set; }
        public string RctrefPrefix { get; set; }
        public bool? StatementByperiod { get; set; }
        public bool? StatementUseformula { get; set; }
        public string StatementObjectname { get; set; }
        public bool? AutobatchInvoice { get; set; }
        public bool? AutobatchCashsale { get; set; }
        public bool? AutobatchCnote { get; set; }
        public bool QuotationCrystal { get; set; }
        public bool Distributor { get; set; }
        public string CrystalPath { get; set; }
        public bool? PorderCrystal { get; set; }
        public bool? GretCrystal { get; set; }
        public bool? SalesorderCrystal { get; set; }
        public bool? SuppstatementCrystal { get; set; }
        public short? GrnDefault { get; set; }
        public bool? GlPostsuppliercategory { get; set; }
        public bool? PartBreakdown { get; set; }
        public bool? LinkLocationSalescode { get; set; }
        public string PurchasecodeDefaultinvoice { get; set; }
        public bool? CommentsMultipleglpayments { get; set; }
        public bool? Printreceiptonsave { get; set; }
        public bool? Discountonsalesaccount { get; set; }
        public bool? Cashsalecreditnote { get; set; }
        public string Entity { get; set; }
        public string Costcentre { get; set; }
        public string Costofsales { get; set; }
        public bool? Showcostofsales { get; set; }
        public bool? GlPostcustomercategory { get; set; }
        public bool? PurchasetransactionlevelPosting { get; set; }
        public bool? Reconchequedate { get; set; }
        public string Acctstockcontrol { get; set; }
        public bool? Printlocalcurrencystatement { get; set; }
        public bool? Multiuserinvoicing { get; set; }
        public bool? Transactcontrol { get; set; }
        public string Placcount { get; set; }
        public string Glyear { get; set; }
        public DateTime? FinStartdate { get; set; }
        public DateTime? FinEnddate { get; set; }
        public double? Openstock { get; set; }
        public bool? Assortedsearch { get; set; }
        public bool? Batchexpiry { get; set; }
        public string DefaultBatch { get; set; }
        public bool? SearchActiveing { get; set; }
        public bool? Multibranch { get; set; }
        public bool? Runbal { get; set; }
        public bool? Checkunbatchedstock { get; set; }
        public string Stockinlocation { get; set; }
        public string Stockoutlocation { get; set; }
        public bool? Locklocations { get; set; }
        public bool? Retailsale { get; set; }
        public string Cashpurchasecode { get; set; }
        public bool? Batchinvoiceonprint { get; set; }
        public bool? Nosalebelowaveragecost { get; set; }
        public bool? Nosalebelowlastcost { get; set; }
        public bool? Nosalebelowminimumprice { get; set; }
        public bool? Pos { get; set; }
        public bool? Singlecashier { get; set; }
        public double? Maxcashsalediscount { get; set; }
        public bool? Lockinvoicebonus { get; set; }
        public bool? Lockcashsalebonus { get; set; }
        public string CrystalConn { get; set; }
        public bool? Lite { get; set; }
        public bool? Maxcashsalediscountperc { get; set; }
        public string InvoiceOrderCaption { get; set; }
        public string InvoiceReferenceCaption { get; set; }
        public string InvoiceCommentsCaption { get; set; }
        public bool? Nearestshilling { get; set; }
        public string Acctopeningstock { get; set; }
        public string Acctclosingstock { get; set; }
        public bool? Returnfromitems { get; set; }
        public bool? Partwhole { get; set; }
        public bool? Pricingwhole { get; set; }
        public string Salepartwhole { get; set; }
        public bool? Itemcodebyname { get; set; }
        public bool? Printlabelonsave { get; set; }
        public bool? Barcode { get; set; }
        public bool? Forcesalesman { get; set; }
        public bool? AutobatchSuppinvoice { get; set; }
        public bool? AutobatchGret { get; set; }
        public bool? Allocatepayonsave { get; set; }
        public bool? Allocatebeforebatch { get; set; }
        public bool? Paydateischqdate { get; set; }
        public bool? Forcereturncomments { get; set; }
        public bool? Twocashsales { get; set; }
        public int? Cashsalecopies { get; set; }
        public bool? Showlastcostsearch { get; set; }
        public bool? Refreshinventory { get; set; }
        public int? Creditnotecopies { get; set; }
        public bool? Returnpart { get; set; }
        public bool? Kahawalink { get; set; }
        public string Branchcode { get; set; }
        public bool? Acctbranch { get; set; }
        public bool? Stockbranch { get; set; }
        public bool? Csbranch { get; set; }
        public bool? StatementByperiodsupp { get; set; }
        public bool? Batchbtransonprint { get; set; }
        public bool? AutobatchBtrans { get; set; }
        public bool? AutobatchBrn { get; set; }
        public bool? AutobatchBranchorder { get; set; }
        public int? Orderprice { get; set; }
        public int? Receiptprice { get; set; }
        public int? Transferprice { get; set; }
        public bool? Blocksalesorders { get; set; }
        public bool? Blockgrn { get; set; }
        public bool? Clocksystem { get; set; }
        public bool? Pointsystem { get; set; }
        public double? Cashpoints { get; set; }
        public int? Redeempoints { get; set; }
        public string PdqBankAcct { get; set; }
        public int? Pdqcommision { get; set; }
        public string Redeemcode { get; set; }
        public bool? Showlastcashdisc { get; set; }
        public double? Transferdisc { get; set; }
        public bool? Pdtoglonmaturity { get; set; }
        public int? Btranscopies { get; set; }
        public bool? Norepeatitem { get; set; }
        public int? Invoicecopies { get; set; }
        public bool? Autostockcode { get; set; }
        public bool? Autosuppcode { get; set; }
        public bool? Autocuscode { get; set; }
        public bool? Updateavgcostontransfer { get; set; }
        public bool? Updatelastcostontransfer { get; set; }
        public bool? Importlastcost { get; set; }
        public bool? Forcetransfercomments { get; set; }
        public bool? Locktransferprices { get; set; }
        public bool? Locktransactiondates { get; set; }
        public bool? Multilocations { get; set; }
        public bool? AutobatchIbi { get; set; }
        public bool? Lockquotation { get; set; }
        public bool? AutobatchQuotation { get; set; }
        public bool? Choosedoccopies { get; set; }
        public bool? Kahawaftp { get; set; }
        public DateTime? Transfertime { get; set; }
        public bool? Notransfer { get; set; }
        public bool? Centraldb { get; set; }
        public bool? Knockolddebt { get; set; }
        public DateTime? Laststocktake { get; set; }
        public DateTime? Currentstocktake { get; set; }
        public bool? Singlecashsalelogin { get; set; }
        public bool? Blockcusonsale { get; set; }
        public int? Pickcustdiscount { get; set; }
        public bool? Newcusageing { get; set; }
        public bool? Newsuppageing { get; set; }
        public bool? Adjustpricefrompricepick { get; set; }
        public bool? Autominprice { get; set; }
        public double? Minpricemarkup { get; set; }
        public string Defcashsalecomment { get; set; }
        public bool? Autobonus { get; set; }
        public bool? Returndocpickanyitem { get; set; }
        public bool? Shownobonus { get; set; }
        public string V1label { get; set; }
        public string V2label { get; set; }
        public string V3label { get; set; }
        public string V4label { get; set; }
        public string V5label { get; set; }
        public string V6label { get; set; }
        public string V7label { get; set; }
        public string V8label { get; set; }
        public string V9label { get; set; }
        public string V10label { get; set; }
        public bool? Kra { get; set; }
        public int? NSerialPort { get; set; }
        public int? NBaudrate { get; set; }
        public bool? Spinvgrnpickfull { get; set; }
        public bool? Nodocdeleting { get; set; }
        public bool? Sppriceanddisc { get; set; }
        public bool? Stockonsave { get; set; }
        public bool? Kahawadirect { get; set; }
        public bool? Reprintinvoicepages { get; set; }
        public bool? Kahawastart { get; set; }
        public DateTime? Kahawastartdate { get; set; }
        public bool? Sortorderbysubgroup { get; set; }
        public bool? Locklinediscount { get; set; }
        public bool? Premcontacts { get; set; }
        public bool? Hidemargin { get; set; }
        public bool? Cashierprinter { get; set; }
        public bool? Ageingoninvoice { get; set; }
        public bool? Salesinvapproval { get; set; }
        public bool? Prembilling { get; set; }
        public bool? Autoprintinvoice { get; set; }
        public bool? Authorisesale { get; set; }
        public double? Valueforpoints { get; set; }
        public bool? Showspecialprice { get; set; }
        public bool? Discminprice { get; set; }
        public bool? Manminprice { get; set; }
        public bool? Hideinvcode { get; set; }
        public string Invoicepartwhole { get; set; }
        public bool? Quotationpricefree { get; set; }
        public bool? Knockolddebtsupp { get; set; }
        public string Cashdebtoracct { get; set; }
        public bool? Twoinvoices { get; set; }
        public bool? Prembusiness { get; set; }
        public bool? Autosbgcode { get; set; }
        public bool? Retailwholesale { get; set; }
        public string Retaildbname { get; set; }
        public string Retaildbsource { get; set; }
        public string PointsCustomerAcct { get; set; }
        public string PointsExpenseAcct { get; set; }
        public string PointsSalesAcct { get; set; }
        public bool? Viewuncollectedtoday { get; set; }
        public bool? Locksalesprice { get; set; }
        public bool? Alterspinvoice { get; set; }
        public bool? Deletepayrep { get; set; }
        public bool? Alterspdocs { get; set; }
        public bool? Kahsupplier { get; set; }
        public bool? Kahcustomer { get; set; }
        public bool? Kahaccounts { get; set; }
        public int? Itemcodestyle { get; set; }
        public DateTime? Tempstocktake { get; set; }
        public bool? Remoteauthorise { get; set; }
        public bool? Paymentcentral { get; set; }
        public bool? Twoquotations { get; set; }
        public bool? Fixedtransfer { get; set; }
        public int? Transferminutes { get; set; }
        public bool? Returndescsort { get; set; }
        public bool? Locktotalcost { get; set; }
        public bool? Lockdiscount { get; set; }
        public bool? Cashsalefromquote { get; set; }
        public bool? Locksalespriceinvoice { get; set; }
        public bool? Lockdiscountinvoice { get; set; }
        public bool? Showspecialpriceinvoice { get; set; }
        public bool? Remoteapprove { get; set; }
        public bool? Lockvatonsale { get; set; }
        public bool? Lockvatonpurchase { get; set; }
        public bool? Splockcash { get; set; }
        public bool? Splockinv { get; set; }
        public int? Margintype { get; set; }
        public double? Kmaxpoints { get; set; }
        public double? Kmaxredeem { get; set; }
        public double? Kmaxvalue { get; set; }
        public bool? Specialnocheck { get; set; }
        public int? Mkupstyle { get; set; }
        public bool? Prempayroll { get; set; }
        public bool? Autoacctcatg { get; set; }
        public bool? Twolabels { get; set; }
        public int? Salesinvoicelines { get; set; }
        public bool? Printcsalefromcashier { get; set; }
        public string MpesaBankAcct { get; set; }
        public bool? Forcesalesmancsale { get; set; }
        public bool? Lockdescriptionchange { get; set; }
        public bool? Collectcashinvoice { get; set; }
        public bool? Zeroprice { get; set; }
        public bool? Pricewarningpopup { get; set; }
        public bool? Costswithvat { get; set; }
        public bool? Lockpartwhole { get; set; }
        public string Branchpartwhole { get; set; }
        public string Quotationprefix { get; set; }
        public string Salesorderprefix { get; set; }
        public string Salesinvoiceprefix { get; set; }
        public string Creditnoteprefix { get; set; }
        public string Purchaseorderprefix { get; set; }
        public string Goodsreceivedprefix { get; set; }
        public string Supplierinvoiceprefix { get; set; }
        public string Goodsreturnedprefix { get; set; }
        public string Branchorderprefix { get; set; }
        public string Branchtransferprefix { get; set; }
        public string Branchreceiptprefix { get; set; }
        public string Locationtransferprefix { get; set; }
        public string Stocktakpartwhole { get; set; }
        public string Purchasepartwhole { get; set; }
        public bool? Branchtogl { get; set; }
        public string GlExciseAccount { get; set; }
        public bool? Btransnocheck { get; set; }
        public bool? Breceiptnoupdate { get; set; }
        public bool? Lockbtrprice { get; set; }
        public string Theatreprefix { get; set; }
        public string Pdqaccount { get; set; }
        public bool? Smuprice { get; set; }
        public bool? Till { get; set; }
        public bool? Singletill { get; set; }
        public string Tillgl { get; set; }
        public string Cashinvoiceprefix { get; set; }
        public bool? Seperatecashinvoice { get; set; }
        public bool? Agedll { get; set; }
        public bool? Tillprintlogout { get; set; }
        public bool? Printduostatement { get; set; }
        public bool? Likesearch { get; set; }
        public bool? Printdelvafterinvoice { get; set; }
        public string Prodpartwhole { get; set; }
        public string Bmtprefix { get; set; }
        public bool? AutobatchBom { get; set; }
        public string Mnfprefix { get; set; }
        public bool? AutobatchMnf { get; set; }
        public bool? Pricecheckalways { get; set; }
        public bool? Clinicdisp { get; set; }
        public string Clinicdbsos { get; set; }
        public string Clinicdbname { get; set; }
        public int? Clinicdbint { get; set; }
        public bool? Batchdispenseonprint { get; set; }
        public bool? AutobatchDispense { get; set; }
        public bool? Autoacct { get; set; }
        public bool? Autosubacct { get; set; }
        public bool? Linkstock { get; set; }
        public bool? Lockpaycomments { get; set; }
        public bool? Allowmorecashpaid { get; set; }
        public double? Maxmorecashpaid { get; set; }
        public string Shortcompany { get; set; }
        public bool? Processrefills { get; set; }
        public bool? Forcebanking { get; set; }
        public DateTime? Forcebankingtime { get; set; }
        public string Forrefillbranchcode { get; set; }
        public string RefillchargeinvCode { get; set; }
        public int? Refillijrntypenum { get; set; }
        public bool? Applycosttotradecombo { get; set; }
        public bool? Applysupptotradecombo { get; set; }
        public int? Defjournalcost { get; set; }
        public bool? Invsearchlike { get; set; }
        public int? Orderpriceprocess { get; set; }
        public int? Quotepriceprocess { get; set; }
        public bool? Companybranch { get; set; }
        public int? Shelfclass { get; set; }
        public int? Defpricingmode { get; set; }
        public string Ibiprefix { get; set; }
        public bool? AutobatchReq { get; set; }
        public bool? Ibifromrequest { get; set; }
        public bool? Lockdefpricingmode { get; set; }
        public bool? Singleuserlogout { get; set; }
        public string DebtorDefaultinvoice { get; set; }
        public string DebtorDefaultcashsale { get; set; }
        public bool? Stocktakegl { get; set; }
        public string Stockadjexpgl { get; set; }
        public string Stockadjastgl { get; set; }
        public int? Stocktakemode { get; set; }
        public string Invhyphen { get; set; }
        public bool? Pickcredref { get; set; }
        public string Acctglopenbalacct { get; set; }
        public bool? Delnorecycle { get; set; }
        public bool? Forcepasscashbook { get; set; }
        public int? Fyekadays { get; set; }
        public bool? Approvereqonbatch { get; set; }
        public bool? CoreHr { get; set; }
        public bool? Customermarginactive { get; set; }
        public int? Customermargintype { get; set; }
        public string Cashsaleprefix { get; set; }
        public bool? Lastdocdelaction { get; set; }
        public bool? Lastdocglaction { get; set; }
        public DateTime? Lastdocdelrun { get; set; }
        public DateTime? Lastdocglrun { get; set; }
        public bool? Dropcuscombo { get; set; }
        public bool? Nolocationonsearch { get; set; }
        public bool? Porderdirect { get; set; }
        public bool? Saleinvdirect { get; set; }
        public DateTime? Housekeeptime { get; set; }
        public int? Housekeepminutes { get; set; }
        public int? Housekeepstatus { get; set; }
        public DateTime? Docgldatefrom { get; set; }
        public DateTime? Docgldateto { get; set; }
        public bool? Branchgl { get; set; }
        public DateTime? Viewtoakill { get; set; }
        public int? Translockdays { get; set; }
        public string Transferpartwhole { get; set; }
        public int? Defpricingmodecash { get; set; }
        public bool? Seperatecashcreditstatements { get; set; }
        public bool? Autoclockout { get; set; }
        public DateTime? Autoclockouttime { get; set; }
        public bool? Calcweight { get; set; }
        public bool? Warddone { get; set; }
        public bool? Nhifdone { get; set; }
        public DateTime? Masaah { get; set; }
        public bool? Dopareto { get; set; }
        public double? Tgstockdepth0 { get; set; }
        public double? Tgstockdepth1 { get; set; }
        public int? Gobackpareto { get; set; }
        public bool? Forcecusref { get; set; }
        public bool? Suppbarcode { get; set; }
        public bool? Stktakebarcode { get; set; }
        public bool? Brnfromitems { get; set; }
        public string Tillsafeacct { get; set; }
        public string Tillexcessacct { get; set; }
        public bool? Autotillreconcile { get; set; }
        public int? Nrstshill { get; set; }
        public int? Nrstshillsupp { get; set; }
        public int? Nrstshillmanf { get; set; }
        public int? Phamacoreproduction { get; set; }
        public bool? Phamakpr { get; set; }
        public bool? Autofillibi { get; set; }
        public DateTime? Lastageingrun { get; set; }
        public DateTime? AgeingEnddate { get; set; }
        public string Mycustcurdate { get; set; }
        public string Mycustthirtydate { get; set; }
        public string Mycustsixtydate { get; set; }
        public string Mycustninetydate { get; set; }
        public string Mycustonetwentydate { get; set; }
        public int? Ndp { get; set; }
        public bool? Singleuserlogoutbtr { get; set; }
        public int? Supplierentrycode { get; set; }
        public int? Purchsalesbranchdocs { get; set; }
        public int? Stkstatus { get; set; }
        public int? Stkref { get; set; }
        public int? Stkupdatemode { get; set; }
        public bool? Stktableupdate { get; set; }
        public int? Approvelpo { get; set; }
        public bool? Premfa { get; set; }
        public bool? Assetpurchaseintegrate { get; set; }
        public bool? Lockdescriptionchangesupp { get; set; }
        public int? BlockPbdSinv { get; set; }
        public int? BlockPbdGret { get; set; }
        public int? BlockPbdSaleinv { get; set; }
        public int? BlockPbdCsale { get; set; }
        public int? BlockPbdCnote { get; set; }
        public int? Supppricelist { get; set; }
        public int? Cashpricelist { get; set; }
        public bool? CoreGl { get; set; }
        public bool? CoreBranch { get; set; }
        public bool? CheckuserLoginbcode { get; set; }
        public bool? Pickcheque { get; set; }
        public bool? Pickchequeonly { get; set; }
        public bool? Locklposuppitems { get; set; }
        public int? Brandgenericsale { get; set; }
        public bool? Lockjrnbranch { get; set; }
        public bool? Tillbanking { get; set; }
        public bool? Manualclose { get; set; }
        public bool? Smartcheck { get; set; }
        public bool? Pickpriceadjustmkup { get; set; }
        public bool? Blockvat { get; set; }
        public bool? Multiminprice { get; set; }
        public bool? Brnpriceupdate { get; set; }
        public bool? Printpostedreceiptsonly { get; set; }
        public int? Invfromquotecheck { get; set; }
        public bool? Directcashprint { get; set; }
        public bool? Directstocksearch { get; set; }
        public bool? Forcesalesmanibi { get; set; }
        public bool? Pickdepartment { get; set; }
        public string DeftaxCode { get; set; }
        public string GlWhtaxAccount { get; set; }
        public string Whvatcode { get; set; }
        public int? Salesdp { get; set; }
        public int? StockupdateallLoc { get; set; }
        public int? StockupdateCheckvariance { get; set; }
        public int? StockupdateAllownonsubgrouptrans { get; set; }
        public bool? Pickdeptforce { get; set; }
        public bool? Forcepaycomments { get; set; }
        public bool? ForceInvshelfclass { get; set; }
        public bool? ForceInvstockformulation { get; set; }
        public bool? ForceInvstockmainclass { get; set; }
        public bool? Printduostatementsupp { get; set; }
        public bool? Corepasscomplex { get; set; }
        public int? Passhistory { get; set; }
        public int? Passage { get; set; }
        public int? Passminlength { get; set; }
        public bool? Passcomplex { get; set; }
        public int? Passmaxtry { get; set; }
        public bool? Dontlocksupponinvoice { get; set; }
        public bool? Dontlockcusinvoice { get; set; }
        public bool? Blocksupponpurchase { get; set; }
        public bool? Salesdeliverybeforepost { get; set; }
        public bool? Managenonreg { get; set; }
        public string Nonreginvprefix { get; set; }
        public string Nonregcashinvprefix { get; set; }
        public string Nonregcnoteprefix { get; set; }
        public bool? Credcontrolstatementfilter { get; set; }
        public bool? Doubleledgercard { get; set; }
        public bool? Binstockinquiry { get; set; }
        public string Locationreturnprefix { get; set; }
        public int? NextretNum { get; set; }
        public bool? Stockmoveincludebt { get; set; }
        public bool? Btrbarcode { get; set; }
        public bool? Suppinvcheckpendingbranchorder { get; set; }
        public bool? Prembusinesssales { get; set; }
        public string SalesanalysisA { get; set; }
        public string SalesanalysisB { get; set; }
        public string SalesanalysisC { get; set; }
        public string SalesanalysisD { get; set; }
        public string SalesanalysisE { get; set; }
        public bool? OneDayTill { get; set; }
        public bool? Singleuserlogoutborder { get; set; }
        public bool? Branchtransfromorder { get; set; }
        public int? Usecuspricelist { get; set; }
        public bool? Blankcashierpaymode { get; set; }
        public string StocksanalysisA { get; set; }
        public string StocksanalysisB { get; set; }
        public string StocksanalysisC { get; set; }
        public string StocksanalysisD { get; set; }
        public string StocksanalysisE { get; set; }
        public bool? Prembusinessstocks { get; set; }
        public int? Csldocid { get; set; }
        public int? Crddocid { get; set; }
        public bool? Dokahapi { get; set; }
        public bool? Invbcodesearch { get; set; }
        public string SalesanalysisF { get; set; }
        public string SalesanalysisG { get; set; }
        public string SalesanalysisH { get; set; }
        public string SalesanalysisI { get; set; }
        public string SalesanalysisJ { get; set; }
        public string SalesanalysisK { get; set; }
        public string SalesanalysisL { get; set; }
        public string SalesanalysisM { get; set; }
        public string SalesanalysisN { get; set; }
        public string SalesanalysisO { get; set; }
        public string StocksanalysisF { get; set; }
        public string StocksanalysisG { get; set; }
        public string StocksanalysisH { get; set; }
        public string StocksanalysisI { get; set; }
        public string StocksanalysisJ { get; set; }
        public string StocksanalysisK { get; set; }
        public string StocksanalysisL { get; set; }
        public string StocksanalysisM { get; set; }
        public string StocksanalysisN { get; set; }
        public string StocksanalysisO { get; set; }
        public bool? Reinforceexpiry { get; set; }
        public bool? Cashierpaymodebanks { get; set; }
        public bool? UnbatchDocs { get; set; }
        public bool? Salebelowmin { get; set; }
        public bool? Barcodetransact { get; set; }
        public bool? Allowexpinvoicebackdate { get; set; }
        public DateTime? Invbcodestockdate { get; set; }
        public int? Btransexporttype { get; set; }
        public bool? Integratedinvoice { get; set; }
        public bool? Updateinventoryontransfer { get; set; }
        public bool? Updatecostontransfer { get; set; }
        public bool? Updatetradepriceontransfer { get; set; }
        public bool? Updateminpriceontransfer { get; set; }
        public bool? Updatemaxpriceontransfer { get; set; }
        public bool? Updateretailpriceontransfer { get; set; }
        public bool? Updatespecialpriceontransfer { get; set; }
        public bool? Diagoninvoice { get; set; }
        public bool? Copayinvoice { get; set; }
        public string Copayglacct { get; set; }
        public string Copaycuscode { get; set; }
        public double? Copayperc { get; set; }
        public bool? Checkcorestock2020 { get; set; }
        public bool? Blockcashsales { get; set; }
        public bool? Allowcashpaidoncashinvoice { get; set; }
        public bool? Stocktakemodifymainclass { get; set; }
        public bool? Stocktakemodifyshelfclass { get; set; }
        public bool? Creditnotepenalty { get; set; }
        public bool? Creditnotepenaltyperc { get; set; }
        public double? Creditnotepenaltyamt { get; set; }
        public string Creditnotepenaltyacct { get; set; }
        public int? Cashinvoicecopies { get; set; }
        public bool? Choosedoccopiescash { get; set; }
        public bool? BlockPbdSaleinvcash { get; set; }
        public bool? Lockinvoicebonuscash { get; set; }
        public bool? Locksalespriceinvoicecash { get; set; }
        public bool? Lockdiscountinvoicecash { get; set; }
        public bool? Salesdeliverybeforepostcash { get; set; }
        public string InvoiceOrderCaptioncash { get; set; }
        public string InvoiceReferenceCaptioncash { get; set; }
        public string InvoiceCommentsCaptioncash { get; set; }
        public bool? Forcetilloncashinvreturn { get; set; }
        public bool? Locklinediscountcash { get; set; }
        public bool? Invtoquote { get; set; }
        public bool? Nocashbooktillrecon { get; set; }
        public bool? Invsearchpw { get; set; }
        public bool? Allowpacksizealteration { get; set; }
        public bool? Locknewpacksize { get; set; }
        public bool? PaymodeTillAlter { get; set; }
        public bool? AllowPartialCashInvoiceCollection { get; set; }
        public bool? Twocnotes { get; set; }
        public bool? Twocashinvoices { get; set; }
        public bool? Usecombinedstockorders { get; set; }
        public bool? Checksupppricechange { get; set; }
        public bool? CheckPendingOrders { get; set; }
        public bool? Relaxcashterms { get; set; }
        public bool? Issmartrelax { get; set; }
        public bool? Returndocpickanyitemgret { get; set; }
        public bool? Logerrormsg { get; set; }
        public bool? Dokahapibranchorder { get; set; }
        public bool? Allocatepdcheques { get; set; }
        public bool? Clearunusedquotation { get; set; }
        public int? Quotationdays { get; set; }
        public bool? Neohybridorder { get; set; }
        public int? Nextautobtrnum { get; set; }
        public bool? Trackbtr { get; set; }
        public bool? Verif2 { get; set; }
        public int? Nextsnvupdatenum { get; set; }
        public bool? Alterpostedsalesinvoice { get; set; }
        public bool? Alterpostedcashinvoice { get; set; }
        public bool? Dispatchdirect { get; set; }
        public bool? Nosaleabovemaxprice { get; set; }
        public bool? DokahapiLpo { get; set; }
        public bool? Pdcashbookopendate { get; set; }
        public bool? Checklasttransactiondate { get; set; }
        public bool? Checstockprocessdate { get; set; }
        public DateTime? Stockprocessdate { get; set; }
        public DateTime? Lasttransrun { get; set; }
        public string Mpesacbook { get; set; }
        public bool? Freezempesacashierdate { get; set; }
        public bool? Mpesaanyaccount { get; set; }
        public int? Bcode { get; set; }
        public string CustomerMemberNoPrefix { get; set; }
        public double? MinimumPointsToTranfer { get; set; }
        public double? MaximumPointsToTranfer { get; set; }
        public double? MinimumPointsToHaveToEnableTranfer { get; set; }
    }
}