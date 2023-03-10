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
    [DataWindow("d_calcap_csp", DwStyle.Default)]
    [Table("CCAP_COL_SUP")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"ccap_col_sup\" ) @(_COLUMNS_PLACEHOLDER_) WHERE(    EXP1 =\"( \\\"CCAP_COL_SUP\\\".\\\"COL_SUP_ID\\\"\"   OP =\"=\"    EXP2 =\":a_sup_id )\"    LOGIC =\"and\" ) WHERE(    EXP1 =\"( \\\"CCAP_COL_SUP\\\".\\\"COL_SUP_TRANSMITTAL_DATE\\\"\"   OP =\"is\"    EXP2 =\"null )\" ) ) ARG(NAME = \"a_sup_id\" TYPE = number)")]
    #endregion
    [DwParameter("a_sup_id", typeof(double?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Calcap_Csp
    {
        [Key]
        [SqlDefaultValue("(NEXT VALUE FOR [CALCAPWEB].[CCAP_COL_SEQ])")]
        [DwColumn("ccap_col_sup", "col_sup_id")]
        public decimal Col_Sup_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_lender_id")]
        public decimal? Col_Sup_Lender_Id { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_any_oth_pro_flag")]
        public string Col_Sup_Any_Oth_Pro_Flag { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_any_oth_pro")]
        public string Col_Sup_Any_Oth_Pro { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_len_loan_no_asn")]
        public string Col_Sup_Len_Loan_No_Asn { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_pro_loan_amt")]
        public decimal? Col_Sup_Pro_Loan_Amt { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_pro_term_sup")]
        public decimal? Col_Sup_Pro_Term_Sup { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_loan_cat_flag")]
        public string Col_Sup_Loan_Cat_Flag { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_sup_req")]
        public decimal? Col_Sup_Sup_Req { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_sup_req_per")]
        public decimal? Col_Sup_Sup_Req_Per { get; set; }

        [StringLength(30)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_name_signer")]
        public string Col_Sup_Name_Signer { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("ccap_col_sup", "col_sup_sign_date", TypeName = "datetime2")]
        public DateTime? Col_Sup_Sign_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("ccap_col_sup", "col_creation_date", TypeName = "datetime2")]
        public DateTime? Col_Creation_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(user_name())")]
        [DwColumn("ccap_col_sup", "col_created_by")]
        public string Col_Created_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(getdate())")]
        [DwColumn("ccap_col_sup", "col_last_update_date", TypeName = "datetime2")]
        public DateTime? Col_Last_Update_Date { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [SqlDefaultValue("(user_name())")]
        [DwColumn("ccap_col_sup", "col_last_updated_by")]
        public string Col_Last_Updated_By { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_csp")]
        public decimal? Col_Sup_Csp { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_loan_fk")]
        public decimal Col_Sup_Loan_Fk { get; set; }

        [StringLength(25)]
        [PropertySave(SaveStrategy.Ignore)]
        [DwColumn("ccap_col_sup", "col_sup_app_type")]
        public string Col_Sup_App_Type { get; set; }

        [ConcurrencyCheck]
        [DwColumn("ccap_col_sup", "col_sup_transmittal_date", TypeName = "datetime2")]
        public DateTime? Col_Sup_Transmittal_Date { get; set; }

    }

}