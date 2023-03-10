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
    [DataWindow("d_abs_csp_payments", DwStyle.Default)]
    [Table("ABS_CSP_PAYMENTS")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_csp_payments\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"\\\"ABS_CSP_PAYMENTS\\\".\\\"CSP_CSI_ID\\\"\"   OP =\"=\"    EXP2 =\":p_csi_id\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"\\\"ABS_CSP_PAYMENTS\\\".\\\"CSP_TYPE\\\"\"   OP =\"=\"    EXP2 =\":p_type\" ) ) ARG(NAME = \"p_type\" TYPE = string)  ARG(NAME = \"p_csi_id\" TYPE = number)")]
    #endregion
    [DwParameter("p_type", typeof(string))]
    [DwParameter("p_csi_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Csp_Payments
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [ABS].[ABS_CSP_SEQ])")]
        [DwColumn("abs_csp_payments", "csp_id")]
        public decimal Csp_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_csp_payments", "csp_csi_id")]
        public decimal Csp_Csi_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_csp_payments", "csp_type")]
        public string Csp_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_csp_payments", "csp_tran_date", TypeName = "datetime2")]
        public DateTime? Csp_Tran_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_csp_payments", "csp_gen_support_amt")]
        public decimal? Csp_Gen_Support_Amt { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_csp_payments", "csp_sac_support_amt")]
        public decimal? Csp_Sac_Support_Amt { get; set; }

        [ConcurrencyCheck]
        [DwColumn("abs_csp_payments", "csp_fee")]
        public decimal? Csp_Fee { get; set; }

        [ConcurrencyCheck]
        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Csp_Payment_Reason), AutoRetrieve = true)]
        [DwColumn("abs_csp_payments", "csp_reason")]
        public string Csp_Reason { get; set; }

    }

}