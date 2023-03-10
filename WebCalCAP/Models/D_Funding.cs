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
    [DataWindow("d_funding", DwStyle.Default)]
    [Table("ABS_FND_FUNDS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_fnd_funds\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ABS_FND_FUNDS\\\".\\\"FND_LOA_ID\\\"\"   OP =\"=\"    EXP2 =\":a_loa_id\" ) ) ARG(NAME = \"a_loa_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_loa_id", typeof(double?))]
    [DwSort("abs_fnd_funds_fnd_id A")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Funding
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_FND_SEQ])")]
        [DwColumn("abs_fnd_funds", "fnd_id")]
        public decimal Abs_Fnd_Funds_Fnd_Id { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Funding), AutoRetrieve = true)]
        [DwColumn("abs_fnd_funds", "fnd_type")]
        public string Abs_Fnd_Funds_Fnd_Type { get; set; }

        [DwColumn("abs_fnd_funds", "fnd_loa_id")]
        public decimal Abs_Fnd_Funds_Fnd_Loa_Id { get; set; }

        [DwColumn("abs_fnd_funds", "fnd_amount")]
        public decimal? Abs_Fnd_Funds_Fnd_Amount { get; set; }

        [DwColumn("abs_fnd_funds", "fnd_date", TypeName = "datetime2")]
        public DateTime? Fnd_Date { get; set; }

        [DwColumn("abs_fnd_funds", "fnd_rate")]
        public decimal? Fnd_Rate { get; set; }

    }

}