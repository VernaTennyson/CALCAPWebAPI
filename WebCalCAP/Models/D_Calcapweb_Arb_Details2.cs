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
    [DataWindow("d_calcapweb_arb_details2", DwStyle.Default)]
    [Table("CCAP_ARB", Schema = "CALCAPWEB")]
    #region DwSelectAttribute  
    [DwSelect("SELECT DISTINCT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +" \r\n "
                  +"FROM \"CCAP_ARB\" \r\n "
                  +" \r\n "
                  +"LEFT JOIN         \"CCAP_ARB_SEC3_DETAIL_DECD\" on ccap_arb.arb_id = ccap_arb_sec3_detail_decd.asd_arb_id_fk \r\n "
                  +"LEFT JOIN         \"CCAP_ARB_SEC3_DETAIL_TRL\" on   ccap_arb.arb_id = ccap_arb_sec3_detail_trl.ASD_ARB_ID_FK \r\n "
                  +"LEFT JOIN       \"CCAP_ARB_SEC3_DETAIL_TRUCK\"  on ccap_arb.arb_id =  ccap_arb_sec3_detail_truck.ASD_ARB_ID_FK \r\n "
                  +"WHERE \r\n "
                  +"( ( \"CCAP_ARB\".\"ARB_ID\" = :a_arb_id )) AND \r\n "
                  +"( \"CCAP_ARB\".\"ARB_TRANSMITTAL_DATE\" is NULL )")]
    #endregion
    [DwParameter("a_arb_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Calcapweb_Arb_Details2
    {
        [Key]
        [DwColumn("\"CCAP_ARB\"", "\"ARB_ID\"")]
        public decimal Ccap_Arb_Arb_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRUCK\"", "\"ASD_PK\"")]
        public decimal? Ccap_Arb_Sec3_Detail_Truck_Asd_Pk { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRUCK\"", "\"ASD_GVWR\"")]
        public decimal? Asd_Gvwr { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRUCK\"", "\"ASD_SELECTION\"")]
        public string Ccap_Arb_Sec3_Detail_Truck_Asd_Selection { get; set; }

        [StringLength(50)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRUCK\"", "\"ASD_ENG_MFG\"")]
        public string Ccap_Arb_Sec3_Detail_Truck_Asd_Eng_Mfg { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRUCK\"", "\"ASD_ENG_MOD_YEAR\"")]
        public decimal? Ccap_Arb_Sec3_Detail_Truck_Asd_Eng_Mod_Year { get; set; }

        [StringLength(15)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRUCK\"", "\"ASD_ENG_HP\"")]
        public string Ccap_Arb_Sec3_Detail_Truck_Asd_Eng_Hp { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRUCK\"", "\"ASD_FUEL_TYPE\"")]
        public string Asd_Fuel_Type { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRUCK\"", "\"ASD_FUEL_TYPE_REP\"")]
        public string Asd_Fuel_Type_Rep { get; set; }

        [StringLength(50)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_DECD\"", "\"ASD_DECD_TECH_TYPE\"")]
        public string Ccap_Arb_Sec3_Detail_Decd_Asd_Decd_Tech_Type { get; set; }

        [StringLength(50)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_DECD\"", "\"ASD_DECD_MFG_MOD_NAME\"")]
        public string Ccap_Arb_Sec3_Detail_Decd_Asd_Decd_Mfg_Mod_Name { get; set; }

        [StringLength(50)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRL\"", "\"ASD_TRL_TRLMFG\"")]
        public string Ccap_Arb_Sec3_Detail_Trl_Asd_Trl_Trlmfg { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRL\"", "\"ASD_TRL_MODL_YEAR\"")]
        public decimal? Ccap_Arb_Sec3_Detail_Trl_Asd_Trl_Modl_Year { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB_SEC3_DETAIL_TRL\"", "\"ASD_TRL_SMRT_CERT\"")]
        public string Ccap_Arb_Sec3_Detail_Trl_Asd_Trl_Smrt_Cert { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB\"", "\"ARB_SEC3_FLTSIZE\"")]
        public decimal? Ccap_Arb_Arb_Sec3_Fltsize { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB\"", "\"ARB_SEC3_GVWR\"")]
        public string Ccap_Arb_Arb_Sec3_Gvwr { get; set; }

        [DwColumn("\"CCAP_ARB\"", "\"ARB_TRANSMITTAL_DATE\"", TypeName = "datetime2")]
        public DateTime? Ccap_Arb_Arb_Transmittal_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB\"", "\"ARB_LEA_ID\"")]
        public decimal Ccap_Arb_Arb_Lea_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_ARB\"", "\"ARB_NON_COMP\"")]
        public string Arb_Non_Comp { get; set; }

    }

}