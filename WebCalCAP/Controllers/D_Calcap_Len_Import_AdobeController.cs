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
	public class D_Calcap_Len_Import_AdobeController : ControllerBase
	{
		private readonly ID_Calcap_Len_Import_AdobeService _id_calcap_len_import_adobeservice;

		public D_Calcap_Len_Import_AdobeController(ID_Calcap_Len_Import_AdobeService id_calcap_len_import_adobeservice)
		{
			_id_calcap_len_import_adobeservice = id_calcap_len_import_adobeservice;
		}

		//POST api/D_Calcap_Len_Import_Adobe/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Calcap_Len_Import_Adobe> dataStore)
		{
			try
			{
				var result = await _id_calcap_len_import_adobeservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Calcap_Len_Import_Adobe/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Calcap_Len_Import_Adobe>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Calcap_Len_Import_Adobe>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_calcap_len_import_adobeservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
