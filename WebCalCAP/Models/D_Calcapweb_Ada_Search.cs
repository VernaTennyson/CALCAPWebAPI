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
    [DataWindow("d_calcapweb_ada_search", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ccap_lea_loan_app\" , \r\n "
                  +"\"ccap_ada\" \r\n "
                  +"WHERE ( \"ccap_lea_loan_app\".\"lea_id\" = \"ccap_ada\".\"ada_lea_id\" ) and \r\n "
                  +"( ( \"CCAP_LEA_LOAN_APP\".\"LEA_TRANSMITTAL_DATE\" is NULL ) and \r\n "
                  +"( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'SUBMITTED' ) )")]
    #endregion
    [DwSort("lea_id D")]
    public class D_Calcapweb_Ada_Search
    {
        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_id\"")]
        public decimal Lea_Id { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_lender_id\"")]
        public decimal? Lea_Lender_Id { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_lender\"")]
        public string Lea_Lender { get; set; }

        [StringLength(60)]
        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_name\"")]
        public string Lea_Bor_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_lender_name\"")]
        public string Lea_Lender_Name { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_city\"")]
        public string Lea_Bor_City { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_bor_zip\"")]
        public string Lea_Bor_Zip { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_transmittal_date\"", TypeName = "datetime2")]
        public DateTime? Lea_Transmittal_Date { get; set; }

        [DwColumn("\"ccap_lea_loan_app\"", "\"lea_submission_date\"", TypeName = "datetime2")]
        public DateTime? Lea_Submission_Date { get; set; }

        [DwColumn("\"ccap_ada\"", "\"ada_lea_id\"")]
        public decimal Ccap_Ada_Ada_Lea_Id { get; set; }

        [DwColumn("\"ccap_ada\"", "\"ada_len_id\"")]
        public decimal Ccap_Ada_Ada_Len_Id { get; set; }

        [DwColumn("\"ccap_ada\"", "\"ada_loan_off_name\"")]
        public string Ccap_Ada_Ada_Loan_Off_Name { get; set; }

        [DwColumn("\"ccap_ada\"", "\"ada_part_len\"")]
        public string Ccap_Ada_Ada_Part_Len { get; set; }

    }

}