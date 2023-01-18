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
	public class D_Abs_Program_Type_Maint_ListController : ControllerBase
	{
		private readonly ID_Abs_Program_Type_Maint_ListService _id_abs_program_type_maint_listservice;

		public D_Abs_Program_Type_Maint_ListController(ID_Abs_Program_Type_Maint_ListService id_abs_program_type_maint_listservice)
		{
			_id_abs_program_type_maint_listservice = id_abs_program_type_maint_listservice;
		}

		//GET api/D_Abs_Program_Type_Maint_List/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Program_Type_Maint_List>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Program_Type_Maint_List>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_program_type_maint_listservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
