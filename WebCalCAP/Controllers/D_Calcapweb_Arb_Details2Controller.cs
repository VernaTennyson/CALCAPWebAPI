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
	public class D_Calcapweb_Arb_Details2Controller : ControllerBase
	{
		private readonly ID_Calcapweb_Arb_Details2Service _id_calcapweb_arb_details2service;

		public D_Calcapweb_Arb_Details2Controller(ID_Calcapweb_Arb_Details2Service id_calcapweb_arb_details2service)
		{
			_id_calcapweb_arb_details2service = id_calcapweb_arb_details2service;
		}

		//POST api/D_Calcapweb_Arb_Details2/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Calcapweb_Arb_Details2> dataStore)
		{
			try
			{
				var result = await _id_calcapweb_arb_details2service.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Calcapweb_Arb_Details2/Retrieve/{a_arb_id}
		[HttpGet("{a_arb_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Calcapweb_Arb_Details2>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Calcapweb_Arb_Details2>>> RetrieveAsync(double? a_arb_id)
		{
			try
			{
				var result = await _id_calcapweb_arb_details2service.RetrieveAsync(a_arb_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
