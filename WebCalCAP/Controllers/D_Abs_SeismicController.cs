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
	public class D_Abs_SeismicController : ControllerBase
	{
		private readonly ID_Abs_SeismicService _id_abs_seismicservice;

		public D_Abs_SeismicController(ID_Abs_SeismicService id_abs_seismicservice)
		{
			_id_abs_seismicservice = id_abs_seismicservice;
		}

		//POST api/D_Abs_Seismic/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Seismic> dataStore)
		{
			try
			{
				var result = await _id_abs_seismicservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Seismic/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Seismic>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Seismic>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_seismicservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
