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
	public class D_Import_IntakeController : ControllerBase
	{
		private readonly ID_Import_IntakeService _id_import_intakeservice;

		public D_Import_IntakeController(ID_Import_IntakeService id_import_intakeservice)
		{
			_id_import_intakeservice = id_import_intakeservice;
		}

		//GET api/D_Import_Intake/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Import_Intake>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Import_Intake>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_import_intakeservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
