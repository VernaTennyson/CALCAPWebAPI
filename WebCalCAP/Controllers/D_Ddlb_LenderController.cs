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
	public class D_Ddlb_LenderController : ControllerBase
	{
		private readonly ID_Ddlb_LenderService _id_ddlb_lenderservice;

		public D_Ddlb_LenderController(ID_Ddlb_LenderService id_ddlb_lenderservice)
		{
			_id_ddlb_lenderservice = id_ddlb_lenderservice;
		}

		//POST api/D_Ddlb_Lender/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Ddlb_Lender> dataStore)
		{
			try
			{
				var result = await _id_ddlb_lenderservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Ddlb_Lender/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Ddlb_Lender>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Ddlb_Lender>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_ddlb_lenderservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
