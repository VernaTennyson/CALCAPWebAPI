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
    [DataWindow("d_abs_fad_conv_sql", DwStyle.Grid)]
    [Table("ABS_FAD_FUND_ADJ", Schema = "ABS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ABS.ABS_FAD_FUND_ADJ\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Fad_Conv_Sql
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_FAD_SEQ])")]
        [DwColumn("ABS.ABS_FAD_FUND_ADJ", "FAD_ID")]
        public decimal Fad_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ABS.ABS_FAD_FUND_ADJ", "FAD_LOA_ID")]
        public decimal Fad_Loa_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("ABS.ABS_FAD_FUND_ADJ", "FAD_ADJ_TYPE")]
        public string Fad_Adj_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ABS.ABS_FAD_FUND_ADJ", "FAD_ADJ_AMOUNT")]
        public decimal? Fad_Adj_Amount { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ABS.ABS_FAD_FUND_ADJ", "FAD_ADJ_DATE", TypeName = "datetime2")]
        public DateTime? Fad_Adj_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(16)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("ABS.ABS_FAD_FUND_ADJ", "CREATED_BY")]
        public string Created_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("ABS.ABS_FAD_FUND_ADJ", "CREATION_DATE", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(16)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("ABS.ABS_FAD_FUND_ADJ", "LAST_UPDATED_BY")]
        public string Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("ABS.ABS_FAD_FUND_ADJ", "LAST_UPDATE_DATE", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

    }

}