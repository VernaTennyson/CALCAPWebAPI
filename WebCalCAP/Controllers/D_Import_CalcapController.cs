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
	public class D_Import_CalcapController : ControllerBase
	{
		private readonly ID_Import_CalcapService _id_import_calcapservice;

		public D_Import_CalcapController(ID_Import_CalcapService id_import_calcapservice)
		{
			_id_import_calcapservice = id_import_calcapservice;
		}

		//GET api/D_Import_Calcap/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Import_Calcap>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Import_Calcap>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_import_calcapservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
