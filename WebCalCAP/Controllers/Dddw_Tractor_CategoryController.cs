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
	public class Dddw_Tractor_CategoryController : ControllerBase
	{
		private readonly IDddw_Tractor_CategoryService _idddw_tractor_categoryservice;

		public Dddw_Tractor_CategoryController(IDddw_Tractor_CategoryService idddw_tractor_categoryservice)
		{
			_idddw_tractor_categoryservice = idddw_tractor_categoryservice;
		}

		//GET api/Dddw_Tractor_Category/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Tractor_Category>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Tractor_Category>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_tractor_categoryservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
