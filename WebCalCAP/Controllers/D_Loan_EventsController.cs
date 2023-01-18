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
	public class D_Loan_EventsController : ControllerBase
	{
		private readonly ID_Loan_EventsService _id_loan_eventsservice;

		public D_Loan_EventsController(ID_Loan_EventsService id_loan_eventsservice)
		{
			_id_loan_eventsservice = id_loan_eventsservice;
		}

		//POST api/D_Loan_Events/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Loan_Events> dataStore)
		{
			try
			{
				var result = await _id_loan_eventsservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Loan_Events/Retrieve/{a_loa_id}
		[HttpGet("{a_loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Loan_Events>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Loan_Events>>> RetrieveAsync(double? a_loa_id)
		{
			try
			{
				var result = await _id_loan_eventsservice.RetrieveAsync(a_loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
