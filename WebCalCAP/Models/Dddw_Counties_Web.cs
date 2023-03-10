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
    [DataWindow("dddw_counties_web", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM CCAP_LOV \r\n "
                  +"WHERE CCAP_LOV_DOMAIN = 'Counties' \r\n "
                  +"AND CCAP_LOV_ACTIVE = 'Y'")]
    #endregion
    public class Dddw_Counties_Web
    {
        [DwColumn("CCAP_LOV_CD")]
        public string Ccap_Lov_Cd { get; set; }

        [StringLength(110)]
        [DwColumn("CCAP_LOV_DESCRIPTION")]
        public string Ccap_Lov_Description { get; set; }

    }

}