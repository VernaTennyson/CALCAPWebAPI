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
	public class D_Abs_Fad_Conv_SqlController : ControllerBase
	{
		private readonly ID_Abs_Fad_Conv_SqlService _id_abs_fad_conv_sqlservice;

		public D_Abs_Fad_Conv_SqlController(ID_Abs_Fad_Conv_SqlService id_abs_fad_conv_sqlservice)
		{
			_id_abs_fad_conv_sqlservice = id_abs_fad_conv_sqlservice;
		}

		//POST api/D_Abs_Fad_Conv_Sql/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Fad_Conv_Sql> dataStore)
		{
			try
			{
				var result = await _id_abs_fad_conv_sqlservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Fad_Conv_Sql/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Fad_Conv_Sql>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Fad_Conv_Sql>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_fad_conv_sqlservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
