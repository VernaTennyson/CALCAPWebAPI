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
	public class D_Calcap_Lea_Loan_ImportController : ControllerBase
	{
		private readonly ID_Calcap_Lea_Loan_ImportService _id_calcap_lea_loan_importservice;

		public D_Calcap_Lea_Loan_ImportController(ID_Calcap_Lea_Loan_ImportService id_calcap_lea_loan_importservice)
		{
			_id_calcap_lea_loan_importservice = id_calcap_lea_loan_importservice;
		}

		//POST api/D_Calcap_Lea_Loan_Import/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Calcap_Lea_Loan_Import> dataStore)
		{
			try
			{
				var result = await _id_calcap_lea_loan_importservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Calcap_Lea_Loan_Import/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Calcap_Lea_Loan_Import>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Calcap_Lea_Loan_Import>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_calcap_lea_loan_importservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
