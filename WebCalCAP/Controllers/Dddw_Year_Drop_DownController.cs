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
	public class Dddw_Year_Drop_DownController : ControllerBase
	{
		private readonly IDddw_Year_Drop_DownService _idddw_year_drop_downservice;

		public Dddw_Year_Drop_DownController(IDddw_Year_Drop_DownService idddw_year_drop_downservice)
		{
			_idddw_year_drop_downservice = idddw_year_drop_downservice;
		}

		//GET api/Dddw_Year_Drop_Down/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Year_Drop_Down>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Year_Drop_Down>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_year_drop_downservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
