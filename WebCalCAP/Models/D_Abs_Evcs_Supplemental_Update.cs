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
    [DataWindow("d_abs_evcs_supplemental_update", DwStyle.Default)]
    [Table("abs_evs_supplemental")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM abs_evs_supplemental \r\n "
                  +"where evs_evc_id = :a_evc_id")]
    #endregion
    [DwParameter("a_evc_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Evcs_Supplemental_Update
    {
        [ConcurrencyCheck]
        [DwColumn("\"evs_id\"")]
        public decimal Evs_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_evc_id\"")]
        public decimal? Evs_Evc_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_site_num\"")]
        public decimal? Evs_Site_Num { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"evs_proj_site_name\"")]
        public string Evs_Proj_Site_Name { get; set; }

        [Key]
        [StringLength(120)]
        [DwColumn("\"evs_street_address\"")]
        public string Evs_Street_Address { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"evs_city\"")]
        public string Evs_City { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"evs_county\"")]
        public string Evs_County { get; set; }

        [ConcurrencyCheck]
        [StringLength(2)]
        [DwColumn("\"evs_state\"")]
        public string Evs_State { get; set; } = "CA";

        [ConcurrencyCheck]
        [StringLength(10)]
        [DwColumn("\"evs_zip_code\"")]
        public string Evs_Zip_Code { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_project_bus_type\"")]
        public string Evs_Project_Bus_Type { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"evs_type_of_bus_act\"")]
        public string Evs_Type_Of_Bus_Act { get; set; }

        [ConcurrencyCheck]
        [StringLength(40)]
        [DwColumn("\"evs_proj_naics_code\"")]
        public string Evs_Proj_Naics_Code { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_project_census_tract\"")]
        public decimal? Evs_Project_Census_Tract { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_mud\"")]
        public string Evs_Mud { get; set; } = "N";

        [ConcurrencyCheck]
        [DwColumn("\"evs_dac\"")]
        public string Evs_Dac { get; set; } = "N";

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"evs_manufacturer\"")]
        public string Evs_Manufacturer { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("\"evs_models\"")]
        public string Evs_Models { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_units_purchased\"")]
        public decimal? Evs_Units_Purchased { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_networked_comm_units\"")]
        public decimal? Evs_Networked_Comm_Units { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_charging_ports\"")]
        public decimal? Evs_Charging_Ports { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_total_evcs_cost\"")]
        public decimal? Evs_Total_Evcs_Cost { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"evs_est_install_cost\"")]
        public decimal? Evs_Est_Install_Cost { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"created_by\"")]
        public string Created_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"creation_date\"", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"last_updated_by\"")]
        public string Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"last_update_date\"", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

    }

}