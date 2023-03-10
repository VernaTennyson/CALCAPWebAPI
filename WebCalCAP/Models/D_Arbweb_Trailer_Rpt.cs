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
    [DataWindow("d_arbweb_trailer_rpt", DwStyle.Default)]
    [Table("CCAP_ARB_SEC3_DETAIL_TRL")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ccap_arb\" )  TABLE(NAME=\"ccap_arb_sec3_detail_trl\" ) @(_COLUMNS_PLACEHOLDER_) JOIN (LEFT=\"ccap_arb_sec3_detail_trl.asd_arb_id_fk\"    OP =\"=\"RIGHT=\"ccap_arb.arb_id\" )WHERE(    EXP1 =\"\\\"CCAP_ARB\\\".\\\"ARB_ID\\\"\"   OP =\"=\"    EXP2 =\":a_arb_id \" ) ) ARG(NAME = \"a_arb_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_arb_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Arbweb_Trailer_Rpt
    {
        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(NEXT VALUE FOR [CALCAPWEB].[CCAP_ARB_SEQ])")]
        [DwColumn("ccap_arb", "arb_id")]
        public decimal Ccap_Arb_Arb_Id { get; set; }

        [StringLength(50)]
        [DwColumn("ccap_arb_sec3_detail_trl", "asd_trl_trlmfg")]
        public string Ccap_Arb_Sec3_Detail_Trl_Asd_Trl_Trlmfg { get; set; }

        [DwColumn("ccap_arb_sec3_detail_trl", "asd_trl_modl_year")]
        public decimal? Ccap_Arb_Sec3_Detail_Trl_Asd_Trl_Modl_Year { get; set; }

        [DwColumn("ccap_arb_sec3_detail_trl", "asd_trl_smrt_cert")]
        public string Ccap_Arb_Sec3_Detail_Trl_Asd_Trl_Smrt_Cert { get; set; }

        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(NEXT VALUE FOR [CALCAPWEB].[CCAP_ARB_SEQ])")]
        [DwColumn("ccap_arb_sec3_detail_trl", "asd_pk")]
        public decimal Ccap_Arb_Sec3_Detail_Trl_Asd_Pk { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_arb_sec3_detail_trl", "asd_arb_id_fk")]
        public decimal? Ccap_Arb_Sec3_Detail_Trl_Asd_Arb_Id_Fk { get; set; }

    }

}