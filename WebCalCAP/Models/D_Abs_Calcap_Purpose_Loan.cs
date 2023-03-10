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
    [DataWindow("d_abs_calcap_purpose_loan", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"COM_LOV\" \r\n "
                  +"WHERE LOV_LOV_DOMAIN = 'CALCAPPurposeLoan' \r\n "
                  +"ORDER BY \"COM_LOV\".\"LOV_LOV_DESCRIPTION\" ASC")]
    #endregion
    public class D_Abs_Calcap_Purpose_Loan
    {
        [StringLength(100)]
        [DwColumn("\"COM_LOV\"", "\"LOV_LOV_DESCRIPTION\"")]
        public string Lov_Lov_Description { get; set; }

    }

}