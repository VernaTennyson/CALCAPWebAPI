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
	public class D_Abs_Lender_ContactsController : ControllerBase
	{
		private readonly ID_Abs_Lender_ContactsService _id_abs_lender_contactsservice;

		public D_Abs_Lender_ContactsController(ID_Abs_Lender_ContactsService id_abs_lender_contactsservice)
		{
			_id_abs_lender_contactsservice = id_abs_lender_contactsservice;
		}

		//POST api/D_Abs_Lender_Contacts/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Lender_Contacts> dataStore)
		{
			try
			{
				var result = await _id_abs_lender_contactsservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Lender_Contacts/Retrieve/{a_len_id}
		[HttpGet("{a_len_id}")]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Lender_Contacts>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Lender_Contacts>>> RetrieveAsync(double? a_len_id)
		{
			try
			{
				var result = await _id_abs_lender_contactsservice.RetrieveAsync(a_len_id, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
