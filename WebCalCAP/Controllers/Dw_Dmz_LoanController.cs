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
	public class Dw_Dmz_LoanController : ControllerBase
	{
		private readonly IDw_Dmz_LoanService _idw_dmz_loanservice;

		public Dw_Dmz_LoanController(IDw_Dmz_LoanService idw_dmz_loanservice)
		{
			_idw_dmz_loanservice = idw_dmz_loanservice;
		}

		//POST api/Dw_Dmz_Loan/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dw_Dmz_Loan> dataStore)
		{
			try
			{
				var result = await _idw_dmz_loanservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dw_Dmz_Loan/Retrieve/{a_f_lenderid}
		[HttpGet("{a_f_lenderid}")]
		[ProducesResponseType(typeof(IDataStore<Dw_Dmz_Loan>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dw_Dmz_Loan>>> RetrieveAsync(double? a_f_lenderid)
		{
			try
			{
				var result = await _idw_dmz_loanservice.RetrieveAsync(a_f_lenderid, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
