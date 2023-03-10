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
    [DataWindow("rpt_calcap_weekly_claims_update", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_LEN_LENDER\", \r\n "
                  +"\"ABS_BOR_BORROWER\", \r\n "
                  +"\"ABS_LOA_LOANS\", \r\n "
                  +"\"ABS_CLA_CLAIM_PROCESSING\" \r\n "
                  +"LEFT JOIN \"ABS_EVN_EVENTS\"  ON abs_cla_claim_processing.cla_id = abs_evn_events.evn_cla_id \r\n "
                  +"WHERE \r\n "
                  +"( \"ABS_LEN_LENDER\".\"LEN_ID\" = \"ABS_LOA_LOANS\".\"LOA_LEN_ID\" ) and \r\n "
                  +"( \"ABS_BOR_BORROWER\".\"BOR_ID\" = \"ABS_LOA_LOANS\".\"LOA_BOR_ID\" ) and \r\n "
                  +"( \"ABS_CLA_CLAIM_PROCESSING\".\"CLA_LOA_ID\" = \"ABS_LOA_LOANS\".\"LOA_ID\" ) and \r\n "
                  +"( ( \"ABS_CLA_CLAIM_PROCESSING\".\"CLA_CLAIM_SUBMITTED_DT\" between :a_begin_dt and :a_end_dt ) ) \r\n "
                  +"and ( (:pending = 'Y'  AND \"ABS_EVN_EVENTS\".\"EVN_CODE\" <>'RE'  AND \"ABS_EVN_EVENTS\".\"EVN_STATUS\" <> 'A') \r\n "
                  +"or (:pending = 'N' ))")]
    #endregion
    [DwParameter("a_begin_dt", typeof(DateTime?))]
    [DwParameter("a_end_dt", typeof(DateTime?))]
    [DwParameter("pending", typeof(string))]
    [DwSort("abs_loa_loans_loa_calcap_loan_num A abs_evn_events_evn_date A")]
    [DwGroupBy(1, "abs_loa_loans_loa_id")]
    public class Rpt_Calcap_Weekly_Claims_Update
    {
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_NAME\"")]
        public string Abs_Len_Lender_Len_Name { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_NAME\"")]
        public string Abs_Bor_Borrower_Bor_Name { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP\"")]
        public decimal? Abs_Loa_Loans_Loa_Calcap { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_APP_RCVD_DT\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_App_Rcvd_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_DELIVERY_METHOD\"")]
        public string Abs_Loa_Loans_Loa_Delivery_Method { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_APP_RCVD_BY\"")]
        public decimal? Abs_Loa_Loans_Loa_App_Rcvd_By { get; set; }

        [DwColumn("\"ABS_CLA_CLAIM_PROCESSING\"", "\"CLA_SUBMITTED\"")]
        public string Abs_Cla_Claim_Processing_Cla_Submitted { get; set; }

        [DwChild("Staff_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"ABS_CLA_CLAIM_PROCESSING\"", "\"CLA_RCVD_BY\"")]
        public decimal? Abs_Cla_Claim_Processing_Cla_Rcvd_By { get; set; }

        [DwColumn("\"ABS_CLA_CLAIM_PROCESSING\"", "\"CLA_CHARGE_OFF_DT\"", TypeName = "datetime2")]
        public DateTime? Abs_Cla_Claim_Processing_Cla_Charge_Off_Dt { get; set; }

        [DwColumn("\"ABS_CLA_CLAIM_PROCESSING\"", "\"CLA_FILED_AMT\"")]
        public decimal? Abs_Cla_Claim_Processing_Cla_Filed_Amt { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Event), AutoRetrieve = true)]
        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_CODE\"")]
        public string Abs_Evn_Events_Evn_Code { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_STATUS\"")]
        public string Abs_Evn_Events_Evn_Status { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_DATE\"", TypeName = "datetime2")]
        public DateTime? Abs_Evn_Events_Evn_Date { get; set; }

        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_ASSIGNED\"")]
        public decimal? Abs_Evn_Events_Evn_Assigned { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_NOTE\"")]
        public string Abs_Evn_Events_Evn_Note { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_LOAN_NUM\"")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_ID\"")]
        public decimal? Abs_Evn_Events_Evn_Id { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_ID\"")]
        public decimal Abs_Loa_Loans_Loa_Id { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_DBA\"")]
        public string Abs_Bor_Borrower_Bor_Dba { get; set; }

        [DwColumn("\"ABS_CLA_CLAIM_PROCESSING\"", "\"CLA_AMT_OF_APPROV_CLAIM\"")]
        public decimal? Abs_Cla_Claim_Processing_Cla_Amt_Of_Approv_Claim { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("'CalCap Claims' + ' \" " 
                  + "+ \"' +  a_begin_dt +' to ' +  a_end_dt")]
        public object Compute_3 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR ALL DISTINCT )")]
        public object Compute_5 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_cla_claim_processing_cla_filed_amt FOR ALL)")]
        public object Compute_4 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_cla_claim_processing_cla_amt_of_approv_claim FOR ALL)")]
        public object Compute_6 { get; set; }

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