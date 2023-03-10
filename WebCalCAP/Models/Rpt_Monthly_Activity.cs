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
    [DataWindow("rpt_monthly_activity", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT 'Loans' loan_sort, \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_LEN_ID\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_APP_RCVD_DT\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_AMOUNT_TOTAL\", \r\n "
                  +"\"ABS_LEN_LENDER\".\"LEN_NAME\", \r\n "
                  +"\"ABS_ARB_DETAILS\".\"ARB_LOA_ID\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_LOA_ID\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_NAME\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREMIUM_PD\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_LOAN_NUM\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREM_PD_DT\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_FILED_AMT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_TYPE\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_AMOUNT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_RATE\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_ID\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_DATE\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_DBA\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_LENDER_LOAN_NBR\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_CODE\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_STATUS\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_DATE\" \r\n "
                  +"FROM \"ABS_LOA_LOANS\" \r\n "
                  +"left join \"ABS_EVN_EVENTS\" on abs_evn_events.evn_loa_id  = loa_id \r\n "
                  +"left join  \"ABS_ARB_DETAILS\" on  abs_arb_details.arb_loa_id  = loa_id \r\n "
                  +"left join  \"ABS_CLA_CLAIM_PROCESSING\" on   abs_cla_claim_processing.cla_loa_id = loa_id \r\n "
                  +"left join  \"ABS_FND_FUNDS\" on  abs_fnd_funds.fnd_loa_id  = loa_id  , \r\n "
                  +" \r\n "
                  +"\"ABS_BOR_BORROWER\", \r\n "
                  +"\"ABS_LEN_LENDER\" \r\n "
                  +" \r\n "
                  +" \r\n "
                  +"WHERE \r\n "
                  +" \r\n "
                  +" \r\n "
                  +"( \"ABS_LOA_LOANS\".\"LOA_BOR_ID\" = \"ABS_BOR_BORROWER\".\"BOR_ID\" ) and \r\n "
                  +"( \"ABS_LOA_LOANS\".\"LOA_LEN_ID\" = \"ABS_LEN_LENDER\".\"LEN_ID\" ) and \r\n "
                  +"( ( ARB_LOA_ID IS NULL ) AND \r\n "
                  +"( CLA_LOA_ID IS NULL ) AND \r\n "
                  +"EVN_CODE = 'RE' AND \r\n "
                  +"EVN_STATUS = 'A' AND \r\n "
                  +"( EVN_DATE BETWEEN :a_begin_dt AND :a_end_dt ) ) \r\n "
                  +"GROUP BY \"ABS_LOA_LOANS\".\"LOA_LEN_ID\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_APP_RCVD_DT\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_AMOUNT_TOTAL\", \r\n "
                  +"\"ABS_LEN_LENDER\".\"LEN_NAME\", \r\n "
                  +"\"ABS_ARB_DETAILS\".\"ARB_LOA_ID\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_LOA_ID\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_NAME\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_LOAN_NUM\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREMIUM_PD\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREM_PD_DT\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_FILED_AMT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_TYPE\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_AMOUNT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_RATE\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_ID\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_DATE\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_DBA\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_LENDER_LOAN_NBR\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_CODE\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_STATUS\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_DATE\" \r\n "
                  +"UNION \r\n "
                  +"SELECT 'ARB On-Road Loans' loan_sort, \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_LEN_ID\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_APP_RCVD_DT\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_AMOUNT_TOTAL\", \r\n "
                  +"\"ABS_LEN_LENDER\".\"LEN_NAME\", \r\n "
                  +"\"ABS_ARB_DETAILS\".\"ARB_LOA_ID\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_LOA_ID\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_NAME\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREMIUM_PD\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_LOAN_NUM\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREM_PD_DT\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_FILED_AMT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_TYPE\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_AMOUNT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_RATE\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_ID\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_DATE\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_DBA\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_LENDER_LOAN_NBR\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_CODE\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_STATUS\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_DATE\" \r\n "
                  +"FROM \"ABS_LOA_LOANS\" \r\n "
                  +"left join \"ABS_EVN_EVENTS\" on abs_evn_events.evn_loa_id  = loa_id \r\n "
                  +"left join  \"ABS_ARB_DETAILS\" on  abs_arb_details.arb_loa_id  = loa_id \r\n "
                  +"left join  \"ABS_CLA_CLAIM_PROCESSING\" on   abs_cla_claim_processing.cla_loa_id = loa_id \r\n "
                  +"left join  \"ABS_FND_FUNDS\" on  abs_fnd_funds.fnd_loa_id  = loa_id  , \r\n "
                  +" \r\n "
                  +"\"ABS_BOR_BORROWER\", \r\n "
                  +"\"ABS_LEN_LENDER\" \r\n "
                  +" \r\n "
                  +"WHERE \r\n "
                  +"( \"ABS_LOA_LOANS\".\"LOA_BOR_ID\" = \"ABS_BOR_BORROWER\".\"BOR_ID\" ) and \r\n "
                  +"( \"ABS_LOA_LOANS\".\"LOA_LEN_ID\" = \"ABS_LEN_LENDER\".\"LEN_ID\" ) and \r\n "
                  +"( ( ARB_LOA_ID IS NOT NULL ) AND \r\n "
                  +"EVN_CODE = 'RE' AND \r\n "
                  +"EVN_STATUS = 'A' AND \r\n "
                  +"( EVN_DATE BETWEEN :a_begin_dt AND :a_end_dt ) ) AND \r\n "
                  +"arb_loan_type = 'O' \r\n "
                  +"GROUP BY \"ABS_LOA_LOANS\".\"LOA_LEN_ID\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_APP_RCVD_DT\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_AMOUNT_TOTAL\", \r\n "
                  +"\"ABS_LEN_LENDER\".\"LEN_NAME\", \r\n "
                  +"\"ABS_ARB_DETAILS\".\"ARB_LOA_ID\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_LOA_ID\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_NAME\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_LOAN_NUM\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREMIUM_PD\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREM_PD_DT\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_FILED_AMT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_TYPE\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_AMOUNT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_RATE\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_ID\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_DATE\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_DBA\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_LENDER_LOAN_NBR\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_CODE\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_STATUS\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_DATE\" \r\n "
                  +"UNION \r\n "
                  +"SELECT 'ARB Off-Road Loans' loan_sort, \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_LEN_ID\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_APP_RCVD_DT\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_AMOUNT_TOTAL\", \r\n "
                  +"\"ABS_LEN_LENDER\".\"LEN_NAME\", \r\n "
                  +"\"ABS_ARB_DETAILS\".\"ARB_LOA_ID\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_LOA_ID\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_NAME\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREMIUM_PD\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_LOAN_NUM\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREM_PD_DT\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_FILED_AMT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_TYPE\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_AMOUNT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_RATE\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_ID\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_DATE\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_DBA\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_LENDER_LOAN_NBR\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_CODE\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_STATUS\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_DATE\" \r\n "
                  +"FROM \"ABS_LOA_LOANS\" \r\n "
                  +"left join \"ABS_EVN_EVENTS\" on abs_evn_events.evn_loa_id  = loa_id \r\n "
                  +"left join  \"ABS_ARB_DETAILS\" on  abs_arb_details.arb_loa_id  = loa_id \r\n "
                  +"left join  \"ABS_CLA_CLAIM_PROCESSING\" on   abs_cla_claim_processing.cla_loa_id = loa_id \r\n "
                  +"left join  \"ABS_FND_FUNDS\" on  abs_fnd_funds.fnd_loa_id  = loa_id  , \r\n "
                  +" \r\n "
                  +"\"ABS_BOR_BORROWER\", \r\n "
                  +"\"ABS_LEN_LENDER\" \r\n "
                  +" \r\n "
                  +"WHERE \r\n "
                  +"( \"ABS_LOA_LOANS\".\"LOA_BOR_ID\" = \"ABS_BOR_BORROWER\".\"BOR_ID\" ) and \r\n "
                  +"( \"ABS_LOA_LOANS\".\"LOA_LEN_ID\" = \"ABS_LEN_LENDER\".\"LEN_ID\" ) and \r\n "
                  +"( ( ARB_LOA_ID IS NOT NULL ) AND \r\n "
                  +"EVN_CODE = 'RE' AND \r\n "
                  +"EVN_STATUS = 'A' AND \r\n "
                  +"( EVN_DATE BETWEEN :a_begin_dt AND :a_end_dt ) ) AND \r\n "
                  +"arb_loan_type = 'F' \r\n "
                  +"GROUP BY \"ABS_LOA_LOANS\".\"LOA_LEN_ID\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_APP_RCVD_DT\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_AMOUNT_TOTAL\", \r\n "
                  +"\"ABS_LEN_LENDER\".\"LEN_NAME\", \r\n "
                  +"\"ABS_ARB_DETAILS\".\"ARB_LOA_ID\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_LOA_ID\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_NAME\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_LOAN_NUM\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREMIUM_PD\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_CALCAP_PREM_PD_DT\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\".\"CLA_FILED_AMT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_TYPE\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_AMOUNT\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_RATE\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_ID\", \r\n "
                  +"\"ABS_FND_FUNDS\".\"FND_DATE\", \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_DBA\", \r\n "
                  +"\"ABS_LOA_LOANS\".\"LOA_LENDER_LOAN_NBR\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_CODE\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_STATUS\", \r\n "
                  +"\"ABS_EVN_EVENTS\".\"EVN_DATE\"")]
    #endregion
    [DwParameter("a_begin_dt", typeof(DateTime?))]
    [DwParameter("a_end_dt", typeof(DateTime?))]
    [DwSort("abs_loa_loans_loa_len_id A loan_sort A abs_loa_loans_loa_calcap_loan_num A")]
    [DwGroupBy(1, "abs_loa_loans_loa_len_id")]
    [DwGroupBy(2, "loan_sort")]
    [DwGroupBy(3, "abs_loa_loans_loa_id")]
    public class Rpt_Monthly_Activity
    {
        [DwColumn("loan_sort")]
        public string Loan_Sort { get; set; }

        [DwColumn("LOA_LEN_ID")]
        public decimal? Abs_Loa_Loans_Loa_Len_Id { get; set; }

        [DwColumn("LOA_APP_RCVD_DT", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_App_Rcvd_Dt { get; set; }

        [DwColumn("LOA_AMOUNT_TOTAL")]
        public decimal? Abs_Loa_Loans_Loa_Amount_Total { get; set; }

        [DwColumn("LEN_NAME")]
        public string Abs_Len_Lender_Len_Name { get; set; }

        [DwColumn("ARB_LOA_ID")]
        public decimal? Abs_Arb_Details_Arb_Loa_Id { get; set; }

        [DwColumn("CLA_LOA_ID")]
        public decimal? Abs_Cla_Claim_Processing_Cla_Loa_Id { get; set; }

        [DwColumn("BOR_NAME")]
        public string Abs_Bor_Borrower_Bor_Name { get; set; }

        [DwColumn("LOA_CALCAP_PREMIUM_PD")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Premium_Pd { get; set; }

        [DwColumn("LOA_CALCAP_LOAN_NUM")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

        [DwColumn("LOA_CALCAP_PREM_PD_DT", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Calcap_Prem_Pd_Dt { get; set; }

        [DwColumn("CLA_FILED_AMT")]
        public decimal? Abs_Cla_Claim_Processing_Cla_Filed_Amt { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Funding), AutoRetrieve = true)]
        [DwColumn("FND_TYPE")]
        public string Abs_Fnd_Funds_Fnd_Type { get; set; }

        [DwColumn("FND_AMOUNT")]
        public decimal? Abs_Fnd_Funds_Fnd_Amount { get; set; }

        [DwColumn("FND_RATE")]
        public decimal? Abs_Fnd_Funds_Fnd_Rate { get; set; }

        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_LOA_SEQ])")]
        [DwColumn("LOA_ID")]
        public decimal? Abs_Loa_Loans_Loa_Id { get; set; }

        [DwColumn("FND_DATE", TypeName = "datetime2")]
        public DateTime? Abs_Fnd_Funds_Fnd_Date { get; set; }

        [DwColumn("BOR_DBA")]
        public string Abs_Bor_Borrower_Bor_Dba { get; set; }

        [DwColumn("LOA_LENDER_LOAN_NBR")]
        public string Abs_Loa_Loans_Loa_Lender_Loan_Nbr { get; set; }

        [DwColumn("EVN_CODE")]
        public string Abs_Evn_Events_Evn_Code { get; set; }

        [DwColumn("EVN_STATUS")]
        public string Abs_Evn_Events_Evn_Status { get; set; }

        [DwColumn("EVN_DATE", TypeName = "datetime2")]
        public DateTime? Abs_Evn_Events_Evn_Date { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("'CalCAP Monthly Activity Report' + ' \" " 
                  + "+ \"' + \" "
                  + "+ \"a_begin_dt  + ' to ' + a_end_dt")]
        public object Compute_1 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute(" abs_fnd_funds_fnd_rate + '%'")]
        public object Compute_16 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Totals for \\\" + loan_sort + \\\":\\\"")]
        public object Compute_9 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR GROUP 2 DISTINCT )")]
        public object Compute_2 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_amount_total FOR GROUP 2 DISTINCT )")]
        public object Compute_3 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_calcap_premium_pd FOR GROUP 2 DISTINCT )")]
        public object Compute_4 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_fnd_funds_fnd_amount FOR GROUP 2)")]
        public object Compute_5 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Totals for \\\" + abs_len_lender_len_name + \\\":\\\"")]
        public object Compute_10 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR GROUP 1 DISTINCT )")]
        public object Compute_8 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_calcap_premium_pd FOR GROUP 1 DISTINCT )")]
        public object Compute_7 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_fnd_funds_fnd_amount FOR GROUP 1)")]
        public object Compute_11 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_amount_total FOR GROUP 1 DISTINCT )")]
        public object Compute_6 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR ALL DISTINCT )")]
        public object Compute_12 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_calcap_premium_pd FOR ALL)")]
        public object Compute_14 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_fnd_funds_fnd_amount FOR ALL)")]
        public object Compute_15 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_amount_total FOR ALL)")]
        public object Compute_13 { get; set; }

    }

}