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
	public class D_Abs_Evc_UpdateController : ControllerBase
	{
		private readonly ID_Abs_Evc_UpdateService _id_abs_evc_updateservice;

		public D_Abs_Evc_UpdateController(ID_Abs_Evc_UpdateService id_abs_evc_updateservice)
		{
			_id_abs_evc_updateservice = id_abs_evc_updateservice;
		}

		//GET api/D_Abs_Evc_Update/Retrieve/{a_loa_id}
		[HttpGet("{a_loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Evc_Update>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Evc_Update>>> RetrieveAsync(double? a_loa_id)
		{
			try
			{
				var result = await _id_abs_evc_updateservice.RetrieveAsync(a_loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
