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
    [DataWindow("d_abs_ssp_import", DwStyle.Default)]
    [Table("abs_loa_loans", Schema = "abs")]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"abs_len_lender\" \r\n "
                  +"RIGHT OUTER JOIN \"abs_loa_loans\" ON \"abs_len_lender\".\"len_id\" = \"abs_loa_loans\".\"loa_len_id\" \r\n "
                  +"RIGHT OUTER JOIN \"abs_bor_borrower\"  ON \"abs_bor_borrower\".\"bor_id\" = \"abs_loa_loans\".\"loa_bor_id\"")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Ssp_Import
    {
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_name\"")]
        public string Bor_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_city\"")]
        public string Bor_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_county\"")]
        public decimal? Bor_County { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_zip\"")]
        public string Bor_Zip { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_zip_4\"")]
        public string Bor_Zip_4 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_len_lender\"", "\"len_name\"")]
        public string Len_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_len_lender\"", "\"len_lendor_number\"")]
        public string Len_Lendor_Number { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_nbr_empoyees\"")]
        public decimal? Loa_Nbr_Empoyees { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_nbr_jobs\"")]
        public decimal? Loa_Nbr_Jobs { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_annual_rev\"")]
        public decimal? Loa_Annual_Rev { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_sev_affected\"")]
        public string Loa_Sev_Affected { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_min_or_women\"")]
        public string Loa_Min_Or_Women { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_purpose\"")]
        public string Loa_Purpose { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_lender_loan_nbr\"")]
        public string Loa_Lender_Loan_Nbr { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_amount_total\"")]
        public decimal? Loa_Amount_Total { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_lender_loan_dt\"", TypeName = "datetime2")]
        public DateTime? Loa_Lender_Loan_Dt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_int_rate_type\"")]
        public string Loa_Int_Rate_Type { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_maturity_dt\"", TypeName = "datetime2")]
        public DateTime? Loa_Maturity_Dt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_refinancing\"")]
        public string Loa_Refinancing { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_premium_pd\"")]
        public decimal? Loa_Calcap_Premium_Pd { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_independnt_cntr_dt\"", TypeName = "datetime2")]
        public DateTime? Loa_Independnt_Cntr_Dt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_interest_rate\"")]
        public decimal? Loa_Interest_Rate { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_increase\"")]
        public decimal? Loa_Increase { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_premium_amt\"")]
        public decimal? Loa_Calcap_Premium_Amt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_premium_amnt\"")]
        public decimal? Loa_Premium_Amnt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_type_of_business\"")]
        public string Bor_Type_Of_Business { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_len_id\"")]
        public decimal? Loa_Len_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_bor_id\"")]
        public decimal? Loa_Bor_Id { get; set; }

        [Key]
        [DwColumn("\"abs_loa_loans\"", "\"loa_id\"")]
        public decimal? Loa_Id { get; set; }

        [DwColumn("\"abs_loa_loans\"", "\"loa_app_rcvd_dt\"", TypeName = "datetime2")]
        public DateTime? Loa_App_Rcvd_Dt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_officer_name\"")]
        public string Loa_Officer_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_officer_phone\"")]
        public string Loa_Officer_Phone { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_loan_type\"")]
        public string Loa_Loan_Type { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_dba\"")]
        public string Bor_Dba { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_address\"")]
        public string Bor_Address { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_phone\"")]
        public string Bor_Phone { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_fax\"")]
        public string Bor_Fax { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_sac_contact_info\"")]
        public string Loa_Sac_Contact_Info { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_used_at_address\"")]
        public string Loa_Used_At_Address { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_used_address\"")]
        public string Loa_Used_Address { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_used_city\"")]
        public string Loa_Used_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_used_county\"")]
        public decimal? Loa_Used_County { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_used_zip\"")]
        public string Loa_Used_Zip { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_first_500_calcap\"")]
        public string Loa_First_500_Calcap { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_secured\"")]
        public string Loa_Secured { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_loan_list\"")]
        public string Loa_Calcap_Loan_List { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_contrib_name\"")]
        public string Loa_Contrib_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_delivery_method\"")]
        public string Loa_Delivery_Method { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_loan_num_prior\"")]
        public string Loa_Calcap_Loan_Num_Prior { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_int_rate_mod\"")]
        public string Loa_Int_Rate_Mod { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_independent_cntr\"")]
        public decimal? Loa_Independent_Cntr { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_naics_code\"")]
        public string Loa_Naics_Code { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_loan_num\"")]
        public string Loa_Calcap_Loan_Num { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_app_rcvd_by\"")]
        public decimal? Loa_App_Rcvd_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_program\"")]
        public string Loa_Program { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_remain_bal\"")]
        public decimal? Loa_Remain_Bal { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_pct\"")]
        public decimal? Loa_Calcap_Pct { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_other_pgm_pct\"")]
        public decimal? Loa_Other_Pgm_Pct { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_guar_pgm_name\"")]
        public string Loa_Guar_Pgm_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_gov_guar_pgm\"")]
        public string Loa_Gov_Guar_Pgm { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_vet_own\"")]
        public string Loa_Vet_Own { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_wom_own\"")]
        public string Loa_Wom_Own { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_min_own\"")]
        public string Loa_Min_Own { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_non_profit\"")]
        public string Loa_Non_Profit { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_bus_opnd_2years\"")]
        public string Loa_Bus_Opnd_2Years { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_jobs_retained\"")]
        public decimal? Loa_Jobs_Retained { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_jobs_created\"")]
        public decimal? Loa_Jobs_Created { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_officer_email\"")]
        public string Loa_Officer_Email { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_sev_affect_com\"")]
        public string Loa_Sev_Affect_Com { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_num_ftes\"")]
        public decimal? Loa_Num_Ftes { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_avg_ann_rev_last_fy\"")]
        public decimal? Loa_Avg_Ann_Rev_Last_Fy { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_census_tract_num\"")]
        public string Loa_Census_Tract_Num { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_year_bus_incorp\"")]
        public decimal? Bor_Year_Bus_Incorp { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_name_resp_person\"")]
        public string Bor_Name_Resp_Person { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_bor_borrower\"", "\"bor_title\"")]
        public string Bor_Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_prop_type\"")]
        public string Loa_Prop_Type { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_mobile_home\"")]
        public string Loa_Mobile_Home { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_num_units\"")]
        public decimal? Loa_Num_Units { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_construct_year\"")]
        public decimal? Loa_Construct_Year { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ABS_LOA_LOANS", "LOA_CSP_APPNUM")]
        public decimal? Loa_Csp_Appnum { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_APP_TYPE]")]
        public string Loa_Seis_App_Type { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_BUS_SEL]")]
        public string Loa_Seis_Bus_Sel { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_BLDG_CERT]")]
        public string Loa_Seis_Bldg_Cert { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_BLDG_RET]")]
        public string Loa_Seis_Bldg_Ret_1 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_BLDG_RET]")]
        public string Loa_Seis_Bldg_Ret { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_QUAL_BLDG]")]
        public string Loa_Seis_Qual_Bldg { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_QUAL_BLDG_UNITS]")]
        public decimal? Loa_Seis_Qual_Bldg_Units { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_DESC_ELI_CST]")]
        public string Loa_Seis_Desc_Eli_Cst { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_OTH_SEIS]")]
        public string Loa_Seis_Oth_Seis { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_OTH_SEIS_AMT]")]
        public decimal? Loa_Seis_Oth_Seis_Amt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_PUB_ENT]")]
        public string Loa_Seis_Pub_Ent { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_PUB_ENT_YES]")]
        public string Loa_Seis_Pub_Ent_Yes { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_SEIS_END_COV]")]
        public string Loa_Seis_End_Cov { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[LOA_LEA_ID]")]
        public decimal? Loa_Lea_Id { get; set; }

    }

}