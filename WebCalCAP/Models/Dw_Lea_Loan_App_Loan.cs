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
    [DataWindow("dw_lea_loan_app_loan", DwStyle.Default)]
    [Table("CCAP_LEA_LOAN_APP")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"CCAP_LEA_LOAN_APP\", \r\n "
                  +"\"CCAP_LEN_LENDER\" \r\n "
                  +"WHERE ( \"CCAP_LEA_LOAN_APP\".\"LEA_LENDER_ID\" = \"CCAP_LEN_LENDER\".\"LEN_ID\" ) and \r\n "
                  +"( ( \"CCAP_LEA_LOAN_APP\".\"LEA_ID\" = :a_f_lenderId ) )")]
    #endregion
    [DwParameter("a_f_lenderId", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dw_Lea_Loan_App_Loan
    {
        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LENDER_ID\"")]
        public decimal? Lea_Lender_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LENDER\"")]
        public string Lea_Lender { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LENDER_NAME\"")]
        public string Lea_Lender_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LENDER_PHONE\"")]
        public string Lea_Lender_Phone { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LENDER_EMAIL\"")]
        public string Lea_Lender_Email { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_NAME\"")]
        public string Lea_Bor_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_DBA\"")]
        public string Lea_Bor_Dba { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_ADDRESS\"")]
        public string Lea_Bor_Address { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_CITY\"")]
        public string Lea_Bor_City { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_COUNTY\"")]
        public string Lea_Bor_County { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_ZIP\"")]
        public string Lea_Bor_Zip { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_TYPE_ACTIVITIES\"")]
        public string Lea_Bor_Type_Activities { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_YEAR_INC\"")]
        public decimal? Lea_Bor_Year_Inc { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_ANNU_REV\"")]
        public decimal? Lea_Bor_Annu_Rev { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_ANNU_REV3\"")]
        public decimal? Lea_Bor_Annu_Rev3 { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_NUM_EMP\"")]
        public decimal? Lea_Bor_Num_Emp { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_FULL_TIME_EQUIV\"")]
        public decimal? Lea_Bor_Full_Time_Equiv { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_JOBS_CREATED\"")]
        public decimal? Lea_Bor_Jobs_Created { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_JOBS_RETAINED\"")]
        public decimal? Lea_Bor_Jobs_Retained { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_BUS_LOC_SAC\"")]
        public string Lea_Bor_Bus_Loc_Sac { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_BUS_LOC_SAC_REASON\"")]
        public string Lea_Bor_Bus_Loc_Sac_Reason { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_MONIES\"")]
        public string Lea_Bor_Monies { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_MONIES_ADDRESS\"")]
        public string Lea_Bor_Monies_Address { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_MONIES_CITY\"")]
        public string Lea_Bor_Monies_City { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_MONIES_COUNTY\"")]
        public string Lea_Bor_Monies_County { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_MONIES_ZIP\"")]
        public string Lea_Bor_Monies_Zip { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_NAICS\"")]
        public string Lea_Bor_Naics { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_CENSUS_TRACT\"")]
        public string Lea_Bor_Census_Tract { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_PURPOSE_LOAN\"")]
        public string Lea_Bor_Purpose_Loan { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_MINORITY_OWNED\"")]
        public string Lea_Bor_Minority_Owned { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_WOMAN_OWNED\"")]
        public string Lea_Bor_Woman_Owned { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_VETERAN_OWNED\"")]
        public string Lea_Bor_Veteran_Owned { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_BUS_LOC_SAC_OTHER\"")]
        public string Lea_Bor_Bus_Loc_Sac_Other { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_GOV_GURANTEE\"")]
        public string Lea_Loan_Gov_Gurantee { get; set; }

        [ConcurrencyCheck]
        [StringLength(40)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_GOV_GURANTEE_YES\"")]
        public string Lea_Loan_Gov_Gurantee_Yes { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_PERCENT_ENROLLED\"")]
        public decimal? Lea_Loan_Percent_Enrolled { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_PERCENT_CALCAP\"")]
        public decimal? Lea_Loan_Percent_Calcap { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_NUMBER\"")]
        public string Lea_Loan_Number { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_TYPEOF\"")]
        public string Lea_Loan_Typeof { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_TOTAL_LOAN\"")]
        public decimal? Lea_Loan_Total_Loan { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_AMT_CALCAP\"")]
        public decimal? Lea_Loan_Amt_Calcap { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_DATE_LOAN\"", TypeName = "datetime2")]
        public DateTime? Lea_Loan_Date_Loan { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_MATURITY\"", TypeName = "datetime2")]
        public DateTime? Lea_Loan_Maturity { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_INT_RATE\"")]
        public decimal? Lea_Loan_Int_Rate { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_INTRT_FIXVAR\"")]
        public string Lea_Loan_Intrt_Fixvar { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_SECURED\"")]
        public string Lea_Loan_Secured { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_REFINANCE_PRIOR\"")]
        public string Lea_Loan_Refinance_Prior { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_CALCAP_NUM\"")]
        public string Lea_Loan_Calcap_Num { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_REMAINING_REF\"")]
        public decimal? Lea_Loan_Remaining_Ref { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_AMT_INCREASE\"")]
        public decimal? Lea_Loan_Amt_Increase { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_BORR_PREM\"")]
        public decimal? Lea_Loan_Borr_Prem { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_BORR_PREM_PERC\"")]
        public decimal? Lea_Loan_Borr_Prem_Perc { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_LEND_PREM\"")]
        public decimal? Lea_Loan_Lend_Prem { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_LEND_PREM_PERC\"")]
        public decimal? Lea_Loan_Lend_Prem_Perc { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_IND_CON\"")]
        public string Lea_Loan_Ind_Con { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_IND_CON_NAME\"")]
        public string Lea_Loan_Ind_Con_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_CREATION_DATE\"", TypeName = "datetime2")]
        public DateTime? Lea_Creation_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_CREATED_BY\"")]
        public string Lea_Created_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LAST_UPDATE_DATE\"", TypeName = "datetime2")]
        public DateTime? Lea_Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LAST_UPDATED_BY\"")]
        public string Lea_Last_Updated_By { get; set; }

        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_ID\"")]
        public decimal Lea_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_SUBMISSION_DATE\"", TypeName = "datetime2")]
        public DateTime? Lea_Submission_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_TRANSMITTAL_DATE\"", TypeName = "datetime2")]
        public DateTime? Lea_Transmittal_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_STATUS\"")]
        public string Lea_Status { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_PUR_LOAN_OTH_APP\"")]
        public string Lea_Pur_Loan_Oth_App { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_TITLE\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_NAME_RESP\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Name_Resp { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_AREA_PROP\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Bor_Area_Prop { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LOAN_STATE_FUND\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Loan_State_Fund { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEN_LENDER\"", "\"LEN_ID\"")]
        public decimal Ccap_Len_Lender_Len_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEN_LENDER\"", "\"LEN_NAME\"")]
        public string Ccap_Len_Lender_Len_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEN_LENDER\"", "\"LEN_OFFICER_NAME\"")]
        public string Ccap_Len_Lender_Len_Officer_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEN_LENDER\"", "\"LEN_OFFICER_PHONE\"")]
        public string Ccap_Len_Lender_Len_Officer_Phone { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEN_LENDER\"", "\"LEN_OFFICER_EMAIL\"")]
        public string Ccap_Len_Lender_Len_Officer_Email { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_LEN_LENDER\"", "\"LEN_LENDOR_NUMBER\"")]
        public string Len_Lendor_Number { get; set; }

    }

}