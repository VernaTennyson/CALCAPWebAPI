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
    [DataWindow("d_calcapweb_ssp_search", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ccap_lea_loan_app\" , \r\n "
                  +"\"ccap_len_lender\" , \r\n "
                  +"\"ccap_seis_safe\" \r\n "
                  +"WHERE ( \"ccap_seis_safe\".\"seis_lea_fk\" = \"ccap_lea_loan_app\".\"lea_id\" ) \r\n "
                  +"and ( \"ccap_lea_loan_app\".\"lea_lender_id\" = \"ccap_len_lender\".\"len_id\" ) \r\n "
                  +"and ( ( \"CCAP_SEIS_SAFE\".\"SEIS_TRANSMITTAL_DATE\" is NULL ) \r\n "
                  +"And ( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'SUBMITTED' ) )")]
    #endregion
    public class D_Calcapweb_Ssp_Search
    {
        [DwColumn("\"ccap_seis_safe\"", "\"seis_lea_fk\"")]
        public decimal Ccap_Seis_Safe_Seis_Lea_Fk { get; set; }

        [DwColumn("\"ccap_seis_safe\"", "\"seis_id\"")]
        public decimal Ccap_Seis_Safe_Seis_Id { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_id\"")]
        public decimal Ccap_Lea_Loan_App_Lea_Id { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_lender_id\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Lender_Id { get; set; }

        [DwColumn("\"ccap_len_lender\"", "\"len_id\"")]
        public decimal Ccap_Len_Lender_Len_Id { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_lender_name\"")]
        public string Ccap_Lea_Loan_App_Lea_Lender_Name { get; set; }

        [StringLength(60)]
        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_name\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_submission_date\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Submission_Date { get; set; }

        [DwColumn("\"ccap_seis_safe\"", "\"seis_transmittal_date\"", TypeName = "datetime2")]
        public DateTime? Ccap_Seis_Safe_Seis_Transmittal_Date { get; set; }

        [DwColumn("\"ccap_len_lender\"", "\"len_officer_name\"")]
        public string Ccap_Len_Lender_Len_Officer_Name { get; set; }

    }

}