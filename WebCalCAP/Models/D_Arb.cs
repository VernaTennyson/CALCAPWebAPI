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
    [DataWindow("d_arb", DwStyle.Default)]
    [Table("abs_arb_details", Schema = "ABS")]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"abs_arb_details\" ,           \"abs_loa_loans\" \r\n "
                  +"WHERE ( \"abs_arb_details\".\"arb_loa_id\" = \"abs_loa_loans\".\"loa_id\" ) and          ( ( \"ABS_LOA_LOANS\".\"LOA_ID\" = :loa_id ) )")]
    #endregion
    [DwParameter("loa_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Arb
    {
        [Key]
        [DwColumn("\"abs_arb_details\"", "\"arb_id\"")]
        public decimal Arb_Id { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Arb_Loan_Type), AutoRetrieve = true)]
        [DwColumn("\"abs_arb_details\"", "\"arb_loan_type\"")]
        public string Arb_Loan_Type { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Tractor_Category), AutoRetrieve = true)]
        [DwColumn("\"abs_arb_details\"", "\"arb_tractor_category\"")]
        public string Arb_Tractor_Category { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"abs_arb_details\"", "\"arb_tractor_eng_man\"")]
        public string Arb_Tractor_Eng_Man { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_tractor_mod_yrl\"")]
        public decimal? Arb_Tractor_Mod_Yrl { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_tractor_smart_crt\"")]
        public string Arb_Tractor_Smart_Crt { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"abs_arb_details\"", "\"arb_ecd_retro_dev_man\"")]
        public string Arb_Ecd_Retro_Dev_Man { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Retro_Tech_Type), AutoRetrieve = true)]
        [DwColumn("\"abs_arb_details\"", "\"arb_ecd_retro_tech_type\"")]
        public string Arb_Ecd_Retro_Tech_Type { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"abs_arb_details\"", "\"arb_trailer_man\"")]
        public string Arb_Trailer_Man { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_trailer_mod_yr\"")]
        public decimal? Arb_Trailer_Mod_Yr { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_trailer_smart_crt\"")]
        public string Arb_Trailer_Smart_Crt { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"abs_arb_details\"", "\"arb_smart_way_man\"")]
        public string Arb_Smart_Way_Man { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"abs_arb_details\"", "\"arb_smart_way_t_type\"")]
        public string Arb_Smart_Way_T_Type { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Or_Equipment_Category), AutoRetrieve = true)]
        [DwColumn("\"abs_arb_details\"", "\"arb_or_eqp_type\"")]
        public string Arb_Or_Eqp_Type { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"abs_arb_details\"", "\"arb_or_veh_type\"")]
        public string Arb_Or_Veh_Type { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"abs_arb_details\"", "\"arb_or_eng_man\"")]
        public string Arb_Or_Eng_Man { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Or_Tier_Level), AutoRetrieve = true)]
        [DwColumn("\"abs_arb_details\"", "\"arb_or_tier_lvl\"")]
        public string Arb_Or_Tier_Lvl { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("\"abs_arb_details\"", "\"arb_or_eng_hp\"")]
        public string Arb_Or_Eng_Hp { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"abs_arb_details\"", "\"arb_or_exh_retro_man\"")]
        public string Arb_Or_Exh_Retro_Man { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"abs_arb_details\"", "\"arb_or_exh_retro_mdl\"")]
        public string Arb_Or_Exh_Retro_Mdl { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_off_ret_ver_level\"")]
        public string Arb_Off_Ret_Ver_Level { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_dealer_cert\"", TypeName = "datetime2")]
        public DateTime? Arb_Dealer_Cert { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_90_day_cert\"", TypeName = "datetime2")]
        public DateTime? Arb_90_Day_Cert { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_arb_details\"", "\"created_by\"")]
        public string Created_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_arb_details\"", "\"creation_date\"", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_arb_details\"", "\"last_updated_by\"")]
        public string Last_Updated_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_arb_details\"", "\"last_update_date\"", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_loa_id\"")]
        public decimal? Arb_Loa_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_lender_loan_nbr\"")]
        public string Abs_Loa_Loans_Loa_Lender_Loan_Nbr { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap\"")]
        public decimal? Abs_Loa_Loans_Loa_Calcap { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_loa_loans\"", "\"loa_calcap_loan_num\"")]
        public string Abs_Loa_Loans_Loa_Calcap_Loan_Num { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_or_eng_ser_num\"")]
        public string Arb_Or_Eng_Ser_Num { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_tractor_eng_man_rplcd\"")]
        public string Abs_Arb_Details_Arb_Tractor_Eng_Man_Rplcd { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_tractor_mod_yrl_rplcd\"")]
        public decimal? Abs_Arb_Details_Arb_Tractor_Mod_Yrl_Rplcd { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_fleet_id\"")]
        public decimal? Abs_Arb_Details_Arb_Fleet_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_replaced_vehicle_ein\"")]
        public string Abs_Arb_Details_Arb_Replaced_Vehicle_Ein { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_replaced_or_vehicle\"")]
        public string Abs_Arb_Details_Arb_Replaced_Or_Vehicle { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_replaced_or_eng_man\"")]
        public string Abs_Arb_Details_Arb_Replaced_Or_Eng_Man { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Or_Tier_Level), AutoRetrieve = true)]
        [DwColumn("\"abs_arb_details\"", "\"arb_replaced_or_tier_lvl\"")]
        public string Abs_Arb_Details_Arb_Replaced_Or_Tier_Lvl { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_replaced_or_ser_num\"")]
        public string Abs_Arb_Details_Arb_Replaced_Or_Ser_Num { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_replaced_or_eng_hp\"")]
        public string Abs_Arb_Details_Arb_Replaced_Or_Eng_Hp { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_onroad_hp\"")]
        public string Abs_Arb_Details_Arb_Onroad_Hp { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_onroad_gvwr\"")]
        public string Abs_Arb_Details_Arb_Onroad_Gvwr { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_quantity\"")]
        public decimal? Arb_Quantity { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Arb_Fuel_Type), AutoRetrieve = true)]
        [DwColumn("\"abs_arb_details\"", "\"arb_fuel_type\"")]
        public string Arb_Fuel_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_arb_details\"", "\"arb_non_comp\"")]
        public string Arb_Non_Comp { get; set; }

    }

}