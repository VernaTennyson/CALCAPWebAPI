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
	public class Dddw_Retro_Tech_TypeController : ControllerBase
	{
		private readonly IDddw_Retro_Tech_TypeService _idddw_retro_tech_typeservice;

		public Dddw_Retro_Tech_TypeController(IDddw_Retro_Tech_TypeService idddw_retro_tech_typeservice)
		{
			_idddw_retro_tech_typeservice = idddw_retro_tech_typeservice;
		}

		//GET api/Dddw_Retro_Tech_Type/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Retro_Tech_Type>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Retro_Tech_Type>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_retro_tech_typeservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
