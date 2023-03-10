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
    [DataWindow("d_lender", DwStyle.Default)]
    [Table("ABS_LEN_LENDER")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_len_lender\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"( \\\"ABS_LEN_LENDER\\\".\\\"LEN_ID\\\"\"   OP =\"=\"    EXP2 =\":a_len_id )\" ) ) ARG(NAME = \"a_len_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_len_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Lender
    {
        [Key]
        [DwColumn("abs_len_lender", "len_id")]
        public decimal Len_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("abs_len_lender", "len_name")]
        public string Len_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_app_rcvd_dt", TypeName = "datetime2")]
        public DateTime? Len_App_Rcvd_Dt { get; set; }

        [ConcurrencyCheck]
        [DwChild("Staff_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("abs_len_lender", "len_app_rcvd_by")]
        public decimal? Len_App_Rcvd_By { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Institution_Type), AutoRetrieve = true)]
        [DwColumn("abs_len_lender", "len_institution_type")]
        public string Len_Institution_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_cap_surplus")]
        public decimal? Len_Cap_Surplus { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_branches")]
        public decimal? Len_Branches { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_highline_date", TypeName = "datetime2")]
        public DateTime? Len_Highline_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_regulatory_agency")]
        public string Len_Regulatory_Agency { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_idc_rating_dt", TypeName = "datetime2")]
        public DateTime? Len_Idc_Rating_Dt { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("abs_len_lender", "len_insur_agency")]
        public string Len_Insur_Agency { get; set; }

        [ConcurrencyCheck]
        [StringLength(8)]
        [DwColumn("abs_len_lender", "len_lendor_number")]
        public string Len_Lendor_Number { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_org_id")]
        public decimal? Len_Org_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_loss_reserve")]
        public string Len_Loss_Reserve { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_officer_name")]
        public string Len_Officer_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_officer_phone")]
        public string Len_Officer_Phone { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_delivery_method")]
        public string Len_Delivery_Method { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_highline_rating")]
        public string Len_Highline_Rating { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_len_lender", "len_idc_rating")]
        public string Len_Idc_Rating { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "len_officer_email")]
        public string Len_Officer_Email { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("abs_len_lender", "len_status")]
        public string Len_Status { get; set; }

    }

}