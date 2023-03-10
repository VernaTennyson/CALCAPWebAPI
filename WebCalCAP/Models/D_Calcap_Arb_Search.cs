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
    [DataWindow("d_calcap_arb_search", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT DISTINCT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"CCAP_LEN_LENDER\", \r\n "
                  +"\"CCAP_LEA_LOAN_APP\", \r\n "
                  +"\"CCAP_ARB\" \r\n "
                  +"WHERE ( \"CCAP_LEN_LENDER\".\"LEN_ID\" = \"CCAP_LEA_LOAN_APP\".\"LEA_LENDER_ID\" ) and \r\n "
                  +"( \"CCAP_ARB\".\"ARB_LEA_ID\" = \"CCAP_LEA_LOAN_APP\".\"LEA_ID\" ) and \r\n "
                  +"--        ( ( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'SUBMIT' ) AND \r\n "
                  +"( ( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'SUBMITTED' ) AND \r\n "
                  +"( \"CCAP_LEA_LOAN_APP\".\"LEA_TRANSMITTAL_DATE\" is NULL ) )")]
    #endregion
    public class D_Calcap_Arb_Search
    {
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_ID\"")]
        public decimal Ccap_Lea_Loan_App_Lea_Id { get; set; }

        [DwColumn("\"CCAP_ARB\"", "\"ARB_ID\"")]
        public decimal Ccap_Arb_Arb_Id { get; set; }

        [DwColumn("\"CCAP_ARB\"", "\"ARB_LEN_ID\"")]
        public decimal Ccap_Arb_Arb_Len_Id { get; set; }

        [StringLength(200)]
        [DwColumn("\"CCAP_LEN_LENDER\"", "\"LEN_NAME\"")]
        public string Ccap_Len_Lender_Len_Name { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_STATUS\"")]
        public string Ccap_Lea_Loan_App_Lea_Status { get; set; }

        [DwColumn("\"CCAP_ARB\"", "\"ARB_PART_LEN\"")]
        public string Ccap_Arb_Arb_Part_Len { get; set; }

        [DwColumn("\"CCAP_ARB\"", "\"ARB_LOAN_OFF_NAME\"")]
        public string Ccap_Arb_Arb_Loan_Off_Name { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_NAME\"")]
        public string Ccap_Lea_Loan_App_Lea_Bor_Name { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LENDER_ID\"")]
        public decimal? Ccap_Lea_Loan_App_Lea_Lender_Id { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_SUBMISSION_DATE\"", TypeName = "datetime2")]
        public DateTime? Ccap_Lea_Loan_App_Lea_Submission_Date { get; set; }

    }

}