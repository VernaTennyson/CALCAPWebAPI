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
	public class D_Abs_Lender_DetailController : ControllerBase
	{
		private readonly ID_Abs_Lender_DetailService _id_abs_lender_detailservice;

		public D_Abs_Lender_DetailController(ID_Abs_Lender_DetailService id_abs_lender_detailservice)
		{
			_id_abs_lender_detailservice = id_abs_lender_detailservice;
		}

		//POST api/D_Abs_Lender_Detail/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Lender_Detail> dataStore)
		{
			try
			{
				var result = await _id_abs_lender_detailservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Lender_Detail/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Lender_Detail>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Lender_Detail>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_lender_detailservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
