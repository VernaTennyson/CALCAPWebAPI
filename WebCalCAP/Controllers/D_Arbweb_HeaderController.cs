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
	public class D_Arbweb_HeaderController : ControllerBase
	{
		private readonly ID_Arbweb_HeaderService _id_arbweb_headerservice;

		public D_Arbweb_HeaderController(ID_Arbweb_HeaderService id_arbweb_headerservice)
		{
			_id_arbweb_headerservice = id_arbweb_headerservice;
		}

		//POST api/D_Arbweb_Header/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Arbweb_Header> dataStore)
		{
			try
			{
				var result = await _id_arbweb_headerservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Arbweb_Header/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Arbweb_Header>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Arbweb_Header>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_arbweb_headerservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
