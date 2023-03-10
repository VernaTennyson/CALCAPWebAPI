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
    [DataWindow("d_lender_events", DwStyle.Default)]
    [Table("ABS_EVN_EVENTS")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_EVN_EVENTS\" \r\n "
                  +"WHERE \"ABS_EVN_EVENTS\".\"EVN_LEN_ID\" = :a_len_id")]
    #endregion
    [DwParameter("a_len_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Lender_Events
    {
        [Key]
        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_ID\"")]
        public decimal Evn_Id { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Event), AutoRetrieve = true)]
        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_CODE\"")]
        public string Evn_Code { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_STATUS\"")]
        public string Evn_Status { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_DATE\"", TypeName = "datetime2")]
        public DateTime? Evn_Date { get; set; }

        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_ASSIGNED\"")]
        public decimal? Evn_Assigned { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_NOTE\"")]
        public string Evn_Note { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_LEN_ID\"")]
        public decimal? Evn_Len_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlCompute("' ' usernum")]
        public string Usernum { get; set; }

    }

}