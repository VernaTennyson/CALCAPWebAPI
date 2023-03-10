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
    [DataWindow("d_abs_lender_maint_list", DwStyle.Default)]
    [Table("ABS_LEN_LENDER", Schema = "ABS")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_LEN_LENDER\"")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Lender_Maint_List
    {
        [Key]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ID\"")]
        public decimal Len_Id { get; set; }

        [ConcurrencyCheck]
        [StringLength(200)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_NAME\"")]
        public string Len_Name { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_APP_RCVD_DT\"", TypeName = "datetime2")]
        public DateTime? Len_App_Rcvd_Dt { get; set; }

        [ConcurrencyCheck]
        [DwChild("Staff_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_APP_RCVD_BY\"")]
        public decimal? Len_App_Rcvd_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_INSTITUTION_TYPE\"")]
        public string Len_Institution_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CAP_SURPLUS\"")]
        public decimal? Len_Cap_Surplus { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_BRANCHES\"")]
        public decimal? Len_Branches { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_HIGHLINE_DATE\"", TypeName = "datetime2")]
        public DateTime? Len_Highline_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_REGULATORY_AGENCY\"")]
        public string Len_Regulatory_Agency { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_IDC_RATING_DT\"", TypeName = "datetime2")]
        public DateTime? Len_Idc_Rating_Dt { get; set; }

        [ConcurrencyCheck]
        [StringLength(80)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_INSUR_AGENCY\"")]
        public string Len_Insur_Agency { get; set; }

        [ConcurrencyCheck]
        [StringLength(8)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_LENDOR_NUMBER\"")]
        public string Len_Lendor_Number { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ORG_ID\"")]
        public decimal? Len_Org_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_OFFICER_NAME\"")]
        public string Len_Officer_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_OFFICER_PHONE\"")]
        public string Len_Officer_Phone { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_LOSS_RESERVE\"")]
        public string Len_Loss_Reserve { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_DELIVERY_METHOD\"")]
        public string Len_Delivery_Method { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_HIGHLINE_RATING\"")]
        public string Len_Highline_Rating { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_IDC_RATING\"")]
        public string Len_Idc_Rating { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_OFFICER_EMAIL\"")]
        public string Len_Officer_Email { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_NUM_BRANCHES\"")]
        public decimal? Len_Num_Branches { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ADDRESS_LINE1\"")]
        public string Len_Address_Line1 { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CITY\"")]
        public string Len_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_STATE\"")]
        public string Len_State { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_ZIP_CODE\"")]
        public string Len_Zip_Code { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CON_TITLE\"")]
        public string Len_Con_Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CON_ADDRESS\"")]
        public string Len_Con_Address { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CON_CITY\"")]
        public string Len_Con_City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CON_ZIP\"")]
        public string Len_Con_Zip { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_PILR\"")]
        public string Len_Pilr { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_DESCRIBE_BOARD_OF_DIRECT\"")]
        public string Len_Describe_Board_Of_Direct { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CON_FAX\"")]
        public string Len_Con_Fax { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_PIARB\"")]
        public string Len_Piarb { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_PICS\"")]
        public string Len_Pics { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_PIEVCS\"")]
        public string Len_Pievcs { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_CON_STATE\"")]
        public string Len_Con_State { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_PIADA\"")]
        public string Len_Piada { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ABS_LEN_LENDER\"", "\"LEN_PISEISMIC\"")]
        public string Len_Piseismic { get; set; }

    }

}