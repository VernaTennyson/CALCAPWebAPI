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
	public class D_Abs_Csp_PaymentsController : ControllerBase
	{
		private readonly ID_Abs_Csp_PaymentsService _id_abs_csp_paymentsservice;

		public D_Abs_Csp_PaymentsController(ID_Abs_Csp_PaymentsService id_abs_csp_paymentsservice)
		{
			_id_abs_csp_paymentsservice = id_abs_csp_paymentsservice;
		}

		//POST api/D_Abs_Csp_Payments/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Csp_Payments> dataStore)
		{
			try
			{
				var result = await _id_abs_csp_paymentsservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Csp_Payments/Retrieve/{p_type}/{p_csi_id}
		[HttpGet("{p_type}/{p_csi_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Csp_Payments>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Csp_Payments>>> RetrieveAsync(string p_type, double? p_csi_id)
		{
			try
			{
				var result = await _id_abs_csp_paymentsservice.RetrieveAsync(p_type, p_csi_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
