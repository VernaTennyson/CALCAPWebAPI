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
    [DataWindow("d_borrower", DwStyle.Default)]
    [Table("ABS_BOR_BORROWER")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_bor_borrower\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"( \\\"ABS_BOR_BORROWER\\\".\\\"BOR_ID\\\"\"   OP =\"=\"    EXP2 =\":a_bor_id )\" ) ) ARG(NAME = \"a_bor_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_bor_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Borrower
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_BOR_SEQ])")]
        [DwChild("Bor_Id", "Bor_Name", typeof(Dddw_Borrower), AutoRetrieve = true)]
        [DwColumn("abs_bor_borrower", "bor_id")]
        public decimal Bor_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("abs_bor_borrower", "bor_name")]
        public string Bor_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("abs_bor_borrower", "bor_city")]
        public string Bor_City { get; set; }

        [ConcurrencyCheck]
        [DwChild("Cou_Id", "Cou_Name", typeof(Dddw_Counties), AutoRetrieve = true)]
        [DwColumn("abs_bor_borrower", "bor_county")]
        public decimal? Bor_County { get; set; }

        [ConcurrencyCheck]
        [StringLength(5)]
        [DwColumn("abs_bor_borrower", "bor_zip")]
        public string Bor_Zip { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_bor_borrower", "bor_zip_4")]
        public string Bor_Zip_4 { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_bor_borrower", "bor_type_of_business")]
        public string Bor_Type_Of_Business { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_bor_borrower", "bor_dba")]
        public string Bor_Dba { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_bor_borrower", "bor_address")]
        public string Bor_Address { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_bor_borrower", "bor_phone")]
        public string Bor_Phone { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_bor_borrower", "bor_fax")]
        public string Bor_Fax { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_bor_borrower", "bor_year_bus_incorp")]
        public decimal? Bor_Year_Bus_Incorp { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_bor_borrower", "bor_name_resp_person")]
        public string Bor_Name_Resp_Person { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_bor_borrower", "bor_title")]
        public string Bor_Title { get; set; }

    }

}