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
    [DataWindow("d_calcap_ssp", DwStyle.Default)]
    [Table("ccap_seis_safe", Schema = "CALCAPWEB")]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ccap_seis_safe\" \r\n "
                  +"WHERE ( \"CCAP_SEIS_SAFE\".\"SEIS_ID\" = :a_ssp_id )")]
    #endregion
    [DwParameter("a_ssp_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Calcap_Ssp
    {
        [Key]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_id\"")]
        public decimal Seis_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_lender_id\"")]
        public decimal? Seis_Lender_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_creation_date\"", TypeName = "datetime2")]
        public DateTime? Seis_Creation_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_created_by\"")]
        public string Seis_Created_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_last_update_date\"", TypeName = "datetime2")]
        public DateTime? Seis_Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_last_updated_by\"")]
        public string Seis_Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_lea_fk\"")]
        public decimal Seis_Lea_Fk { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_app_type\"")]
        public string Seis_App_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_transmittal_date\"", TypeName = "datetime2")]
        public DateTime? Seis_Transmittal_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_bus_sel\"")]
        public string Seis_Bus_Sel { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_bldg_cert\"")]
        public string Seis_Bldg_Cert { get; set; }

        [ConcurrencyCheck]
        [StringLength(100)]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_bldg_ret\"")]
        public string Seis_Bldg_Ret { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_qual_bldg\"")]
        public string Seis_Qual_Bldg { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_qual_bldg_units\"")]
        public decimal? Seis_Qual_Bldg_Units { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_desc_eli_cst\"")]
        public string Seis_Desc_Eli_Cst { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_oth_seis\"")]
        public string Seis_Oth_Seis { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_oth_seis_amt\"")]
        public decimal? Seis_Oth_Seis_Amt { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_pub_ent\"")]
        public string Seis_Pub_Ent { get; set; }

        [ConcurrencyCheck]
        [StringLength(100)]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_pub_ent_yes\"")]
        public string Seis_Pub_Ent_Yes { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("\"ccap_seis_safe\"", "\"seis_end_cov\"")]
        public string Seis_End_Cov { get; set; }

    }

}