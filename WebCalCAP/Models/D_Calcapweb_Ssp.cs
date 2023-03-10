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
    [DataWindow("d_calcapweb_ssp", DwStyle.Default)]
    [Table("CCAP_SEIS_SAFE", Schema = "CALCAPWEB")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"CALCAPWEB\".\"CCAP_SEIS_SAFE\" \r\n "
                  +"WHERE ( \"CALCAPWEB\".\"CCAP_SEIS_SAFE\".\"SEIS_ID\" = :a_ssp_id )   AND \r\n "
                  +"( \"CALCAPWEB\".\"CCAP_SEIS_SAFE\".\"SEIS_TRANSMITTAL_DATE\" is null )")]
    #endregion
    [DwParameter("a_ssp_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Calcapweb_Ssp
    {
        [Key]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_ID\"")]
        public decimal Seis_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_LENDER_ID\"")]
        public decimal? Seis_Lender_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_CREATION_DATE\"", TypeName = "datetime2")]
        public DateTime? Seis_Creation_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_CREATED_BY\"")]
        public string Seis_Created_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_LAST_UPDATE_DATE\"", TypeName = "datetime2")]
        public DateTime? Seis_Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_LAST_UPDATED_BY\"")]
        public string Seis_Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_LEA_FK\"")]
        public decimal Seis_Lea_Fk { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_APP_TYPE\"")]
        public string Seis_App_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_TRANSMITTAL_DATE\"", TypeName = "datetime2")]
        public DateTime? Seis_Transmittal_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_BUS_SEL\"")]
        public string Seis_Bus_Sel { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_BLDG_CERT\"")]
        public string Seis_Bldg_Cert { get; set; }

        [ConcurrencyCheck]
        [StringLength(100)]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_BLDG_RET\"")]
        public string Seis_Bldg_Ret { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_QUAL_BLDG\"")]
        public string Seis_Qual_Bldg { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_QUAL_BLDG_UNITS\"")]
        public decimal? Seis_Qual_Bldg_Units { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_DESC_ELI_CST\"")]
        public string Seis_Desc_Eli_Cst { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_OTH_SEIS\"")]
        public string Seis_Oth_Seis { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_OTH_SEIS_AMT\"")]
        public decimal? Seis_Oth_Seis_Amt { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_PUB_ENT\"")]
        public string Seis_Pub_Ent { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_PUB_ENT_YES\"")]
        public string Seis_Pub_Ent_Yes { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"SEIS_END_COV\"")]
        public string Seis_End_Cov { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"CALCAPWEB\".\"CCAP_SEIS_SAFE\"", "\"ROWID\"")]
        public Guid Rowid { get; set; }

    }

}