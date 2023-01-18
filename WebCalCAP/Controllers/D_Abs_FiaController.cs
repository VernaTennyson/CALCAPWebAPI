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
	public class D_Abs_FiaController : ControllerBase
	{
		private readonly ID_Abs_FiaService _id_abs_fiaservice;

		public D_Abs_FiaController(ID_Abs_FiaService id_abs_fiaservice)
		{
			_id_abs_fiaservice = id_abs_fiaservice;
		}

		//POST api/D_Abs_Fia/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Fia> dataStore)
		{
			try
			{
				var result = await _id_abs_fiaservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Fia/Retrieve/{a_lender_number}
		[HttpGet("{a_lender_number}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Fia>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Fia>>> RetrieveAsync(string a_lender_number)
		{
			try
			{
				var result = await _id_abs_fiaservice.RetrieveAsync(a_lender_number, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
