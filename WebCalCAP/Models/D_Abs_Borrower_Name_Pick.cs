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
    [DataWindow("d_abs_borrower_name_pick", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT DISTINCT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_BOR_BORROWER\", \r\n "
                  +"\"ABS_LOA_LOANS\" \r\n "
                  +"WHERE ( \"ABS_BOR_BORROWER\".\"BOR_ID\" = \"ABS_LOA_LOANS\".\"LOA_BOR_ID\" ) and \r\n "
                  +"( ( Upper(\"ABS_BOR_BORROWER\".\"BOR_NAME\") like Upper(:a_bor) + '%' ) )")]
    #endregion
    [DwParameter("a_bor", typeof(string))]
    [DwSort("bor_name A")]
    public class D_Abs_Borrower_Name_Pick
    {
        [StringLength(200)]
        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_NAME\"")]
        public string Bor_Name { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_ID\"")]
        public decimal Bor_Id { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_CITY\"")]
        public string Bor_City { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_COUNTY\"")]
        public decimal? Bor_County { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_ZIP\"")]
        public string Bor_Zip { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_ZIP_4\"")]
        public string Bor_Zip_4 { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_TYPE_OF_BUSINESS\"")]
        public string Bor_Type_Of_Bus { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_DBA\"")]
        public string Bor_Dba { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_ADDRESS\"")]
        public string Bor_Address { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_PHONE\"")]
        public string Bor_Phone { get; set; }

        [DwColumn("\"ABS_BOR_BORROWER\"", "\"BOR_FAX\"")]
        public string Bor_Fax { get; set; }

    }

}