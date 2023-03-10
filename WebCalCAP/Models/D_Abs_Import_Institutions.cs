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
    [DataWindow("d_abs_import_institutions", DwStyle.Grid)]
    public class D_Abs_Import_Institutions
    {
        [DwColumn("bank_name")]
        public string Bank_Name { get; set; }

        [DwColumn("contact")]
        public string Contact { get; set; }

        [DwColumn("address")]
        public string Address { get; set; }

        [DwColumn("city")]
        public string City { get; set; }

        [DwColumn("state")]
        public string State { get; set; }

        [DwColumn("zip")]
        public string Zip { get; set; }

        [DwColumn("phone")]
        public string Phone { get; set; }

    }

}