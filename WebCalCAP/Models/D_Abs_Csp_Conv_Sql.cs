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
    [DataWindow("d_abs_csp_conv_sql", DwStyle.Grid)]
    [Table("ABS_CSP_PAYMENTS")]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ABS_CSP_PAYMENTS\"")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Csp_Conv_Sql
    {
        [Key]
        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CSP_ID\"")]
        public decimal Csp_Id { get; set; }

        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CSP_CSI_ID\"")]
        public decimal Csp_Csi_Id { get; set; }

        [StringLength(3)]
        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CSP_TYPE\"")]
        public string Csp_Type { get; set; }

        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CSP_TRAN_DATE\"", TypeName = "datetime2")]
        public DateTime? Csp_Tran_Date { get; set; }

        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CSP_GEN_SUPPORT_AMT\"")]
        public decimal? Csp_Gen_Support_Amt { get; set; }

        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CSP_SAC_SUPPORT_AMT\"")]
        public decimal? Csp_Sac_Support_Amt { get; set; }

        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CSP_FEE\"")]
        public decimal? Csp_Fee { get; set; }

        [StringLength(120)]
        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CSP_REASON\"")]
        public string Csp_Reason { get; set; }

        [StringLength(15)]
        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CREATED_BY\"")]
        public string Created_By { get; set; }

        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"CREATION_DATE\"", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [StringLength(15)]
        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"LAST_UPDATED_BY\"")]
        public string Last_Updated_By { get; set; }

        [DwColumn("\"ABS_CSP_PAYMENTS\"", "\"LAST_UPDATE_DATE\"", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

    }

}