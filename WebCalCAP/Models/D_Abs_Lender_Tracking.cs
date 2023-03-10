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
    [DataWindow("d_abs_lender_tracking", DwStyle.Default)]
    [Table("ABS_LEN_LENDER")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_LEN_LENDER\"")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Lender_Tracking
    {
        [Key]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ID\"")]
        public decimal Len_Id { get; set; }

        [StringLength(200)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_NAME\"")]
        public string Len_Name { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_APP_RCVD_DT\"", TypeName = "datetime2")]
        public DateTime? Len_App_Rcvd_Dt { get; set; }

        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_APP_RCVD_BY\"")]
        public decimal? Len_App_Rcvd_By { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_INSTITUTION_TYPE\"")]
        public string Len_Institution_Type { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CAP_SURPLUS\"")]
        public decimal? Len_Cap_Surplus { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_BRANCHES\"")]
        public decimal? Len_Branches { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_HIGHLINE_DATE\"", TypeName = "datetime2")]
        public DateTime? Len_Highline_Date { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_REGULATORY_AGENCY\"")]
        public string Len_Regulatory_Agency { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_IDC_RATING_DT\"", TypeName = "datetime2")]
        public DateTime? Len_Idc_Rating_Dt { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_INSUR_AGENCY\"")]
        public string Len_Insur_Agency { get; set; }

        [StringLength(8)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_LENDOR_NUMBER\"")]
        public string Len_Lendor_Number { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ORG_ID\"")]
        public decimal? Len_Org_Id { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_OFFICER_NAME\"")]
        public string Len_Officer_Name { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_OFFICER_PHONE\"")]
        public string Len_Officer_Phone { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_LOSS_RESERVE\"")]
        public string Len_Loss_Reserve { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_DELIVERY_METHOD\"")]
        public string Len_Delivery_Method { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_HIGHLINE_RATING\"")]
        public string Len_Highline_Rating { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_IDC_RATING\"")]
        public string Len_Idc_Rating { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_OFFICER_EMAIL\"")]
        public string Len_Officer_Email { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Lender_Status), AutoRetrieve = true)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_STATUS\"")]
        public string Len_Status { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Lender_Funding), AutoRetrieve = true)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_FUND_TYPE\"")]
        public string Len_Fund_Type { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_NUM_BRANCHES\"")]
        public decimal? Len_Num_Branches { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ADDRESS_LINE1\"")]
        public string Len_Address_Line1 { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ADDRESS_LINE2\"")]
        public string Len_Address_Line2 { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CITY\"")]
        public string Len_City { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_STATE\"")]
        public string Len_State { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ZIP_CODE\"")]
        public string Len_Zip_Code { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_EIN\"")]
        public decimal? Len_Ein { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlCompute("' ' decoy")]
        public string Decoy { get; set; }

        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_INSTITUTION_TYPE_MULTI\"")]
        public string Len_Institution_Type_Multi { get; set; }

    }

}