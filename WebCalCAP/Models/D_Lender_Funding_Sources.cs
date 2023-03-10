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
    [DataWindow("d_lender_funding_sources", DwStyle.Default)]
    [Table("ABS_LFS_LENDER_FUNDING_SOURCES")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_lfs_lender_funding_sources\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ABS_LFS_LENDER_FUNDING_SOURCES\\\".\\\"LFS_LEN_ID\\\"\"   OP =\"=\"    EXP2 =\":a_len_id\" ) ) ARG(NAME = \"a_len_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_len_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Lender_Funding_Sources
    {
        [PropertySave(SaveStrategy.Ignore)]
        [SqlCompute("' ' usernum")]
        public string Usernum { get; set; }

        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_lfs_lender_funding_sources", "lfs_id")]
        public decimal Lfs_Id { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Lender_Funding), AutoRetrieve = true)]
        [DwColumn("abs_lfs_lender_funding_sources", "lfs_lender_fund_type")]
        public string Lfs_Lender_Fund_Type { get; set; }

        [DwColumn("abs_lfs_lender_funding_sources", "lfs_len_id")]
        public decimal? Lfs_Len_Id { get; set; }

    }

}