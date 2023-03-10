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
    [DataWindow("d_loan_funding", DwStyle.Default)]
    [Table("ABS_LOA_LOANS", Schema = "ABS")]
    #region DwSelectAttribute  
    [DwSelect("SELECT DISTINCT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_LOA_LOANS\" \r\n "
                  +"LEFT JOIN  \"ABS_BOR_BORROWER\"  ON ( \"ABS_LOA_LOANS\".\"LOA_BOR_ID\" = \"ABS_BOR_BORROWER\".\"BOR_ID\" ) \r\n "
                  +" \r\n "
                  +"ORDER BY \"ABS_LOA_LOANS\".\"LOA_CALCAP_LOAN_NUM\" DESC")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Loan_Funding
    {
        [Key]
        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_ID\"")]
        public decimal Loa_Id { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_DELIVERY_METHOD\"")]
        public string Loa_Delivery_Method { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LOAN_TYPE\"")]
        public string Loa_Loan_Type { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LEN_ID\"")]
        public decimal? Loa_Len_Id { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_BOR_ID\"")]
        public decimal? Loa_Bor_Id { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_NBR_EMPOYEES\"")]
        public decimal? Loa_Nbr_Empoyees { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_NBR_JOBS\"")]
        public decimal? Loa_Nbr_Jobs { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_ANNUAL_REV\"")]
        public decimal? Loa_Annual_Rev { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEV_AFFECTED\"")]
        public string Loa_Sev_Affected { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_PURPOSE\"")]
        public string Loa_Purpose { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_MIN_OR_WOMEN\"")]
        public string Loa_Min_Or_Women { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_INTEREST_RATE\"")]
        public decimal? Loa_Interest_Rate { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_INT_RATE_TYPE\"")]
        public string Loa_Int_Rate_Type { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_INT_RATE_MOD\"")]
        public string Loa_Int_Rate_Mod { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LENDER_LOAN_DT\"", TypeName = "datetime2")]
        public DateTime? Loa_Lender_Loan_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_REFINANCING\"")]
        public string Loa_Refinancing { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_INCREASE\"")]
        public decimal? Loa_Increase { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_MATURITY_DT\"", TypeName = "datetime2")]
        public DateTime? Loa_Maturity_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_AMOUNT_TOTAL\"")]
        public decimal? Loa_Amount_Total { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP\"")]
        public decimal? Loa_Calcap { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Program_Type), AutoRetrieve = true)]
        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_PROGRAM\"")]
        public string Loa_Program { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_PREMIUM_AMNT\"")]
        public decimal? Loa_Premium_Amnt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_PREMIUM_PD_DT\"", TypeName = "datetime2")]
        public DateTime? Loa_Premium_Pd_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_INDEPENDENT_CNTR\"")]
        public decimal? Loa_Independent_Cntr { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_PREMIUM_PD\"")]
        public decimal? Loa_Calcap_Premium_Pd { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_COMMENTS\"")]
        public string Loa_Comments { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LENDER_LOAN_NBR\"")]
        public string Loa_Lender_Loan_Nbr { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_OFFICER_NAME\"")]
        public string Loa_Officer_Name { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_OFFICER_PHONE\"")]
        public string Loa_Officer_Phone { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SAC_CONTACT_INFO\"")]
        public string Loa_Sac_Contact_Info { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_USED_AT_ADDRESS\"")]
        public string Loa_Used_At_Address { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_USED_ADDRESS\"")]
        public string Loa_Used_Address { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_USED_CITY\"")]
        public string Loa_Used_City { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_USED_COUNTY\"")]
        public decimal? Loa_Used_County { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_USED_ZIP\"")]
        public string Loa_Used_Zip { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_FIRST_500_CALCAP\"")]
        public string Loa_First_500_Calcap { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SECURED\"")]
        public string Loa_Secured { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_LOAN_LIST\"")]
        public string Loa_Calcap_Loan_List { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CONTRIB_NAME\"")]
        public string Loa_Contrib_Name { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_LOAN_NUM_PRIOR\"")]
        public string Loa_Calcap_Loan_Num_Prior { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_NAICS_CODE\"")]
        public string Loa_Naics_Code { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_LOAN_NUM\"")]
        public string Loa_Calcap_Loan_Num { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_APP_RCVD_DT\"", TypeName = "datetime2")]
        public DateTime? Loa_App_Rcvd_Dt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_NAME\"")]
        public string Abs_Bor_Borrower_Bor_Name { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_BUS_OPND_2YEARS\"")]
        public string Abs_Loa_Loans_Loa_Bus_Opnd_2Years { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_NON_PROFIT\"")]
        public string Abs_Loa_Loans_Loa_Non_Profit { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEV_AFFECT_COM\"")]
        public string Abs_Loa_Loans_Loa_Sev_Affect_Com { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_MIN_OWN\"")]
        public string Abs_Loa_Loans_Loa_Min_Own { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_WOM_OWN\"")]
        public string Abs_Loa_Loans_Loa_Wom_Own { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_VET_OWN\"")]
        public string Abs_Loa_Loans_Loa_Vet_Own { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_GOV_GUAR_PGM\"")]
        public string Abs_Loa_Loans_Loa_Gov_Guar_Pgm { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_GUAR_PGM_NAME\"")]
        public string Abs_Loa_Loans_Loa_Guar_Pgm_Name { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_OTHER_PGM_PCT\"")]
        public decimal? Abs_Loa_Loans_Loa_Other_Pgm_Pct { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_PCT\"")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Pct { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_REMAIN_BAL\"")]
        public decimal? Abs_Loa_Loans_Loa_Remain_Bal { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_APP_RCVD_BY\"")]
        public decimal? Abs_Loa_Loans_Loa_App_Rcvd_By { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_INDEPENDNT_CNTR_DT\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Independnt_Cntr_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_PREMIUM_AMT\"")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Premium_Amt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LENDER_PREMIUM_PD_DT\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Lender_Premium_Pd_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_BORROW_PREMIUM_PD_DT\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Borrow_Premium_Pd_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_PREM_PD_DT\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Calcap_Prem_Pd_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_BORROWER_PREMIUM_AMNT\"")]
        public decimal? Abs_Loa_Loans_Loa_Borrower_Premium_Amnt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_OFFICER_EMAIL\"")]
        public string Abs_Loa_Loans_Loa_Officer_Email { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_JOBS_RETAINED\"")]
        public decimal? Abs_Loa_Loans_Loa_Jobs_Retained { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_JOBS_CREATED\"")]
        public decimal? Abs_Loa_Loans_Loa_Jobs_Created { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_AVG_ANN_REV_LAST_FY\"")]
        public decimal? Abs_Loa_Loans_Loa_Avg_Ann_Rev_Last_Fy { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_NUM_FTES\"")]
        public decimal? Abs_Loa_Loans_Loa_Num_Ftes { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CENSUS_TRACT_NUM\"")]
        public string Abs_Loa_Loans_Loa_Census_Tract_Num { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CSP_APPNUM\"")]
        public decimal? Abs_Loa_Loans_Loa_Csp_Appnum { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LENDER_LOAN_NBR_2\"")]
        public string Abs_Loa_Loans_Loa_Lender_Loan_Nbr_2 { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LOAN_TYPE_2\"")]
        public string Abs_Loa_Loans_Loa_Loan_Type_2 { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_MATURITY_DT_2\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Maturity_Dt_2 { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOAN_LENDER2_LOAN_AMNT\"")]
        public decimal? Abs_Loa_Loans_Loan_Lender2_Loan_Amnt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"COMMENT_BOX\"")]
        public string Abs_Loa_Loans_Comment_Box { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_INTEREST_RATE_2\"")]
        public decimal? Abs_Loa_Loans_Loa_Interest_Rate_2 { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_PROP_TYPE\"")]
        public string Abs_Loa_Loans_Loa_Prop_Type { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_MOBILE_HOME\"")]
        public string Abs_Loa_Loans_Loa_Mobile_Home { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CONSTRUCT_YEAR\"")]
        public decimal? Abs_Loa_Loans_Loa_Construct_Year { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_NUM_UNITS\"")]
        public decimal? Abs_Loa_Loans_Loa_Num_Units { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_TERM_RCV\"")]
        public string Loa_Term_Rcv { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_TERM_DATE\"", TypeName = "datetime2")]
        public DateTime? Loa_Term_Date { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_TERM_PURPOSE\"")]
        public string Loa_Term_Purpose { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LAST_UPDATE_DATE\"", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CHNGE_EFFECTIVE_DT\"", TypeName = "datetime2")]
        public DateTime? Loa_Chnge_Effective_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LAST_UPDATED_BY\"")]
        public string Last_Updated_By { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CIT_APPROVE\"")]
        public string Loa_Cit_Approve { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_APP_TYPE\"")]
        public string Loa_Seis_App_Type { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_BUS_SEL\"")]
        public string Loa_Seis_Bus_Sel { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_BLDG_CERT\"")]
        public string Loa_Seis_Bldg_Cert { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_BLDG_RET\"")]
        public string Loa_Seis_Bldg_Ret { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_QUAL_BLDG\"")]
        public string Loa_Seis_Qual_Bldg { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_QUAL_BLDG_UNITS\"")]
        public decimal? Loa_Seis_Qual_Bldg_Units { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_DESC_ELI_CST\"")]
        public string Loa_Seis_Desc_Eli_Cst { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_OTH_SEIS\"")]
        public string Loa_Seis_Oth_Seis { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_OTH_SEIS_AMT\"")]
        public decimal? Loa_Seis_Oth_Seis_Amt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_PUB_ENT\"")]
        public string Loa_Seis_Pub_Ent { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_PUB_ENT_YES\"")]
        public string Loa_Seis_Pub_Ent_Yes { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_SEIS_END_COV\"")]
        public string Loa_Seis_End_Cov { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LEA_ID\"")]
        public decimal? Loa_Lea_Id { get; set; }

    }

}