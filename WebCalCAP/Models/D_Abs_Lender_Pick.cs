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
    [DataWindow("d_abs_lender_pick", DwStyle.Grid)]
    [Table("ABS_LEN_LENDER")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_LEN_LENDER\" \r\n "
                  +"WHERE Upper(\"ABS_LEN_LENDER\".\"LEN_NAME\") like Upper(:a_len) + '%'")]
    #endregion
    [DwParameter("a_len", typeof(string))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Lender_Pick
    {
        [Key]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ID\"")]
        public decimal Len_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_NAME\"")]
        public string Len_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_LENDOR_NUMBER\"")]
        public string Len_Lendor_Number { get; set; }

        [ConcurrencyCheck]
        [StringLength(100)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_OFFICER_NAME\"")]
        public string Len_Officer_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_OFFICER_PHONE\"")]
        public string Len_Officer_Phone { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_STATUS\"")]
        public string Len_Status { get; set; }

    }

}