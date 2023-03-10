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
    [DataWindow("d_calcap_evcs_search", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_)      FROM \"ccap_len_lender\" ,           \"ccap_evcs\" ,           \"ccap_lea_loan_app\"     WHERE ( \"ccap_len_lender\".\"len_id\" = \"ccap_lea_loan_app\".\"lea_lender_id\" ) and          ( \"ccap_evcs\".\"evcs_lea_id\" = \"ccap_lea_loan_app\".\"lea_id\" ) \r\n "
                  +"and          ( \"CCAP_EVCS\".\"EVCS_TRANSMITTAL_DATE\" is Null ) \r\n "
                  +"and          ( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'SUBMITTED' ) \r\n "
                  +"--and          ( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'SUBMIT' )")]
    #endregion
    public class D_Calcap_Evcs_Search
    {
        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_id\"")]
        public decimal Ccap_Lea_Loan_App_Lea_Id { get; set; }

        [DwColumn("\"ccap_evcs\"", "\"evcs_id\"")]
        public decimal Ccap_Evcs_Evcs_Id { get; set; }

        [DwColumn("\"ccap_len_lender\"", "\"len_name\"")]
        public string Ccap_Len_Lender_Len_Name { get; set; }

        [DwColumn("\"ccap_evcs\"", "\"evcs_transmittal_date\"", TypeName = "datetime2")]
        public DateTime? Ccap_Evcs_Evcs_Transmittal_Date { get; set; }

        [DwColumn("\"ccap_evcs\"", "\"evcs_len_name\"")]
        public string Ccap_Evcs_Evcs_Len_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_lender_name\"")]
        public string Ccap_Lea_Loan_App_Lea_Lender_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_lender_id\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Lender_Id { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_name\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_submission_date\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Submission_Date { get; set; }

    }

}