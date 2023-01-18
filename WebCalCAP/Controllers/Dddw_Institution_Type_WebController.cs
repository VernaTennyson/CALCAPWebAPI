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
	public class Dddw_Institution_Type_WebController : ControllerBase
	{
		private readonly IDddw_Institution_Type_WebService _idddw_institution_type_webservice;

		public Dddw_Institution_Type_WebController(IDddw_Institution_Type_WebService idddw_institution_type_webservice)
		{
			_idddw_institution_type_webservice = idddw_institution_type_webservice;
		}

		//GET api/Dddw_Institution_Type_Web/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Institution_Type_Web>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Institution_Type_Web>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_institution_type_webservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
