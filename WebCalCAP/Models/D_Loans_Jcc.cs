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
    [DataWindow("d_loans_jcc", DwStyle.Default)]
    [Table("ABS_LOA_LOANS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_loa_loans\" )  TABLE(NAME=\"abs_bor_borrower\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"abs_loa_loans.loa_bor_id\"    OP =\"=\"RIGHT=\"abs_bor_borrower.bor_id\" )) ORDER(NAME=\"abs_loa_loans.loa_calcap_loan_num\" ASC=no)")]
    #endregion
    [DwSort("loa_calcap_loan_num D")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Loans_Jcc
    {
        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_LOA_SEQ])")]
        [DwColumn("abs_loa_loans", "loa_id")]
        public decimal Loa_Id { get; set; }

        [DwColumn("abs_loa_loans", "loa_delivery_method")]
        public string Loa_Delivery_Method { get; set; }

        [DwColumn("abs_loa_loans", "loa_loan_type")]
        public string Loa_Loan_Type { get; set; }

        [DwColumn("abs_loa_loans", "loa_len_id")]
        public decimal? Loa_Len_Id { get; set; }

        [DwColumn("abs_loa_loans", "loa_bor_id")]
        public decimal? Loa_Bor_Id { get; set; }

        [DwColumn("abs_loa_loans", "loa_nbr_empoyees")]
        public decimal? Loa_Nbr_Empoyees { get; set; }

        [DwColumn("abs_loa_loans", "loa_nbr_jobs")]
        public decimal? Loa_Nbr_Jobs { get; set; }

        [DwColumn("abs_loa_loans", "loa_annual_rev")]
        public decimal? Loa_Annual_Rev { get; set; }

        [DwColumn("abs_loa_loans", "loa_sev_affected")]
        public string Loa_Sev_Affected { get; set; }

        [DwColumn("abs_loa_loans", "loa_purpose")]
        public string Loa_Purpose { get; set; }

        [DwColumn("abs_loa_loans", "loa_min_or_women")]
        public string Loa_Min_Or_Women { get; set; }

        [DwColumn("abs_loa_loans", "loa_interest_rate")]
        public decimal? Loa_Interest_Rate { get; set; }

        [DwColumn("abs_loa_loans", "loa_int_rate_type")]
        public string Loa_Int_Rate_Type { get; set; }

        [DwColumn("abs_loa_loans", "loa_int_rate_mod")]
        public string Loa_Int_Rate_Mod { get; set; }

        [DwColumn("abs_loa_loans", "loa_lender_loan_dt", TypeName = "datetime2")]
        public DateTime? Loa_Lender_Loan_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_refinancing")]
        public string Loa_Refinancing { get; set; }

        [DwColumn("abs_loa_loans", "loa_increase")]
        public decimal? Loa_Increase { get; set; }

        [DwColumn("abs_loa_loans", "loa_maturity_dt", TypeName = "datetime2")]
        public DateTime? Loa_Maturity_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_amount_total")]
        public decimal? Loa_Amount_Total { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap")]
        public decimal? Loa_Calcap { get; set; }

        [DwColumn("abs_loa_loans", "loa_program")]
        public string Loa_Program { get; set; }

        [DwColumn("abs_loa_loans", "loa_premium_amnt")]
        public decimal? Loa_Premium_Amnt { get; set; }

        [DwColumn("abs_loa_loans", "loa_premium_pd_dt", TypeName = "datetime2")]
        public DateTime? Loa_Premium_Pd_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_independent_cntr")]
        public decimal? Loa_Independent_Cntr { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_premium_pd")]
        public decimal? Loa_Calcap_Premium_Pd { get; set; }

        [DwColumn("abs_loa_loans", "loa_comments")]
        public string Loa_Comments { get; set; }

        [DwColumn("abs_loa_loans", "loa_lender_loan_nbr")]
        public string Loa_Lender_Loan_Nbr { get; set; }

        [DwColumn("abs_loa_loans", "loa_officer_name")]
        public string Loa_Officer_Name { get; set; }

        [DwColumn("abs_loa_loans", "loa_officer_phone")]
        public string Loa_Officer_Phone { get; set; }

        [DwColumn("abs_loa_loans", "loa_sac_contact_info")]
        public string Loa_Sac_Contact_Info { get; set; }

        [DwColumn("abs_loa_loans", "loa_used_at_address")]
        public string Loa_Used_At_Address { get; set; }

        [DwColumn("abs_loa_loans", "loa_used_address")]
        public string Loa_Used_Address { get; set; }

        [DwColumn("abs_loa_loans", "loa_used_city")]
        public string Loa_Used_City { get; set; }

        [DwColumn("abs_loa_loans", "loa_used_county")]
        public decimal? Loa_Used_County { get; set; }

        [DwColumn("abs_loa_loans", "loa_used_zip")]
        public string Loa_Used_Zip { get; set; }

        [DwColumn("abs_loa_loans", "loa_first_500_calcap")]
        public string Loa_First_500_Calcap { get; set; }

        [DwColumn("abs_loa_loans", "loa_secured")]
        public string Loa_Secured { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_loan_list")]
        public string Loa_Calcap_Loan_List { get; set; }

        [DwColumn("abs_loa_loans", "loa_contrib_name")]
        public string Loa_Contrib_Name { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_loan_num_prior")]
        public string Loa_Calcap_Loan_Num_Prior { get; set; }

        [DwColumn("abs_loa_loans", "loa_naics_code")]
        public string Loa_Naics_Code { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_loan_num")]
        public string Loa_Calcap_Loan_Num { get; set; }

        [DwColumn("abs_loa_loans", "loa_app_rcvd_dt", TypeName = "datetime2")]
        public DateTime? Loa_App_Rcvd_Dt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_bor_borrower", "bor_name")]
        public string Abs_Bor_Borrower_Bor_Name { get; set; }

        [DwColumn("abs_loa_loans", "loa_bus_opnd_2years")]
        public string Abs_Loa_Loans_Loa_Bus_Opnd_2Years { get; set; }

        [DwColumn("abs_loa_loans", "loa_non_profit")]
        public string Abs_Loa_Loans_Loa_Non_Profit { get; set; }

        [DwColumn("abs_loa_loans", "loa_sev_affect_com")]
        public string Abs_Loa_Loans_Loa_Sev_Affect_Com { get; set; }

        [DwColumn("abs_loa_loans", "loa_min_own")]
        public string Abs_Loa_Loans_Loa_Min_Own { get; set; }

        [DwColumn("abs_loa_loans", "loa_wom_own")]
        public string Abs_Loa_Loans_Loa_Wom_Own { get; set; }

        [DwColumn("abs_loa_loans", "loa_vet_own")]
        public string Abs_Loa_Loans_Loa_Vet_Own { get; set; }

        [DwColumn("abs_loa_loans", "loa_gov_guar_pgm")]
        public string Abs_Loa_Loans_Loa_Gov_Guar_Pgm { get; set; }

        [DwColumn("abs_loa_loans", "loa_guar_pgm_name")]
        public string Abs_Loa_Loans_Loa_Guar_Pgm_Name { get; set; }

        [DwColumn("abs_loa_loans", "loa_other_pgm_pct")]
        public decimal? Abs_Loa_Loans_Loa_Other_Pgm_Pct { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_pct")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Pct { get; set; }

        [DwColumn("abs_loa_loans", "loa_remain_bal")]
        public decimal? Abs_Loa_Loans_Loa_Remain_Bal { get; set; }

        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("abs_loa_loans", "loa_app_rcvd_by")]
        public decimal? Abs_Loa_Loans_Loa_App_Rcvd_By { get; set; }

        [DwColumn("abs_loa_loans", "loa_independnt_cntr_dt", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Independnt_Cntr_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_premium_amt")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Premium_Amt { get; set; }

        [DwColumn("abs_loa_loans", "loa_lender_premium_pd_dt", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Lender_Premium_Pd_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_borrow_premium_pd_dt", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Borrow_Premium_Pd_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_prem_pd_dt", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Calcap_Prem_Pd_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_borrower_premium_amnt")]
        public decimal? Abs_Loa_Loans_Loa_Borrower_Premium_Amnt { get; set; }

        [DwColumn("abs_loa_loans", "loa_officer_email")]
        public string Abs_Loa_Loans_Loa_Officer_Email { get; set; }

        [DwColumn("abs_loa_loans", "loa_jobs_retained")]
        public decimal? Abs_Loa_Loans_Loa_Jobs_Retained { get; set; }

        [DwColumn("abs_loa_loans", "loa_jobs_created")]
        public decimal? Abs_Loa_Loans_Loa_Jobs_Created { get; set; }

        [DwColumn("abs_loa_loans", "loa_avg_ann_rev_last_fy")]
        public decimal? Abs_Loa_Loans_Loa_Avg_Ann_Rev_Last_Fy { get; set; }

        [DwColumn("abs_loa_loans", "loa_num_ftes")]
        public decimal? Abs_Loa_Loans_Loa_Num_Ftes { get; set; }

        [DwColumn("abs_loa_loans", "loa_census_tract_num")]
        public string Abs_Loa_Loans_Loa_Census_Tract_Num { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_loa_loans", "loa_csp_appnum")]
        public decimal? Abs_Loa_Loans_Loa_Csp_Appnum { get; set; }

    }

}