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
	public class D_Abs_Calcap_StaffController : ControllerBase
	{
		private readonly ID_Abs_Calcap_StaffService _id_abs_calcap_staffservice;

		public D_Abs_Calcap_StaffController(ID_Abs_Calcap_StaffService id_abs_calcap_staffservice)
		{
			_id_abs_calcap_staffservice = id_abs_calcap_staffservice;
		}

		//POST api/D_Abs_Calcap_Staff/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Calcap_Staff> dataStore)
		{
			try
			{
				var result = await _id_abs_calcap_staffservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Calcap_Staff/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Calcap_Staff>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Calcap_Staff>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_calcap_staffservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
