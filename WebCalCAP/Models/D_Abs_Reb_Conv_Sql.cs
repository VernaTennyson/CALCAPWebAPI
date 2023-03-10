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
    [DataWindow("d_abs_reb_conv_sql", DwStyle.Grid)]
    [Table("ABS_REB_REBATE", Schema = "ABS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ABS.ABS_REB_REBATE\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Reb_Conv_Sql
    {
        [Key]
        [DwColumn("ABS.ABS_REB_REBATE", "REB_ID")]
        public decimal Reb_Id { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_REQ_REC_DATE", TypeName = "datetime2")]
        public DateTime? Reb_Req_Rec_Date { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_REC_BY")]
        public string Reb_Rec_By { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_ELI_FOR_REB")]
        public string Reb_Eli_For_Reb { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_BORROWER_ID")]
        public decimal? Reb_Borrower_Id { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_EST_ELI_DATE", TypeName = "datetime2")]
        public DateTime? Reb_Est_Eli_Date { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_ACT_ELI_DATE", TypeName = "datetime2")]
        public DateTime? Reb_Act_Eli_Date { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_CONTRIB_AMT")]
        public decimal? Reb_Contrib_Amt { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_REB_AMT")]
        public decimal? Reb_Reb_Amt { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_CHECK_ISSUE_DATE", TypeName = "datetime2")]
        public DateTime? Reb_Check_Issue_Date { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_CPCFA_CONFIRMED_DATE", TypeName = "datetime2")]
        public DateTime? Reb_Cpcfa_Confirmed_Date { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_DENIAL_SENT_DATE", TypeName = "datetime2")]
        public DateTime? Reb_Denial_Sent_Date { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "CREATED_BY")]
        public string Created_By { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "CREATION_DATE", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "LAST_UPDATED_BY")]
        public string Last_Updated_By { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "LAST_UPDATE_DATE", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_EVC_ID")]
        public decimal? Reb_Evc_Id { get; set; }

        [DwColumn("ABS.ABS_REB_REBATE", "REB_COMMENTS")]
        public string Reb_Comments { get; set; }

    }

}