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
    [DataWindow("d_abs_comp_rpt", DwStyle.Default)]
    #region DwSelectAttribute  
    [DwSelect("SELECT @(_COLUMNS_PLACEHOLDER_)  from dual")]
    #endregion
    [DwParameter("a_date", typeof(DateTime?))]
    public class D_Abs_Comp_Rpt
    {
        [SqlCompute("1")]
        public int Compute_0001 { get; set; }

/*        [JsonIgnore]
        [IgnoreDataMember]
       [DwReport(typeof(D_Rpt_Arb_Onroad_Stats2), ParamValues = "a_date")]
        public IList<D_Rpt_Arb_Onroad_Stats2> Dw_1 { get; set; } 

        [JsonIgnore]
        [IgnoreDataMember]
        [DwReport(typeof(D_Rpt_Arb_Onroad_Stats_Weekly), ParamValues = "a_date")]
        public IList<D_Rpt_Arb_Onroad_Stats_Weekly> Dw_2 { get; set; }
*/
    }

}