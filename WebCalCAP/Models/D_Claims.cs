using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using SnapObjects.Data;
using DWNet.Data;
using Newtonsoft.Json;
using System.Collections;

namespace WebCalCAP.Models
{
    [DataWindow("d_claims", DwStyle.Default)]
    [Table("abs_cla_claim_processing", Schema = "abs")]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \r\n "
                  +"\"abs_cla_claim_processing\" , \r\n "
                  +"\"abs_loa_loans\" , \r\n "
                  +"\"abs_bor_borrower\" , \r\n "
                  +"\"abs_len_lender\" \r\n "
                  +"WHERE (\"abs_cla_claim_processing\".\"cla_loa_id\" = \"abs_loa_loans\".\"loa_id\" ) \r\n "
                  +"and ( \"abs_loa_loans\".\"loa_bor_id\" = \"abs_bor_borrower\".\"bor_id\" ) \r\n "
                  +"and ( \"abs_loa_loans\".\"loa_len_id\" = \"abs_len_lender\".\"len_id\" ) \r\n "
                  +"and ( ( \"ABS_LOA_LOANS\".\"LOA_ID\" = :loa_id ) )")]
    #endregion
    [DwParameter("loa_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Claims
    {
        [Key]
        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_id\"")]
        public decimal Cla_Id { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_app_rcvd_dt\"", TypeName = "datetime2")]
        public DateTime? Cla_App_Rcvd_Dt { get; set; }

        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_rcvd_by\"")]
        public decimal? Cla_Rcvd_By { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_submitted\"")]
        public string Cla_Submitted { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_len_id\"")]
        public decimal? Cla_Len_Id { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_bor_id\"")]
        public decimal? Cla_Bor_Id { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_loa_id\"")]
        public decimal? Cla_Loa_Id { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_charge_off_dt\"", TypeName = "datetime2")]
        public DateTime? Cla_Charge_Off_Dt { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_filed_amt\"")]
        public decimal? Cla_Filed_Amt { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_amt_of_approv_claim\"")]
        public decimal? Cla_Amt_Of_Approv_Claim { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_claim_recoveries\"")]
        public string Cla_Claim_Recoveries { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_loan_sold\"")]
        public string Abs_Cla_Claim_Processing_Cla_Loan_Sold { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_amnt_paid_dt\"", TypeName = "datetime2")]
        public DateTime? Abs_Cla_Claim_Processing_Cla_Amnt_Paid_Dt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_lender_loan_nbr\"")]
        public string Abs_Loa_Loans_Loa_Lender_Loan_Nbr { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap\"")]
        public decimal? Abs_Loa_Loans_Loa_Calcap { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_delivery_method\"")]
        public string Cla_Delivery_Method { get; set; }

        [DwColumn("\"abs_cla_claim_processing\"", "\"cla_claim_submitted_dt\"", TypeName = "datetime2")]
        public DateTime? Abs_Cla_Claim_Processing_Cla_Claim_Submitted_Dt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_loan_num\"")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_len_lender\"", "\"len_name\"")]
        public string Abs_Len_Lender_Len_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_name\"")]
        public string Abs_Bor_Borrower_Bor_Name { get; set; }

    }

}