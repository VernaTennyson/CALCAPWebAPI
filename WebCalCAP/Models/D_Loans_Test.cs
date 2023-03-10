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
    [DataWindow("d_loans_test", DwStyle.Default)]
    [Table("ABS_LOA_LOANS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_loa_loans\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Loans_Test
    {
        [DwColumn("abs_loa_loans", "loa_len_id")]
        public decimal? Loa_Len_Id { get; set; }

        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_LOA_SEQ])")]
        [DwColumn("abs_loa_loans", "loa_id")]
        public decimal Loa_Id { get; set; }

    }

}