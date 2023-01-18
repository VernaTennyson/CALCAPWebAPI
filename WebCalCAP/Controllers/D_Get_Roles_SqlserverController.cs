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
	public class D_Get_Roles_SqlserverController : ControllerBase
	{
		private readonly ID_Get_Roles_SqlserverService _id_get_roles_sqlserverservice;

		public D_Get_Roles_SqlserverController(ID_Get_Roles_SqlserverService id_get_roles_sqlserverservice)
		{
			_id_get_roles_sqlserverservice = id_get_roles_sqlserverservice;
		}

		//GET api/D_Get_Roles_Sqlserver/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Get_Roles_Sqlserver>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Get_Roles_Sqlserver>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_get_roles_sqlserverservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
