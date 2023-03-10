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
    [DataWindow("rpt_calcap_monthly_claims_detail", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_len_lender\" )  TABLE(NAME=\"abs_bor_borrower\" )  TABLE(NAME=\"abs_loa_loans\" )  TABLE(NAME=\"abs_cla_claim_processing\" )  TABLE(NAME=\"abs_evn_events\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"abs_cla_claim_processing.cla_id\"    OP =\"=\"RIGHT=\"abs_evn_events.evn_cla_id\"    OUTER1 =\"abs_cla_claim_processing.cla_id\" )    JOIN (LEFT=\"abs_len_lender.len_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_len_id\" )    JOIN (LEFT=\"abs_bor_borrower.bor_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_bor_id\" )    JOIN (LEFT=\"abs_cla_claim_processing.cla_loa_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_id\" )WHERE(    EXP1 =\"\\\"ABS_EVN_EVENTS\\\".\\\"EVN_STATUS\\\"\"   OP =\"=\"    EXP2 =\"'A'\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"\\\"ABS_EVN_EVENTS\\\".\\\"EVN_CODE\\\"\"   OP =\"=\"    EXP2 =\"'ST'\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"( ( \\\"ABS_CLA_CLAIM_PROCESSING\\\".\\\"CLA_CLAIM_SUBMITTED_DT\\\"\"   OP =\"between\"    EXP2 =\":a_begin_dt and :a_end_dt ) )\" ) ) ARG(NAME = \"a_begin_dt\" TYPE = date)  ARG(NAME = \"a_end_dt\" TYPE = date)")]
    #endregion
    [DwParameter("a_begin_dt", typeof(DateTime?))]
    [DwParameter("a_end_dt", typeof(DateTime?))]
    [DwSort("abs_len_lender_len_name A abs_loa_loans_loa_calcap_loan_num A")]
    [DwGroupBy(1, "abs_loa_loans_loa_id")]
    public class Rpt_Calcap_Monthly_Claims_Detail
    {
        [DwColumn("abs_len_lender", "len_name")]
        public string Abs_Len_Lender_Len_Name { get; set; }

        [DwColumn("abs_bor_borrower", "bor_name")]
        public string Abs_Bor_Borrower_Bor_Name { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap")]
        public decimal? Abs_Loa_Loans_Loa_Calcap { get; set; }

        [DwColumn("abs_loa_loans", "loa_app_rcvd_dt", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_App_Rcvd_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_delivery_method")]
        public string Abs_Loa_Loans_Loa_Delivery_Method { get; set; }

        [DwColumn("abs_loa_loans", "loa_app_rcvd_by")]
        public decimal? Abs_Loa_Loans_Loa_App_Rcvd_By { get; set; }

        [DwColumn("abs_cla_claim_processing", "cla_submitted")]
        public string Abs_Cla_Claim_Processing_Cla_Submitted { get; set; }

        [DwColumn("abs_cla_claim_processing", "cla_rcvd_by")]
        public decimal? Abs_Cla_Claim_Processing_Cla_Rcvd_By { get; set; }

        [DwColumn("abs_cla_claim_processing", "cla_charge_off_dt", TypeName = "datetime2")]
        public DateTime? Abs_Cla_Claim_Processing_Cla_Charge_Off_Dt { get; set; }

        [DwColumn("abs_cla_claim_processing", "cla_filed_amt")]
        public decimal? Abs_Cla_Claim_Processing_Cla_Filed_Amt { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Event), AutoRetrieve = true)]
        [DwColumn("abs_evn_events", "evn_code")]
        public string Abs_Evn_Events_Evn_Code { get; set; }

        [DwColumn("abs_evn_events", "evn_status")]
        public string Abs_Evn_Events_Evn_Status { get; set; }

        [DwColumn("abs_evn_events", "evn_date", TypeName = "datetime2")]
        public DateTime? Abs_Evn_Events_Evn_Date { get; set; }

        [DwColumn("abs_evn_events", "evn_assigned")]
        public decimal? Abs_Evn_Events_Evn_Assigned { get; set; }

        [DwColumn("abs_evn_events", "evn_note")]
        public string Abs_Evn_Events_Evn_Note { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_loan_num")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_EVN_SEQ])")]
        [DwColumn("abs_evn_events", "evn_id")]
        public decimal? Abs_Evn_Events_Evn_Id { get; set; }

        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_LOA_SEQ])")]
        [DwColumn("abs_loa_loans", "loa_id")]
        public decimal? Abs_Loa_Loans_Loa_Id { get; set; }

        [DwColumn("abs_bor_borrower", "bor_dba")]
        public string Abs_Bor_Borrower_Bor_Dba { get; set; }

        [DwColumn("abs_cla_claim_processing", "cla_amt_of_approv_claim")]
        public decimal? Abs_Cla_Claim_Processing_Cla_Amt_Of_Approv_Claim { get; set; }

        [DwColumn("abs_loa_loans", "loa_amount_total")]
        public decimal? Abs_Loa_Loans_Loa_Amount_Total { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_premium_pd")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Premium_Pd { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("'CalCap Monthly Claims Detail' + ' \" " 
                  + "+ \"' +  a_begin_dt +' to ' +  a_end_dt")]
        public object Compute_3 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR ALL DISTINCT )")]
        public object Compute_5 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_amount_total FOR ALL)")]
        public object Compute_4 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_cla_claim_processing_cla_amt_of_approv_claim FOR ALL)")]
        public object Compute_6 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_calcap_premium_pd FOR ALL)")]
        public object Compute_7 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Page \\\" + Page() + \\\" of \\\" + PageCount()")]
        public object Compute_2 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Today()")]
        public object Compute_1 { get; set; }

    }

}