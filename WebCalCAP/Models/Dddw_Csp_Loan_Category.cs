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
    [DataWindow("dddw_csp_loan_category", DwStyle.Grid)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM COM_LOV \r\n "
                  +"WHERE LOV_LOV_ACTIVE = 'Y' \r\n "
                  +"AND LOV_LOV_DOMAIN = 'CSP-LoanCategory'")]
    #endregion
    public class Dddw_Csp_Loan_Category
    {
        [DwColumn("LOV_LOV_CD")]
        public string Lov_Lov_Cd { get; set; }

        [StringLength(100)]
        [DwColumn("LOV_LOV_DESCRIPTION")]
        public string Lov_Lov_Description { get; set; }

    }

}