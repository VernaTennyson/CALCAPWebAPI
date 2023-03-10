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
    [DataWindow("dddw_loan", DwStyle.Default)]
    [Table("ABS_LOA_LOANS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_loa_loans\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dddw_Loan
    {
        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_LOA_SEQ])")]
        [DwColumn("abs_loa_loans", "loa_id")]
        public decimal Loa_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_loa_loans", "loa_calcap_loan_num")]
        public string Loa_Calcap_Loan_Num { get; set; }

    }

}