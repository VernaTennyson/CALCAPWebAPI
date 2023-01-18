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
	public class Dddw_Arb_Loan_TypeController : ControllerBase
	{
		private readonly IDddw_Arb_Loan_TypeService _idddw_arb_loan_typeservice;

		public Dddw_Arb_Loan_TypeController(IDddw_Arb_Loan_TypeService idddw_arb_loan_typeservice)
		{
			_idddw_arb_loan_typeservice = idddw_arb_loan_typeservice;
		}

		//GET api/Dddw_Arb_Loan_Type/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Arb_Loan_Type>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Arb_Loan_Type>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_arb_loan_typeservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
