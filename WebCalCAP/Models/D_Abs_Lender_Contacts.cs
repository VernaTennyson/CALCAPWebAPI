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
    [DataWindow("d_abs_lender_contacts", DwStyle.Default)]
    [Table("ABS_LCT_LENDER_CONTACTS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_lct_lender_contacts\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ABS_LCT_LENDER_CONTACTS\\\".\\\"LCT_LEN_ID\\\"\"   OP =\"=\"    EXP2 =\":a_len_id\" ) ) ARG(NAME = \"a_len_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_len_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Lender_Contacts
    {
        [Key]
        [DwColumn("abs_lct_lender_contacts", "lct_id")]
        public decimal Lct_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_name")]
        public string Ltc_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_phone1_area_code")]
        public decimal? Ltc_Phone1_Area_Code { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_email")]
        public string Ltc_Email { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_address_line1")]
        public string Ltc_Address_Line1 { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_address_line2")]
        public string Ltc_Address_Line2 { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_phone1_number")]
        public decimal? Ltc_Phone1_Number { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_city")]
        public string Ltc_City { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_state")]
        public string Ltc_State { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_zip_code")]
        public string Ltc_Zip_Code { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Lender_Contact_Type), AutoRetrieve = true)]
        [DwColumn("abs_lct_lender_contacts", "ltc_contact_type")]
        public string Ltc_Contact_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "ltc_phone1_extension")]
        public decimal? Ltc_Phone1_Extension { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lct_lender_contacts", "lct_len_id")]
        public decimal? Lct_Len_Id { get; set; }

    }

}