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
	public class D_Abs_Csp_InfoController : ControllerBase
	{
		private readonly ID_Abs_Csp_InfoService _id_abs_csp_infoservice;

		public D_Abs_Csp_InfoController(ID_Abs_Csp_InfoService id_abs_csp_infoservice)
		{
			_id_abs_csp_infoservice = id_abs_csp_infoservice;
		}

		//POST api/D_Abs_Csp_Info/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Csp_Info> dataStore)
		{
			try
			{
				var result = await _id_abs_csp_infoservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Csp_Info/Retrieve/{p_loa_id}
		[HttpGet("{p_loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Csp_Info>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Csp_Info>>> RetrieveAsync(double? p_loa_id)
		{
			try
			{
				var result = await _id_abs_csp_infoservice.RetrieveAsync(p_loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
