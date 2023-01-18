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
    [DataWindow("dddw_lender_contact_type", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM COM_LOV WHERE \r\n "
                  +"LOV_LOV_ACTIVE = 'Y' AND \r\n "
                  +"LOV_LOV_DOMAIN = 'CalCAPContactType'")]
    #endregion
    public class Dddw_Lender_Contact_Type
    {
        [DwColumn("LOV_LOV_CD")]
        public string Lov_Lov_Cd { get; set; }

        [DwColumn("LOV_LOV_DESCRIPTION")]
        public string Lov_Lov_Description { get; set; }

    }

}