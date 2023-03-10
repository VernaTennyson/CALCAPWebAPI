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
    [DataWindow("d_calcap_len_import_adobe", DwStyle.Default)]
    [Table("ABS_LEN_LENDER")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_len_lender\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Calcap_Len_Import_Adobe
    {
        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_app_rcvd_dt", TypeName = "datetime2")]
        public DateTime? Len_App_Rcvd_Dt { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("abs_len_lender", "len_name")]
        public string Len_Name { get; set; }

        [Key]
        [DwColumn("abs_len_lender", "len_id")]
        public decimal Len_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("abs_len_lender", "len_delivery_method")]
        public string Len_Delivery_Method { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_app_rcvd_by")]
        public decimal? Len_App_Rcvd_By { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("abs_len_lender", "len_institution_type")]
        public string Len_Institution_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_cap_surplus")]
        public decimal? Len_Cap_Surplus { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_branches")]
        public decimal? Len_Branches { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("abs_len_lender", "len_highline_rating")]
        public string Len_Highline_Rating { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_highline_date", TypeName = "datetime2")]
        public DateTime? Len_Highline_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("abs_len_lender", "len_regulatory_agency")]
        public string Len_Regulatory_Agency { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("abs_len_lender", "len_idc_rating")]
        public string Len_Idc_Rating { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_idc_rating_dt", TypeName = "datetime2")]
        public DateTime? Len_Idc_Rating_Dt { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("abs_len_lender", "len_insur_agency")]
        public string Len_Insur_Agency { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("abs_len_lender", "len_lendor_number")]
        public string Len_Lendor_Number { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [DwColumn("abs_len_lender", "created_by")]
        public string Created_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [DwColumn("abs_len_lender", "last_updated_by")]
        public string Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_org_id")]
        public decimal? Len_Org_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(100)]
        [DwColumn("abs_len_lender", "len_officer_name")]
        public string Len_Officer_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(20)]
        [DwColumn("abs_len_lender", "len_officer_phone")]
        public string Len_Officer_Phone { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("abs_len_lender", "len_loss_reserve")]
        public string Len_Loss_Reserve { get; set; }

        [ConcurrencyCheck]
        [StringLength(40)]
        [DwColumn("abs_len_lender", "len_officer_email")]
        public string Len_Officer_Email { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("abs_len_lender", "len_status")]
        public string Len_Status { get; set; }

        [ConcurrencyCheck]
        [StringLength(3)]
        [DwColumn("abs_len_lender", "len_fund_type")]
        public string Len_Fund_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_num_branches")]
        public decimal? Len_Num_Branches { get; set; }

        [ConcurrencyCheck]
        [StringLength(40)]
        [DwColumn("abs_len_lender", "len_address_line1")]
        public string Len_Address_Line1 { get; set; }

        [ConcurrencyCheck]
        [StringLength(40)]
        [DwColumn("abs_len_lender", "len_address_line2")]
        public string Len_Address_Line2 { get; set; }

        [ConcurrencyCheck]
        [StringLength(26)]
        [DwColumn("abs_len_lender", "len_city")]
        public string Len_City { get; set; }

        [ConcurrencyCheck]
        [StringLength(2)]
        [DwColumn("abs_len_lender", "len_state")]
        public string Len_State { get; set; }

        [ConcurrencyCheck]
        [StringLength(10)]
        [DwColumn("abs_len_lender", "len_zip_code")]
        public string Len_Zip_Code { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_ein")]
        public decimal? Len_Ein { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("abs_len_lender", "len_institution_type_multi")]
        public string Len_Institution_Type_Multi { get; set; }

    }

}