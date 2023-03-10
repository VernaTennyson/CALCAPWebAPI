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
    [DataWindow("d_abs_cla_conv_sql", DwStyle.Grid)]
    [Table("ABS_CLA_CLAIM_PROCESSING", Schema = "ABS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT(TABLE(NAME=\"abs.abs_cla_claim_processing\") @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Cla_Conv_Sql
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_CLA_SEQ])")]
        [DwColumn("abs.abs_cla_claim_processing", "cla_id")]
        public decimal Cla_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_cla_claim_processing", "cla_app_rcvd_dt", TypeName = "datetime2")]
        public DateTime? Cla_App_Rcvd_Dt { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("abs.abs_cla_claim_processing", "cla_delivery_method")]
        public string Cla_Delivery_Method { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_cla_claim_processing", "cla_rcvd_by")]
        public decimal? Cla_Rcvd_By { get; set; }

        [ConcurrencyCheck]
        [StringLength(1)]
        [DwColumn("abs.abs_cla_claim_processing", "cla_submitted")]
        public string Cla_Submitted { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_cla_claim_processing", "cla_len_id")]
        public decimal? Cla_Len_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_cla_claim_processing", "cla_bor_id")]
        public decimal? Cla_Bor_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_cla_claim_processing", "cla_loa_id")]
        public decimal? Cla_Loa_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_cla_claim_processing", "cla_charge_off_dt", TypeName = "datetime2")]
        public DateTime? Cla_Charge_Off_Dt { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_cla_claim_processing", "cla_filed_amt")]
        public decimal? Cla_Filed_Amt { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs.abs_cla_claim_processing", "created_by")]
        public string Created_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs.abs_cla_claim_processing", "creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [ConcurrencyCheck]
        [StringLength(15)]
        [SqlDefaultValue("([dbo].[sto_user]())")]
        [DwColumn("abs.abs_cla_claim_processing", "last_updated_by")]
        public string Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("abs.abs_cla_claim_processing", "last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_cla_claim_processing", "cla_amt_of_approv_claim")]
        public decimal? Cla_Amt_Of_Approv_Claim { get; set; }

        [ConcurrencyCheck]
        [StringLength(100)]
        [DwColumn("abs.abs_cla_claim_processing", "cla_claim_recoveries")]
        public string Cla_Claim_Recoveries { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs.abs_cla_claim_processing", "cla_claim_submitted_dt", TypeName = "datetime2")]
        public DateTime? Cla_Claim_Submitted_Dt { get; set; }

    }

}