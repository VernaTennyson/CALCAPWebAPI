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
	public class Dw_Fia_InstitutionController : ControllerBase
	{
		private readonly IDw_Fia_InstitutionService _idw_fia_institutionservice;

		public Dw_Fia_InstitutionController(IDw_Fia_InstitutionService idw_fia_institutionservice)
		{
			_idw_fia_institutionservice = idw_fia_institutionservice;
		}

		//POST api/Dw_Fia_Institution/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<Dw_Fia_Institution> dataStore)
		{
			try
			{
				var result = await _idw_fia_institutionservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/Dw_Fia_Institution/Retrieve/{a_f_fiaId}
		[HttpGet("{a_f_fiaId}")]
		[ProducesResponseType(typeof(IDataStore<Dw_Fia_Institution>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dw_Fia_Institution>>> RetrieveAsync(double? a_f_fiaId)
		{
			try
			{
				var result = await _idw_fia_institutionservice.RetrieveAsync(a_f_fiaId, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
