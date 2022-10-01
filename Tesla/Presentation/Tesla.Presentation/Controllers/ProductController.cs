using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tesla.Presentation.Api
{
    public class ProductController : ControllerBase
    {
        private readonly Tesla.Aplication.Interfaces.IProduct productApp;

        public ProductController(Tesla.Aplication.Interfaces.IProduct product)
        {
            productApp = product;
        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <param name="parameter">obj parameter</param>
        /// <returns></returns>
        [HttpGet, Route("getAll/{parameter}")]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status500InternalServerError)]
        public ActionResult GetAll([FromRoute] string parameter)
        {
            if (string.IsNullOrWhiteSpace(parameter))
                return BadRequest();

            return Ok(this.productApp.GetAll(parameter));
        }

        /// <summary>
        /// Get Parameter
        /// </summary>
        /// <param name="parameter">obj product</param>
        /// <returns></returns>
        [HttpGet, Route("getProductParameter/{parameter}")]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status500InternalServerError)]
        public ActionResult GetProductByParameter([FromRoute] string parameter)
        {
            if (string.IsNullOrWhiteSpace(parameter))
                return BadRequest();

            return Ok(this.productApp.GetProductbyParameter(parameter));
        }

        /// <summary>
        /// Best Saller
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("bestSaller")]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status500InternalServerError)]
        public ActionResult BestSaller()
        {
            return Ok(this.productApp.BestSaller());
        }


        /// <summary>
        /// Get By Id
        /// </summary>
        /// <param name="id">obj parameter</param>
        /// <returns></returns>
        [HttpGet, Route("getById/{id}")]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Domain.Domain.Products), StatusCodes.Status500InternalServerError)]
        public ActionResult GetById([FromRoute] int id)
        {
            return Ok(this.productApp.GetById(id));
        }
    }
}
