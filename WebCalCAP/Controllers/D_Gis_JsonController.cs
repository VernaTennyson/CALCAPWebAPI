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
	public class D_Gis_JsonController : ControllerBase
	{
		private readonly ID_Gis_JsonService _id_gis_jsonservice;

		public D_Gis_JsonController(ID_Gis_JsonService id_gis_jsonservice)
		{
			_id_gis_jsonservice = id_gis_jsonservice;
		}

		//GET api/D_Gis_Json/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Gis_Json>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Gis_Json>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_gis_jsonservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
