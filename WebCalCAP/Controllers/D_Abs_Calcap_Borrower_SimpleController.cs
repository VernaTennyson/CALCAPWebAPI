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
	public class D_Abs_Calcap_Borrower_SimpleController : ControllerBase
	{
		private readonly ID_Abs_Calcap_Borrower_SimpleService _id_abs_calcap_borrower_simpleservice;

		public D_Abs_Calcap_Borrower_SimpleController(ID_Abs_Calcap_Borrower_SimpleService id_abs_calcap_borrower_simpleservice)
		{
			_id_abs_calcap_borrower_simpleservice = id_abs_calcap_borrower_simpleservice;
		}

		//POST api/D_Abs_Calcap_Borrower_Simple/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Calcap_Borrower_Simple> dataStore)
		{
			try
			{
				var result = await _id_abs_calcap_borrower_simpleservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Calcap_Borrower_Simple/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Calcap_Borrower_Simple>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Calcap_Borrower_Simple>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_calcap_borrower_simpleservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
