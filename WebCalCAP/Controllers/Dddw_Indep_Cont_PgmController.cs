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
	public class Dddw_Indep_Cont_PgmController : ControllerBase
	{
		private readonly IDddw_Indep_Cont_PgmService _idddw_indep_cont_pgmservice;

		public Dddw_Indep_Cont_PgmController(IDddw_Indep_Cont_PgmService idddw_indep_cont_pgmservice)
		{
			_idddw_indep_cont_pgmservice = idddw_indep_cont_pgmservice;
		}

		//GET api/Dddw_Indep_Cont_Pgm/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Indep_Cont_Pgm>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Indep_Cont_Pgm>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_indep_cont_pgmservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
