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
	public class Dddw_CountiesController : ControllerBase
	{
		private readonly IDddw_CountiesService _idddw_countiesservice;

		public Dddw_CountiesController(IDddw_CountiesService idddw_countiesservice)
		{
			_idddw_countiesservice = idddw_countiesservice;
		}

		//POST api/Dddw_Counties/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dddw_Counties> dataStore)
		{
			try
			{
				var result = await _idddw_countiesservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dddw_Counties/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Counties>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Counties>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_countiesservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
