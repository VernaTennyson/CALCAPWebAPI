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
	public class Dddw_Program_TypeController : ControllerBase
	{
		private readonly IDddw_Program_TypeService _idddw_program_typeservice;

		public Dddw_Program_TypeController(IDddw_Program_TypeService idddw_program_typeservice)
		{
			_idddw_program_typeservice = idddw_program_typeservice;
		}

		//GET api/Dddw_Program_Type/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Program_Type>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Program_Type>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_program_typeservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
