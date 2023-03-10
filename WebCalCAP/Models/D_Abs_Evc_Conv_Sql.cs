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
    [DataWindow("d_abs_evc_conv_sql", DwStyle.Grid)]
    [Table("ABS_EVC_EVCS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT(TABLE(NAME=\"ABS_EVC_EVCS\") @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Evc_Conv_Sql
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_FAD_SEQ])")]
        [DwColumn("ABS_EVC_EVCS", "EVC_ID")]
        public decimal Evc_Id { get; set; }

        [DwColumn("ABS_EVC_EVCS", "EVC_LOA_ID")]
        public decimal? Evc_Loa_Id { get; set; }

        [StringLength(1)]
        [DwColumn("ABS_EVC_EVCS", "EVC_MULTI_UNIT_DWELLING")]
        public string Evc_Multi_Unit_Dwelling { get; set; }

        [StringLength(1)]
        [DwColumn("ABS_EVC_EVCS", "EVC_DISADVANTAGE_COMMUNITY")]
        public string Evc_Disadvantage_Community { get; set; }

        [StringLength(120)]
        [DwColumn("ABS_EVC_EVCS", "EVC_MANUFACTURER")]
        public string Evc_Manufacturer { get; set; }

        [StringLength(200)]
        [DwColumn("ABS_EVC_EVCS", "EVC_MODELS")]
        public string Evc_Models { get; set; }

        [DwColumn("ABS_EVC_EVCS", "EVC_UNITS_PURCHASED")]
        public decimal? Evc_Units_Purchased { get; set; }

        [DwColumn("ABS_EVC_EVCS", "EVC_NETWORKED_COMM_UNITS")]
        public decimal? Evc_Networked_Comm_Units { get; set; }

        [DwColumn("ABS_EVC_EVCS", "EVC_CHARGING_PORTS")]
        public decimal? Evc_Charging_Ports { get; set; }

        [DwColumn("ABS_EVC_EVCS", "EVC_TOTAL_EVCS_COST")]
        public decimal? Evc_Total_Evcs_Cost { get; set; }

        [DwColumn("ABS_EVC_EVCS", "EVC_EST_INSTALL_COST")]
        public decimal? Evc_Est_Install_Cost { get; set; }

        [StringLength(15)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("ABS_EVC_EVCS", "CREATED_BY")]
        public string Created_By { get; set; }

        [SqlDefaultValue("(getdate())")]
        [DwColumn("ABS_EVC_EVCS", "CREATION_DATE", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [StringLength(15)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("ABS_EVC_EVCS", "LAST_UPDATED_BY")]
        public string Last_Updated_By { get; set; }

        [SqlDefaultValue("(getdate())")]
        [DwColumn("ABS_EVC_EVCS", "LAST_UPDATE_DATE", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

    }

}