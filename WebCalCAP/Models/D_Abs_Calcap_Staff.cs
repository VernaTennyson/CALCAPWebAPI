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
    [DataWindow("d_abs_calcap_staff", DwStyle.Default)]
    [Table("abs_sta_staff_calcap", Schema = "abs")]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"abs_sta_staff_calcap\" \r\n "
                  +"ORDER BY \r\n "
                  +"\"abs_sta_staff_calcap\".\"sta_last_name\" ASC, \r\n "
                  +"\"abs_sta_staff_calcap\".\"sta_first_name\" ASC, \r\n "
                  +"\"abs_sta_staff_calcap\".\"sta_middle_name\" ASC")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Abs_Calcap_Staff
    {
        [Key]
        [DwColumn("\"abs_sta_staff_calcap\"", "\"sta_emp_id\"")]
        public decimal Abs_Sta_Staff_Calcap_Sta_Emp_Id { get; set; }

        [DwColumn("\"abs_sta_staff_calcap\"", "\"sta_username\"")]
        public string Sta_Username { get; set; }

        [DwColumn("\"abs_sta_staff_calcap\"", "\"sta_first_name\"")]
        public string First_Name { get; set; }

        [DwColumn("\"abs_sta_staff_calcap\"", "\"sta_last_name\"")]
        public string Sta_Last_Name { get; set; }

        [DwColumn("\"abs_sta_staff_calcap\"", "\"sta_middle_name\"")]
        public string Middle_Name { get; set; }

        [DwColumn("\"abs_sta_staff_calcap\"", "\"sta_sex\"")]
        public string Sta_Sex { get; set; }

        [DwColumn("\"abs_sta_staff_calcap\"", "\"sta_room\"")]
        public string Sta_Room { get; set; }

    }

}