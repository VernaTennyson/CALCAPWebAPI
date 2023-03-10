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
    [DataWindow("d_abs_evc_update", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"abs_evc_evcs\" \r\n "
                  +"WHERE (\"ABS_EVC_EVCS\".\"EVC_LOA_ID\" = :a_loa_id)")]
    #endregion
    [DwParameter("a_loa_id", typeof(double?))]
    public class D_Abs_Evc_Update
    {
        [DwColumn("\"abs_evc_evcs\"", "\"evc_id\"")]
        public decimal Evc_Id { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"evc_loa_id\"")]
        public decimal? Evc_Loa_Id { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"evc_multi_unit_dwelling\"")]
        public string Evc_Multi_Unit_Dwelling { get; set; } = "N";

        [DwColumn("\"abs_evc_evcs\"", "\"evc_disadvantage_community\"")]
        public string Evc_Disadvantage_Community { get; set; } = "N";

        [StringLength(120)]
        [DwColumn("\"abs_evc_evcs\"", "\"evc_manufacturer\"")]
        public string Evc_Manufacturer { get; set; }

        [StringLength(200)]
        [DwColumn("\"abs_evc_evcs\"", "\"evc_models\"")]
        public string Evc_Models { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"evc_units_purchased\"")]
        public decimal? Evc_Units_Purchased { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"evc_networked_comm_units\"")]
        public decimal? Evc_Networked_Comm_Units { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"evc_charging_ports\"")]
        public decimal? Evc_Charging_Ports { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"evc_total_evcs_cost\"")]
        public decimal? Evc_Total_Evcs_Cost { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"evc_est_install_cost\"")]
        public decimal? Evc_Est_Install_Cost { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"created_by\"")]
        public string Created_By { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"creation_date\"", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"last_updated_by\"")]
        public string Last_Updated_By { get; set; }

        [DwColumn("\"abs_evc_evcs\"", "\"last_update_date\"", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

    }

}