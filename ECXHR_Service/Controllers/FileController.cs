
using ECX.HR.Application.CQRS.File.Request.Command;
using ECX.HR.Application.CQRS.File.Request.Queries;
using ECX.HR.Application.CQRS.LeaveRequest.Request.Command;
using ECX.HR.Application.DTOs.File;
using ECX.HR.Application.Response;

using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ECXHR_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase

    {
        private readonly IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public FileController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            this._httpContextAccessor = httpContextAccessor;
        }
        // GET: api/<FileController>
        [HttpGet]
        public async Task<ActionResult<List<FileDto>>> Get()
        {
            var File = await _mediator.Send(new GetFileListRequest());
            return Ok(File);
        }

        // GET api/<FileController>/5
        [HttpGet("{File}")]
        public async Task<ActionResult<FileDto>> Get(string file)
        {
            var FileData = await _mediator.Send(new GetFileDetailRequest { file = file });
          if (FileData == null)
            {
                return NotFound(); // File not found
            }
            string contentType = "application/pdf"; // Set a default content type
            Response.Headers.Add("contentType", "application/pdf");
            return File(FileData,contentType);

            


        }

       
        [HttpPost]

        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] FileDto File)
        {
            var user = _httpContextAccessor.HttpContext.User;
            var command = new CreateFileCommand { FileDto = File };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<FileController>/5
        [HttpPut("{id}")]


        public async Task<ActionResult> Put([FromBody] FileDto File)
        {
            var command = new UpdateFileCommand { FileDto = File };
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteFileCommand { Id = id };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}