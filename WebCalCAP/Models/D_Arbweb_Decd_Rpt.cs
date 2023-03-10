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
    [DataWindow("d_arbweb_decd_rpt", DwStyle.Default)]
    [Table("ccap_arb", Schema = "calcapweb")]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ccap_arb_sec3_detail_decd\" , \r\n "
                  +"\"ccap_arb\" \r\n "
                  +"WHERE ( \"ccap_arb_sec3_detail_decd\".\"asd_arb_id_fk\" = \"ccap_arb\".\"arb_id\" ) and          ( ( \"ccap_arb\".\"arb_id\"= :a_arb_id ) )")]
    #endregion
    [DwParameter("a_arb_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Arbweb_Decd_Rpt
    {
        [Key]
        [DwColumn("\"ccap_arb\"", "\"arb_id\"")]
        public decimal Ccap_Arb_Arb_Id { get; set; }

        [StringLength(50)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ccap_arb_sec3_detail_decd\"", "\"asd_decd_mfg_mod_name\"")]
        public string Ccap_Arb_Sec3_Detail_Decd_Asd_Decd_Mfg_Mod_Name { get; set; }

        [StringLength(50)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ccap_arb_sec3_detail_decd\"", "\"asd_decd_tech_type\"")]
        public string Ccap_Arb_Sec3_Detail_Decd_Asd_Decd_Tech_Type { get; set; }

        [Identity]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ccap_arb_sec3_detail_decd\"", "\"asd_pk\"")]
        public decimal Ccap_Arb_Sec3_Detail_Decd_Asd_Pk { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ccap_arb_sec3_detail_decd\"", "\"asd_arb_id_fk\"")]
        public decimal? Ccap_Arb_Sec3_Detail_Decd_Asd_Arb_Id_Fk { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[ASD_LEA_ID]")]
        public decimal? Asd_Lea_Id { get; set; }

    }

}