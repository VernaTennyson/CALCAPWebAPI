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
    [DataWindow("d_recoveries", DwStyle.Default)]
    [Table("ABS_REC_RECOVERIES")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_rec_recoveries\" )  TABLE(NAME=\"abs_loa_loans\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"abs_rec_recoveries.rec_loa_id\"    OP =\"=\"RIGHT=\"abs_loa_loans.loa_id\" )WHERE(    EXP1 =\"\\\"ABS_LOA_LOANS\\\".\\\"LOA_ID\\\"\"   OP =\"=\"    EXP2 =\":a_loa_id\" ) ) ARG(NAME = \"a_loa_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_loa_id", typeof(double?))]
    [DwSort("rec_id A")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Recoveries
    {
        [DwColumn("abs_rec_recoveries", "rec_recovery_rec_dt", TypeName = "datetime2")]
        public DateTime? Abs_Rec_Recoveries_Rec_Recovery_Rec_Dt { get; set; }

        [DwChild("Len_Id", "Len_Name", typeof(Dddw_Lender), AutoRetrieve = true)]
        [DwColumn("abs_rec_recoveries", "rec_len_id")]
        public decimal? Rec_Len_Id { get; set; }

        [DwColumn("abs_rec_recoveries", "rec_recovery_rcv_amt")]
        public decimal? Abs_Rec_Recoveries_Rec_Recovery_Rcv_Amt { get; set; }

        [DwColumn("abs_rec_recoveries", "rec_loa_id")]
        public decimal? Rec_Loa_Id { get; set; }

        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_REC_SEQ])")]
        [DwColumn("abs_rec_recoveries", "rec_id")]
        public decimal? Rec_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_loa_loans", "loa_calcap_loan_num")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

    }

}