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
    [DataWindow("d_abs_fund_adjustment_bk", DwStyle.Default)]
    [Table("ABS_FAD_FUND_ADJ")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_fad_fund_adj\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ABS_FAD_FUND_ADJ\\\".\\\"FAD_LOA_ID\\\"\"   OP =\"=\"    EXP2 =\":p_loa_id\" ) ) ARG(NAME = \"p_loa_id\" TYPE = number)")]
    #endregion
    [DwParameter("p_loa_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Fund_Adjustment_Bk
    {
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Funding))]
        [DwColumn("abs_fad_fund_adj", "fad_adj_type")]
        public string Fad_Adj_Type { get; set; }

        [DwColumn("abs_fad_fund_adj", "fad_adj_amount")]
        public decimal? Fad_Adj_Amount { get; set; }

        [DwColumn("abs_fad_fund_adj", "fad_adj_date", TypeName = "datetime2")]
        public DateTime? Fad_Adj_Date { get; set; }

        [DwColumn("abs_fad_fund_adj", "fad_loa_id")]
        public decimal Fad_Loa_Id { get; set; }

        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_FAD_SEQ])")]
        [DwColumn("abs_fad_fund_adj", "fad_id")]
        public decimal Fad_Id { get; set; }

    }

}