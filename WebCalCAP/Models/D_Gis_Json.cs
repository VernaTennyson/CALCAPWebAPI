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
    [DataWindow("d_gis_json", DwStyle.Grid)]
    public class D_Gis_Json
    {
        [DwColumn("state_upper_house_district_1_id_value")]
        public string State_Upper_House_District_1_Id_Value { get; set; }

        [DwColumn("request_address")]
        public string Request_Address { get; set; }

        [DwColumn("name_1")]
        public string Request_Status_Code { get; set; }

    }

}