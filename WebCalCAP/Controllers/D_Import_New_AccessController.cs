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
	public class D_Import_New_AccessController : ControllerBase
	{
		private readonly ID_Import_New_AccessService _id_import_new_accessservice;

		public D_Import_New_AccessController(ID_Import_New_AccessService id_import_new_accessservice)
		{
			_id_import_new_accessservice = id_import_new_accessservice;
		}

		//GET api/D_Import_New_Access/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Import_New_Access>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Import_New_Access>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_import_new_accessservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
