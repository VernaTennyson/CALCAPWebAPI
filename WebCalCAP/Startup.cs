using System;
using System.IO.Compression;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SnapObjects.Data;
using SnapObjects.Data.SqlServer;
using SnapObjects.Data.AspNetCore;
using DWNet.Data.AspNetCore;
using WebCalCAP.Services;
using WebCalCAP.Services.Impl;


namespace WebCalCAP
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(m =>
            {
                m.UseCoreIntegrated();

                m.UsePowerBuilderIntegrated();
            });

            services.AddDataContext<CalCAPDataContext>(m => m.UseSqlServer(this.Configuration, "ENT_DB"));
            services.AddScoped<IDddw_Arb_Fuel_TypeService, Dddw_Arb_Fuel_TypeService>();
            services.AddScoped<IDddw_Arb_Loan_TypeService, Dddw_Arb_Loan_TypeService>();
            services.AddScoped<IDddw_BorrowerService, Dddw_BorrowerService>();
            services.AddScoped<IDddw_CountiesService, Dddw_CountiesService>();
            services.AddScoped<IDddw_Counties_WebService, Dddw_Counties_WebService>();
            services.AddScoped<IDddw_Csp_Loan_CategoryService, Dddw_Csp_Loan_CategoryService>();
            services.AddScoped<IDddw_Csp_Payment_ReasonService, Dddw_Csp_Payment_ReasonService>();
            services.AddScoped<IDddw_Employee_NamesService, Dddw_Employee_NamesService>();
            services.AddScoped<IDddw_EventService, Dddw_EventService>();
            services.AddScoped<IDddw_Event_AdminService, Dddw_Event_AdminService>();
            services.AddScoped<IDddw_Event_AnalystService, Dddw_Event_AnalystService>();
            services.AddScoped<IDddw_Event_ManagerService, Dddw_Event_ManagerService>();
            services.AddScoped<IDddw_Event_StatusService, Dddw_Event_StatusService>();
            services.AddScoped<IDddw_FundingService, Dddw_FundingService>();
            services.AddScoped<IDddw_Indep_Cont_PgmService, Dddw_Indep_Cont_PgmService>();
            services.AddScoped<IDddw_Institution_TypeService, Dddw_Institution_TypeService>();
            services.AddScoped<IDddw_Institution_Type_WebService, Dddw_Institution_Type_WebService>();
            services.AddScoped<IDddw_LenderService, Dddw_LenderService>();
            services.AddScoped<IDddw_Lender_Contact_TypeService, Dddw_Lender_Contact_TypeService>();
            services.AddScoped<IDddw_Lender_FundingService, Dddw_Lender_FundingService>();
            services.AddScoped<IDddw_Lender_StatusService, Dddw_Lender_StatusService>();
            services.AddScoped<IDddw_LoanService, Dddw_LoanService>();
            services.AddScoped<IDddw_Or_Equipment_CategoryService, Dddw_Or_Equipment_CategoryService>();
            services.AddScoped<IDddw_Or_Tier_LevelService, Dddw_Or_Tier_LevelService>();
            services.AddScoped<IDddw_Program_TypeService, Dddw_Program_TypeService>();
            services.AddScoped<IDddw_Reporting_TypeService, Dddw_Reporting_TypeService>();
            services.AddScoped<IDddw_Retro_Tech_TypeService, Dddw_Retro_Tech_TypeService>();
            services.AddScoped<IDddw_Sev_Aff_ComService, Dddw_Sev_Aff_ComService>();
            services.AddScoped<IDddw_Tractor_CategoryService, Dddw_Tractor_CategoryService>();
            services.AddScoped<IDddw_Year_Drop_DownService, Dddw_Year_Drop_DownService>();
            services.AddScoped<IDw_Dmz_LoanService, Dw_Dmz_LoanService>();
            services.AddScoped<IDw_Fia_InstitutionService, Dw_Fia_InstitutionService>();
            services.AddScoped<IDw_Lea_Loan_App_Lender_BorrowerService, Dw_Lea_Loan_App_Lender_BorrowerService>();
            services.AddScoped<IDw_Lea_Loan_App_LoanService, Dw_Lea_Loan_App_LoanService>();
            services.AddScoped<ID_Abs_Arb_Conv_SqlService, D_Abs_Arb_Conv_SqlService>();
            services.AddScoped<ID_Abs_Arb_ImportService, D_Abs_Arb_ImportService>();
            services.AddScoped<ID_Abs_Borrower_Dba_PickService, D_Abs_Borrower_Dba_PickService>();
            services.AddScoped<ID_Abs_Borrower_MaintService, D_Abs_Borrower_MaintService>();
            services.AddScoped<ID_Abs_Borrower_Maint_ListService, D_Abs_Borrower_Maint_ListService>();
            services.AddScoped<ID_Abs_Borrower_Name_PickService, D_Abs_Borrower_Name_PickService>();
            services.AddScoped<ID_Abs_Borrower_PickService, D_Abs_Borrower_PickService>();
            services.AddScoped<ID_Abs_Calcap_Borrower_SimpleService, D_Abs_Calcap_Borrower_SimpleService>();
            services.AddScoped<ID_Abs_Calcap_EnrollmentService, D_Abs_Calcap_EnrollmentService>();
            services.AddScoped<ID_Abs_Calcap_Lender_SimpleService, D_Abs_Calcap_Lender_SimpleService>();
            services.AddScoped<ID_Abs_Calcap_List_MaintService, D_Abs_Calcap_List_MaintService>();
            services.AddScoped<ID_Abs_Calcap_Purpose_LoanService, D_Abs_Calcap_Purpose_LoanService>();
            services.AddScoped<ID_Abs_Calcap_StaffService, D_Abs_Calcap_StaffService>();
            services.AddScoped<ID_Abs_Calcap_Staff_TempService, D_Abs_Calcap_Staff_TempService>();
            services.AddScoped<ID_Abs_Cla_Conv_SqlService, D_Abs_Cla_Conv_SqlService>();
            services.AddScoped<ID_Abs_CommentsService, D_Abs_CommentsService>();
            services.AddScoped<ID_Abs_Comp_RptService, D_Abs_Comp_RptService>();
            services.AddScoped<ID_Abs_Csi_Conv_SqlService, D_Abs_Csi_Conv_SqlService>();
            services.AddScoped<ID_Abs_Csp_Conv_SqlService, D_Abs_Csp_Conv_SqlService>();
            services.AddScoped<ID_Abs_Csp_InfoService, D_Abs_Csp_InfoService>();
            services.AddScoped<ID_Abs_Csp_PaymentsService, D_Abs_Csp_PaymentsService>();
            services.AddScoped<ID_Abs_Evcs_Supplemental_UpdateService, D_Abs_Evcs_Supplemental_UpdateService>();
            services.AddScoped<ID_Abs_Evc_Conv_SqlService, D_Abs_Evc_Conv_SqlService>();
            services.AddScoped<ID_Abs_Evc_RebateService, D_Abs_Evc_RebateService>();
            services.AddScoped<ID_Abs_Evc_UpdateService, D_Abs_Evc_UpdateService>();
            services.AddScoped<ID_Abs_Evn_Conv_SqlService, D_Abs_Evn_Conv_SqlService>();
            services.AddScoped<ID_Abs_Evs_Conv_SqlService, D_Abs_Evs_Conv_SqlService>();
            services.AddScoped<ID_Abs_Fad_Conv_SqlService, D_Abs_Fad_Conv_SqlService>();
            services.AddScoped<ID_Abs_FiaService, D_Abs_FiaService>();
            services.AddScoped<ID_Abs_Fnd_Conv_SqlService, D_Abs_Fnd_Conv_SqlService>();
            services.AddScoped<ID_Abs_Fund_AdjustmentService, D_Abs_Fund_AdjustmentService>();
            services.AddScoped<ID_Abs_Fund_Adjustment_BkService, D_Abs_Fund_Adjustment_BkService>();
            services.AddScoped<ID_Abs_Import_InstitutionsService, D_Abs_Import_InstitutionsService>();
            services.AddScoped<ID_Abs_Lender_ContactsService, D_Abs_Lender_ContactsService>();
            services.AddScoped<ID_Abs_Lender_DetailService, D_Abs_Lender_DetailService>();
            services.AddScoped<ID_Abs_Lender_MaintService, D_Abs_Lender_MaintService>();
            services.AddScoped<ID_Abs_Lender_Maint_ListService, D_Abs_Lender_Maint_ListService>();
            services.AddScoped<ID_Abs_Lender_Maint_Service, D_Abs_Lender_Maint_Service>();
            services.AddScoped<ID_Abs_Lender_PickService, D_Abs_Lender_PickService>();
            services.AddScoped<ID_Abs_Lender_ReportingService, D_Abs_Lender_ReportingService>();
            services.AddScoped<ID_Abs_Lender_TrackingService, D_Abs_Lender_TrackingService>();
            services.AddScoped<ID_Abs_Loan_Sql_ConvService, D_Abs_Loan_Sql_ConvService>();
            services.AddScoped<ID_Abs_Program_Type_MaintService, D_Abs_Program_Type_MaintService>();
            services.AddScoped<ID_Abs_Program_Type_Maint_ListService, D_Abs_Program_Type_Maint_ListService>();
            services.AddScoped<ID_Abs_Reb_Conv_SqlService, D_Abs_Reb_Conv_SqlService>();
            services.AddScoped<ID_Abs_Reb_EventsService, D_Abs_Reb_EventsService>();
            services.AddScoped<ID_Abs_Rec_Conv_SqlService, D_Abs_Rec_Conv_SqlService>();
            services.AddScoped<ID_Abs_SeismicService, D_Abs_SeismicService>();
            services.AddScoped<ID_Abs_Ssp_ImportService, D_Abs_Ssp_ImportService>();
            services.AddScoped<ID_ArbService, D_ArbService>();
            services.AddScoped<ID_Arbweb_Decd_RptService, D_Arbweb_Decd_RptService>();
            services.AddScoped<ID_Arbweb_HeaderService, D_Arbweb_HeaderService>();
            services.AddScoped<ID_Arbweb_Trailer_RptService, D_Arbweb_Trailer_RptService>();
            services.AddScoped<ID_Arbweb_Truck_RptService, D_Arbweb_Truck_RptService>();
            services.AddScoped<ID_Arb_DetailsService, D_Arb_DetailsService>();
            services.AddScoped<ID_Arb_OrigService, D_Arb_OrigService>();
            services.AddScoped<ID_Arb_RptService, D_Arb_RptService>();
            services.AddScoped<ID_Arb_Rpt_OrigService, D_Arb_Rpt_OrigService>();
            services.AddScoped<ID_BorrowerService, D_BorrowerService>();
            services.AddScoped<ID_Calcapweb_Ada_SearchService, D_Calcapweb_Ada_SearchService>();
            services.AddScoped<ID_Calcapweb_Arb_Details2Service, D_Calcapweb_Arb_Details2Service>();
            services.AddScoped<ID_Calcapweb_Fia_SearchService, D_Calcapweb_Fia_SearchService>();
            services.AddScoped<ID_Calcapweb_Ssbci_SearchService, D_Calcapweb_Ssbci_SearchService>();
            services.AddScoped<ID_Calcapweb_SspService, D_Calcapweb_SspService>();
            services.AddScoped<ID_Calcapweb_Ssp_SearchService, D_Calcapweb_Ssp_SearchService>();
            services.AddScoped<ID_Calcap_Arb_SearchService, D_Calcap_Arb_SearchService>();
            services.AddScoped<ID_Calcap_CspService, D_Calcap_CspService>();
            services.AddScoped<ID_Calcap_Csp_SearchService, D_Calcap_Csp_SearchService>();
            services.AddScoped<ID_Calcap_EvcsService, D_Calcap_EvcsService>();
            services.AddScoped<ID_Calcap_Evcs_SearchService, D_Calcap_Evcs_SearchService>();
            services.AddScoped<ID_Calcap_Lea_Loan_ImportService, D_Calcap_Lea_Loan_ImportService>();
            services.AddScoped<ID_Calcap_Len_Import_AdobeService, D_Calcap_Len_Import_AdobeService>();
            services.AddScoped<ID_Calcap_SspService, D_Calcap_SspService>();
            services.AddScoped<ID_ClaimsService, D_ClaimsService>();
            services.AddScoped<ID_Claim_EventsService, D_Claim_EventsService>();
            services.AddScoped<ID_Dddw_BorrowerService, D_Dddw_BorrowerService>();
            services.AddScoped<ID_Dddw_Loan_TypeService, D_Dddw_Loan_TypeService>();
            services.AddScoped<ID_Ddlb_LenderService, D_Ddlb_LenderService>();
            services.AddScoped<ID_FundingService, D_FundingService>();
            services.AddScoped<ID_Get_Roles_SqlserverService, D_Get_Roles_SqlserverService>();
            services.AddScoped<ID_Gis_JsonService, D_Gis_JsonService>();
            services.AddScoped<ID_Import_CalcapService, D_Import_CalcapService>();
            services.AddScoped<ID_Import_ExternalService, D_Import_ExternalService>();
            services.AddScoped<ID_Import_IntakeService, D_Import_IntakeService>();
            services.AddScoped<ID_Import_New_AccessService, D_Import_New_AccessService>();
            services.AddScoped<ID_LenderService, D_LenderService>();
            services.AddScoped<ID_Lender_EventsService, D_Lender_EventsService>();
            services.AddScoped<ID_Lender_Funding_SourcesService, D_Lender_Funding_SourcesService>();
            services.AddScoped<ID_LoansService, D_LoansService>();
            services.AddScoped<ID_Loans_JccService, D_Loans_JccService>();
            services.AddScoped<ID_Loans_TestService, D_Loans_TestService>();
            services.AddScoped<ID_Loan_DetailService, D_Loan_DetailService>();
            services.AddScoped<ID_Loan_Detail_OrigService, D_Loan_Detail_OrigService>();
            services.AddScoped<ID_Loan_EventsService, D_Loan_EventsService>();
            services.AddScoped<ID_Loan_Events_JccService, D_Loan_Events_JccService>();
            services.AddScoped<ID_Loan_FundingService, D_Loan_FundingService>();
            services.AddScoped<ID_RecoveriesService, D_RecoveriesService>();
            services.AddScoped<ID_Ssbci_Pdf_RptService, D_Ssbci_Pdf_RptService>();
            services.AddScoped<IRpt_Analyst_Outstanding_LoansService, Rpt_Analyst_Outstanding_LoansService>();
            services.AddScoped<IRpt_Calcap_Monthly_Claims_DetailService, Rpt_Calcap_Monthly_Claims_DetailService>();
            services.AddScoped<IRpt_Calcap_Weekly_Claims_UpdateService, Rpt_Calcap_Weekly_Claims_UpdateService>();
            services.AddScoped<IRpt_Calcap_Weekly_Intake_UpdateService, Rpt_Calcap_Weekly_Intake_UpdateService>();
            services.AddScoped<IRpt_LenderService, Rpt_LenderService>();
            services.AddScoped<IRpt_Lenders_Active_ArbService, Rpt_Lenders_Active_ArbService>();
            services.AddScoped<IRpt_Loans_By_BorrowerService, Rpt_Loans_By_BorrowerService>();
            services.AddScoped<IRpt_Loans_By_Borrower_MultiService, Rpt_Loans_By_Borrower_MultiService>();
            services.AddScoped<IRpt_Monthly_ActivityService, Rpt_Monthly_ActivityService>();


            services.AddGzipCompression(CompressionLevel.Fastest);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // Adds middleware for redirecting HTTP Requests to HTTPS.
            // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseResponseCompression();

            app.UseDataWindow();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}