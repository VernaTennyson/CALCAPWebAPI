using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Collections.Generic;
using DWNet.Data;
using WebCalCAP.Services;
using System.Threading.Tasks;
using System.Threading;
using WebCalCAP.Models;

namespace WebCalCAP.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class D_Ssbci_Pdf_RptController : ControllerBase
	{
		private readonly ID_Ssbci_Pdf_RptService _id_ssbci_pdf_rptservice;

		public D_Ssbci_Pdf_RptController(ID_Ssbci_Pdf_RptService id_ssbci_pdf_rptservice)
		{
			_id_ssbci_pdf_rptservice = id_ssbci_pdf_rptservice;
		}

		//GET api/D_Ssbci_Pdf_Rpt/Retrieve/{a_id}
		[HttpGet("{a_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Ssbci_Pdf_Rpt>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Ssbci_Pdf_Rpt>>> RetrieveAsync(double? a_id)
		{
			try
			{
				var result = await _id_ssbci_pdf_rptservice.RetrieveAsync(a_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
