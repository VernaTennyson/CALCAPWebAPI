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
	public class D_Import_ExternalController : ControllerBase
	{
		private readonly ID_Import_ExternalService _id_import_externalservice;

		public D_Import_ExternalController(ID_Import_ExternalService id_import_externalservice)
		{
			_id_import_externalservice = id_import_externalservice;
		}

		//GET api/D_Import_External/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Import_External>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Import_External>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_import_externalservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
