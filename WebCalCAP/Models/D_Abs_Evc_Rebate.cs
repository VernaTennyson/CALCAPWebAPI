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
    [DataWindow("d_abs_evc_rebate", DwStyle.Default)]
    [Table("ABS_REB_REBATE")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_reb_rebate\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ABS_REB_REBATE\\\".\\\"REB_EVC_ID\\\"\"   OP =\"=\"    EXP2 =\":a_evc\" ) ) ARG(NAME = \"a_evc\" TYPE = number)")]
    #endregion
    [DwParameter("a_evc", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Evc_Rebate
    {
        [Key]
        [DwColumn("abs_reb_rebate", "reb_id")]
        public decimal Reb_Id { get; set; }

        [DwColumn("abs_reb_rebate", "reb_req_rec_date", TypeName = "datetime2")]
        public DateTime? Reb_Req_Rec_Date { get; set; }

        [StringLength(15)]
        [DwColumn("abs_reb_rebate", "reb_rec_by")]
        public string Reb_Rec_By { get; set; }

        [DwColumn("abs_reb_rebate", "reb_eli_for_reb")]
        public string Reb_Eli_For_Reb { get; set; } = "Y";

        [DwColumn("abs_reb_rebate", "reb_borrower_id")]
        public decimal? Reb_Borrower_Id { get; set; }

        [DwColumn("abs_reb_rebate", "reb_est_eli_date", TypeName = "datetime2")]
        public DateTime? Reb_Est_Eli_Date { get; set; }

        [DwColumn("abs_reb_rebate", "reb_act_eli_date", TypeName = "datetime2")]
        public DateTime? Reb_Act_Eli_Date { get; set; }

        [DwColumn("abs_reb_rebate", "reb_contrib_amt")]
        public decimal? Reb_Contrib_Amt { get; set; }

        [DwColumn("abs_reb_rebate", "reb_reb_amt")]
        public decimal? Reb_Reb_Amt { get; set; }

        [DwColumn("abs_reb_rebate", "reb_check_issue_date", TypeName = "datetime2")]
        public DateTime? Reb_Check_Issue_Date { get; set; }

        [DwColumn("abs_reb_rebate", "reb_cpcfa_confirmed_date", TypeName = "datetime2")]
        public DateTime? Reb_Cpcfa_Confirmed_Date { get; set; }

        [DwColumn("abs_reb_rebate", "reb_denial_sent_date", TypeName = "datetime2")]
        public DateTime? Reb_Denial_Sent_Date { get; set; }

        [DwColumn("abs_reb_rebate", "created_by")]
        public string Created_By { get; set; }

        [DwColumn("abs_reb_rebate", "creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [DwColumn("abs_reb_rebate", "last_updated_by")]
        public string Last_Updated_By { get; set; }

        [DwColumn("abs_reb_rebate", "last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [DwColumn("abs_reb_rebate", "reb_evc_id")]
        public decimal? Reb_Evc_Id { get; set; }

        [DwColumn("abs_reb_rebate", "reb_comments")]
        public string Reb_Comments { get; set; }

    }

}