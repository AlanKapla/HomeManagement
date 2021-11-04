using HomeManagement.Application.CQRS.HomeMembers.Queries.GetHomeMember;
using HomeManagement.Application.CQRS.Incomes.Commands.AddIncome;
using HomeManagement.Application.CQRS.Incomes.Commands.RemoveIncome;
using HomeManagement.Application.CQRS.Incomes.Queries.GetHomeMemberAnnualIncome;
using HomeManagement.Application.CQRS.Incomes.Queries.GetIncome;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeController : ControllerBase
    {
        private IMediator _mediator;

        public IncomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddIncome([FromBody] AddIncomeCommand addIncomeCommand)
        {
            try
            {

                var result = await _mediator.Send(addIncomeCommand);
                return Ok(result);
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteIncome(int id)
        {
            try
            {
                var homeMember = await _mediator.Send(new GetIncomeQuery() { Id = id });

                return homeMember switch
                {
                    null => NotFound($"Cannot remove Home Member with id: {id}, because this not exist"),
                    _ => Ok(await _mediator.Send(new RemoveIncomeCommand() { Id = id }))
                };
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("getHomeMemberAnnual/{id}/{year}")]
        public async Task<IActionResult> GetHomeMemberAnnual(int id,int year)
        {
            try
            {
                var homeMember = await _mediator.Send(new GetHomeMemberQuery() { Id = id });

                return homeMember switch
                {
                    null => NotFound($"Cannot get annual incomes for  Home Member with id: {id}, because this not exist"),
                    _ => Ok(await _mediator.Send(new GetHomeMemberAnnualIncomeQuery() { HomeMemberId = id, Year = year }))
                };
            }
            catch (ArgumentException)
            {
                return BadRequest();
            }
        }
    }
}
