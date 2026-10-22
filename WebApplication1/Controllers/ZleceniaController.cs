using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WebApplication1.ObiektyORMLinq2DB.ZleceniaSpedycja;
using WebApplication1.Repositories.Zlecenia;
using WebApplication1.Repositories.Zlecenia.DTO;
using WebApplication1.Repositories.Zlecenia.Helpers;
using WebApplication1.Repositories.Zlecenia.Queries;
using WebApplication1.Tools;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ZleceniaController : ControllerBase
    {
        private readonly IZlecenia_Repository _zlecenia_Repository;

        public ZleceniaController(IZlecenia_Repository zlecenia_repository)
        {
            _zlecenia_Repository = zlecenia_repository;
        }



        [Authorize]
        [HttpGet("GetListaZlecen")]
        [ProducesResponseType(typeof(Lista_Zlecen_Response_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetListaZlecen([FromQuery] Get_Zlecenia_List_Query querry)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }

            var result = await _zlecenia_Repository.Get_Zlecenia_List_Async(querry, userId);

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
        [HttpGet("GetLadunekZbiorowy/{id}")]
        [ProducesResponseType(typeof(Ladunek_Zbiorowy_Response_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetLadunekZbiorowy([FromRoute] int id)
        {


            var result = await _zlecenia_Repository.Get_Ladunek_Zbiorowy_Async(id);

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



        // ==== ZLECENIA ========================================
        [Authorize]
        [HttpPost("CreateZlecenie")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateZlecenie([FromBody] Update_Zlecenie_Dto body)
        {
            var result = await _zlecenia_Repository.Create_Zlecenia_Async(body);

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

        [Authorize]
        [HttpPost("UpdateZlecenie/{id}")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdateZlecenie([FromRoute] int id, [FromBody] Update_Zlecenie_Dto body)
        {
            var result = await _zlecenia_Repository.Edit_Zlecenia_Async(id, body);

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
        [HttpDelete("DeleteZlecenie/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteZlecenie([FromRoute] int id)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }

            var result = await _zlecenia_Repository.Delete_Zlecenia_Async(id, userId);

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
        [HttpGet("GetZlecenieForEditById/{id}")]
        [ProducesResponseType(typeof(GetZlecenieToEdit_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetZlecenieForEdit([FromRoute] int id)
        {

            var result = await _zlecenia_Repository.Get_Zlecenie_ById_Async(id);

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
        // ======================================================



        // ==== TOWARY ==========================================
        [Authorize]
        [HttpGet("GetTowarById/{id}")]
        [ProducesResponseType(typeof(Update_Towar_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTowarById([FromRoute] int id)
        {


            var result = await _zlecenia_Repository.Get_Towar_Async(id);

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
        [HttpPost("UpdatetTowar")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatetTowar([FromBody] Update_Towar_Dto body)
        {
            var result = await _zlecenia_Repository.Update_Towar_Async(body);

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
        [HttpPost("CreateTowar")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateTowar([FromBody] Update_Towar_Dto body)
        {
            var result = await _zlecenia_Repository.Create_Towar_Async(body);

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


        [Authorize]
        [HttpDelete("DeleteTowar/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteTowar([FromRoute] int id)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }

            var result = await _zlecenia_Repository.Delete_Towar_Async(id, userId);

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
        // ======================================================



        // ==== STAWKI WLASNE =================================== 
        [Authorize]
        [HttpGet("GetStawkaWlasnaById/{id}")]
        [ProducesResponseType(typeof(Update_Stawka_Wlasna_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStawkaWlasnaById([FromRoute] int id)
        {


            var result = await _zlecenia_Repository.Get_Stawka_Wlasna_Async(id);

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
        [HttpPost("UpdatetStawkaWlasna")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatetStawkaWlasna([FromBody] Update_Stawka_Wlasna_Dto body)
        {
            var result = await _zlecenia_Repository.Update_Stawka_Wlasna_Async(body);

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
        [HttpPost("CreateStawkaWlasna")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateStawkaWlasna([FromBody] Update_Stawka_Wlasna_Dto body)
        {
            var result = await _zlecenia_Repository.Create_Stawka_Wlasna_Async(body);

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

        [Authorize]
        [HttpDelete("DeleteStawkaWlasna/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteStawkaWlasna([FromRoute] int id)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }

            var result = await _zlecenia_Repository.Delete_Stawka_Wlasna_Async(id, userId);

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
        // ======================================================




        // ==== STAWKI KOSZTOWE =================================
        [Authorize]
        [HttpGet("GetStawkaKosztById/{id}")]
        [ProducesResponseType(typeof(Update_Stawka_Kosztowa_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetStawkaKosztById([FromRoute] int id)
        {


            var result = await _zlecenia_Repository.Get_Stawka_Kosztowa_Async(id);

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
        [HttpPost("UpdatetStawkaKosztowa")]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> UpdatetStawkaKosztowa([FromBody] Update_Stawka_Kosztowa_Dto body)
        {
            var result = await _zlecenia_Repository.Update_Stawka_Kosztowa_Async(body);

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
        [HttpPost("CreateStawkaKosztowa")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateStawkaKosztowa([FromBody] Update_Stawka_Kosztowa_Dto body)
        {
            var result = await _zlecenia_Repository.Create_Stawka_Kosztowa_Async(body);

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

        [Authorize]
        [HttpDelete("DeleteStawkaKosztowa/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteStawkaKosztowa([FromRoute] int id)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!int.TryParse(userIdString, out int userId))
            {
                return Unauthorized();
            }

            var result = await _zlecenia_Repository.Delete_Stawka_Kosztow_Async(id, userId);

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
        // ======================================================




        [Authorize]
        [HttpGet("GetDataForCreate")]
        [ProducesResponseType(typeof(Lista_Dane_do_kontrolek_Dto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetDataForCreate()
        {

            var result = await _zlecenia_Repository.Get_datne_dodatkowe();

            if (result == null)
            {
                return StatusCode(500, new { message = "Błąd podczas uspobierania danych bazowych do formatki dodaj/edytuj zlecenie" });

            }

            return Ok(result);

        }
    }
}

