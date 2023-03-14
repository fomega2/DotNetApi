using Microsoft.AspNetCore.Mvc;
using DotNetApi.Entities;
using DotNetApi.Interfaces;
using Microsoft.AspNetCore.Authorization;
using DotNetApi.Helpers.DTOs;

namespace DotNetApi.Controllers;

[AllowAnonymous]
[ApiController]
[Route("[controller]")]
public class CustomersController : ControllerBase
{
    public ICustomers _customers;

    public CustomersController(ICustomers customers)
    {
        _customers = customers;
    }

    [HttpGet(Name = "lst_custumers")]
    public async Task<IActionResult> GetCustomersAsync()
    {
        var resultLstUsers = await _customers.GetCustomersAsync(); 
        return Ok(resultLstUsers);
    }

    [HttpPost(Name = "create_custumer")]
    public async Task<IActionResult> PostCustomersAsync(CustomerDto customer)
    {
        try{            
            await _customers.PostCustomersAsync(customer); 
            return Ok(new ResultDto().Success("Success"));
        }catch(Exception ex){
            return Ok(new ResultDto().Success("Error: " + ex.Message));
        }
    }
}
