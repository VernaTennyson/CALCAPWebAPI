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
	public class D_Loan_DetailController : ControllerBase
	{
		private readonly ID_Loan_DetailService _id_loan_detailservice;

		public D_Loan_DetailController(ID_Loan_DetailService id_loan_detailservice)
		{
			_id_loan_detailservice = id_loan_detailservice;
		}

		//POST api/D_Loan_Detail/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Loan_Detail> dataStore)
		{
			try
			{
				var result = await _id_loan_detailservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Loan_Detail/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Loan_Detail>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Loan_Detail>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_loan_detailservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
