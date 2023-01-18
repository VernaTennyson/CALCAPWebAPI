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
	public class Dddw_Or_Equipment_CategoryController : ControllerBase
	{
		private readonly IDddw_Or_Equipment_CategoryService _idddw_or_equipment_categoryservice;

		public Dddw_Or_Equipment_CategoryController(IDddw_Or_Equipment_CategoryService idddw_or_equipment_categoryservice)
		{
			_idddw_or_equipment_categoryservice = idddw_or_equipment_categoryservice;
		}

		//GET api/Dddw_Or_Equipment_Category/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Or_Equipment_Category>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Or_Equipment_Category>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_or_equipment_categoryservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
