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
    [DataWindow("d_calcap_lea_loan_import", DwStyle.Grid)]
    [Table("CCAP_LEA_LOAN_APP", Schema = "CALCAPWEB")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT(TABLE(NAME=\"CALCAPWEB.CCAP_LEA_LOAN_APP\") @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Calcap_Lea_Loan_Import
    {
        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LENDER_ID")]
        public decimal? Lea_Lender_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LENDER")]
        public string Lea_Lender { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LENDER_NAME")]
        public string Lea_Lender_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(12)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LENDER_PHONE")]
        public string Lea_Lender_Phone { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LENDER_EMAIL")]
        public string Lea_Lender_Email { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_NAME")]
        public string Lea_Bor_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_DBA")]
        public string Lea_Bor_Dba { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_ADDRESS")]
        public string Lea_Bor_Address { get; set; }

        [ConcurrencyCheck]
        [StringLength(40)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_CITY")]
        public string Lea_Bor_City { get; set; }

        [ConcurrencyCheck]
        [StringLength(30)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_COUNTY")]
        public string Lea_Bor_County { get; set; }

        [ConcurrencyCheck]
        [StringLength(10)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_ZIP")]
        public string Lea_Bor_Zip { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_TYPE_ACTIVITIES")]
        public string Lea_Bor_Type_Activities { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_YEAR_INC")]
        public decimal? Lea_Bor_Year_Inc { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_ANNU_REV")]
        public decimal? Lea_Bor_Annu_Rev { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_ANNU_REV3")]
        public decimal? Lea_Bor_Annu_Rev3 { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_NUM_EMP")]
        public decimal? Lea_Bor_Num_Emp { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_FULL_TIME_EQUIV")]
        public decimal? Lea_Bor_Full_Time_Equiv { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_JOBS_CREATED")]
        public decimal? Lea_Bor_Jobs_Created { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_JOBS_RETAINED")]
        public decimal? Lea_Bor_Jobs_Retained { get; set; }

        [ConcurrencyCheck]
        [StringLength(2)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_BUS_LOC_SAC")]
        public string Lea_Bor_Bus_Loc_Sac { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_BUS_LOC_SAC_REASON")]
        public string Lea_Bor_Bus_Loc_Sac_Reason { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_MONIES")]
        public string Lea_Bor_Monies { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_MONIES_ADDRESS")]
        public string Lea_Bor_Monies_Address { get; set; }

        [ConcurrencyCheck]
        [StringLength(40)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_MONIES_CITY")]
        public string Lea_Bor_Monies_City { get; set; }

        [ConcurrencyCheck]
        [StringLength(30)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_MONIES_COUNTY")]
        public string Lea_Bor_Monies_County { get; set; }

        [ConcurrencyCheck]
        [StringLength(10)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_MONIES_ZIP")]
        public string Lea_Bor_Monies_Zip { get; set; }

        [ConcurrencyCheck]
        [StringLength(40)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_NAICS")]
        public string Lea_Bor_Naics { get; set; }

        [ConcurrencyCheck]
        [StringLength(19)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_CENSUS_TRACT")]
        public string Lea_Bor_Census_Tract { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_PURPOSE_LOAN")]
        public string Lea_Bor_Purpose_Loan { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_MINORITY_OWNED")]
        public string Lea_Bor_Minority_Owned { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_WOMAN_OWNED")]
        public string Lea_Bor_Woman_Owned { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_VETERAN_OWNED")]
        public string Lea_Bor_Veteran_Owned { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_BUS_LOC_SAC_OTHER")]
        public string Lea_Bor_Bus_Loc_Sac_Other { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_GOV_GURANTEE")]
        public string Lea_Loan_Gov_Gurantee { get; set; }

        [ConcurrencyCheck]
        [StringLength(40)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_GOV_GURANTEE_YES")]
        public string Lea_Loan_Gov_Gurantee_Yes { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0))")]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_PERCENT_ENROLLED")]
        public decimal? Lea_Loan_Percent_Enrolled { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_PERCENT_CALCAP")]
        public decimal? Lea_Loan_Percent_Calcap { get; set; }

        [ConcurrencyCheck]
        [StringLength(100)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_NUMBER")]
        public string Lea_Loan_Number { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_TYPEOF")]
        public string Lea_Loan_Typeof { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_TOTAL_LOAN")]
        public decimal? Lea_Loan_Total_Loan { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_AMT_CALCAP")]
        public decimal? Lea_Loan_Amt_Calcap { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_DATE_LOAN", TypeName = "datetime2")]
        public DateTime? Lea_Loan_Date_Loan { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_MATURITY", TypeName = "datetime2")]
        public DateTime? Lea_Loan_Maturity { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_INT_RATE")]
        public decimal? Lea_Loan_Int_Rate { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_INTRT_FIXVAR")]
        public string Lea_Loan_Intrt_Fixvar { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_SECURED")]
        public string Lea_Loan_Secured { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_REFINANCE_PRIOR")]
        public string Lea_Loan_Refinance_Prior { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_CALCAP_NUM")]
        public string Lea_Loan_Calcap_Num { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_REMAINING_REF")]
        public decimal? Lea_Loan_Remaining_Ref { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_AMT_INCREASE")]
        public decimal? Lea_Loan_Amt_Increase { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_BORR_PREM")]
        public decimal? Lea_Loan_Borr_Prem { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_BORR_PREM_PERC")]
        public decimal? Lea_Loan_Borr_Prem_Perc { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_LEND_PREM")]
        public decimal? Lea_Loan_Lend_Prem { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_LEND_PREM_PERC")]
        public decimal? Lea_Loan_Lend_Prem_Perc { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_IND_CON")]
        public string Lea_Loan_Ind_Con { get; set; }

        [ConcurrencyCheck]
        [StringLength(60)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_IND_CON_NAME")]
        public string Lea_Loan_Ind_Con_Name { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_CREATION_DATE", TypeName = "datetime2")]
        public DateTime? Lea_Creation_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [SqlDefaultValue("(user_name())")]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_CREATED_BY")]
        public string Lea_Created_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LAST_UPDATE_DATE", TypeName = "datetime2")]
        public DateTime? Lea_Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [SqlDefaultValue("(user_name())")]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LAST_UPDATED_BY")]
        public string Lea_Last_Updated_By { get; set; }

        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [CALCAPWEB].[CALCAPWEB_LEA_SEQ])")]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_ID")]
        public decimal Lea_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_SUBMISSION_DATE", TypeName = "datetime2")]
        public DateTime? Lea_Submission_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_TRANSMITTAL_DATE", TypeName = "datetime2")]
        public DateTime? Lea_Transmittal_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [SqlDefaultValue("('OPEN')")]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_STATUS")]
        public string Lea_Status { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_PUR_LOAN_OTH_APP")]
        public string Lea_Pur_Loan_Oth_App { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_TITLE")]
        public string Lea_Bor_Title { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_NAME_RESP")]
        public string Lea_Bor_Name_Resp { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_AREA_PROP")]
        public decimal? Lea_Bor_Area_Prop { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_STATE_FUND")]
        public decimal? Lea_Loan_State_Fund { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LEN_CERT_FORM")]
        public string Lea_Len_Cert_Form { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_CERT_FORM")]
        public string Lea_Bor_Cert_Form { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_RISK_ASSESS_FORM")]
        public string Lea_Risk_Assess_Form { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_AGREE_FORM")]
        public string Lea_Bor_Agree_Form { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_MULT_PROJ_FORM")]
        public string Lea_Mult_Proj_Form { get; set; }

        [ConcurrencyCheck]
        [StringLength(100)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_PURPOSE_LOAN_EXP")]
        public string Lea_Bor_Purpose_Loan_Exp { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_EXTRA_ATTACHMENTS")]
        public string Lea_Extra_Attachments { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_PROOF_DEPOSITS")]
        public string Lea_Proof_Deposits { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(newid())")]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "ROWID")]
        public Guid Rowid { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_CSP_NUM")]
        public string Lea_Csp_Num { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_APP_ORI_CS_APP_AMT")]
        public decimal? Lea_App_Ori_Cs_App_Amt { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_CCAP_LOAN_NUM")]
        public string Lea_Ccap_Loan_Num { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_APP_TOT_CS_APP_AMT")]
        public decimal? Lea_App_Tot_Cs_App_Amt { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_LOAN_STATUS")]
        public string Lea_Loan_Status { get; set; }

        [ConcurrencyCheck]
        [DwColumn("CALCAPWEB.CCAP_LEA_LOAN_APP", "LEA_BOR_ID")]
        public decimal? Lea_Bor_Id { get; set; }

    }

}