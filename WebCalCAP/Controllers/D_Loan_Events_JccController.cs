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
	public class D_Loan_Events_JccController : ControllerBase
	{
		private readonly ID_Loan_Events_JccService _id_loan_events_jccservice;

		public D_Loan_Events_JccController(ID_Loan_Events_JccService id_loan_events_jccservice)
		{
			_id_loan_events_jccservice = id_loan_events_jccservice;
		}

		//POST api/D_Loan_Events_Jcc/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Loan_Events_Jcc> dataStore)
		{
			try
			{
				var result = await _id_loan_events_jccservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Loan_Events_Jcc/Retrieve/{a_loa_id}
		[HttpGet("{a_loa_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Loan_Events_Jcc>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Loan_Events_Jcc>>> RetrieveAsync(double? a_loa_id)
		{
			try
			{
				var result = await _id_loan_events_jccservice.RetrieveAsync(a_loa_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
