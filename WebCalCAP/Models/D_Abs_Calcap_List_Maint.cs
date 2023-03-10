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
    [DataWindow("d_abs_calcap_list_maint", DwStyle.Default)]
    [Table("COM_LOV")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"com_lov\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"COM_LOV\\\".\\\"LOV_LOV_DOMAIN\\\"\"   OP =\"=\"    EXP2 =\":a_domain\" ) ) ARG(NAME = \"a_domain\" TYPE = string)")]
    #endregion
    [DwParameter("a_domain", typeof(string))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Calcap_List_Maint
    {
        [ConcurrencyCheck]
        [DwColumn("com_lov", "lov_lov_cd")]
        public string Lov_Lov_Cd { get; set; }

        [ConcurrencyCheck]
        [StringLength(100)]
        [DwColumn("com_lov", "lov_lov_description")]
        public string Lov_Lov_Description { get; set; }

        [ConcurrencyCheck]
        [DwColumn("com_lov", "lov_lov_active")]
        public string Lov_Lov_Active { get; set; }

        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(NEXT VALUE FOR [COMMON].[COM_LOV_SEQ])")]
        [DwColumn("com_lov", "lov_lov_id")]
        public decimal Lov_Lov_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("com_lov", "lov_lov_domain")]
        public string Lov_Lov_Domain { get; set; }

    }

}