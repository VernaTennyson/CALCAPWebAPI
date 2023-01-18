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
	public class D_RecoveriesController : ControllerBase
	{
		private readonly ID_RecoveriesService _id_recoveriesservice;

		public D_RecoveriesController(ID_RecoveriesService id_recoveriesservice)
		{
			_id_recoveriesservice = id_recoveriesservice;
		}

		//POST api/D_Recoveries/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Recoveries> dataStore)
		{
			try
			{
				var result = await _id_recoveriesservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Recoveries/Retrieve/{a_loa_id}
		[HttpGet("{a_loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Recoveries>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Recoveries>>> RetrieveAsync(double? a_loa_id)
		{
			try
			{
				var result = await _id_recoveriesservice.RetrieveAsync(a_loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
