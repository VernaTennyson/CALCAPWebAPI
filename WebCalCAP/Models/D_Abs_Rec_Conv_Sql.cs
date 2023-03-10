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
    [DataWindow("d_abs_rec_conv_sql", DwStyle.Grid)]
    [Table("ABS_REC_RECOVERIES", Schema = "ABS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT(TABLE(NAME=\"abs.abs_rec_recoveries\") @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Rec_Conv_Sql
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_REC_SEQ])")]
        [DwColumn("abs.abs_rec_recoveries", "rec_id")]
        public decimal? Rec_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_rec_recoveries", "rec_recovery_rec_dt", TypeName = "datetime2")]
        public DateTime? Rec_Recovery_Rec_Dt { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_rec_recoveries", "rec_len_id")]
        public decimal? Rec_Len_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_rec_recoveries", "rec_loa_id")]
        public decimal? Rec_Loa_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_rec_recoveries", "rec_recovery_rcv_amt")]
        public decimal? Rec_Recovery_Rcv_Amt { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs.abs_rec_recoveries", "created_by")]
        public string Created_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs.abs_rec_recoveries", "creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs.abs_rec_recoveries", "last_updated_by")]
        public string Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs.abs_rec_recoveries", "last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

    }

}