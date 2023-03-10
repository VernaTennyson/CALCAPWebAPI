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
    [DataWindow("rpt_analyst_outstanding_loans", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT 'LOANS'                  TRANS_TYPE, \r\n "
                  +"LOA_ID                   LOANID, \r\n "
                  +"LOA_LENDER_LOAN_NBR      LOAN_NBR, \r\n "
                  +"LEN_NAME                 LENDER, \r\n "
                  +"BOR_NAME                 BORROWER, \r\n "
                  +"BOR_DBA                  BOR_DBA, \r\n "
                  +"--       BOR_NAME                 LENDER, \r\n "
                  +"--       BOR_DBA                  BORROWER, \r\n "
                  +"--       LEN_NAME                 BOR_DBA, \r\n "
                  +"LOA_APP_RCVD_DT          DATE_RECEIVED, \r\n "
                  +"LOA_CALCAP_LOAN_NUM      CALCAP_LOANNUM, \r\n "
                  +"LOA_PROGRAM, \r\n "
                  +"EVN_ID                   EVENTID, \r\n "
                  +"STA_EMP_ID               STAFFID, \r\n "
                  +"STA_FIRST_NAME           FNAME, \r\n "
                  +"STA_MIDDLE_NAME          MNAME, \r\n "
                  +"STA_LAST_NAME            LNAME, \r\n "
                  +"EVN_CODE                 EVENTCODE, \r\n "
                  +"EVN_STATUS               EVENTSTAT, \r\n "
                  +"EVN_DATE                 EVENTDATE, \r\n "
                  +"EVN_ASSIGNED             EVENTASSIGN, \r\n "
                  +"EVN_NOTE                 EVENTNOTE \r\n "
                  +"FROM   ABS_LEN_LENDER           LEN, \r\n "
                  +"ABS_LOA_LOANS            LOA, \r\n "
                  +"ABS_BOR_BORROWER         BOR, \r\n "
                  +"ABS_EVN_EVENTS           EVN, \r\n "
                  +"ABS_STA_STAFF_CALCAP STA \r\n "
                  +"WHERE  LEN.LEN_ID = LOA.LOA_LEN_ID \r\n "
                  +"AND    BOR.BOR_ID = LOA.LOA_BOR_ID \r\n "
                  +"AND    LOA.LOA_ID = EVN.EVN_LOA_ID \r\n "
                  +"AND    EVN.EVN_ASSIGNED = STA.STA_EMP_ID \r\n "
                  +"AND    LOA.LOA_CALCAP_LOAN_NUM IS NULL \r\n "
                  +"AND    (STA.STA_EMP_ID = :a_analyst_assigned or :a_analyst_assigned is null) \r\n "
                  +"AND    EVN.EVN_STATUS = 'P' \r\n "
                  +"AND    EVN.EVN_ID = ( SELECT MAX (EVN2.EVN_ID) \r\n "
                  +"FROM   ABS_EVN_EVENTS EVN2 \r\n "
                  +"WHERE  EVN2.EVN_LOA_ID = LOA.LOA_ID \r\n "
                  +"AND    EVN2.EVN_ASSIGNED = STA_EMP_ID ) \r\n "
                  +"AND    LOA.LOA_ID NOT IN (SELECT DISTINCT EVN2.EVN_LOA_ID \r\n "
                  +"FROM   ABS_EVN_EVENTS EVN2 \r\n "
                  +"WHERE  EVN2.EVN_LOA_ID = LOA.LOA_ID \r\n "
                  +"AND    EVN2.EVN_CODE = 'LC' \r\n "
                  +"AND    EVN2.EVN_STATUS IN ('W','R','E','C') ) \r\n "
                  +" \r\n "
                  +"UNION \r\n "
                  +" \r\n "
                  +"SELECT 'CLAIMS'                 TRANS_TYPE, \r\n "
                  +"LOA_ID                   LOANID, \r\n "
                  +"LOA_LENDER_LOAN_NBR      LOAN_NBR, \r\n "
                  +"LEN_NAME                 LENDER, \r\n "
                  +"BOR_NAME                 BORROWER, \r\n "
                  +"BOR_DBA                  BOR_DBA, \r\n "
                  +"CLA_CLAIM_SUBMITTED_DT   DATE_RECEIVED, \r\n "
                  +"LOA_CALCAP_LOAN_NUM      CALCAP_LOANNUM, \r\n "
                  +"LOA_PROGRAM, \r\n "
                  +"EVN_ID                   EVENTID, \r\n "
                  +"STA_EMP_ID               STAFFID, \r\n "
                  +"STA_FIRST_NAME           FNAME, \r\n "
                  +"STA_MIDDLE_NAME          MNAME, \r\n "
                  +"STA_LAST_NAME            LNAME, \r\n "
                  +"EVN_CODE                 EVENTCODE, \r\n "
                  +"EVN_STATUS               EVENTSTAT, \r\n "
                  +"EVN_DATE                 EVENTDATE, \r\n "
                  +"EVN_ASSIGNED             EVENTASSIGN, \r\n "
                  +"EVN_NOTE                 EVENTNOTE \r\n "
                  +"FROM ABS_LOA_LOANS            LOA, \r\n "
                  +"ABS_LEN_LENDER           LEN, \r\n "
                  +"ABS_BOR_BORROWER         BOR, \r\n "
                  +"ABS_CLA_CLAIM_PROCESSING CLA, \r\n "
                  +"ABS_EVN_EVENTS           EVN \r\n "
                  +"LEFT JOIN   ABS_STA_STAFF_CALCAP     STA    ON EVN.EVN_ASSIGNED =  STA.STA_EMP_ID \r\n "
                  +"WHERE LOA.LOA_LEN_ID   = LEN.LEN_ID \r\n "
                  +"AND LOA.LOA_BOR_ID   = BOR.BOR_ID \r\n "
                  +"AND LOA.LOA_ID       = CLA.CLA_LOA_ID \r\n "
                  +"AND CLA.CLA_ID       = EVN.EVN_CLA_ID \r\n "
                  +" \r\n "
                  +"AND (STA.STA_EMP_ID = :a_analyst_assigned or :a_analyst_assigned is null) \r\n "
                  +"AND EVN.EVN_ID       = ( SELECT MAX (EVN2.EVN_ID) \r\n "
                  +"FROM   ABS_CLA_CLAIM_PROCESSING CLA2, ABS_EVN_EVENTS EVN2 \r\n "
                  +"WHERE  CLA2.CLA_ID     = EVN2.EVN_CLA_ID \r\n "
                  +"AND    CLA2.CLA_LOA_ID = LOA.LOA_ID \r\n "
                  +"AND EVN2.EVN_ASSIGNED  = STA_EMP_ID  ) \r\n "
                  +"AND CLA.CLA_ID NOT IN (SELECT DISTINCT CLA2.CLA_ID \r\n "
                  +"FROM   ABS_CLA_CLAIM_PROCESSING CLA2, ABS_EVN_EVENTS EVN2 \r\n "
                  +"WHERE  CLA2.CLA_ID     = EVN2.EVN_CLA_ID \r\n "
                  +"AND    CLA2.CLA_ID = CLA.CLA_ID \r\n "
                  +"AND    EVN2.EVN_CODE   = 'RE' \r\n "
                  +"AND    EVN2.EVN_STATUS = 'A' ) \r\n "
                  +"ORDER BY  TRANS_TYPE DESC, LENDER, BORROWER")]
    #endregion
    [DwParameter("a_analyst_assigned", typeof(double?))]
    [DwSort("abs_sta_staff_calcap_staffid A trans_type D abs_len_lender_lender A abs_bor_borrower_borrower A")]
    [DwGroupBy(1, "abs_sta_staff_calcap_staffid")]
    [DwGroupBy(2, "trans_type")]
    public class Rpt_Analyst_Outstanding_Loans
    {
        [StringLength(6)]
        [DwColumn("trans_type")]
        public string Trans_Type { get; set; }

        [DwColumn("loanid")]
        public decimal? Abs_Loa_Loans_Loanid { get; set; }

        [StringLength(100)]
        [DwColumn("loan_nbr")]
        public string Abs_Loa_Loans_Loan_Nbr { get; set; }

        [DwColumn("lender")]
        public string Abs_Len_Lender_Lender { get; set; }

        [StringLength(200)]
        [DwColumn("borrower")]
        public string Abs_Bor_Borrower_Borrower { get; set; }

        [DwColumn("bor_dba")]
        public string Abs_Bor_Borrower_Bor_Dba { get; set; }

        [DwColumn("date_received", TypeName = "datetime2")]
        public DateTime? Abs_Loa_Loans_Date_Received { get; set; }

        [StringLength(15)]
        [DwColumn("calcap_loannum")]
        public string Abs_Loa_Loans_Calcap_Loannum { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Program_Type), AutoRetrieve = true)]
        [DwColumn("loa_program")]
        public string Abs_Loa_Loans_Loa_Program { get; set; }

        [DwColumn("eventid")]
        public decimal? Abs_Evn_Events_Eventid { get; set; }

        [DwColumn("staffid")]
        public decimal? Abs_Sta_Staff_Calcap_Staffid { get; set; }

        [DwColumn("fname")]
        public string Abs_Sta_Staff_Calcap_Fname { get; set; }

        [DwColumn("mname")]
        public string Abs_Sta_Staff_Calcap_Mname { get; set; }

        [DwColumn("lname")]
        public string Abs_Sta_Staff_Calcap_Lname { get; set; }

        [DwChild("Lov_Lov_Cd", "Lov_Lov_Description", typeof(Dddw_Event), AutoRetrieve = true)]
        [DwColumn("eventcode")]
        public string Abs_Evn_Events_Eventcode { get; set; }

        [DwColumn("eventstat")]
        public string Abs_Evn_Events_Eventstat { get; set; }

        [DwColumn("eventdate", TypeName = "datetime2")]
        public DateTime? Abs_Evn_Events_Eventdate { get; set; }

        [DwColumn("eventassign")]
        public decimal? Abs_Evn_Events_Eventassign { get; set; }

        [StringLength(2000)]
        [DwColumn("eventnote")]
        public string Abs_Evn_Events_Eventnote { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Total Outstanding \\\" + trans_type + \\\" : \\\" + Count(abs_loa_loans_loan_nbr FOR GROUP 1)")]
        public object Compute_2 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("\\\"Page \\\" + Page() + \\\" of \\\" + PageCount()")]
        public object Page_1 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("'Outstanding Loans/Claims \" " 
                  + "+ \"' +    abs_sta_staff_calcap_fname + ' '+ if(isnull(  abs_sta_staff_calcap_mname ), '',   abs_sta_staff_calcap_mname + ' ') +   abs_sta_staff_calcap_lname + ' \" "
                  + "+ \"' + date(today())")]
        public object Compute_1 { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("CASE(trans_type WHEN \\\"LOANS\\\" THEN \\\"Date Received\\\" WHEN \\\"CLAIMS\\\" THEN \\\"Submitted Date\\\" ELSE \\\"Date\\\")")]
        public object Compute_3 { get; set; }

    }

}