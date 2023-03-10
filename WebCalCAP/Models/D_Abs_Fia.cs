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
    [DataWindow("d_abs_fia", DwStyle.Default)]
    [Table("abs_len_lender")]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +" \r\n "
                  +"FROM \"abs_len_lender\" \r\n "
                  +"WHERE ( \"ABS_LEN_LENDER\".\"LEN_LENDOR_NUMBER\" = :a_lender_number )")]
    #endregion
    [DwParameter("a_lender_number", typeof(string))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Fia
    {
        [Key]
        [DwColumn("\"abs_len_lender\"", "\"len_id\"")]
        public decimal Len_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("\"abs_len_lender\"", "\"len_name\"")]
        public string Len_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_app_rcvd_dt\"", TypeName = "datetime2")]
        public DateTime? Len_App_Rcvd_Dt { get; set; }

        [ConcurrencyCheck]
        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"abs_len_lender\"", "\"len_app_rcvd_by\"")]
        public decimal? Len_App_Rcvd_By { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Institution_Type), AutoRetrieve = true)]
        [DwColumn("\"abs_len_lender\"", "\"len_institution_type\"")]
        public string Len_Institution_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_cap_surplus\"")]
        public decimal? Len_Cap_Surplus { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_branches\"")]
        public decimal? Len_Branches { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_highline_date\"", TypeName = "datetime2")]
        public DateTime? Len_Highline_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("\"abs_len_lender\"", "\"len_regulatory_agency\"")]
        public string Len_Regulatory_Agency { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_idc_rating_dt\"", TypeName = "datetime2")]
        public DateTime? Len_Idc_Rating_Dt { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("\"abs_len_lender\"", "\"len_insur_agency\"")]
        public string Len_Insur_Agency { get; set; }

        [ConcurrencyCheck]
        [StringLength(8)]
        [DwColumn("\"abs_len_lender\"", "\"len_lendor_number\"")]
        public string Len_Lendor_Number { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_org_id\"")]
        public decimal? Len_Org_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_officer_name\"")]
        public string Len_Officer_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_officer_phone\"")]
        public string Len_Officer_Phone { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_loss_reserve\"")]
        public string Len_Loss_Reserve { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_delivery_method\"")]
        public string Len_Delivery_Method { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_highline_rating\"")]
        public string Len_Highline_Rating { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_idc_rating\"")]
        public string Len_Idc_Rating { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_officer_email\"")]
        public string Len_Officer_Email { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_num_branches\"")]
        public decimal? Len_Num_Branches { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_address_line1\"")]
        public string Len_Address_Line1 { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_city\"")]
        public string Len_City { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_state\"")]
        public string Len_State { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_zip_code\"")]
        public string Len_Zip_Code { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_con_title\"")]
        public string Len_Con_Title { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_con_address\"")]
        public string Len_Con_Address { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_con_city\"")]
        public string Len_Con_City { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_con_zip\"")]
        public string Len_Con_Zip { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_pilr\"")]
        public string Len_Pilr { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_describe_board_of_direct\"")]
        public string Len_Describe_Board_Of_Direct { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_con_fax\"")]
        public string Len_Con_Fax { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_piarb\"")]
        public string Len_Piarb { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_pics\"")]
        public string Len_Pics { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_pievcs\"")]
        public string Len_Pievcs { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"len_con_state\"")]
        public string Len_Con_State { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"LEN_PISEISMIC\"")]
        public string Len_Piseismic { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_len_lender\"", "\"LEN_PIADA\"")]
        public string Len_Piada { get; set; }

    }

}