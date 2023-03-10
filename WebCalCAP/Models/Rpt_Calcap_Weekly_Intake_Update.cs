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
    [DataWindow("rpt_calcap_weekly_intake_update", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_len_lender\" )  TABLE(NAME=\"abs_bor_borrower\" )  TABLE(NAME=\"abs_loa_loans\" )  TABLE(NAME=\"abs_evn_events\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"abs_evn_events.evn_loa_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_id\"    OUTER2 =\"abs_loa_loans.loa_id\" )    JOIN (LEFT=\"abs_len_lender.len_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_len_id\" )    JOIN (LEFT=\"abs_bor_borrower.bor_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_bor_id\" )WHERE(    EXP1 =\"( ( \\\"ABS_LOA_LOANS\\\".\\\"LOA_APP_RCVD_DT\\\"\"   OP =\"between\"    EXP2 =\":a_begin_dt and :a_end_dt ) )\" ) ) ARG(NAME = \"a_begin_dt\" TYPE = date)  ARG(NAME = \"a_end_dt\" TYPE = date)")]
    #endregion
    [DwParameter("a_begin_dt", typeof(DateTime?))]
    [DwParameter("a_end_dt", typeof(DateTime?))]
    [DwSort("abs_loa_loans_loa_calcap_loan_num A abs_loa_loans_loa_id A abs_evn_events_evn_id A")]
    [DwGroupBy(1, "abs_loa_loans_loa_id")]
    public class Rpt_Calcap_Weekly_Intake_Update
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

        [DwChild("Staff_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("abs_loa_loans", "loa_app_rcvd_by")]
        public decimal? Abs_Loa_Loans_Loa_App_Rcvd_By { get; set; }

        [DwColumn("abs_evn_events", "evn_loa_id")]
        public decimal? Abs_Evn_Events_Evn_Loa_Id { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Event), AutoRetrieve = true)]
        [DwColumn("abs_evn_events", "evn_code")]
        public string Abs_Evn_Events_Evn_Code { get; set; }

        [DwColumn("abs_evn_events", "evn_status")]
        public string Abs_Evn_Events_Evn_Status { get; set; }

        [DwColumn("abs_evn_events", "evn_date", TypeName = "datetime2")]
        public DateTime? Abs_Evn_Events_Evn_Date { get; set; }

        [DwChild("Staff_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
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

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("'CalCap Loan Enrollment' + ' \" " 
                  + "+ \"' +  a_begin_dt +' to ' +  a_end_dt")]
        public object Compute_3 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR GROUP 1 DISTINCT )")]
        public object Compute_5 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR ALL DISTINCT )")]
        public object Compute_4 { get; set; }

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