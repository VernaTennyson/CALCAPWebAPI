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
    [DataWindow("dw_fia_institution", DwStyle.Default)]
    [Table("ccap_fia_institution", Schema = "calcapweb")]
    #region DwSelectAttribute  
    [DwSelect("SELECT \r\n "
                  +"@(_COLUMNS_PLACEHOLDER_) \r\n "
                  +"FROM ccap_fia_institution \r\n "
                  +"WHERE ( \"FIA_ID\" = :a_f_fiaId )")]
    #endregion
    [DwParameter("a_f_fiaId", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class Dw_Fia_Institution
    {
        [Key]
        [DwColumn("\"fia_id\"")]
        public decimal Fia_Id { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_name\"")]
        public string Fia_Name { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_address\"")]
        public string Fia_Address { get; set; }

        [StringLength(40)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_city\"")]
        public string Fia_City { get; set; }

        [StringLength(2)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_state\"")]
        public string Fia_State { get; set; }

        [StringLength(10)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_zip\"")]
        public string Fia_Zip { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_person\"")]
        public string Fia_Con_Person { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_title\"")]
        public string Fia_Con_Title { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_address\"")]
        public string Fia_Con_Address { get; set; }

        [StringLength(40)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_city\"")]
        public string Fia_Con_City { get; set; }

        [StringLength(2)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_state\"")]
        public string Fia_Con_State { get; set; }

        [StringLength(10)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_zip\"")]
        public string Fia_Con_Zip { get; set; }

        [StringLength(12)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_phone\"")]
        public string Fia_Con_Phone { get; set; }

        [StringLength(12)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_fax\"")]
        public string Fia_Con_Fax { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Ccap_Lov_Cd", "Ccap_Lov_Description", typeof(Dddw_Institution_Type_Web), AutoRetrieve = true)]
        [DwColumn("\"fia_typeof_institution\"")]
        public string Fia_Typeof_Institution { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_insuringagency\"")]
        public string Fia_Insuringagency { get; set; }

        [StringLength(120)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_describeboardofdirect\"")]
        public string Fia_Describeboardofdirect { get; set; }

        [StringLength(120)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_sign_auth\"")]
        public string Fia_Sign_Auth { get; set; }

        [StringLength(120)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_sign_name\"")]
        public string Fia_Sign_Name { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_sign_title\"")]
        public string Fia_Sign_Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_capitalandsurplus\"")]
        public decimal? Fia_Capitalandsurplus { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_numberofbranches\"")]
        public decimal? Fia_Numberofbranches { get; set; }

        [StringLength(60)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_regulatoryagency\"")]
        public string Fia_Regulatoryagency { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_created_by\"")]
        public string Fia_Created_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_last_updated_by\"")]
        public string Fia_Last_Updated_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_sign_date\"", TypeName = "datetime2")]
        public DateTime? Fia_Sign_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_creation_date\"", TypeName = "datetime2")]
        public DateTime? Fia_Creation_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_last_update_date\"", TypeName = "datetime2")]
        public DateTime? Fia_Last_Update_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_pi_lr\"")]
        public string Fia_Pi_Lr { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_pi_arb\"")]
        public string Fia_Pi_Arb { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_pi_cs\"")]
        public string Fia_Pi_Cs { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_pi_evcs\"")]
        public string Fia_Pi_Evcs { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[FIA_PI_ADA]")]
        public string Fia_Pi_Ada { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("[FIA_PI_SEISMIC_SAFETY]")]
        public string Fia_Pi_Seismic_Safety { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_len_number\"")]
        public string Fia_Len_Number { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_email\"")]
        public string Fia_Con_Email { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_con_address2\"")]
        public string Fia_Con_Address2 { get; set; }

        [DwColumn("\"transmitted_date\"", TypeName = "datetime2")]
        public DateTime? Transmitted_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_email_confirm\"")]
        public string Fia_Email_Confirm { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_email_verify\"")]
        public string Fia_Email_Verify { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("\"fia_address2\"")]
        public string Fia_Address2 { get; set; }

    }

}