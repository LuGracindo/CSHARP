using BookStoreManager.Application.UseCases.Books.Delete;
using BookStoreManager.Application.UseCases.Books.GetAll;
using BookStoreManager.Application.UseCases.Books.GetById;
using BookStoreManager.Application.UseCases.Books.PutById;
using BookStoreManager.Application.UseCases.Books.Register;
using BookStoreManager.Comunication.Requests;
using BookStoreManager.Comunication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookStoreController : ControllerBase
    {
        [HttpPost("create")]
        [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Register([FromServices] IRegisterBookUseCase useCase, [FromBody] RequestRegisterBookJson request)
        {
            var response = await useCase.Execute(request);

            return Created(string.Empty, response);
        }


        [HttpGet("getall")]
        [ProducesResponseType(typeof(ResponseGetAllBookJson), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetAll([FromServices] IGetAllBookUseCase useCase)
        {
            var response = await useCase.Execute();

            if (response.Books.Count != 0)
                return Ok(response);

            return NoContent();
        }

        [HttpGet("{id:long}")]
        [ProducesResponseType(typeof(ResponseShortGetAllBookJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetById([FromServices] IGetBookByIdUseCase useCase, [FromRoute] long id)
        {
            var response = await useCase.Execute(id);

            return Ok(response);
        }

        [HttpPut("{id:long}")]
        [ProducesResponseType(typeof(ResponseShortGetAllBookJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Update([FromServices] IPutBookByIdUseCase useCase, [FromRoute] long id, [FromBody] RequestUpdateBookJson request)
        {
            var response = await useCase.Execute(id, request);

            return Ok(response);
        }

        [HttpDelete("{id:long}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete([FromServices] IDeleteBookByIdUseCase useCase, [FromRoute] long id)
        {
            await useCase.Execute(id);

            return NoContent();
        }
    }
}
