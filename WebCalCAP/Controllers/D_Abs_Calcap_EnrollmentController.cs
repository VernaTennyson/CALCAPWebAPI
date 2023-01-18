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
	public class D_Abs_Calcap_EnrollmentController : ControllerBase
	{
		private readonly ID_Abs_Calcap_EnrollmentService _id_abs_calcap_enrollmentservice;

		public D_Abs_Calcap_EnrollmentController(ID_Abs_Calcap_EnrollmentService id_abs_calcap_enrollmentservice)
		{
			_id_abs_calcap_enrollmentservice = id_abs_calcap_enrollmentservice;
		}

		//POST api/D_Abs_Calcap_Enrollment/Update
		[HttpPost]
		[ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<int>> UpdateAsync([FromBody]IDataStore<D_Abs_Calcap_Enrollment> dataStore)
		{
			try
			{
				var result = await _id_abs_calcap_enrollmentservice.UpdateAsync(dataStore, default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}


		//GET api/D_Abs_Calcap_Enrollment/Retrieve
		[HttpGet]
		[ProducesResponseType(typeof(IDataStore<D_Abs_Calcap_Enrollment>), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<IDataStore<D_Abs_Calcap_Enrollment>>> RetrieveAsync()
		{
			try
			{
				var result = await _id_abs_calcap_enrollmentservice.RetrieveAsync(default);
				
				return Ok(result);
			}
            catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}

	}
}
