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
    [DataWindow("d_abs_borrower_maint_list", DwStyle.Default)]
    [Table("ABS_BOR_BORROWER")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_BOR_BORROWER\"")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Borrower_Maint_List
    {
        [Key]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_ID\"")]
        public decimal Bor_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_NAME\"")]
        public string Bor_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(120)]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_CITY\"")]
        public string Bor_City { get; set; }

        [ConcurrencyCheck]
        [DwChild("Cou_Id", "Cou_Name", typeof(Dddw_Counties), AutoRetrieve = true)]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_COUNTY\"")]
        public decimal? Bor_County { get; set; }

        [ConcurrencyCheck]
        [StringLength(5)]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_ZIP\"")]
        public string Bor_Zip { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_ZIP_4\"")]
        public string Bor_Zip_4 { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_TYPE_OF_BUSINESS\"")]
        public string Bor_Type_Of_Business { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_DBA\"")]
        public string Bor_Dba { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_ADDRESS\"")]
        public string Bor_Address { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_PHONE\"")]
        public string Bor_Phone { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_FAX\"")]
        public string Bor_Fax { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_YEAR_BUS_INCORP\"")]
        public decimal? Bor_Year_Bus_Incorp { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_NAME_RESP_PERSON\"")]
        public string Bor_Name_Resp_Person { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_TITLE\"")]
        public string Bor_Title { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"CREATED_BY\"")]
        public string Created_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"CREATION_DATE\"", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"LAST_UPDATED_BY\"")]
        public string Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"LAST_UPDATE_DATE\"", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_ASSEMBLY_DIST\"")]
        public decimal? Bor_Assembly_Dist { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_SENATE_DIST\"")]
        public decimal? Bor_Senate_Dist { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_CONGRESS_DIST\"")]
        public decimal? Bor_Congress_Dist { get; set; }

    }

}