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
	public class D_Arb_DetailsController : ControllerBase
	{
		private readonly ID_Arb_DetailsService _id_arb_detailsservice;

		public D_Arb_DetailsController(ID_Arb_DetailsService id_arb_detailsservice)
		{
			_id_arb_detailsservice = id_arb_detailsservice;
		}

		//GET api/D_Arb_Details/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Arb_Details>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Arb_Details>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_arb_detailsservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
