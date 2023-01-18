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
	public class D_Abs_Evcs_Supplemental_UpdateController : ControllerBase
	{
		private readonly ID_Abs_Evcs_Supplemental_UpdateService _id_abs_evcs_supplemental_updateservice;

		public D_Abs_Evcs_Supplemental_UpdateController(ID_Abs_Evcs_Supplemental_UpdateService id_abs_evcs_supplemental_updateservice)
		{
			_id_abs_evcs_supplemental_updateservice = id_abs_evcs_supplemental_updateservice;
		}

		//POST api/D_Abs_Evcs_Supplemental_Update/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Evcs_Supplemental_Update> dataStore)
		{
			try
			{
				var result = await _id_abs_evcs_supplemental_updateservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Evcs_Supplemental_Update/Retrieve/{a_evc_id}
		[HttpGet("{a_evc_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Evcs_Supplemental_Update>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Evcs_Supplemental_Update>>> RetrieveAsync(double? a_evc_id)
		{
			try
			{
				var result = await _id_abs_evcs_supplemental_updateservice.RetrieveAsync(a_evc_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
