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
    [DataWindow("d_calcapweb_fia_search", DwStyle.Grid)]
    [Table("CCAP_FIA_INSTITUTION")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"CCAP_FIA_INSTITUTION\" \r\n "
                  +"WHERE \"CCAP_FIA_INSTITUTION\".\"TRANSMITTED_DATE\" is null")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Calcapweb_Fia_Search
    {
        [Key]
        [DwColumn("\"CCAP_FIA_INSTITUTION\"", "\"FIA_ID\"")]
        public decimal Fia_Id { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_FIA_INSTITUTION\"", "\"FIA_NAME\"")]
        public string Fia_Name { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_FIA_INSTITUTION\"", "\"FIA_ADDRESS\"")]
        public string Fia_Address { get; set; }

        [StringLength(40)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_FIA_INSTITUTION\"", "\"FIA_CITY\"")]
        public string Fia_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_FIA_INSTITUTION\"", "\"FIA_STATE\"")]
        public string Fia_State { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_FIA_INSTITUTION\"", "\"FIA_ZIP\"")]
        public string Fia_Zip { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_FIA_INSTITUTION\"", "\"FIA_CON_PERSON\"")]
        public string Fia_Con_Person { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"CCAP_FIA_INSTITUTION\"", "\"FIA_CON_TITLE\"")]
        public string Fia_Con_Title { get; set; }

        [DwColumn("\"CCAP_FIA_INSTITUTION\"", "\"TRANSMITTED_DATE\"", TypeName = "datetime2")]
        public DateTime? Transmitted_Date { get; set; }

    }

}