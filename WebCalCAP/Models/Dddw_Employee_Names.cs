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
    [DataWindow("dddw_employee_names", DwStyle.Default)]
    [Table("ABS_STA_STAFF_CALCAP")]
    #region DwSelectAttribute  
    [DwSelect("SELECT * \r\n "
                  +"FROM \r\n "
                  +"ABS_STA_STAFF_CALCAP")]
    #endregion
    [DwSort("compute_name A")]
    [DwFilter(" Not IsNull(compute_name )")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dddw_Employee_Names
    {
        [Key]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("sta_emp_id")]
        public decimal Sta_Emp_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("created_by")]
        public string Created_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("creation_date", TypeName = "datetime2")]
        public DateTime? Creation_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("last_updated_by")]
        public string Last_Updated_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("last_update_date", TypeName = "datetime2")]
        public DateTime? Last_Update_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("sta_first_name")]
        public string Sta_First_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("sta_last_name")]
        public string Sta_Last_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("sta_middle_name")]
        public string Sta_Middle_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("sta_sex")]
        public string Sta_Sex { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("sta_room")]
        public string Sta_Room { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("sta_username")]
        public string Sta_Username { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [JsonIgnore]
        [IgnoreDataMember]
        [DwCompute("IF(ISNULL(sta_first_name), \\\"\\\", sta_first_name) + \\\" \\\" + IF(ISNULL(sta_middle_name), \\\"\\\", sta_middle_name + \\\" \\\") + IF(ISNULL(sta_last_name), \\\"\\\", sta_last_name)")]
        public object Compute_Name { get; set; }

    }

}