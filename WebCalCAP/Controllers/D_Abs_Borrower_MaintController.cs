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
	public class D_Abs_Borrower_MaintController : ControllerBase
	{
		private readonly ID_Abs_Borrower_MaintService _id_abs_borrower_maintservice;

		public D_Abs_Borrower_MaintController(ID_Abs_Borrower_MaintService id_abs_borrower_maintservice)
		{
			_id_abs_borrower_maintservice = id_abs_borrower_maintservice;
		}

		//POST api/D_Abs_Borrower_Maint/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Borrower_Maint> dataStore)
		{
			try
			{
				var result = await _id_abs_borrower_maintservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Borrower_Maint/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Borrower_Maint>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Borrower_Maint>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_borrower_maintservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
