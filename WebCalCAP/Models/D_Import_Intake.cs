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
    [DataWindow("d_import_intake", DwStyle.Grid)]
    public class D_Import_Intake
    {
        [DwColumn("bank")]
        public string Bank { get; set; }

        [DwColumn("name_1")]
        public string Lender_Id { get; set; }

        [DwColumn("name_5")]
        public string Calcap_Loan_Nbr { get; set; }

        [DwColumn("name_6")]
        public string Delivery_Method { get; set; }

        [DwColumn("dt_recv_admin")]
        public string Loan_Enroll_Rec { get; set; }

        [DwColumn("admin_init")]
        public string Loan_Recv_Init { get; set; }

        [DwColumn("dt_recv_by_calcap")]
        public string Loan_Assign_Dt { get; set; }

        [DwColumn("calcap_init")]
        public string Assign_To { get; set; }

        [DwColumn("app_to_man")]
        public string Borrower { get; set; }

        [DwColumn("name_7")]
        public string Borrower_City { get; set; }

        [DwColumn("name_8")]
        public string Borrower_County { get; set; }

        [DwColumn("app_to_exec")]
        public string Borrower_Zip { get; set; }

        [DwColumn("app_to_admin")]
        public string Type_Of_Bus { get; set; }

        [DwColumn("app_to_trustee")]
        public string Naics_Code { get; set; }

        [DwColumn("name_3")]
        public string Num_Of_Emp { get; set; }

        [DwColumn("name_2")]
        public string Num_Of_Jobs { get; set; }

        [DwColumn("name_4")]
        public string Annual_Rev { get; set; }

        [DwColumn("hold_over")]
        public string Severly_Aff { get; set; }

        [DwColumn("comment")]
        public string Purpose_Of_Load { get; set; }

        [DwColumn("name_9")]
        public string Min_Women { get; set; }

        [DwColumn("name_11")]
        public string Type_Of_Loan { get; set; }

        [DwColumn("name_10")]
        public string Lender_Loan_Nbr { get; set; }

    }

}