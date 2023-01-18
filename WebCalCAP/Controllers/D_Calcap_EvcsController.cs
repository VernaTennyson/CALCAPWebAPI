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
	public class D_Calcap_EvcsController : ControllerBase
	{
		private readonly ID_Calcap_EvcsService _id_calcap_evcsservice;

		public D_Calcap_EvcsController(ID_Calcap_EvcsService id_calcap_evcsservice)
		{
			_id_calcap_evcsservice = id_calcap_evcsservice;
		}

		//POST api/D_Calcap_Evcs/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Calcap_Evcs> dataStore)
		{
			try
			{
				var result = await _id_calcap_evcsservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Calcap_Evcs/Retrieve/{a_evcs_id}
		[HttpGet("{a_evcs_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Calcap_Evcs>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Calcap_Evcs>>> RetrieveAsync(double? a_evcs_id)
		{
			try
			{
				var result = await _id_calcap_evcsservice.RetrieveAsync(a_evcs_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
