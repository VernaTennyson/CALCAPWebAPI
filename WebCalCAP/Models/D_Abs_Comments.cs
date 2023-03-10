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
    [DataWindow("d_abs_comments", DwStyle.Default)]
    [Table("ABS_COM_COMMENTS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_com_comments\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ABS_COM_COMMENTS\\\".\\\"COM_TYPE\\\"\"   OP =\"=\"    EXP2 =\":p_type\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"\\\"ABS_COM_COMMENTS\\\".\\\"COM_LOA_ID\\\"\"   OP =\"=\"    EXP2 =\":p_loa_id\" ) ) ARG(NAME = \"p_loa_id\" TYPE = number)  ARG(NAME = \"p_type\" TYPE = string)")]
    #endregion
    [DwParameter("p_loa_id", typeof(double?))]
    [DwParameter("p_type", typeof(string))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Comments
    {
        [ConcurrencyCheck]
        [StringLength(1000)]
        [DwColumn("abs_com_comments", "com_comments")]
        public string Com_Comments { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_com_comments", "com_loa_id")]
        public decimal Com_Loa_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(16)]
        [DwColumn("abs_com_comments", "com_type")]
        public string Com_Type { get; set; }

        [Key]
        [DwColumn("abs_com_comments", "com_id")]
        public decimal Com_Id { get; set; }

    }

}