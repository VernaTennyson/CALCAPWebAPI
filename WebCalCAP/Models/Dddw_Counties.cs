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
    [DataWindow("dddw_counties", DwStyle.Default)]
    [Table("COM_COU_COUNTIES")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"com_cou_counties\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dddw_Counties
    {
        [Key]
        [DwColumn("com_cou_counties", "cou_id")]
        public decimal Cou_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("com_cou_counties", "cou_name")]
        public string Cou_Name { get; set; }

    }

}