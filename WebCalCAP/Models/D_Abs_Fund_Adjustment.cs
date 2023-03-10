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
    [DataWindow("d_abs_fund_adjustment", DwStyle.Default)]
    [Table("abs_fad_fund_adj")]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM abs_fad_fund_adj \r\n "
                  +"WHERE ( FAD_LOA_ID = :p_loa_id )")]
    #endregion
    [DwParameter("p_loa_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Fund_Adjustment
    {
        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Funding), AutoRetrieve = true)]
        [DwColumn("abs_fad_fund_adj", "fad_adj_type")]
        public string Fad_Adj_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_fad_fund_adj", "fad_adj_amount")]
        public decimal? Fad_Adj_Amount { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_fad_fund_adj", "fad_adj_date", TypeName = "datetime2")]
        public DateTime? Fad_Adj_Date { get; set; }

        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_FAD_SEQ])")]
        [DwColumn("abs_fad_fund_adj", "fad_id")]
        public decimal Fad_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_fad_fund_adj", "fad_loa_id")]
        public decimal Fad_Loa_Id { get; set; }

    }

}