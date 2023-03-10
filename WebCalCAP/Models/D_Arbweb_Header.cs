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
    [DataWindow("d_arbweb_header", DwStyle.Default)]
    [Table("CCAP_ARB")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ccap_arb\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Arbweb_Header
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [CALCAPWEB].[CCAP_ARB_SEQ])")]
        [DwColumn("ccap_arb", "arb_id")]
        public decimal Arb_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"CALIFORNIA CAPITAL ACCESS PROGRAM\\r\\nCalifornia Pollution Control Financing Authority\\r\\nCalCAP@treasurer.ca.gov\\r\\n(916) 654-5610\\\"")]
        public object Compute_1 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Mailing Address: P.O. Box 942809\\r\\nSacramento, CA 94209-0001\\r\\nFax (916) 589-2805\\\"")]
        public object Compute_2 { get; set; }

    }

}