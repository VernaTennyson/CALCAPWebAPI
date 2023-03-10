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
    [DataWindow("d_ddlb_lender", DwStyle.Grid)]
    [Table("ABS_LEN_LENDER")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_len_lender\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwSort("len_name A")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Ddlb_Lender
    {
        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("abs_len_lender", "len_name")]
        public string Len_Name { get; set; }

        [Key]
        [DwColumn("abs_len_lender", "len_id")]
        public decimal Len_Id { get; set; }

    }

}