using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Serilog.Core;
using System.Security.Claims;
using WebApplication1.Repositories.User;
using WebApplication1.Repositories.User.DTO;
using WebApplication1.Repositories.User.Queries;
using WebApplication1.Repositories.Zlecenia.DTO;
using WebApplication1.Repositories.Zlecenia.Queries;
using WebApplication1.Tools;

namespace WebApplication1.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserRepository _usersRepository;

        public UsersController(IUserRepository userRepository)
        {
            this._usersRepository = userRepository;
        }

        [Authorize]
        [HttpGet("Me")]
        [ProducesResponseType(typeof(Update_User_DTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMyProfile()
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }

            var result = await _usersRepository.GetByIdAsync(userId);

            if (!result.Success)
            {
                return result.ErrorType switch
                {
                    ErrorType.NotFound =>
                        NotFound(new { message = result.Error }),

                    ErrorType.Unauthorized =>
                        Unauthorized(new { message = result.Error }),

                    ErrorType.Forbidden =>
                         StatusCode(403, new { message = result.Error }),

                    ErrorType.Conflict =>
                        Conflict(new { message = result.Error }),

                    ErrorType.Validation =>
                        BadRequest(new { message = result.Error }),

                    _ =>
                        StatusCode(500, new { message = result.Error })
                };
            }

            return Ok(result.Data);
        }



        [Authorize]
        [HttpPost("UpdateMe")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateUser([FromBody] Update_User_DTO body)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }


            var result = await _usersRepository.Update_User_Basic_Info_Async(userId, body);

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

            return Ok();
        }


        [Authorize]
        [HttpPost("ResetPassMe")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RessetPasseUser([FromBody] Update_User_Pass_Dto body)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }


            var result = await _usersRepository.Update_User_Pass_Async(userId, body);

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

            return Ok();
        }


        // [Authorize]
        [HttpGet("GetUserToEdit/{id}")]
        [ProducesResponseType(typeof(GetAllUserInfo_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetMyPGetUserToEditrofile([FromRoute] int id)
        {
            //var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            //if (!int.TryParse(userIdString, out int id))
            //{
            //    return Unauthorized();
            //}

            var result = await _usersRepository.GetAllInfoByIdAsync(id);

            if (!result.Success)
            {
                return result.ErrorType switch
                {
                    ErrorType.NotFound =>
                        NotFound(new { message = result.Error }),

                    ErrorType.Unauthorized =>
                        Unauthorized(new { message = result.Error }),

                    ErrorType.Forbidden =>
                         StatusCode(403, new { message = result.Error }),

                    ErrorType.Conflict =>
                        Conflict(new { message = result.Error }),

                    ErrorType.Validation =>
                        BadRequest(new { message = result.Error }),

                    _ =>
                        StatusCode(500, new { message = result.Error })
                };
            }

            return Ok(result.Data);
        }


        [Authorize]
        [HttpGet("GetUserList")]
        [ProducesResponseType(typeof(User_List_Response_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetListaZlecen([FromQuery] Get_User_List_Query querry)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized(new { message = "Nieprawidłowy identyfikator użytkownika" });
            }


            var result = await _usersRepository.Get_User_List(userId, querry);

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

        [Authorize]
        [HttpPost("UpdateUser/{id}")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateUser_All_Info([FromRoute] int id, [FromBody] Update_User_AllInfo_DTO body)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }


            var result = await _usersRepository.Update_User_All_Info_Async(userId, id, body);

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

            return Ok();
        }


        [Authorize]
        [HttpPost("ResetUserPass/{id}")]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RessetPasseUserAdminMode([FromRoute] int id, [FromBody] string newPass)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }


            var result = await _usersRepository.Reset_User_Pass_Async(userId, id, newPass);

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

            return Ok();
        }

        [Authorize]
        [HttpDelete("DeleteUser/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteUser([FromRoute] int id)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }

            var result = await _usersRepository.Delete_User_async(id, userId);

            if (!result.Success)
            {
                return result.ErrorType switch
                {
                    ErrorType.NotFound =>
                        NotFound(new { message = result.Error }),

                    ErrorType.Unauthorized =>
                        Unauthorized(new { message = result.Error }),

                    ErrorType.Forbidden =>
                         StatusCode(403, new { message = result.Error }),

                    ErrorType.Conflict =>
                        Conflict(new { message = result.Error }),

                    ErrorType.Validation =>
                        BadRequest(new { message = result.Error }),

                    _ =>
                        StatusCode(500, new { message = result.Error })
                };
            }

            return NoContent();
        }


        [Authorize]
        [HttpPost("CreateUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateUser([FromBody] Create_User_Dto body)
        {
            var result = await _usersRepository.Create_User_Async(body);

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

            return StatusCode(StatusCodes.Status201Created, result.Data);
        }
    }
}
