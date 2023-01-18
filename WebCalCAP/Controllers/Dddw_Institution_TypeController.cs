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
	public class Dddw_Institution_TypeController : ControllerBase
	{
		private readonly IDddw_Institution_TypeService _idddw_institution_typeservice;

		public Dddw_Institution_TypeController(IDddw_Institution_TypeService idddw_institution_typeservice)
		{
			_idddw_institution_typeservice = idddw_institution_typeservice;
		}

		//GET api/Dddw_Institution_Type/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Institution_Type>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Institution_Type>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_institution_typeservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
