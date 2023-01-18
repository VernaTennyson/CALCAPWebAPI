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
	public class D_Abs_CommentsController : ControllerBase
	{
		private readonly ID_Abs_CommentsService _id_abs_commentsservice;

		public D_Abs_CommentsController(ID_Abs_CommentsService id_abs_commentsservice)
		{
			_id_abs_commentsservice = id_abs_commentsservice;
		}

		//POST api/D_Abs_Comments/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Comments> dataStore)
		{
			try
			{
				var result = await _id_abs_commentsservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Comments/Retrieve/{p_loa_id}/{p_type}
		[HttpGet("{p_loa_id}/{p_type}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Comments>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Comments>>> RetrieveAsync(double? p_loa_id, string p_type)
		{
			try
			{
				var result = await _id_abs_commentsservice.RetrieveAsync(p_loa_id, p_type, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
