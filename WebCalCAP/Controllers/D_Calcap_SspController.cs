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
	public class D_Calcap_SspController : ControllerBase
	{
		private readonly ID_Calcap_SspService _id_calcap_sspservice;

		public D_Calcap_SspController(ID_Calcap_SspService id_calcap_sspservice)
		{
			_id_calcap_sspservice = id_calcap_sspservice;
		}

		//POST api/D_Calcap_Ssp/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Calcap_Ssp> dataStore)
		{
			try
			{
				var result = await _id_calcap_sspservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Calcap_Ssp/Retrieve/{a_ssp_id}
		[HttpGet("{a_ssp_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Calcap_Ssp>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Calcap_Ssp>>> RetrieveAsync(double? a_ssp_id)
		{
			try
			{
				var result = await _id_calcap_sspservice.RetrieveAsync(a_ssp_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
