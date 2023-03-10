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
    [DataWindow("d_abs_evs_conv_sql", DwStyle.Grid)]
    [Table("ABS_EVS_SUPPLEMENTAL")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT(TABLE(NAME=\"ABS_EVS_SUPPLEMENTAL\") @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Evs_Conv_Sql
    {
        [Key]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_ID")]
        public decimal Evs_Id { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_EVC_ID")]
        public decimal? Evs_Evc_Id { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_SITE_NUM")]
        public decimal? Evs_Site_Num { get; set; }

        [StringLength(120)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_PROJ_SITE_NAME")]
        public string Evs_Proj_Site_Name { get; set; }

        [StringLength(120)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_STREET_ADDRESS")]
        public string Evs_Street_Address { get; set; }

        [StringLength(120)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_CITY")]
        public string Evs_City { get; set; }

        [StringLength(120)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_COUNTY")]
        public string Evs_County { get; set; }

        [StringLength(2)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_STATE")]
        public string Evs_State { get; set; }

        [StringLength(10)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_ZIP_CODE")]
        public string Evs_Zip_Code { get; set; }

        [StringLength(120)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_PROJECT_BUS_TYPE")]
        public string Evs_Project_Bus_Type { get; set; }

        [StringLength(120)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_TYPE_OF_BUS_ACT")]
        public string Evs_Type_Of_Bus_Act { get; set; }

        [StringLength(40)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_PROJ_NAICS_CODE")]
        public string Evs_Proj_Naics_Code { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_PROJECT_CENSUS_TRACT")]
        public decimal? Evs_Project_Census_Tract { get; set; }

        [StringLength(1)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_MUD")]
        public string Evs_Mud { get; set; }

        [StringLength(1)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_DAC")]
        public string Evs_Dac { get; set; }

        [StringLength(120)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_MANUFACTURER")]
        public string Evs_Manufacturer { get; set; }

        [StringLength(200)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_MODELS")]
        public string Evs_Models { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_UNITS_PURCHASED")]
        public decimal? Evs_Units_Purchased { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_NETWORKED_COMM_UNITS")]
        public decimal? Evs_Networked_Comm_Units { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_CHARGING_PORTS")]
        public decimal? Evs_Charging_Ports { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_TOTAL_EVCS_COST")]
        public decimal? Evs_Total_Evcs_Cost { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "EVS_EST_INSTALL_COST")]
        public decimal? Evs_Est_Install_Cost { get; set; }

        [StringLength(15)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "CREATED_BY")]
        public string Created_By { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "CREATION_DATE", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [StringLength(15)]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "LAST_UPDATED_BY")]
        public string Last_Updated_By { get; set; }

        [DwColumn("ABS_EVS_SUPPLEMENTAL", "LAST_UPDATE_DATE", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(newid())")]
        [DwColumn("ABS_EVS_SUPPLEMENTAL", "ROWID")]
        public Guid Rowid { get; set; }

    }

}