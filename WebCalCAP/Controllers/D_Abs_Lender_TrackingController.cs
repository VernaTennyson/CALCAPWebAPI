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
	public class D_Abs_Lender_TrackingController : ControllerBase
	{
		private readonly ID_Abs_Lender_TrackingService _id_abs_lender_trackingservice;

		public D_Abs_Lender_TrackingController(ID_Abs_Lender_TrackingService id_abs_lender_trackingservice)
		{
			_id_abs_lender_trackingservice = id_abs_lender_trackingservice;
		}

		//POST api/D_Abs_Lender_Tracking/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Lender_Tracking> dataStore)
		{
			try
			{
				var result = await _id_abs_lender_trackingservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Lender_Tracking/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Lender_Tracking>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Lender_Tracking>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_lender_trackingservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
