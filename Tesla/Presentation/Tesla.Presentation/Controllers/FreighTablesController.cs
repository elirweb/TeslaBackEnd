using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tesla.Aplication.Interfaces;

namespace Tesla.Presentation.Controllers
{
    public class FreighTablesController : ControllerBase
    {
        private readonly IFreightTables freightTablesApp;

        public FreighTablesController(IFreightTables freightTablesApp)
        {
            this.freightTablesApp = freightTablesApp;
        }

        /// <summary>
        /// Get Freight
        /// </summary>
        /// <param name="startZipCode">obj start ZipCode</param>
        /// <param name="endZipCode">obj end ZipCode</param>
        /// <returns></returns>
        [HttpGet, Route("getFreight/{startZipCode}/{endZipCode}")]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status500InternalServerError)]
        public ActionResult GetFreight([FromRoute] string startZipCode, [FromRoute] string endZipCode)
        {
            if (string.IsNullOrWhiteSpace(startZipCode) || string.IsNullOrWhiteSpace(endZipCode))
                return BadRequest();

            return Ok(this.freightTablesApp.GetFreight(startZipCode, endZipCode));
        }

    }
}
