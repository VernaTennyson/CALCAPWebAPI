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
	public class D_Abs_Calcap_Staff_TempController : ControllerBase
	{
		private readonly ID_Abs_Calcap_Staff_TempService _id_abs_calcap_staff_tempservice;

		public D_Abs_Calcap_Staff_TempController(ID_Abs_Calcap_Staff_TempService id_abs_calcap_staff_tempservice)
		{
			_id_abs_calcap_staff_tempservice = id_abs_calcap_staff_tempservice;
		}

		//POST api/D_Abs_Calcap_Staff_Temp/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Calcap_Staff_Temp> dataStore)
		{
			try
			{
				var result = await _id_abs_calcap_staff_tempservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Calcap_Staff_Temp/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Calcap_Staff_Temp>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Calcap_Staff_Temp>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_calcap_staff_tempservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
