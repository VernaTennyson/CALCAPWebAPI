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
	public class Dddw_Employee_NamesController : ControllerBase
	{
		private readonly IDddw_Employee_NamesService _idddw_employee_namesservice;

		public Dddw_Employee_NamesController(IDddw_Employee_NamesService idddw_employee_namesservice)
		{
			_idddw_employee_namesservice = idddw_employee_namesservice;
		}

		//POST api/Dddw_Employee_Names/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dddw_Employee_Names> dataStore)
		{
			try
			{
				var result = await _idddw_employee_namesservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dddw_Employee_Names/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Employee_Names>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Employee_Names>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_employee_namesservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
