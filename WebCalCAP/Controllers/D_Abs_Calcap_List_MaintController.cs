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
	public class D_Abs_Calcap_List_MaintController : ControllerBase
	{
		private readonly ID_Abs_Calcap_List_MaintService _id_abs_calcap_list_maintservice;

		public D_Abs_Calcap_List_MaintController(ID_Abs_Calcap_List_MaintService id_abs_calcap_list_maintservice)
		{
			_id_abs_calcap_list_maintservice = id_abs_calcap_list_maintservice;
		}

		//POST api/D_Abs_Calcap_List_Maint/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Calcap_List_Maint> dataStore)
		{
			try
			{
				var result = await _id_abs_calcap_list_maintservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Calcap_List_Maint/Retrieve/{a_domain}
		[HttpGet("{a_domain}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Calcap_List_Maint>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Calcap_List_Maint>>> RetrieveAsync(string a_domain)
		{
			try
			{
				var result = await _id_abs_calcap_list_maintservice.RetrieveAsync(a_domain, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
