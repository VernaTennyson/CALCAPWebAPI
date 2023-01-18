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
	public class Dddw_Lender_Contact_TypeController : ControllerBase
	{
		private readonly IDddw_Lender_Contact_TypeService _idddw_lender_contact_typeservice;

		public Dddw_Lender_Contact_TypeController(IDddw_Lender_Contact_TypeService idddw_lender_contact_typeservice)
		{
			_idddw_lender_contact_typeservice = idddw_lender_contact_typeservice;
		}

		//GET api/Dddw_Lender_Contact_Type/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<Dddw_Lender_Contact_Type>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<Dddw_Lender_Contact_Type>>> RetrieveAsync()
		{
			try
			{
				var result = await _idddw_lender_contact_typeservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
