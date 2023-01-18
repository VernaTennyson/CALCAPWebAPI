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
	public class Dddw_Sev_Aff_ComController : ControllerBase
	{
		private readonly IDddw_Sev_Aff_ComService _idddw_sev_aff_comservice;

		public Dddw_Sev_Aff_ComController(IDddw_Sev_Aff_ComService idddw_sev_aff_comservice)
		{
			_idddw_sev_aff_comservice = idddw_sev_aff_comservice;
		}

		//GET api/Dddw_Sev_Aff_Com/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Sev_Aff_Com>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Sev_Aff_Com>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_sev_aff_comservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
