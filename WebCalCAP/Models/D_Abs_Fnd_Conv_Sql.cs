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
    [DataWindow("d_abs_fnd_conv_sql", DwStyle.Grid)]
    [Table("ABS_FND_FUNDS", Schema = "ABS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ABS.ABS_FND_FUNDS\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Fnd_Conv_Sql
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_FND_SEQ])")]
        [DwColumn("ABS.ABS_FND_FUNDS", "FND_ID")]
        public decimal Fnd_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("ABS.ABS_FND_FUNDS", "FND_TYPE")]
        public string Fnd_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ABS.ABS_FND_FUNDS", "FND_LOA_ID")]
        public decimal Fnd_Loa_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ABS.ABS_FND_FUNDS", "FND_RATE")]
        public decimal? Fnd_Rate { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ABS.ABS_FND_FUNDS", "FND_AMOUNT")]
        public decimal? Fnd_Amount { get; set; }

        [ConcurrencyCheck]
        [StringLength(16)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("ABS.ABS_FND_FUNDS", "CREATED_BY")]
        public string Created_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("ABS.ABS_FND_FUNDS", "CREATION_DATE", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(16)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("ABS.ABS_FND_FUNDS", "LAST_UPDATED_BY")]
        public string Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("ABS.ABS_FND_FUNDS", "LAST_UPDATE_DATE", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ABS.ABS_FND_FUNDS", "FND_DATE", TypeName = "datetime2")]
        public DateTime? Fnd_Date { get; set; }

    }

}