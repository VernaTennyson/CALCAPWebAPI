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
    [DataWindow("rpt_lender", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_len_lender\" )  TABLE(NAME=\"abs_loa_loans\" )  TABLE(NAME=\"abs_bor_borrower\" )  TABLE(NAME=\"abs_fnd_funds\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"abs_loa_loans.loa_id\"    OP =\"=\"RIGHT=\"abs_fnd_funds.fnd_loa_id\"    OUTER1 =\"abs_loa_loans.loa_id\" )    JOIN (LEFT=\"abs_len_lender.len_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_len_id\" )    JOIN (LEFT=\"abs_bor_borrower.bor_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_bor_id\" )WHERE(    EXP1 =\"( ( \\\"ABS_LOA_LOANS\\\".\\\"LOA_LENDER_LOAN_DT\\\"\"   OP =\"between\"    EXP2 =\":a_begin_dt and :a_end_dt )\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"( \\\"ABS_LEN_LENDER\\\".\\\"LEN_ID\\\"\"   OP =\"=\"    EXP2 =\":a_len_id ) )\" ) ) ARG(NAME = \"a_begin_dt\" TYPE = date)  ARG(NAME = \"a_end_dt\" TYPE = date)  ARG(NAME = \"a_len_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_begin_dt", typeof(DateTime?))]
    [DwParameter("a_end_dt", typeof(DateTime?))]
    [DwParameter("a_len_id", typeof(double?))]
    [DwSort("abs_loa_loans_loa_calcap_loan_num A")]
    [DwGroupBy(1, "abs_loa_loans_loa_id")]
    public class Rpt_Lender
    {
        [DwColumn("abs_loa_loans", "loa_lender_loan_nbr")]
        public string Abs_Loa_Loans_Loa_Lender_Loan_Nbr { get; set; }

        [DwColumn("abs_loa_loans", "loa_app_rcvd_dt", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_App_Rcvd_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_lender_loan_dt", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Lender_Loan_Dt { get; set; }

        [DwColumn("abs_bor_borrower", "bor_name")]
        public string Abs_Bor_Borrower_Bor_Name { get; set; }

        [DwColumn("abs_bor_borrower", "bor_city")]
        public string Abs_Bor_Borrower_Bor_City { get; set; }

        [DwColumn("abs_loa_loans", "loa_amount_total")]
        public decimal? Abs_Loa_Loans_Loa_Amount_Total { get; set; }

        [DwColumn("abs_loa_loans", "loa_interest_rate")]
        public decimal? Abs_Loa_Loans_Loa_Interest_Rate { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_premium_pd")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Premium_Pd { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Funding), AutoRetrieve = true)]
        [DwColumn("abs_fnd_funds", "fnd_type")]
        public string Abs_Fnd_Funds_Fnd_Type { get; set; }

        [DwColumn("abs_len_lender", "len_name")]
        public string Abs_Len_Lender_Len_Name { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap")]
        public decimal? Abs_Loa_Loans_Loa_Calcap { get; set; }

        [DwColumn("abs_bor_borrower", "bor_county")]
        public decimal? Abs_Bor_Borrower_Bor_County { get; set; }

        [DwColumn("abs_fnd_funds", "fnd_amount")]
        public decimal? Abs_Fnd_Funds_Fnd_Amount { get; set; }

        [DwColumn("abs_fnd_funds", "fnd_rate")]
        public decimal? Abs_Fnd_Funds_Fnd_Rate { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_premium_amt")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Premium_Amt { get; set; }

        [DwColumn("abs_len_lender", "len_lendor_number")]
        public string Abs_Len_Lender_Len_Lendor_Number { get; set; }

        [DwColumn("abs_loa_loans", "loa_contrib_name")]
        public string Abs_Loa_Loans_Loa_Contrib_Name { get; set; }

        [DwColumn("abs_loa_loans", "loa_independent_cntr")]
        public decimal? Abs_Loa_Loans_Loa_Independent_Cntr { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_loan_num")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Program_Type), AutoRetrieve = true)]
        [DwColumn("abs_loa_loans", "loa_program")]
        public string Abs_Loa_Loans_Loa_Program { get; set; }

        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_LOA_SEQ])")]
        [DwColumn("abs_loa_loans", "loa_id")]
        public decimal? Abs_Loa_Loans_Loa_Id { get; set; }

        [DwColumn("abs_bor_borrower", "bor_dba")]
        public string Abs_Bor_Borrower_Bor_Dba { get; set; }

        [DwColumn("abs_fnd_funds", "fnd_date", TypeName = "datetime2")]
        public DateTime? Abs_Fnd_Funds_Fnd_Date { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("abs_len_lender_len_name + ', ' +  abs_len_lender_len_lendor_number + ' \" " 
                  + "+ \"' +  a_begin_dt  + ' to ' + a_end_dt")]
        public object Compute_3 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute(" abs_fnd_funds_fnd_rate + '%'")]
        public object Compute_9 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("IF(abs_fnd_funds_fnd_type = \\\"L\\\", abs_fnd_funds_fnd_amount, 0)")]
        public object Compute_Lender { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("IF((abs_fnd_funds_fnd_type = \\\"ICR\\\") AND (abs_loa_loans_loa_program = \\\"A\\\"), abs_fnd_funds_fnd_amount, 0)")]
        public object Compute_Arb_On_Road { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("IF((abs_fnd_funds_fnd_type = \\\"ICR\\\") AND (abs_loa_loans_loa_program = \\\"F\\\"), abs_fnd_funds_fnd_amount, 0)")]
        public object Compute_Arb_Off_Road { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("IF(abs_fnd_funds_fnd_type = \\\"B\\\", abs_fnd_funds_fnd_amount, 0)")]
        public object Compute_Borrower { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("IF(abs_fnd_funds_fnd_type = \\\"SBA\\\", abs_fnd_funds_fnd_amount, 0)")]
        public object Compute_Sbaf { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("IF(abs_fnd_funds_fnd_type = \\\"S\\\", abs_fnd_funds_fnd_amount, 0)")]
        public object Compute_State { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Page \\\" + Page() + \\\" of \\\" + PageCount()")]
        public object Compute_2 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Today()")]
        public object Compute_1 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("IF(abs_fnd_funds_fnd_type = \\\"F\\\", abs_fnd_funds_fnd_amount, 0)")]
        public object Compute_Federal { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR ALL DISTINCT )")]
        public object Compute_13 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_amount_total)")]
        public object Compute_4 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_calcap_premium_pd FOR ALL)")]
        public object Compute_6 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(compute_sbaf FOR ALL)")]
        public object Compute_5 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(compute_state FOR ALL)")]
        public object Compute_7 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(compute_federal FOR ALL)")]
        public object Compute_8 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(compute_arb_on_road FOR ALL)")]
        public object Compute_10 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(compute_arb_off_road FOR ALL)")]
        public object Compute_11 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(compute_lender FOR ALL)")]
        public object Compute_12 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(compute_borrower FOR ALL)")]
        public object Compute_14 { get; set; }

    }

}