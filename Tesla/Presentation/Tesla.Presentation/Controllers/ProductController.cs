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
        public void Teste()
        {
        }
    }
}
