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
	public class D_Loan_Detail_OrigController : ControllerBase
	{
		private readonly ID_Loan_Detail_OrigService _id_loan_detail_origservice;

		public D_Loan_Detail_OrigController(ID_Loan_Detail_OrigService id_loan_detail_origservice)
		{
			_id_loan_detail_origservice = id_loan_detail_origservice;
		}

		//POST api/D_Loan_Detail_Orig/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Loan_Detail_Orig> dataStore)
		{
			try
			{
				var result = await _id_loan_detail_origservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Loan_Detail_Orig/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Loan_Detail_Orig>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Loan_Detail_Orig>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_loan_detail_origservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
