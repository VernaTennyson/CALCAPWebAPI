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
    [DataWindow("d_abs_csi_conv_sql", DwStyle.Grid)]
    [Table("ABS_CSI_CSP_INFO")]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_)    FROM \"ABS_CSI_CSP_INFO\"")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Csi_Conv_Sql
    {
        [Key]
        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_ID\"")]
        public decimal Csi_Id { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_LOA_ID\"")]
        public decimal Csi_Loa_Id { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_LOAN_CATEGORY\"")]
        public string Csi_Loan_Category { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_CHARGEOFF_DT\"", TypeName = "datetime2")]
        public DateTime? Csi_Chargeoff_Dt { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_GEN_SUPPORT_AMT\"")]
        public decimal? Csi_Gen_Support_Amt { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_GEN_SUPPORT_PCT\"")]
        public decimal? Csi_Gen_Support_Pct { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_SAC_SUPPORT_AMT\"")]
        public decimal? Csi_Sac_Support_Amt { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_SAC_SUPPORT_PCT\"")]
        public decimal? Csi_Sac_Support_Pct { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_TOT_SUPPORT_AMT\"")]
        public decimal? Csi_Tot_Support_Amt { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_TOT_SUPPORT_PCT\"")]
        public decimal? Csi_Tot_Support_Pct { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_ADDL_PARAMETERS\"")]
        public string Csi_Addl_Parameters { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_MIN_REQ_GEN_RECAP\"")]
        public decimal? Csi_Min_Req_Gen_Recap { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_MIN_REQ_SAC_RECAP\"")]
        public decimal? Csi_Min_Req_Sac_Recap { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_ANNUAL_FEE\"")]
        public decimal? Csi_Annual_Fee { get; set; }

        [StringLength(400)]
        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_COMMENTS\"")]
        public string Csi_Comments { get; set; }

        [StringLength(15)]
        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CREATED_BY\"")]
        public string Created_By { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CREATION_DATE\"", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [StringLength(15)]
        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"LAST_UPDATED_BY\"")]
        public string Last_Updated_By { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"LAST_UPDATE_DATE\"", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [DwColumn("\"ABS_CSI_CSP_INFO\"", "\"CSI_TERMS_SUPPORT\"")]
        public decimal? Csi_Terms_Support { get; set; }

    }

}