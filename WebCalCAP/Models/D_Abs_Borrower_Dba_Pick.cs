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
    [DataWindow("d_abs_borrower_dba_pick", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT DISTINCT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"abs_bor_borrower\" ,           \"abs_loa_loans\" \r\n "
                  +"WHERE ( \"abs_bor_borrower\".\"bor_id\" = \"abs_loa_loans\".\"loa_bor_id\" ) and          ( ( Upper(\"ABS_BOR_BORROWER\".\"BOR_DBA\") like Upper(:a_bor) + '%' ) )")]
    #endregion
    [DwParameter("a_bor", typeof(string))]
    [DwSort("bor_dba A")]
    public class D_Abs_Borrower_Dba_Pick
    {
        [DwColumn("\"abs_bor_borrower\"", "\"bor_dba\"")]
        public string Bor_Dba { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_name\"")]
        public string Bor_Name { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_id\"")]
        public decimal Bor_Id { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_city\"")]
        public string Bor_City { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_county\"")]
        public decimal? Bor_County { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_zip\"")]
        public string Bor_Zip { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_zip_4\"")]
        public string Bor_Zip_4 { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_type_of_business\"")]
        public string Bor_Type_Of_Bus { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_address\"")]
        public string Bor_Address { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_phone\"")]
        public string Bor_Phone { get; set; }

        [DwColumn("\"abs_bor_borrower\"", "\"bor_fax\"")]
        public string Bor_Fax { get; set; }

    }

}