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
    [DataWindow("d_abs_evn_conv_sql", DwStyle.Grid)]
    [Table("ABS_EVN_EVENTS", Schema = "ABS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT(TABLE(NAME=\"abs.abs_evn_events\") @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Evn_Conv_Sql
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_EVN_SEQ])")]
        [DwColumn("abs.abs_evn_events", "evn_id")]
        public decimal Evn_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_evn_events", "evn_loa_id")]
        public decimal? Evn_Loa_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("abs.abs_evn_events", "evn_code")]
        public string Evn_Code { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("abs.abs_evn_events", "evn_status")]
        public string Evn_Status { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_evn_events", "evn_date", TypeName = "datetime2")]
        public DateTime? Evn_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_evn_events", "evn_assigned")]
        public decimal? Evn_Assigned { get; set; }

        [ConcurrencyCheck]
        [StringLength(2000)]
        [DwColumn("abs.abs_evn_events", "evn_note")]
        public string Evn_Note { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_evn_events", "evn_len_id")]
        public decimal? Evn_Len_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(16)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs.abs_evn_events", "created_by")]
        public string Created_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs.abs_evn_events", "creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(16)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs.abs_evn_events", "last_updated_by")]
        public string Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs.abs_evn_events", "last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_evn_events", "evn_cla_id")]
        public decimal? Evn_Cla_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_evn_events", "evn_reb_id")]
        public decimal? Evn_Reb_Id { get; set; }

    }

}