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
    [DataWindow("d_arbweb_truck_rpt", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ccap_arb\" , \r\n "
                  +"\"ccap_arb_sec3_detail_truck\" \r\n "
                  +"WHERE ( \"ccap_arb\".\"arb_id\" = \"ccap_arb_sec3_detail_truck\".\"asd_arb_id_fk\" ) \r\n "
                  +"and   ( ( \"CCAP_ARB\".\"ARB_ID\" = :a_arb_id ) )")]
    #endregion
    [DwParameter("a_arb_id", typeof(double?))]
    public class D_Arbweb_Truck_Rpt
    {
        [DwColumn("\"ccap_arb\"", "\"arb_id\"")]
        public decimal Ccap_Arb_Arb_Id { get; set; }

        [DwColumn("\"ccap_arb_sec3_detail_truck\"", "\"asd_selection\"")]
        public string Ccap_Arb_Sec3_Detail_Truck_Asd_Selection { get; set; }

        [StringLength(50)]
        [DwColumn("\"ccap_arb_sec3_detail_truck\"", "\"asd_eng_mfg\"")]
        public string Ccap_Arb_Sec3_Detail_Truck_Asd_Eng_Mfg { get; set; }

        [DwColumn("\"ccap_arb_sec3_detail_truck\"", "\"asd_eng_mod_year\"")]
        public decimal? Ccap_Arb_Sec3_Detail_Truck_Asd_Eng_Mod_Year { get; set; }

        [StringLength(15)]
        [DwColumn("\"ccap_arb_sec3_detail_truck\"", "\"asd_eng_hp\"")]
        public string Ccap_Arb_Sec3_Detail_Truck_Asd_Eng_Hp { get; set; }

        [DwColumn("[ASD_FUEL_TYPE]")]
        public string Asd_Fuel_Type { get; set; }

        [DwColumn("[ASD_FUEL_TYPE_REP]")]
        public string Asd_Fuel_Type_Rep { get; set; }

    }

}