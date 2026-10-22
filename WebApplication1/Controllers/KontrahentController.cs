using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApplication1.Repositories.Kontrahenci;
using WebApplication1.Repositories.Kontrahenci.DTO;
using WebApplication1.Repositories.Kontrahenci.Queries;
using WebApplication1.Repositories.User;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Repositories.User.Queries;
using WebApplication1.Tools;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KontrahentController : ControllerBase
    {
        private readonly IKontrahenciRepository _kontrahentRepository;

        public KontrahentController(IKontrahenciRepository kontrahentRepository)
        {
            _kontrahentRepository = kontrahentRepository;
        }


        [Authorize]
        [HttpGet("GetKontrahentList")]
        [ProducesResponseType(typeof(KontrahenciList_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetListaKonrtrahentow([FromQuery] Get_kontrahenci_Query querry)
        {
          

            var result = await _kontrahentRepository.Get_Konntrahenci_List_Async(querry);

            //var result = await _usersRepository.Get_User_List(1, querry);

            if (!result.Success)
            {
                return result.ErrorType switch
                {
                    ErrorType.NotFound => NotFound(new { message = result.Error }),

                    ErrorType.Validation => BadRequest(new { message = result.Error }),

                    ErrorType.Unauthorized => Unauthorized(new { message = result.Error }),

                    ErrorType.Conflict => Conflict(new { message = result.Error }),

                    _ => StatusCode(500, new { message = result.Error })  // default to tratus 500
                };
            }

            return Ok(result.Data);

        }
    }
}
