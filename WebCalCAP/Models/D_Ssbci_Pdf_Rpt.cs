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
    [DataWindow("d_ssbci_pdf_rpt", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ccap_lea_loan_app\" \r\n "
                  +"left join CCAP_LEN_LENDER on CCAP_LEN_LENDER.LEN_ID = LEA_LENDER_ID \r\n "
                  +"WHERE ( (\"ccap_lea_loan_app\".\"lea_id\" = :a_id ) )")]
    #endregion
    [DwParameter("a_id", typeof(double?))]
    public class D_Ssbci_Pdf_Rpt
    {
        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_id\"")]
        public decimal Ccap_Lea_Loan_App_Lea_Id { get; set; }

        [DwColumn("LEN_ID")]
        public decimal? Len_Id { get; set; }

        [DwColumn("[LEN_NAME]")]
        public string Len_Name { get; set; }

        [DwColumn("[LEN_OFFICER_NAME]")]
        public string Len_Officer_Name { get; set; }

        [DwColumn("[LEN_OFFICER_PHONE]")]
        public string Len_Officer_Phone { get; set; }

        [DwColumn("[LEN_OFFICER_EMAIL]")]
        public string Len_Officer_Email { get; set; }

        [DwColumn("LEN_LENDOR_NUMBER")]
        public string Len_Lendor_Number { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_name\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_dba\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Dba { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_address\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Address { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_city\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_City { get; set; }

        [DwChild("Ccap_Lov_Cd", "Ccap_Lov_Description", typeof(Dddw_Counties_Web), AutoRetrieve = true)]
        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_county\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_County { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_zip\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Zip { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_type_activities\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Type_Activities { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_year_inc\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Bor_Year_Inc { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_annu_rev\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Bor_Annu_Rev { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_annu_rev3\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Bor_Annu_Rev3 { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_num_emp\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Bor_Num_Emp { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_full_time_equiv\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Bor_Full_Time_Equiv { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_jobs_created\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Bor_Jobs_Created { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_jobs_retained\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Bor_Jobs_Retained { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_bus_loc_sac\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Bus_Loc_Sac { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_bus_loc_sac_reason\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Bus_Loc_Sac_Reason { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_monies\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Monies { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_monies_address\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Monies_Address { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_monies_city\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Monies_City { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_monies_county\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Monies_County { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_monies_zip\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Monies_Zip { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_naics\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Naics { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_census_tract\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Census_Tract { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_purpose_loan\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Purpose_Loan { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_minority_owned\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Minority_Owned { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_woman_owned\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Woman_Owned { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_veteran_owned\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Veteran_Owned { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_bus_loc_sac_other\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Bus_Loc_Sac_Other { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_gov_gurantee\"")]
        public string Ccap_Lea_Loan_App_Lea_Loan_Gov_Gurantee { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_gov_gurantee_yes\"")]
        public string Ccap_Lea_Loan_App_Lea_Loan_Gov_Gurantee_Yes { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_percent_enrolled\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Percent_Enrolled { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_percent_calcap\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Percent_Calcap { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_number\"")]
        public string Ccap_Lea_Loan_App_Lea_Loan_Number { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_typeof\"")]
        public string Ccap_Lea_Loan_App_Lea_Loan_Typeof { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_total_loan\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Total_Loan { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_amt_calcap\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Amt_Calcap { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_date_loan\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Loan_Date_Loan { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_maturity\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Loan_Maturity { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_int_rate\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Int_Rate { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_intrt_fixvar\"")]
        public string Ccap_Lea_Loan_App_Lea_Loan_Intrt_Fixvar { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_secured\"")]
        public string Ccap_Lea_Loan_App_Lea_Loan_Secured { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_refinance_prior\"")]
        public string Ccap_Lea_Loan_App_Lea_Loan_Refinance_Prior { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_calcap_num\"")]
        public string Ccap_Le_Loan_App_Lea_Loan_Calcap_Num { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_remaining_ref\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Remaining_Ref { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_amt_increase\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Amt_Increase { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_borr_prem\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Borr_Prem { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_borr_prem_perc\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Borr_Prem_Perc { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_lend_prem\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Lend_Prem { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_lend_prem_perc\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_Lend_Prem_Perc { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_ind_con\"")]
        public string Ccap_Lea_Loan_App_Lea_Loan_Ind_Con { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_ind_con_name\"")]
        public string Ccap_Lea_Loan_App_Lea_Loan_Ind_Con_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_creation_date\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Creation_Date { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_created_by\"")]
        public string Ccap_Lea_Loan_App_Lea_Created_By { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_last_update_date\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Last_Update_Date { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_last_updated_by\"")]
        public string Ccap_Lea_Loan_App_Lea_Last_Updated_By { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_submission_date\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Submission_Date { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_transmittal_date\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Transmittal_Date { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_status\"")]
        public string Ccap_Lea_Loan_App_Lea_Status { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_pur_loan_oth_app\"")]
        public string Ccap_Lea_Loan_App_Lea_Pur_Loan_Oth_App { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_title\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Title { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_name_resp\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Name_Resp { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_area_prop\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Bor_Area_Prop { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_loan_state_fund\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_State_Fund { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_len_cert_form\"")]
        public string Ccap_Lea_Loan_App_Lea_Len_Cert_Form { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_cert_form\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Cert_Form { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_risk_assess_form\"")]
        public string Ccap_Lea_Loan_App_Lea_Risk_Assess_Form { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_agree_form\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Agree_Form { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_mult_proj_form\"")]
        public string Ccap_Lea_Loan_App_Lea_Mult_Proj_Form { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_purpose_loan_exp\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Purpose_Loan_Exp { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_extra_attachments\"")]
        public string Ccap_Lea_Loan_App_Lea_Extra_Attachments { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"CalCAP Small Business Page \\\" + Page()")]
        public object Compute_1 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwReport(typeof(D_Arbweb_Header))]
        public IList<D_Arbweb_Header> Dw_1 { get; set; }

    }

}