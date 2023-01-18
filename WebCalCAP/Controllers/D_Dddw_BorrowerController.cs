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
	public class D_Dddw_BorrowerController : ControllerBase
	{
		private readonly ID_Dddw_BorrowerService _id_dddw_borrowerservice;

		public D_Dddw_BorrowerController(ID_Dddw_BorrowerService id_dddw_borrowerservice)
		{
			_id_dddw_borrowerservice = id_dddw_borrowerservice;
		}

		//POST api/D_Dddw_Borrower/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Dddw_Borrower> dataStore)
		{
			try
			{
				var result = await _id_dddw_borrowerservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Dddw_Borrower/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Dddw_Borrower>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Dddw_Borrower>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_dddw_borrowerservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
