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
	public class D_Dddw_Loan_TypeController : ControllerBase
	{
		private readonly ID_Dddw_Loan_TypeService _id_dddw_loan_typeservice;

		public D_Dddw_Loan_TypeController(ID_Dddw_Loan_TypeService id_dddw_loan_typeservice)
		{
			_id_dddw_loan_typeservice = id_dddw_loan_typeservice;
		}

		//GET api/D_Dddw_Loan_Type/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Dddw_Loan_Type>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Dddw_Loan_Type>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_dddw_loan_typeservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
