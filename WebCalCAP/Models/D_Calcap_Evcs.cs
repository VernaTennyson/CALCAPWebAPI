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
    [DataWindow("d_calcap_evcs", DwStyle.Default)]
    [Table("ccap_evcs", Schema = "CALCAPWEB")]
    #region DwSelectAttribute  
    [DwSelect("SELECT  @(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM \"ccap_evcs\" \r\n "
                  +"WHERE ( \"CCAP_EVCS\".\"EVCS_ID\" = :a_evcs_id )")]
    #endregion
    [DwParameter("a_evcs_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Calcap_Evcs
    {
        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("\"ccap_evcs\"", "\"evcs_part_len\"")]
        public string Evcs_Part_Len { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("\"ccap_evcs\"", "\"evcs_len_name\"")]
        public string Evcs_Len_Name { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("\"ccap_evcs\"", "\"evcs_len_email\"")]
        public string Evcs_Len_Email { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_evcs\"", "\"evcs_len_phone\"")]
        public string Evcs_Len_Phone { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("\"ccap_evcs\"", "\"evcs_name_per_res\"")]
        public string Evcs_Name_Per_Res { get; set; }

        [ConcurrencyCheck]
        [StringLength(50)]
        [DwColumn("\"ccap_evcs\"", "\"evcs_title_per_res\"")]
        public string Evcs_Title_Per_Res { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_evcs\"", "\"evcs_bor_multi_flag\"")]
        public string Evcs_Bor_Multi_Flag { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_evcs\"", "\"evcs_bor_dis_com_flag\"")]
        public string Evcs_Bor_Dis_Com_Flag { get; set; }

        [Key]
        [DwColumn("\"ccap_evcs\"", "\"evcs_id\"")]
        public decimal Evcs_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ccap_evcs\"", "\"evcs_lea_id\"")]
        public decimal? Evcs_Lea_Id { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_evcs\"", "\"evcs_creation_date\"", TypeName = "datetime2")]
        public DateTime? Evcs_Creation_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_evcs\"", "\"evcs_created_by\"")]
        public string Evcs_Created_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_evcs\"", "\"evcs_last_update_date\"", TypeName = "datetime2")]
        public DateTime? Evcs_Last_Update_Date { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_evcs\"", "\"evcs_last_updated_by\"")]
        public string Evcs_Last_Updated_By { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_evcs\"", "\"evcs_app_type\"")]
        public string Evcs_App_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("\"ccap_evcs\"", "\"evcs_transmittal_date\"", TypeName = "datetime2")]
        public DateTime? Evcs_Transmittal_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ccap_evcs\"", "\"evcs_len_id\"")]
        public decimal? Evcs_Len_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"ccap_evcs\"", "\"evcs_multiple_projects\"")]
        public string Evcs_Multiple_Projects { get; set; }

    }

}