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
	public class D_Arbweb_Truck_RptController : ControllerBase
	{
		private readonly ID_Arbweb_Truck_RptService _id_arbweb_truck_rptservice;

		public D_Arbweb_Truck_RptController(ID_Arbweb_Truck_RptService id_arbweb_truck_rptservice)
		{
			_id_arbweb_truck_rptservice = id_arbweb_truck_rptservice;
		}

		//GET api/D_Arbweb_Truck_Rpt/Retrieve/{a_arb_id}
		[HttpGet("{a_arb_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Arbweb_Truck_Rpt>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Arbweb_Truck_Rpt>>> RetrieveAsync(double? a_arb_id)
		{
			try
			{
				var result = await _id_arbweb_truck_rptservice.RetrieveAsync(a_arb_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
