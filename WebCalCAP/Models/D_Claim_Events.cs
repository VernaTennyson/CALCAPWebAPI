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
    [DataWindow("d_claim_events", DwStyle.Default)]
    [Table("ABS_EVN_EVENTS")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_EVN_EVENTS\" \r\n "
                  +"WHERE \"ABS_EVN_EVENTS\".\"EVN_CLA_ID\" = :a_cla_id")]
    #endregion
    [DwParameter("a_cla_id", typeof(double?))]
    [DwSort("evn_id A")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Claim_Events
    {
        [Key]
        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_ID\"")]
        public decimal Evn_Id { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Event), AutoRetrieve = true)]
        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_CODE\"")]
        public string Evn_Code { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Event_Status), AutoRetrieve = true)]
        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_STATUS\"")]
        public string Evn_Status { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_DATE\"", TypeName = "datetime2")]
        public DateTime? Evn_Date { get; set; }

        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_ASSIGNED\"")]
        public decimal? Evn_Assigned { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_NOTE\"")]
        public string Evn_Note { get; set; }

        [DwColumn("\"ABS_EVN_EVENTS\"", "\"EVN_CLA_ID\"")]
        public decimal? Evn_Cla_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlCompute("' ' usernum")]
        public string Usernum { get; set; }

    }

}