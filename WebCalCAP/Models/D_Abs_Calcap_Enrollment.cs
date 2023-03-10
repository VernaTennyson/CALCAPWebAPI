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
    [DataWindow("d_abs_calcap_enrollment", DwStyle.Default)]
    [Table("abs_loa_loans", Schema = "abs")]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"abs_len_lender\" \r\n "
                  +"RIGHT OUTER JOIN \"abs_loa_loans\" ON \"abs_len_lender\".\"len_id\" = \"abs_loa_loans\".\"loa_len_id\" \r\n "
                  +"RIGHT OUTER JOIN \"abs_bor_borrower\"  ON \"abs_bor_borrower\".\"bor_id\" = \"abs_loa_loans\".\"loa_bor_id\"")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Calcap_Enrollment
    {
        [StringLength(200)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_name\"")]
        public string Bor_Name { get; set; }

        [StringLength(200)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_city\"")]
        public string Bor_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Cou_Id", "Cou_Name", typeof(Dddw_Counties), AutoRetrieve = true)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_county\"")]
        public decimal? Bor_County { get; set; }

        [StringLength(5)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_zip\"")]
        public string Bor_Zip { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_zip_4\"")]
        public string Bor_Zip_4 { get; set; }

        [StringLength(200)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_len_lender\"", "\"len_name\"")]
        public string Len_Name { get; set; }

        [StringLength(80)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_len_lender\"", "\"len_lendor_number\"")]
        public string Len_Lendor_Number { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_nbr_empoyees\"")]
        public decimal? Loa_Nbr_Empoyees { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_nbr_jobs\"")]
        public decimal? Loa_Nbr_Jobs { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_annual_rev\"")]
        public decimal? Loa_Annual_Rev { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_sev_affected\"")]
        public string Loa_Sev_Affected { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_min_or_women\"")]
        public string Loa_Min_Or_Women { get; set; }

        [StringLength(120)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_purpose\"")]
        public string Loa_Purpose { get; set; }

        [StringLength(100)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_lender_loan_nbr\"")]
        public string Loa_Lender_Loan_Nbr { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_amount_total\"")]
        public decimal? Loa_Amount_Total { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_lender_loan_dt\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Lender_Loan_Dt { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_int_rate_type\"")]
        public string Loa_Int_Rate_Type { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_maturity_dt\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Maturity_Dt { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_refinancing\"")]
        public string Loa_Refinancing { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_premium_pd\"")]
        public decimal? Loa_Calcap_Premium_Pd { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_independnt_cntr_dt\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Independnt_Cntr_Dt { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_interest_rate\"")]
        public decimal? Loa_Interest_Rate { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_increase\"")]
        public decimal? Loa_Increase { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_premium_amt\"")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Premium_Amt { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_premium_amnt\"")]
        public decimal? Abs_Loa_Loans_Loa_Premium_Amnt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_type_of_business\"")]
        public string Bor_Type_Of_Bus { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_len_id\"")]
        public decimal? Loa_Len_Id { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_bor_id\"")]
        public decimal? Loa_Bor_Id { get; set; }

        [Key]
        [DwColumn("\"abs_loa_loans\"", "\"loa_id\"")]
        public decimal? Loa_Id { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_app_rcvd_dt\"", TypeName = "datetime2")]
        public DateTime? Loa_App_Rcvd_Dt { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_officer_name\"")]
        public string Loa_Officer_Name { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_officer_phone\"")]
        public string Loa_Officer_Phone { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(D_Dddw_Loan_Type), AutoRetrieve = true)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_loan_type\"")]
        public string Loa_Loan_Type { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_dba\"")]
        public string Abs_Bor_Borrower_Bor_Dba { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_address\"")]
        public string Bor_Address { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_phone\"")]
        public string Bor_Phone { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_fax\"")]
        public string Bor_Fax { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_sac_contact_info\"")]
        public string Loa_Sac_Contact_Info { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_used_at_address\"")]
        public string Loa_Used_At_Address { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_used_address\"")]
        public string Loa_Used_Address { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_used_city\"")]
        public string Loa_Used_City { get; set; }

        [DwChild("Cou_Id", "Cou_Name", typeof(Dddw_Counties), AutoRetrieve = true)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_used_county\"")]
        public decimal? Loa_Used_County { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_used_zip\"")]
        public string Loa_Used_Zip { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_first_500_calcap\"")]
        public string Abs_Loa_Loans_Loa_First_500_Calcap { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_secured\"")]
        public string Abs_Loa_Loans_Loa_Secured { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_loan_list\"")]
        public string Loa_Calcap_Loan_List { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_contrib_name\"")]
        public string Loa_Contrib_Name { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_delivery_method\"")]
        public string Abs_Loa_Loans_Loa_Delivery_Method { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_loan_num_prior\"")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num_Prior { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_int_rate_mod\"")]
        public string Abs_Loa_Loans_Loa_Int_Rate_Mod { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_independent_cntr\"")]
        public decimal? Loa_Independent_Cntr { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_naics_code\"")]
        public string Abs_Loa_Loans_Loa_Naics_Code { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_loan_num\"")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_app_rcvd_by\"")]
        public decimal? Abs_Loa_Loans_Loa_App_Rcvd_By { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Program_Type), AutoRetrieve = true)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_program\"")]
        public string Abs_Loa_Loans_Loa_Program { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_remain_bal\"")]
        public decimal? Abs_Loa_Loans_Loa_Remain_Bal { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_pct\"")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Pct { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_other_pgm_pct\"")]
        public decimal? Abs_Loa_Loans_Loa_Other_Pgm_Pct { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_guar_pgm_name\"")]
        public string Abs_Loa_Loans_Loa_Guar_Pgm_Name { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_gov_guar_pgm\"")]
        public string Abs_Loa_Loans_Loa_Gov_Guar_Pgm { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_vet_own\"")]
        public string Abs_Loa_Loans_Loa_Vet_Own { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_wom_own\"")]
        public string Abs_Loa_Loans_Loa_Wom_Own { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_min_own\"")]
        public string Abs_Loa_Loans_Loa_Min_Own { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_non_profit\"")]
        public string Abs_Loa_Loans_Loa_Non_Profit { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_bus_opnd_2years\"")]
        public string Abs_Loa_Loans_Loa_Bus_Opnd_2Years { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_jobs_retained\"")]
        public decimal? Abs_Loa_Loans_Loa_Jobs_Retained { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_jobs_created\"")]
        public decimal? Abs_Loa_Loans_Loa_Jobs_Created { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_officer_email\"")]
        public string Abs_Loa_Loans_Loa_Officer_Email { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Sev_Aff_Com), AutoRetrieve = true)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_sev_affect_com\"")]
        public string Abs_Loa_Loans_Loa_Sev_Affect_Com { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_num_ftes\"")]
        public decimal? Abs_Loa_Loans_Loa_Num_Ftes { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_avg_ann_rev_last_fy\"")]
        public decimal? Abs_Loa_Loans_Loa_Avg_Ann_Rev_Last_Fy { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_census_tract_num\"")]
        public string Abs_Loa_Loans_Loa_Census_Tract_Num { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_year_bus_incorp\"")]
        public decimal? Abs_Bor_Borrower_Bor_Year_Bus_Incorp { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_name_resp_person\"")]
        public string Abs_Bor_Borrower_Bor_Name_Resp_Person { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_title\"")]
        public string Abs_Bor_Borrower_Bor_Title { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_prop_type\"")]
        public string Loa_Prop_Type { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_mobile_home\"")]
        public string Abs_Loa_Loans_Loa_Mobile_Home { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_num_units\"")]
        public decimal? Loa_Num_Units { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_construct_year\"")]
        public decimal? Abs_Loa_Loans_Loa_Construct_Year { get; set; }

        [DwColumn("ABS_LOA_LOANS", "LOA_CSP_APPNUM")]
        public decimal? Abs_Loa_Loans_Loa_Csp_Appnum { get; set; }

        [DwColumn("[LOA_SEIS_APP_TYPE]")]
        public string Loa_Seis_App_Type { get; set; }

        [DwColumn("[LOA_SEIS_BUS_SEL]")]
        public string Loa_Seis_Bus_Sel { get; set; }

        [DwColumn("[LOA_SEIS_BLDG_CERT]")]
        public string Loa_Seis_Bldg_Cert { get; set; }

        [DwColumn("[LOA_SEIS_BLDG_RET]")]
        public string Loa_Seis_Bldg_Ret_1 { get; set; }

        [DwColumn("[LOA_SEIS_BLDG_RET]")]
        public string Loa_Seis_Bldg_Ret { get; set; }

        [DwColumn("[LOA_SEIS_QUAL_BLDG]")]
        public string Loa_Seis_Qual_Bldg { get; set; }

        [DwColumn("[LOA_SEIS_QUAL_BLDG_UNITS]")]
        public decimal? Loa_Seis_Qual_Bldg_Units { get; set; }

        [DwColumn("[LOA_SEIS_DESC_ELI_CST]")]
        public string Loa_Seis_Desc_Eli_Cst { get; set; }

        [DwColumn("[LOA_SEIS_OTH_SEIS]")]
        public string Loa_Seis_Oth_Seis { get; set; }

        [DwColumn("[LOA_SEIS_OTH_SEIS_AMT]")]
        public decimal? Loa_Seis_Oth_Seis_Amt { get; set; }

        [DwColumn("[LOA_SEIS_PUB_ENT]")]
        public string Loa_Seis_Pub_Ent { get; set; }

        [DwColumn("[LOA_SEIS_PUB_ENT_YES]")]
        public string Loa_Seis_Pub_Ent_Yes { get; set; }

        [DwColumn("[LOA_SEIS_END_COV]")]
        public string Loa_Seis_End_Cov { get; set; }

        [DwColumn("[LOA_LEA_ID]")]
        public decimal? Loa_Lea_Id { get; set; }

    }

}