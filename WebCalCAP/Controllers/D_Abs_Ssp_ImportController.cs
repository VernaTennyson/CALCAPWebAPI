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
	public class D_Abs_Ssp_ImportController : ControllerBase
	{
		private readonly ID_Abs_Ssp_ImportService _id_abs_ssp_importservice;

		public D_Abs_Ssp_ImportController(ID_Abs_Ssp_ImportService id_abs_ssp_importservice)
		{
			_id_abs_ssp_importservice = id_abs_ssp_importservice;
		}

		//POST api/D_Abs_Ssp_Import/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Ssp_Import> dataStore)
		{
			try
			{
				var result = await _id_abs_ssp_importservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Ssp_Import/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Ssp_Import>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Ssp_Import>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_ssp_importservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
