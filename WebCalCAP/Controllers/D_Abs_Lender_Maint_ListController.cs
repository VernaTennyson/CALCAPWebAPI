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
	public class D_Abs_Lender_Maint_ListController : ControllerBase
	{
		private readonly ID_Abs_Lender_Maint_ListService _id_abs_lender_maint_listservice;

		public D_Abs_Lender_Maint_ListController(ID_Abs_Lender_Maint_ListService id_abs_lender_maint_listservice)
		{
			_id_abs_lender_maint_listservice = id_abs_lender_maint_listservice;
		}

		//POST api/D_Abs_Lender_Maint_List/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Lender_Maint_List> dataStore)
		{
			try
			{
				var result = await _id_abs_lender_maint_listservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Lender_Maint_List/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Lender_Maint_List>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Lender_Maint_List>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_lender_maint_listservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
