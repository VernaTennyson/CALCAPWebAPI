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
	public class D_Abs_Import_InstitutionsController : ControllerBase
	{
		private readonly ID_Abs_Import_InstitutionsService _id_abs_import_institutionsservice;

		public D_Abs_Import_InstitutionsController(ID_Abs_Import_InstitutionsService id_abs_import_institutionsservice)
		{
			_id_abs_import_institutionsservice = id_abs_import_institutionsservice;
		}

		//GET api/D_Abs_Import_Institutions/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Import_Institutions>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Import_Institutions>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_import_institutionsservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
