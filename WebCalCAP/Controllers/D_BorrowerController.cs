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
	public class D_BorrowerController : ControllerBase
	{
		private readonly ID_BorrowerService _id_borrowerservice;

		public D_BorrowerController(ID_BorrowerService id_borrowerservice)
		{
			_id_borrowerservice = id_borrowerservice;
		}

		//POST api/D_Borrower/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Borrower> dataStore)
		{
			try
			{
				var result = await _id_borrowerservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Borrower/Retrieve/{a_bor_id}
		[HttpGet("{a_bor_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Borrower>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Borrower>>> RetrieveAsync(double? a_bor_id)
		{
			try
			{
				var result = await _id_borrowerservice.RetrieveAsync(a_bor_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
