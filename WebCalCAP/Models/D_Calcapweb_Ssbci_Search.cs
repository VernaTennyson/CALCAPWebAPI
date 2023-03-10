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
    [DataWindow("d_calcapweb_ssbci_search", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"CCAP_LEA_LOAN_APP\", \r\n "
                  +"\"CCAP_LEN_LENDER\" \r\n "
                  +"WHERE ( \"CCAP_LEA_LOAN_APP\".\"LEA_LENDER_ID\" = \"CCAP_LEN_LENDER\".\"LEN_ID\" ) and \r\n "
                  +"( ( \"CCAP_LEA_LOAN_APP\".\"LEA_TRANSMITTAL_DATE\" is NULL ) AND \r\n "
                  +"--	( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'S' ) )    and \r\n "
                  +"( \"CCAP_LEA_LOAN_APP\".\"LEA_STATUS\" = 'SUBMITTED' ) )    and \r\n "
                  +"\"CCAP_LEA_LOAN_APP\".\"LEA_ID\"  not in ( select ARB_LEA_ID from CCAP_ARB ) and \r\n "
                  +"\"CCAP_LEA_LOAN_APP\".\"LEA_ID\"  not in ( select EVCS_LEA_ID   from CCAP_EVCS   ) and \r\n "
                  +"\"CCAP_LEA_LOAN_APP\".\"LEA_ID\"  not in ( select ADA_LEA_ID   from CCAP_ADA   ) and \r\n "
                  +"\"CCAP_LEA_LOAN_APP\".\"LEA_ID\"  not in ( select COL_SUP_LOAN_FK   from CCAP_COL_SUP   )")]
    #endregion
    [DwSort("lea_id D")]
    public class D_Calcapweb_Ssbci_Search
    {
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_ID\"")]
        public decimal Lea_Id { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LENDER_ID\"")]
        public decimal? Lea_Lender_Id { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LENDER\"")]
        public string Lea_Lender { get; set; }

        [StringLength(60)]
        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_NAME\"")]
        public string Lea_Bor_Name { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_LENDER_NAME\"")]
        public string Lea_Lender_Name { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_CITY\"")]
        public string Lea_Bor_City { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_BOR_ZIP\"")]
        public string Lea_Bor_Zip { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_TRANSMITTAL_DATE\"", TypeName = "datetime2")]
        public DateTime? Lea_Transmittal_Date { get; set; }

        [DwColumn("\"CCAP_LEA_LOAN_APP\"", "\"LEA_SUBMISSION_DATE\"", TypeName = "datetime2")]
        public DateTime? Lea_Submission_Date { get; set; }

        [DwColumn("\"CCAP_LEN_LENDER\"", "\"LEN_NAME\"")]
        public string Ccap_Len_Lender_Len_Name { get; set; }

    }

}