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
    [DataWindow("dddw_event_analyst", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"COM_LOV\" \r\n "
                  +"WHERE ( LOV_LOV_domain = 'CALCAPEventType' ) AND \r\n "
                  +"( LOV_LOV_ACTIVE = 'Y' )")]
    #endregion
    [DwFilter("lov_lov_cd in (  \"RA\",\"SM\",\"RM\",\"H\")\r\n\r\n\r\n")]
    public class Dddw_Event_Analyst
    {
        [DwColumn("\"COM_LOV\"", "\"LOV_LOV_CD\"")]
        public string Lov_Lov_Cd { get; set; }

        [DwColumn("\"COM_LOV\"", "\"LOV_LOV_DESCRIPTION\"")]
        public string Lov_Lov_Description { get; set; }

    }

}