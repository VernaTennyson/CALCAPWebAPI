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
	public class D_Abs_Lender_Maint_Controller : ControllerBase
	{
		private readonly ID_Abs_Lender_Maint_Service _id_abs_lender_maint_service;

		public D_Abs_Lender_Maint_Controller(ID_Abs_Lender_Maint_Service id_abs_lender_maint_service)
		{
			_id_abs_lender_maint_service = id_abs_lender_maint_service;
		}

		//POST api/D_Abs_Lender_Maint_/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Lender_Maint_> dataStore)
		{
			try
			{
				var result = await _id_abs_lender_maint_service.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Lender_Maint_/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Lender_Maint_>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Lender_Maint_>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_lender_maint_service.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
