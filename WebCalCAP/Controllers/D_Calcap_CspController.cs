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
	public class D_Calcap_CspController : ControllerBase
	{
		private readonly ID_Calcap_CspService _id_calcap_cspservice;

		public D_Calcap_CspController(ID_Calcap_CspService id_calcap_cspservice)
		{
			_id_calcap_cspservice = id_calcap_cspservice;
		}

		//POST api/D_Calcap_Csp/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Calcap_Csp> dataStore)
		{
			try
			{
				var result = await _id_calcap_cspservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Calcap_Csp/Retrieve/{a_sup_id}
		[HttpGet("{a_sup_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Calcap_Csp>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Calcap_Csp>>> RetrieveAsync(double? a_sup_id)
		{
			try
			{
				var result = await _id_calcap_cspservice.RetrieveAsync(a_sup_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
