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
    [DataWindow("d_abs_reb_events", DwStyle.Default)]
    [Table("abs_evn_events", Schema = "abs")]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"abs_evn_events\" \r\n "
                  +"WHERE ( \"ABS_EVN_EVENTS\".\"EVN_REB_ID\" = :a_cla_id )")]
    #endregion
    [DwParameter("a_cla_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Reb_Events
    {
        [Key]
        [DwColumn("\"abs_evn_events\"", "\"evn_id\"")]
        public decimal Evn_Id { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Event), AutoRetrieve = true)]
        [DwColumn("\"abs_evn_events\"", "\"evn_code\"")]
        public string Evn_Code { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Event_Status), AutoRetrieve = true)]
        [DwColumn("\"abs_evn_events\"", "\"evn_status\"")]
        public string Evn_Status { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_evn_events\"", "\"evn_date\"", TypeName = "datetime2")]
        public DateTime? Evn_Date { get; set; }

        [ConcurrencyCheck]
        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("\"abs_evn_events\"", "\"evn_assigned\"")]
        public decimal? Evn_Assigned { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_evn_events\"", "\"evn_note\"")]
        public string Evn_Note { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_evn_events\"", "\"evn_cla_id\"")]
        public decimal? Evn_Cla_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"abs_evn_events\"", "\"evn_reb_id\"")]
        public decimal? Evn_Reb_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlCompute("' ' usernum")]
        public string Usernum { get; set; }

    }

}