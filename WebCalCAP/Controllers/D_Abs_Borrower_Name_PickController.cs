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
	public class D_Abs_Borrower_Name_PickController : ControllerBase
	{
		private readonly ID_Abs_Borrower_Name_PickService _id_abs_borrower_name_pickservice;

		public D_Abs_Borrower_Name_PickController(ID_Abs_Borrower_Name_PickService id_abs_borrower_name_pickservice)
		{
			_id_abs_borrower_name_pickservice = id_abs_borrower_name_pickservice;
		}

		//GET api/D_Abs_Borrower_Name_Pick/Retrieve/{a_bor}
		[HttpGet("{a_bor}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Borrower_Name_Pick>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Borrower_Name_Pick>>> RetrieveAsync(string a_bor)
		{
			try
			{
				var result = await _id_abs_borrower_name_pickservice.RetrieveAsync(a_bor, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
