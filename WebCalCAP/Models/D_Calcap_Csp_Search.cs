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
    [DataWindow("d_calcap_csp_search", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_)      FROM \"ccap_col_sup\" ,           \"ccap_len_lender\" ,           \"ccap_lea_loan_app\"     WHERE ( \"ccap_len_lender\".\"len_id\" = \"ccap_lea_loan_app\".\"lea_lender_id\" ) and          ( \"ccap_col_sup\".\"col_sup_loan_fk\" = \"ccap_lea_loan_app\".\"lea_id\" ) \r\n "
                  +"and          (COL_SUP_TRANSMITTAL_DATE is null) \r\n "
                  +"and          ( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'SUBMITTED' ) \r\n "
                  +"--and ( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'SUBMIT' )")]
    #endregion
    public class D_Calcap_Csp_Search
    {
        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_id\"")]
        public decimal Ccap_Lea_Loan_App_Lea_Id { get; set; }

        [DwColumn("\"ccap_col_sup\"", "\"col_sup_id\"")]
        public decimal Ccap_Col_Sup_Col_Sup_Id { get; set; }

        [DwColumn("\"ccap_len_lender\"", "\"len_name\"")]
        public string Ccap_Len_Lender_Len_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_status\"")]
        public string Ccap_Lea_Loan_App_Lea_Status { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_lender_id\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Lender_Id { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_lender_name\"")]
        public string Ccap_Lea_Loan_App_Lea_Lender_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_name\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_submission_date\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Submission_Date { get; set; }

    }

}