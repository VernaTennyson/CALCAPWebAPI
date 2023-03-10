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
    [DataWindow("d_import_calcap", DwStyle.Grid)]
    public class D_Import_Calcap
    {
        [DwColumn("bank")]
        public string Bank { get; set; }

        [DwColumn("borrower")]
        public string Borrower { get; set; }

        [DwColumn("dt_recv_admin")]
        public string Dt_Recv_Admin { get; set; }

        [DwColumn("admin_init")]
        public string Admin_Init { get; set; }

        [DwColumn("dt_recv_by_calcap")]
        public string Dt_Recv_By_Calcap { get; set; }

        [DwColumn("calcap_init")]
        public string Calcap_Init { get; set; }

        [DwColumn("app_to_man")]
        public string App_To_Man { get; set; }

        [DwColumn("app_to_exec")]
        public string App_To_Exec { get; set; }

        [DwColumn("app_to_admin")]
        public string App_To_Admin { get; set; }

        [DwColumn("app_to_trustee")]
        public string App_To_Trustee { get; set; }

        [DwColumn("hold_over")]
        public string Hold_Over { get; set; }

        [DwColumn("comment")]
        public string Comment { get; set; }

    }

}