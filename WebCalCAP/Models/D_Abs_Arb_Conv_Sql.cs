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
    [DataWindow("d_abs_arb_conv_sql", DwStyle.Grid)]
    [Table("ABS_ARB_DETAILS")]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_)      FROM \"ABS_ARB_DETAILS\"")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Arb_Conv_Sql
    {
        [Key]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_ID\"")]
        public decimal Arb_Id { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_LOAN_TYPE\"")]
        public string Arb_Loan_Type { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_TRACTOR_CATEGORY\"")]
        public string Arb_Tractor_Category { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_TRACTOR_ENG_MAN\"")]
        public string Arb_Tractor_Eng_Man { get; set; }

        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_TRACTOR_MOD_YRL\"")]
        public decimal? Arb_Tractor_Mod_Yrl { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_TRACTOR_SMART_CRT\"")]
        public string Arb_Tractor_Smart_Crt { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_ECD_RETRO_DEV_MAN\"")]
        public string Arb_Ecd_Retro_Dev_Man { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_ECD_RETRO_TECH_TYPE\"")]
        public string Arb_Ecd_Retro_Tech_Type { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_TRAILER_MAN\"")]
        public string Arb_Trailer_Man { get; set; }

        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_TRAILER_MOD_YR\"")]
        public decimal? Arb_Trailer_Mod_Yr { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_TRAILER_SMART_CRT\"")]
        public string Arb_Trailer_Smart_Crt { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_SMART_WAY_MAN\"")]
        public string Arb_Smart_Way_Man { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_SMART_WAY_T_TYPE\"")]
        public string Arb_Smart_Way_T_Type { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_OR_EQP_TYPE\"")]
        public string Arb_Or_Eqp_Type { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_OR_VEH_TYPE\"")]
        public string Arb_Or_Veh_Type { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_OR_ENG_MAN\"")]
        public string Arb_Or_Eng_Man { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_OR_TIER_LVL\"")]
        public string Arb_Or_Tier_Lvl { get; set; }

        [StringLength(30)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_OR_ENG_SER_NUM\"")]
        public string Arb_Or_Eng_Ser_Num { get; set; }

        [StringLength(20)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_OR_ENG_HP\"")]
        public string Arb_Or_Eng_Hp { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_OR_EXH_RETRO_MAN\"")]
        public string Arb_Or_Exh_Retro_Man { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_OR_EXH_RETRO_MDL\"")]
        public string Arb_Or_Exh_Retro_Mdl { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_OFF_RET_VER_LEVEL\"")]
        public string Arb_Off_Ret_Ver_Level { get; set; }

        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_DEALER_CERT\"", TypeName = "datetime2")]
        public DateTime? Arb_Dealer_Cert { get; set; }

        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_90_DAY_CERT\"", TypeName = "datetime2")]
        public DateTime? Arb_90_Day_Cert { get; set; }

        [StringLength(15)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"CREATED_BY\"")]
        public string Created_By { get; set; }

        [DwColumn("\"ABS_ARB_DETAILS\"", "\"CREATION_DATE\"", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [StringLength(15)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"LAST_UPDATED_BY\"")]
        public string Last_Updated_By { get; set; }

        [DwColumn("\"ABS_ARB_DETAILS\"", "\"LAST_UPDATE_DATE\"", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_LOA_ID\"")]
        public decimal? Arb_Loa_Id { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_TRACTOR_ENG_MAN_RPLCD\"")]
        public string Arb_Tractor_Eng_Man_Rplcd { get; set; }

        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_TRACTOR_MOD_YRL_RPLCD\"")]
        public decimal? Arb_Tractor_Mod_Yrl_Rplcd { get; set; }

        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_FLEET_ID\"")]
        public decimal? Arb_Fleet_Id { get; set; }

        [StringLength(20)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_REPLACED_VEHICLE_EIN\"")]
        public string Arb_Replaced_Vehicle_Ein { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_REPLACED_OR_VEHICLE\"")]
        public string Arb_Replaced_Or_Vehicle { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_REPLACED_OR_ENG_MAN\"")]
        public string Arb_Replaced_Or_Eng_Man { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_REPLACED_OR_TIER_LVL\"")]
        public string Arb_Replaced_Or_Tier_Lvl { get; set; }

        [StringLength(30)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_REPLACED_OR_SER_NUM\"")]
        public string Arb_Replaced_Or_Ser_Num { get; set; }

        [StringLength(20)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_REPLACED_OR_ENG_HP\"")]
        public string Arb_Replaced_Or_Eng_Hp { get; set; }

        [StringLength(20)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_ONROAD_HP\"")]
        public string Arb_Onroad_Hp { get; set; }

        [StringLength(20)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_ONROAD_GVWR\"")]
        public string Arb_Onroad_Gvwr { get; set; }

        [StringLength(30)]
        [DwColumn("\"ABS_ARB_DETAILS\"", "\"ARB_FUEL_TYPE\"")]
        public string Arb_Fuel_Type { get; set; }

    }

}