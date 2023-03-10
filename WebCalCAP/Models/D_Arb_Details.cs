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
    [DataWindow("d_arb_details", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_arb_details\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    public class D_Arb_Details
    {
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_ARB_SEQ])")]
        [DwColumn("abs_arb_details", "arb_id")]
        public decimal Arb_Id { get; set; }

        [DwColumn("abs_arb_details", "arb_loan_type")]
        public string Arb_Loan_Type { get; set; }

        [DwColumn("abs_arb_details", "arb_tractor_category")]
        public string Arb_Tractor_Category { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_tractor_eng_man")]
        public string Arb_Tractor_Eng_Man { get; set; }

        [DwColumn("abs_arb_details", "arb_tractor_mod_yrl")]
        public decimal? Arb_Tractor_Mod_Yrl { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_tractor_smart_crt")]
        public string Arb_Tractor_Smart_Crt { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_ecd_retro_dev_man")]
        public string Arb_Ecd_Retro_Dev_Man { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_ecd_retro_tech_type")]
        public string Arb_Ecd_Retro_Tech_Type { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_trailer_man")]
        public string Arb_Trailer_Man { get; set; }

        [DwColumn("abs_arb_details", "arb_trailer_mod_yr")]
        public decimal? Arb_Trailer_Mod_Yr { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_trailer_smart_crt")]
        public string Arb_Trailer_Smart_Crt { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_smart_way_man")]
        public string Arb_Smart_Way_Man { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_smart_way_t_type")]
        public string Arb_Smart_Way_T_Type { get; set; }

        [StringLength(2)]
        [DwColumn("abs_arb_details", "arb_or_eqp_type")]
        public string Arb_Or_Eqp_Type { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_or_veh_type")]
        public string Arb_Or_Veh_Type { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_or_eng_man")]
        public string Arb_Or_Eng_Man { get; set; }

        [StringLength(2)]
        [DwColumn("abs_arb_details", "arb_or_tier_lvl")]
        public string Arb_Or_Tier_Lvl { get; set; }

        [StringLength(20)]
        [DwColumn("abs_arb_details", "arb_or_eng_ser_num")]
        public string Arb_Or_Eng_Ser_Num { get; set; }

        [StringLength(20)]
        [DwColumn("abs_arb_details", "arb_or_eng_hp")]
        public string Arb_Or_Eng_Hp { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_or_exh_retro_man")]
        public string Arb_Or_Exh_Retro_Man { get; set; }

        [StringLength(120)]
        [DwColumn("abs_arb_details", "arb_or_exh_retro_mdl")]
        public string Arb_Or_Exh_Retro_Mdl { get; set; }

        [StringLength(2)]
        [DwColumn("abs_arb_details", "arb_off_ret_ver_level")]
        public string Arb_Off_Ret_Ver_Level { get; set; }

        [DwColumn("abs_arb_details", "arb_dealer_cert", TypeName = "datetime2")]
        public DateTime? Arb_Dealer_Cert { get; set; }

        [DwColumn("abs_arb_details", "arb_90_day_cert", TypeName = "datetime2")]
        public DateTime? Arb_90_Day_Cert { get; set; }

        [StringLength(15)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs_arb_details", "created_by")]
        public string Created_By { get; set; }

        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs_arb_details", "creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [StringLength(15)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs_arb_details", "last_updated_by")]
        public string Last_Updated_By { get; set; }

        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs_arb_details", "last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

    }

}