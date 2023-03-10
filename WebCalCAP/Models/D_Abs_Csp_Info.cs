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
    [DataWindow("d_abs_csp_info", DwStyle.Default)]
    [Table("abs_csi_csp_info")]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"abs_csi_csp_info\" \r\n "
                  +"WHERE (\"ABS_CSI_CSP_INFO\".\"CSI_LOA_ID\" = :p_loa_id)")]
    #endregion
    [DwParameter("p_loa_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Csp_Info
    {
        [Key]
        [DwColumn("\"abs_csi_csp_info\"", "\"csi_id\"")]
        public decimal Csi_Id { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_loa_id\"")]
        public decimal Csi_Loa_Id { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Csp_Loan_Category), AutoRetrieve = true)]
        [DwColumn("\"abs_csi_csp_info\"", "\"csi_loan_category\"")]
        public string Csi_Loan_Category { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_chargeoff_dt\"", TypeName = "datetime2")]
        public DateTime? Csi_Chargeoff_Dt { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_gen_support_amt\"")]
        public decimal? Csi_Gen_Support_Amt { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_gen_support_pct\"")]
        public decimal? Csi_Gen_Support_Pct { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_sac_support_amt\"")]
        public decimal? Csi_Sac_Support_Amt { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_sac_support_pct\"")]
        public decimal? Csi_Sac_Support_Pct { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_tot_support_amt\"")]
        public decimal? Csi_Tot_Support_Amt { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_tot_support_pct\"")]
        public decimal? Csi_Tot_Support_Pct { get; set; }

        [StringLength(120)]
        [DwColumn("\"abs_csi_csp_info\"", "\"csi_addl_parameters\"")]
        public string Csi_Addl_Parameters { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_min_req_gen_recap\"")]
        public decimal? Csi_Min_Req_Gen_Recap { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_min_req_sac_recap\"")]
        public decimal? Csi_Min_Req_Sac_Recap { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_annual_fee\"")]
        public decimal? Csi_Annual_Fee { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_comments\"")]
        public string Csi_Comments { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_csi_csp_info\"", "\"created_by\"")]
        public string Created_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"abs_csi_csp_info\"", "\"creation_date\"", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [DwColumn("\"abs_csi_csp_info\"", "\"csi_terms_support\"")]
        public decimal? Csi_Terms_Support { get; set; }

    }

}