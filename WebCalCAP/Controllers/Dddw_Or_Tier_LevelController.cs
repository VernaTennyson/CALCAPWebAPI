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
	public class Dddw_Or_Tier_LevelController : ControllerBase
	{
		private readonly IDddw_Or_Tier_LevelService _idddw_or_tier_levelservice;

		public Dddw_Or_Tier_LevelController(IDddw_Or_Tier_LevelService idddw_or_tier_levelservice)
		{
			_idddw_or_tier_levelservice = idddw_or_tier_levelservice;
		}

		//GET api/Dddw_Or_Tier_Level/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Or_Tier_Level>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Or_Tier_Level>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_or_tier_levelservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
