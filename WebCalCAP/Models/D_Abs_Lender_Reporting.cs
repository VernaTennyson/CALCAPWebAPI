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
    [DataWindow("d_abs_lender_reporting", DwStyle.Default)]
    [Table("ABS_LRP_LENDER_REPORTING")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_lrp_lender_reporting\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ABS_LRP_LENDER_REPORTING\\\".\\\"LRP_LEN_ID\\\"\"   OP =\"=\"    EXP2 =\":a_len_id\" ) ) ARG(NAME = \"a_len_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_len_id", typeof(double?))]
    [DwSort("lrp_date A")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Lender_Reporting
    {
        [Key]
        [DwColumn("abs_lrp_lender_reporting", "lrp_id")]
        public decimal Lrp_Id { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Reporting_Type), AutoRetrieve = true)]
        [DwColumn("abs_lrp_lender_reporting", "lrp_activity")]
        public string Lrp_Activity { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lrp_lender_reporting", "lrp_date", TypeName = "datetime2")]
        public DateTime? Lrp_Date { get; set; }

        [ConcurrencyCheck]
        [DwChild("Sta_Emp_Id", "Compute_Name", typeof(Dddw_Employee_Names), AutoRetrieve = true)]
        [DwColumn("abs_lrp_lender_reporting", "lrp_app_rcvd_by")]
        public decimal? Lrp_App_Rcvd_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lrp_lender_reporting", "lrp_note")]
        public string Lrp_Note { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_lrp_lender_reporting", "lrp_len_id")]
        public decimal? Lrp_Len_Id { get; set; }

    }

}