using BookStoreManager.Application.UseCases.Books.Register;
using BookStoreManager.Comunication.Requests;
using BookStoreManager.Comunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreManager.API.Controllers
{
    [Route("api/[controller]/create")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromServices] IRegisterBookUseCase useCase, [FromBody] RequestRegisterBookJson request)
        {
            var response = await useCase.Execute(request);

            return Created(string.Empty, response);
        }
    }
}
