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
	public class D_Arbweb_Decd_RptController : ControllerBase
	{
		private readonly ID_Arbweb_Decd_RptService _id_arbweb_decd_rptservice;

		public D_Arbweb_Decd_RptController(ID_Arbweb_Decd_RptService id_arbweb_decd_rptservice)
		{
			_id_arbweb_decd_rptservice = id_arbweb_decd_rptservice;
		}

		//POST api/D_Arbweb_Decd_Rpt/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Arbweb_Decd_Rpt> dataStore)
		{
			try
			{
				var result = await _id_arbweb_decd_rptservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Arbweb_Decd_Rpt/Retrieve/{a_arb_id}
		[HttpGet("{a_arb_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Arbweb_Decd_Rpt>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Arbweb_Decd_Rpt>>> RetrieveAsync(double? a_arb_id)
		{
			try
			{
				var result = await _id_arbweb_decd_rptservice.RetrieveAsync(a_arb_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
