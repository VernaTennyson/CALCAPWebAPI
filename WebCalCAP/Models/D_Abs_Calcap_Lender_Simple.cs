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
    [DataWindow("d_abs_calcap_lender_simple", DwStyle.Default)]
    [Table("ABS_LEN_LENDER")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_len_lender\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Calcap_Lender_Simple
    {
        [Key]
        [DwColumn("abs_len_lender", "len_id")]
        public decimal Len_Id { get; set; }

        [StringLength(200)]
        [DwColumn("abs_len_lender", "len_name")]
        public string Len_Name { get; set; }

        [DwColumn("abs_len_lender", "len_app_rcvd_dt", TypeName = "datetime2")]
        public DateTime? Len_App_Rcvd_Dt { get; set; }

        [DwColumn("abs_len_lender", "len_delivery_method")]
        public string Len_Delivery_Method { get; set; }

        [DwColumn("abs_len_lender", "len_app_rcvd_by")]
        public decimal? Len_App_Rcvd_By { get; set; }

        [DwColumn("abs_len_lender", "len_institution_type")]
        public string Len_Institution_Type { get; set; }

        [DwColumn("abs_len_lender", "len_cap_surplus")]
        public decimal? Len_Cap_Surplus { get; set; }

        [DwColumn("abs_len_lender", "len_branches")]
        public decimal? Len_Branches { get; set; }

        [DwColumn("abs_len_lender", "len_highline_rating")]
        public string Len_Highline_Rating { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "len_highline_date", TypeName = "datetime2")]
        public DateTime? Len_Highline_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "len_regulatory_agency")]
        public string Len_Regulatory_Agency { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "len_idc_rating")]
        public string Len_Idc_Rating { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "len_idc_rating_dt", TypeName = "datetime2")]
        public DateTime? Len_Idc_Rating_Dt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "len_insur_agency")]
        public string Len_Insur_Agency { get; set; }

        [StringLength(80)]
        [DwColumn("abs_len_lender", "len_lendor_number")]
        public string Len_Lendor_Number { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "created_by")]
        public string Created_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "last_updated_by")]
        public string Last_Updated_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "len_org_id")]
        public decimal? Len_Org_Id { get; set; }

        [DwColumn("abs_len_lender", "len_officer_name")]
        public string Len_Officer_Name { get; set; }

        [DwColumn("abs_len_lender", "len_officer_phone")]
        public string Len_Officer_Phone { get; set; }

        [DwColumn("abs_len_lender", "len_loss_reserve")]
        public string Len_Loss_Reserve { get; set; }

    }

}