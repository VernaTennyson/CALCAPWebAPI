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
    [DataWindow("d_abs_calcap_staff_temp", DwStyle.Default)]
    [Table("ABS_STA_STAFF_CALCAP")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"abs_sta_staff_calcap\" ) @(_COLUMNS_PLACEHOLDER_) )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Calcap_Staff_Temp
    {
        [Key]
 //       [DwChild("Staff_Id", "Sex", typeof(Dddw_Staff), AutoRetrieve = true)]
        [DwColumn("abs_sta_staff_calcap", "sta_emp_id")]
        public decimal Abs_Sta_Staff_Calcap_Sta_Emp_Id { get; set; }

        [DwColumn("abs_sta_staff_calcap", "sta_username")]
        public string Abs_Sta_Staff_Calcap_Sta_Username { get; set; }

        [DwColumn("abs_sta_staff_calcap", "sta_first_name")]
        public string Abs_Sta_Staff_Calcap_Sta_First_Name { get; set; }

        [DwColumn("abs_sta_staff_calcap", "sta_last_name")]
        public string Abs_Sta_Staff_Calcap_Sta_Last_Name { get; set; }

        [DwColumn("abs_sta_staff_calcap", "sta_middle_name")]
        public string Abs_Sta_Staff_Calcap_Sta_Middle_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("/*  hr_staff_v_first_name  + ' '+ if(isnull( hr_staff_v_middle_name ), '',  hr_staff_v_middle_name  + ' ') + hr_staff_v_last_name   */")]
        public object Compute_Name { get; set; }

    }

}