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
    [DataWindow("rpt_loans_by_borrower", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_len_lender\" )  TABLE(NAME=\"abs_loa_loans\" )  TABLE(NAME=\"abs_bor_borrower\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"abs_len_lender.len_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_len_id\" )    JOIN (LEFT=\"abs_bor_borrower.bor_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_bor_id\" )WHERE(    EXP1 =\"( ( \\\"ABS_BOR_BORROWER\\\".\\\"BOR_NAME\\\"\"   OP =\"=\"    EXP2 =\":a_bor_name )\"    LOGIC =\"or\" ) WHERE(    EXP1 =\"( \\\"ABS_BOR_BORROWER\\\".\\\"BOR_DBA\\\"\"   OP =\"=\"    EXP2 =\":a_bor_dba ) )\" ) ) ARG(NAME = \"a_bor_name\" TYPE = string)  ARG(NAME = \"a_bor_dba\" TYPE = string)")]
    #endregion
    [DwParameter("a_bor_name", typeof(string))]
    [DwParameter("a_bor_dba", typeof(string))]
    [DwSort("abs_len_lender_len_name A abs_loa_loans_loa_calcap_loan_num A abs_bor_borrower_bor_name A")]
    [DwGroupBy(1, "abs_len_lender_len_name")]
    public class Rpt_Loans_By_Borrower
    {
        [DwColumn("abs_loa_loans", "loa_lender_loan_dt", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Lender_Loan_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_amount_total")]
        public decimal? Abs_Loa_Loans_Loa_Amount_Total { get; set; }

        [DwColumn("abs_loa_loans", "loa_maturity_dt", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Maturity_Dt { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_premium_pd")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Premium_Pd { get; set; }

        [DwColumn("abs_loa_loans", "loa_lender_loan_nbr")]
        public string Abs_Loa_Loans_Loa_Lender_Loan_Nbr { get; set; }

        [DwColumn("abs_loa_loans", "loa_calcap_loan_num")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

        [DwColumn("abs_bor_borrower", "bor_name")]
        public string Abs_Bor_Borrower_Bor_Name { get; set; }

        [DwColumn("abs_bor_borrower", "bor_dba")]
        public string Abs_Bor_Borrower_Bor_Dba { get; set; }

        [DwColumn("abs_len_lender", "len_name")]
        public string Abs_Len_Lender_Len_Name { get; set; }

        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_LOA_SEQ])")]
        [DwColumn("abs_loa_loans", "loa_id")]
        public decimal Abs_Loa_Loans_Loa_Id { get; set; }

        [DwColumn("abs_len_lender", "len_id")]
        public decimal Abs_Len_Lender_Len_Id { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Loans By Borrower\\nBorrower: \\\" + a_bor_name + \\\"\\nBorrower DBA: \\\" + a_bor_dba")]
        public object Compute_3 { get; set; }

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
        [DwCompute("Sum(abs_loa_loans_loa_calcap_premium_pd FOR GROUP 1)")]
        public object Compute_6 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_calcap_premium_pd FOR ALL)")]
        public object Compute_12 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_amount_total FOR ALL)")]
        public object Compute_4 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_amount_total FOR GROUP 1)")]
        public object Compute_5 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR ALL) + \\\" record\\\" + IF(Count(abs_loa_loans_loa_id FOR ALL) > 0, \\\"s\\\", \\\"\\\")")]
        public object Compute_9 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR GROUP 1) + \\\" record\\\" + IF(Count(abs_loa_loans_loa_id FOR GROUP 1) > 1, \\\"s\\\", \\\"\\\")")]
        public object Compute_8 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Totals For \\\" + abs_len_lender_len_name")]
        public object Compute_7 { get; set; }

    }

}