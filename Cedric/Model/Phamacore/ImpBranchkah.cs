using System;
using System.Collections.Generic;

#nullable disable

namespace Cedric.Model.Phamacore
{
    public partial class ImpBranchkah
    {
        public string Branchcode { get; set; }
        public string BranchName { get; set; }
        public string Branchserverpath { get; set; }
        public string BranchIp { get; set; }
        public string Databasename { get; set; }
        public bool? Enabled { get; set; }
        public bool? Mainbranch { get; set; }
        public string Cstctr { get; set; }
        public int Bcode { get; set; }
        public bool? Acct { get; set; }
        public bool? Integrated { get; set; }
        public string Datasourcename { get; set; }
        public string Branchgoodsacct { get; set; }
        public string Branchcostacct { get; set; }
        public int? NextsaleinvNum { get; set; }
        public int? NextcnoteNum { get; set; }
        public string Saleinvoiceprefix { get; set; }
        public string Creditnoteprefix { get; set; }
        public string CusCode { get; set; }
        public string SuppCode { get; set; }
        public int? NextbrnNum { get; set; }
        public string Branchreceiptprefix { get; set; }
        public string DefLoc { get; set; }
        public bool? Blockcustomer { get; set; }
        public bool? Blocksupplier { get; set; }
        public bool? Blockinventory { get; set; }
        public bool? Blocksalesinvoice { get; set; }
        public bool? Blockcashsale { get; set; }
        public bool? Blockcnote { get; set; }
        public bool? Blockquotation { get; set; }
        public bool? Blockporder { get; set; }
        public bool? Blockgrn { get; set; }
        public bool? Blocksuppinvoice { get; set; }
        public bool? Blockgret { get; set; }
        public bool? Blockinvjournals { get; set; }
        public int? Defpricingmode { get; set; }
        public string Salepartwhole { get; set; }
        public string Invoicepartwhole { get; set; }
        public string Reqprefix { get; set; }
        public int? NextreqNum { get; set; }
        public string Locationtransferprefix { get; set; }
        public int? NextibiNum { get; set; }
        public bool? Lockdefpricingmode { get; set; }
        public int? NextBmtNum { get; set; }
        public int? NextborderNum { get; set; }
        public int? NextbrepNum { get; set; }
        public int? NextbtransNum { get; set; }
        public int? NextcinvNum { get; set; }
        public int? NextcsaleNum { get; set; }
        public int? NextgretNum { get; set; }
        public int? NextgrnNum { get; set; }
        public int? NextinvjNum { get; set; }
        public int? NextjournNum { get; set; }
        public int? NextMnfNum { get; set; }
        public int? NextporderNum { get; set; }
        public int? NextquoNum { get; set; }
        public int? NextsinvNum { get; set; }
        public int? NextsoNum { get; set; }
        public int? Nextijrnnum { get; set; }
        public string Cashinvoiceprefix { get; set; }
        public string Quotationprefix { get; set; }
        public string Salesorderprefix { get; set; }
        public string Purchaseorderprefix { get; set; }
        public string Goodsreceivedprefix { get; set; }
        public string Supplierinvoiceprefix { get; set; }
        public string Goodsreturnedprefix { get; set; }
        public string Branchorderprefix { get; set; }
        public string Branchtransferprefix { get; set; }
        public double? Openstock { get; set; }
        public string Bmtprefix { get; set; }
        public string Mnfprefix { get; set; }
        public string Cashsaleprefix { get; set; }
        public bool? Branchdirect { get; set; }
        public string Transferpartwhole { get; set; }
        public int? Defpricingmodecash { get; set; }
        public bool? Lockpartwholeinvoice { get; set; }
        public bool? Lockpartwholesale { get; set; }
        public int? Nextbomdet { get; set; }
        public int? Nextbmrdet { get; set; }
        public bool? Lockpartwholejournal { get; set; }
        public string Journalpartwhole { get; set; }
        public bool? Lockpartwholestocktake { get; set; }
        public string Stocktakepartwhole { get; set; }
        public bool? Blockbranchtransfer { get; set; }
        public bool? Blockbranchreceipt { get; set; }
        public bool? Blockcashinvoice { get; set; }
        public bool? Blockbranchorder { get; set; }
        public bool? Selme { get; set; }
        public string Invuser { get; set; }
        public bool? Custexport { get; set; }
        public bool? Suppexport { get; set; }
        public bool? Invexport { get; set; }
        public bool? Priceexport { get; set; }
        public bool? Branchexport { get; set; }
        public bool? Glexport { get; set; }
        public bool? Kahawalink { get; set; }
        public bool? Kahawadirect { get; set; }
        public bool? Kahcustomer { get; set; }
        public bool? Kahsupplier { get; set; }
        public bool? Kahinventory { get; set; }
        public bool? Kahprices { get; set; }
        public bool? Kahbranch { get; set; }
        public bool? Kahgl { get; set; }
        public bool? Importprices { get; set; }
        public bool? Importpriceslstcost { get; set; }
        public bool? Importpricesavgcost { get; set; }
    }
}
