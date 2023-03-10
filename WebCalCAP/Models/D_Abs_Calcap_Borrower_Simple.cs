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
    [DataWindow("d_abs_calcap_borrower_simple", DwStyle.Default)]
    [Table("ABS_BOR_BORROWER")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_bor_borrower\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Calcap_Borrower_Simple
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_BOR_SEQ])")]
        [DwColumn("abs_bor_borrower", "bor_id")]
        public decimal Bor_Id { get; set; }

        [StringLength(200)]
        [DwColumn("abs_bor_borrower", "bor_name")]
        public string Bor_Name { get; set; }

        [StringLength(200)]
        [DwColumn("abs_bor_borrower", "bor_city")]
        public string Bor_City { get; set; }

        [DwChild("Cou_Id", "Cou_Name", typeof(Dddw_Counties), AutoRetrieve = true)]
        [DwColumn("abs_bor_borrower", "bor_county")]
        public decimal? Bor_County { get; set; }

        [StringLength(5)]
        [DwColumn("abs_bor_borrower", "bor_zip")]
        public string Bor_Zip { get; set; }

        [DwColumn("abs_bor_borrower", "bor_zip_4")]
        public string Bor_Zip_4 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs_bor_borrower", "created_by")]
        public string Created_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs_bor_borrower", "creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs_bor_borrower", "last_updated_by")]
        public string Last_Updated_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs_bor_borrower", "last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [DwColumn("abs_bor_borrower", "bor_type_of_business")]
        public string Bor_Type_Of_Bus { get; set; }

        [DwColumn("abs_bor_borrower", "bor_dba")]
        public string Abs_Bor_Borrower_Bor_Dba { get; set; }

        [DwColumn("abs_bor_borrower", "bor_address")]
        public string Bor_Address { get; set; }

        [DwColumn("abs_bor_borrower", "bor_phone")]
        public string Bor_Phone { get; set; }

        [DwColumn("abs_bor_borrower", "bor_fax")]
        public string Bor_Fax { get; set; }

        [DwColumn("abs_bor_borrower", "bor_year_bus_incorp")]
        public decimal? Bor_Year_Bus_Incorp { get; set; }

    }

}