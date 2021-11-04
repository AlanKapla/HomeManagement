using HomeManagement.Application.CQRS.HomeMembers.Commands.AddHomeMember;
using HomeManagement.Application.CQRS.HomeMembers.Commands.RemoveHomeMember;
using HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMember;
using HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMembers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HomeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeMemberController : ControllerBase
    {
        private IMediator _mediator;

        public HomeMemberController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get/{id}")]
        public async Task<IActionResult> GetHomeMemberDetails(int id)
        {
            try
            {
                var result = await _mediator.Send(new GetHomeMemberQuery() { Id = id });
                return result switch
                {
                    null => NotFound($"Home Member with id: {id} not exist"),
                    _ => Ok(result)
                };
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetHomeMembers()
        {
            try
            {
                var result = await _mediator.Send(new GetHomeMembersQuery());
                return result switch
                {
                    null => NotFound($"Home Members not exist"),
                    _ => Ok(result)
                };
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddHomeMembers([FromBody] AddHomeMemberCommand addHomeMemberCommand)
        {
            try
            {
                var result = await _mediator.Send(addHomeMemberCommand);
                return Ok(result);
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteHomeMembers(int id)
        {
            try
            {
                var homeMember = await _mediator.Send(new GetHomeMemberQuery() { Id = id });

                return homeMember switch
                {
                    null => NotFound($"Cannot remove Home Member with id: {id}, because this not exist"),
                    _ => Ok(await _mediator.Send(new RemoveHomeMemberCommand() { Id = id }))
                };
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
        }
    }
}