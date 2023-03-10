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
    [DataWindow("dddw_borrower", DwStyle.Default)]
    [Table("ABS_BOR_BORROWER")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_bor_borrower\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [DwSort("bor_name A")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dddw_Borrower
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_BOR_SEQ])")]
        [DwColumn("abs_bor_borrower", "bor_id")]
        public decimal Bor_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("abs_bor_borrower", "bor_name")]
        public string Bor_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_bor_borrower", "bor_city")]
        public string Bor_City { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_bor_borrower", "bor_county")]
        public decimal? Bor_County { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_bor_borrower", "bor_zip")]
        public string Bor_Zip { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_bor_borrower", "bor_zip_4")]
        public string Bor_Zip_4 { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs_bor_borrower", "created_by")]
        public string Created_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs_bor_borrower", "creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs_bor_borrower", "last_updated_by")]
        public string Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs_bor_borrower", "last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_bor_borrower", "bor_type_of_business")]
        public string Bor_Type_Of_Business { get; set; }

    }

}