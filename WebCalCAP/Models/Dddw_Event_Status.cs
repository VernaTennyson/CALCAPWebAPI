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
    [DataWindow("dddw_event_status", DwStyle.Default)]
    [Table("COM_LOV")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"com_lov\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"( LOV_LOV_domain\"   OP =\"=\"    EXP2 =\"'CALCAPEventStatus' )\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"( LOV_LOV_ACTIVE\"   OP =\"=\"    EXP2 =\"'Y' )\" ) )")]
    #endregion
    [DwSort("lov_lov_id A")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dddw_Event_Status
    {
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("com_lov", "lov_lov_cd")]
        public string Lov_Lov_Cd { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("com_lov", "lov_lov_description")]
        public string Lov_Lov_Description { get; set; }

        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(NEXT VALUE FOR [COMMON].[COM_LOV_SEQ])")]
        [DwColumn("com_lov", "lov_lov_id")]
        public decimal Lov_Lov_Id { get; set; }

    }

}