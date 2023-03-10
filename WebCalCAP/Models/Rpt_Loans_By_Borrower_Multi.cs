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
    [DataWindow("rpt_loans_by_borrower_multi", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_LEN_LENDER\", \r\n "
                  +"\"ABS_LOA_LOANS\", \r\n "
                  +"\"ABS_BOR_BORROWER\" \r\n "
                  +"WHERE ( \"ABS_LEN_LENDER\".\"LEN_ID\" = \"ABS_LOA_LOANS\".\"LOA_LEN_ID\" ) and \r\n "
                  +"( \"ABS_BOR_BORROWER\".\"BOR_ID\" = \"ABS_LOA_LOANS\".\"LOA_BOR_ID\" ) and \r\n "
                  +"( \"ABS_BOR_BORROWER\".\"BOR_NAME\" in ( :a_bor_name ) OR \r\n "
                  +"\"ABS_BOR_BORROWER\".\"BOR_DBA\" in ( :a_bor_dba ) )")]
    #endregion
    [DwParameter("a_bor_name", typeof(String[]))]
    [DwParameter("a_bor_dba", typeof(String[]))]
    [DwSort("abs_len_lender_len_name A abs_loa_loans_loa_calcap_loan_num A abs_bor_borrower_bor_name A")]
    [DwGroupBy(1, "abs_len_lender_len_name")]
    public class Rpt_Loans_By_Borrower_Multi
    {
        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LENDER_LOAN_DT\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Lender_Loan_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_AMOUNT_TOTAL\"")]
        public decimal? Abs_Loa_Loans_Loa_Amount_Total { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_MATURITY_DT\"", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Loa_Maturity_Dt { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_PREMIUM_PD\"")]
        public decimal? Abs_Loa_Loans_Loa_Calcap_Premium_Pd { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_LENDER_LOAN_NBR\"")]
        public string Abs_Loa_Loans_Loa_Lender_Loan_Nbr { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_CALCAP_LOAN_NUM\"")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_NAME\"")]
        public string Abs_Bor_Borrower_Bor_Name { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_DBA\"")]
        public string Abs_Bor_Borrower_Bor_Dba { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_NAME\"")]
        public string Abs_Len_Lender_Len_Name { get; set; }

        [DwColumn("\"ABS_LOA_LOANS\"", "\"LOA_ID\"")]
        public decimal Abs_Loa_Loans_Loa_Id { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ID\"")]
        public decimal Abs_Len_Lender_Len_Id { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_calcap_premium_pd FOR GROUP 1)")]
        public object Compute_6 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Sum(abs_loa_loans_loa_amount_total FOR GROUP 1)")]
        public object Compute_5 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("Count(abs_loa_loans_loa_id FOR GROUP 1) + \\\" record\\\" + IF(Count(abs_loa_loans_loa_id FOR GROUP 1) > 1, \\\"s\\\", \\\"\\\")")]
        public object Compute_8 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Totals For \\\" + abs_len_lender_len_name")]
        public object Compute_7 { get; set; }

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
        [DwCompute("Count(abs_loa_loans_loa_id FOR ALL) + \\\" record\\\" + IF(Count(abs_loa_loans_loa_id FOR ALL) > 0, \\\"s\\\", \\\"\\\")")]
        public object Compute_9 { get; set; }

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