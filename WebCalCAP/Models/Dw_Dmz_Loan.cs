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
    [DataWindow("dw_dmz_loan", DwStyle.Default)]
    [Table("ccap_lea_loan_app")]
    #region DwSelectAttribute  
    [DwSelect("/* Formatted on 5/16/2019 2:30:09 PM (QP5 v5.269.14213.34746) */ \r\n "
                  +"SELECT lea_lender_id, \r\n "
                  +"lea_lender, \r\n "
                  +"lea_lender_name, \r\n "
                  +"lea_lender_phone, \r\n "
                  +"lea_lender_email, \r\n "
                  +"lea_bor_name, \r\n "
                  +"lea_bor_dba, \r\n "
                  +"lea_bor_address, \r\n "
                  +"lea_bor_city, \r\n "
                  +"lea_bor_county, \r\n "
                  +"lea_bor_zip, \r\n "
                  +"lea_bor_type_activities, \r\n "
                  +"lea_bor_year_inc, \r\n "
                  +"lea_bor_annu_rev, \r\n "
                  +"lea_bor_annu_rev3, \r\n "
                  +"lea_bor_num_emp, \r\n "
                  +"lea_bor_full_time_equiv, \r\n "
                  +"lea_bor_jobs_created, \r\n "
                  +"lea_bor_jobs_retained, \r\n "
                  +"lea_bor_bus_loc_sac, \r\n "
                  +"lea_bor_bus_loc_sac_reason, \r\n "
                  +"lea_bor_monies, \r\n "
                  +"lea_bor_monies_address, \r\n "
                  +"lea_bor_monies_city, \r\n "
                  +"lea_bor_monies_county, \r\n "
                  +"lea_bor_monies_zip, \r\n "
                  +"lea_bor_naics, \r\n "
                  +"lea_bor_census_tract, \r\n "
                  +"lea_bor_purpose_loan, \r\n "
                  +"lea_bor_minority_owned, \r\n "
                  +"lea_bor_woman_owned, \r\n "
                  +"lea_bor_veteran_owned, \r\n "
                  +"lea_bor_bus_loc_sac_other, \r\n "
                  +"lea_loan_gov_gurantee, \r\n "
                  +"lea_loan_gov_gurantee_yes, \r\n "
                  +"lea_loan_percent_enrolled, \r\n "
                  +"lea_loan_percent_calcap, \r\n "
                  +"lea_loan_number, \r\n "
                  +"lea_loan_typeof, \r\n "
                  +"lea_loan_total_loan, \r\n "
                  +"lea_loan_amt_calcap, \r\n "
                  +"lea_loan_date_loan, \r\n "
                  +"lea_loan_maturity, \r\n "
                  +"lea_loan_int_rate, \r\n "
                  +"lea_loan_intrt_fixvar, \r\n "
                  +"lea_loan_secured, \r\n "
                  +"lea_loan_refinance_prior, \r\n "
                  +"lea_loan_calcap_num, \r\n "
                  +"lea_loan_remaining_ref, \r\n "
                  +"lea_loan_amt_increase, \r\n "
                  +"lea_loan_borr_prem, \r\n "
                  +"lea_loan_borr_prem_perc, \r\n "
                  +"lea_loan_lend_prem, \r\n "
                  +"lea_loan_lend_prem_perc, \r\n "
                  +"lea_loan_ind_con, \r\n "
                  +"lea_loan_ind_con_name, \r\n "
                  +"lea_creation_date, \r\n "
                  +"lea_created_by, \r\n "
                  +"lea_last_update_date, \r\n "
                  +"lea_last_updated_by, \r\n "
                  +"lea_id, \r\n "
                  +"lea_submission_date, \r\n "
                  +"lea_transmittal_date, \r\n "
                  +"lea_status, \r\n "
                  +"lea_pur_loan_oth_app, \r\n "
                  +"lea_bor_title, \r\n "
                  +"lea_bor_name_resp, \r\n "
                  +"lea_bor_area_prop, \r\n "
                  +"lea_loan_state_fund, \r\n "
                  +"len_id, \r\n "
                  +"len_name, \r\n "
                  +"len_officer_name, \r\n "
                  +"len_officer_phone, \r\n "
                  +"len_officer_email, \r\n "
                  +"LEA_CSP_NUM, \r\n "
                  +"LEA_APP_ORI_CS_APP_AMT, \r\n "
                  +"LEA_CCAP_LOAN_NUM, \r\n "
                  +"LEA_APP_TOT_CS_APP_AMT, \r\n "
                  +"LEA_LOAN_STATUS \r\n "
                  +"FROM ccap_lea_loan_app, \r\n "
                  +"ccap_len_lender \r\n "
                  +"WHERE lea_lender_id = len_id AND LEA_ID = :a_f_lenderId")]
    #endregion
    [DwParameter("a_f_lenderid", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dw_Dmz_Loan
    {
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_lender_id")]
        public decimal? Lea_Lender_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_lender")]
        public string Lea_Lender { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_lender_name")]
        public string Lea_Lender_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_lender_phone")]
        public string Lea_Lender_Phone { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_lender_email")]
        public string Lea_Lender_Email { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_name")]
        public string Lea_Bor_Name { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_dba")]
        public string Lea_Bor_Dba { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_address")]
        public string Lea_Bor_Address { get; set; }

        [StringLength(40)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_city")]
        public string Lea_Bor_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Ccap_Lov_Cd", "Ccap_Lov_Description", typeof(Dddw_Counties_Web), AutoRetrieve = true)]
        [DwColumn("lea_bor_county")]
        public string Lea_Bor_County { get; set; }

        [StringLength(10)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_zip")]
        public string Lea_Bor_Zip { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_type_activities")]
        public string Lea_Bor_Type_Activities { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_year_inc")]
        public decimal? Lea_Bor_Year_Inc { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_annu_rev")]
        public decimal? Lea_Bor_Annu_Rev { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_annu_rev3")]
        public decimal? Lea_Bor_Annu_Rev3 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_num_emp")]
        public decimal? Lea_Bor_Num_Emp { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_full_time_equiv")]
        public decimal? Lea_Bor_Full_Time_Equiv { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_jobs_created")]
        public decimal? Lea_Bor_Jobs_Created { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_jobs_retained")]
        public decimal? Lea_Bor_Jobs_Retained { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_bus_loc_sac")]
        public string Lea_Bor_Bus_Loc_Sac { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_bus_loc_sac_reason")]
        public string Lea_Bor_Bus_Loc_Sac_Reason { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_monies")]
        public string Lea_Bor_Monies { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_monies_address")]
        public string Lea_Bor_Monies_Address { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_monies_city")]
        public string Lea_Bor_Monies_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_monies_county")]
        public string Lea_Bor_Monies_County { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_monies_zip")]
        public string Lea_Bor_Monies_Zip { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_naics")]
        public string Lea_Bor_Naics { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_census_tract")]
        public string Lea_Bor_Census_Tract { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_purpose_loan")]
        public string Lea_Bor_Purpose_Loan { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_minority_owned")]
        public string Lea_Bor_Minority_Owned { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_woman_owned")]
        public string Lea_Bor_Woman_Owned { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_veteran_owned")]
        public string Lea_Bor_Veteran_Owned { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_bus_loc_sac_other")]
        public string Lea_Bor_Bus_Loc_Sac_Other { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_gov_gurantee")]
        public string Lea_Loan_Gov_Gurantee { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_gov_gurantee_yes")]
        public string Lea_Loan_Gov_Gurantee_Yes { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_percent_enrolled")]
        public decimal? Lea_Loan_Percent_Enrolled { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_percent_calcap")]
        public decimal? Lea_Loan_Percent_Calcap { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_number")]
        public string Lea_Loan_Number { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_typeof")]
        public string Lea_Loan_Typeof { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_total_loan")]
        public decimal? Lea_Loan_Total_Loan { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_amt_calcap")]
        public decimal? Lea_Loan_Amt_Calcap { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_date_loan", TypeName = "datetime2")]
        public DateTime? Lea_Loan_Date_Loan { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_maturity", TypeName = "datetime2")]
        public DateTime? Lea_Loan_Maturity { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_int_rate")]
        public decimal? Lea_Loan_Int_Rate { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_intrt_fixvar")]
        public string Lea_Loan_Intrt_Fixvar { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_secured")]
        public string Lea_Loan_Secured { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_refinance_prior")]
        public string Lea_Loan_Refinance_Prior { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_calcap_num")]
        public string Lea_Loan_Calcap_Num { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_remaining_ref")]
        public decimal? Lea_Loan_Remaining_Ref { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_amt_increase")]
        public decimal? Lea_Loan_Amt_Increase { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_borr_prem")]
        public decimal? Lea_Loan_Borr_Prem { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_borr_prem_perc")]
        public decimal? Lea_Loan_Borr_Prem_Perc { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_lend_prem")]
        public decimal? Lea_Loan_Lend_Prem { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_lend_prem_perc")]
        public decimal? Lea_Loan_Lend_Prem_Perc { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_ind_con")]
        public string Lea_Loan_Ind_Con { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_ind_con_name")]
        public string Lea_Loan_Ind_Con_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_creation_date", TypeName = "datetime2")]
        public DateTime? Lea_Creation_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_created_by")]
        public string Lea_Created_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_last_update_date", TypeName = "datetime2")]
        public DateTime? Lea_Last_Update_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_last_updated_by")]
        public string Lea_Last_Updated_By { get; set; }

        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_id")]
        public decimal Lea_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_submission_date", TypeName = "datetime2")]
        public DateTime? Lea_Submission_Date { get; set; }

        [DwColumn("lea_transmittal_date", TypeName = "datetime2")]
        public DateTime? Lea_Transmittal_Date { get; set; }

        [DwColumn("lea_status")]
        public string Lea_Status { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_pur_loan_oth_app")]
        public string Lea_Pur_Loan_Oth_App { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_title")]
        public string Lea_Bor_Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_name_resp")]
        public string Lea_Bor_Name_Resp { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_bor_area_prop")]
        public decimal? Lea_Bor_Area_Prop { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("lea_loan_state_fund")]
        public decimal? Lea_Loan_State_Fund { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("len_id")]
        public decimal Ccap_Len_Lender_Len_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("len_name")]
        public string Ccap_Len_Lender_Len_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("len_officer_name")]
        public string Ccap_Len_Lender_Len_Officer_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("len_officer_phone")]
        public string Ccap_Len_Lender_Len_Officer_Phone { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("len_officer_email")]
        public string Ccap_Len_Lender_Len_Officer_Email { get; set; }

        [DwColumn("LEA_CSP_NUM")]
        public string Lea_Csp_Num { get; set; }

        [DwColumn("LEA_APP_ORI_CS_APP_AMT")]
        public decimal? Lea_App_Ori_Cs_App_Amt { get; set; }

        [DwColumn("LEA_CCAP_LOAN_NUM")]
        public string Lea_Ccap_Loan_Num { get; set; }

        [DwColumn("LEA_APP_TOT_CS_APP_AMT")]
        public decimal? Lea_App_Tot_Cs_App_Amt { get; set; }

        [DwColumn("LEA_LOAN_STATUS")]
        public string Lea_Loan_Status { get; set; }

    }

}