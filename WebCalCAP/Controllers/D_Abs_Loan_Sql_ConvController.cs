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
	public class D_Abs_Loan_Sql_ConvController : ControllerBase
	{
		private readonly ID_Abs_Loan_Sql_ConvService _id_abs_loan_sql_convservice;

		public D_Abs_Loan_Sql_ConvController(ID_Abs_Loan_Sql_ConvService id_abs_loan_sql_convservice)
		{
			_id_abs_loan_sql_convservice = id_abs_loan_sql_convservice;
		}

		//POST api/D_Abs_Loan_Sql_Conv/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Loan_Sql_Conv> dataStore)
		{
			try
			{
				var result = await _id_abs_loan_sql_convservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Loan_Sql_Conv/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Loan_Sql_Conv>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Loan_Sql_Conv>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_loan_sql_convservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
