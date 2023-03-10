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
    [DataWindow("d_import_new_access", DwStyle.Grid)]
    public class D_Import_New_Access
    {
        [DwColumn("bank")]
        public string Bank { get; set; }

        [DwColumn("name_1")]
        public string Lender_Id { get; set; }

        [DwColumn("name_5")]
        public string Calcap_Loan_Nbr { get; set; }

        [DwColumn("name_6")]
        public string Delivery_Method { get; set; }

        [DwColumn("dt_recv_admin")]
        public string Loan_Enroll_Rec { get; set; }

        [DwColumn("admin_init")]
        public string Loan_Recv_Init { get; set; }

        [DwColumn("dt_recv_by_calcap")]
        public string Loan_Assign_Dt { get; set; }

        [DwColumn("calcap_init")]
        public string Assign_To { get; set; }

        [DwColumn("app_to_man")]
        public string Borrower { get; set; }

        [DwColumn("name_7")]
        public string Borrower_City { get; set; }

        [DwColumn("name_8")]
        public string Borrower_County { get; set; }

        [DwColumn("app_to_exec")]
        public string Borrower_Zip { get; set; }

        [DwColumn("app_to_admin")]
        public string Type_Of_Bus { get; set; }

        [DwColumn("app_to_trustee")]
        public string Naics_Code { get; set; }

        [DwColumn("name_3")]
        public string Num_Of_Emp { get; set; }

        [DwColumn("name_2")]
        public string Num_Of_Jobs { get; set; }

        [DwColumn("name_4")]
        public string Annual_Rev { get; set; }

        [DwColumn("hold_over")]
        public string Severly_Aff { get; set; }

        [DwColumn("comment")]
        public string Purpose_Of_Loan { get; set; }

        [DwColumn("name_9")]
        public string Min_Women { get; set; }

        [DwColumn("name_11")]
        public string Type_Of_Loan { get; set; }

        [DwColumn("name_10")]
        public string Lender_Loan_Nbr { get; set; }

        [DwColumn("name_12")]
        public string Interest_Rate { get; set; }

        [DwColumn("name_13")]
        public string Int_Modifyer { get; set; }

        [DwColumn("name_14")]
        public string Int_Type { get; set; }

        [DwColumn("name_15")]
        public string Lender_Loan_Dt { get; set; }

        [DwColumn("name_16")]
        public string Refinancing_Loan { get; set; }

        [DwColumn("name_17")]
        public string Loan_Increase { get; set; }

        [DwColumn("name_18")]
        public string Loan_Mat_Dt { get; set; }

        [DwColumn("name_19")]
        public string Loan_Total { get; set; }

        [DwColumn("name_20")]
        public string Calcap_Loan_Amt { get; set; }

        [DwColumn("name_21")]
        public string Loan_Program { get; set; }

        [DwColumn("name_22")]
        public string Loa_To_Man { get; set; }

        [DwColumn("name_36")]
        public string Loa_Approv_Man { get; set; }

        [DwColumn("name_24")]
        public string Loa_To_Exec { get; set; }

        [DwColumn("name_35")]
        public string Loa_Approv_Exec { get; set; }

        [DwColumn("name_34")]
        public string File_Sent_Admin { get; set; }

        [DwColumn("name_30")]
        public string Lender_Prem_Amt { get; set; }

        [DwColumn("name_33")]
        public string Lender_Prem_Pd { get; set; }

        [DwColumn("name_78")]
        public string Borrower_Prem_Amt { get; set; }

        [DwColumn("name_79")]
        public string Borrower_Prem_Pd { get; set; }

        [DwColumn("name_32")]
        public string Ind_Contr_Amt { get; set; }

        [DwColumn("name_77")]
        public string Dt_Ind_Contr_Amt_Pd { get; set; }

        [DwColumn("name_31")]
        public string To_Trustee_Bnk { get; set; }

        [DwColumn("name_29")]
        public string Calcap_Prem_Amt { get; set; }

        [DwColumn("name_28")]
        public string Calcap_Prem_Pd { get; set; }

        [DwColumn("name_23")]
        public string Loss_Reserv_Loc { get; set; }

        [DwColumn("name_27")]
        public string Loan_Hold_Dt { get; set; }

        [DwColumn("name_25")]
        public string Loan_Hold_Reason { get; set; }

        [DwColumn("name_26")]
        public string Arb_Loan_Type { get; set; }

        [DwColumn("name_37")]
        public string Tractor_Cat { get; set; }

        [DwColumn("name_38")]
        public string Trac_Eng_Man { get; set; }

        [DwColumn("name_39")]
        public string Trac_End_Mod { get; set; }

        [DwColumn("name_40")]
        public string Trac_Smart_Way { get; set; }

        [DwColumn("name_41")]
        public string Arb_Retro_Man { get; set; }

        [DwColumn("name_42")]
        public string Arb_Retro_Type { get; set; }

        [DwColumn("name_43")]
        public string Trailer_Man { get; set; }

        [DwColumn("name_44")]
        public string Trailer_Mod_Yr { get; set; }

        [DwColumn("name_45")]
        public string Trailer_Smart { get; set; }

        [DwColumn("name_46")]
        public string Smart_Aero_Tec_Man { get; set; }

        [DwColumn("name_47")]
        public string Smart_Aero_Tec_Type { get; set; }

        [DwColumn("name_48")]
        public string Off_Rd_Equip_Cat { get; set; }

        [DwColumn("name_49")]
        public string Off_Rd_Veh_Type { get; set; }

        [DwColumn("name_50")]
        public string Off_Rd_Eng_Man { get; set; }

        [DwColumn("name_51")]
        public string Off_Rd_Tier_Lvl { get; set; }

        [DwColumn("name_52")]
        public string Off_Rd_Eng_Ser_Nbr { get; set; }

        [DwColumn("name_53")]
        public string Off_Rd_Eng_Hrsp { get; set; }

        [DwColumn("name_54")]
        public string Off_Rd_Exh_Ret_Man { get; set; }

        [DwColumn("name_55")]
        public string Off_Rd_Exh_Ret_Model { get; set; }

        [DwColumn("name_56")]
        public string Off_Rd_Ret_Ver_Lvl { get; set; }

        [DwColumn("name_57")]
        public string Dt_Dealer_Cert { get; set; }

        [DwColumn("name_58")]
        public string Ninety_Day_Cert { get; set; }

        [DwColumn("name_59")]
        public string Claim_Submitted { get; set; }

        [DwColumn("name_60")]
        public string Del_Method_Claim_Rec { get; set; }

        [DwColumn("name_61")]
        public string Dt_Claimed_Rec { get; set; }

        [DwColumn("name_62")]
        public string Admin_Init_Claim_Rec { get; set; }

        [DwColumn("name_63")]
        public string Dt_Claim_Assgned { get; set; }

        [DwColumn("name_64")]
        public string Dt_Charge_Off { get; set; }

        [DwColumn("name_65")]
        public string Amt_Claim_Filed { get; set; }

        [DwColumn("name_66")]
        public string Claim_Recv_By { get; set; }

        [DwColumn("name_67")]
        public string Dt_Claim_To_Man { get; set; }

        [DwColumn("name_68")]
        public string Dt_Claim_Approv_Man { get; set; }

        [DwColumn("name_69")]
        public string Dt_Claim_To_Exec { get; set; }

        [DwColumn("name_70")]
        public string Dt_Claim_Appr_By_Exec { get; set; }

        [DwColumn("name_71")]
        public string Amt_Of_Approv_Claim { get; set; }

        [DwColumn("name_72")]
        public string Dt_Appr_Clam_Sent_To_Admin { get; set; }

        [DwColumn("name_73")]
        public string Dt_Appr_Claim_Sent_To_Trustee { get; set; }

        [DwColumn("name_74")]
        public string Claim_Hold_Date { get; set; }

        [DwColumn("name_75")]
        public string Claim_Hold_Reason { get; set; }

        [DwColumn("name_76")]
        public string Claim_Recoveries { get; set; }

    }

}