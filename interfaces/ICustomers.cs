namespace DotNetApi.Interfaces; 
    
using DotNetApi.Entities;
using DotNetApi.Helpers.DTOs;

public interface ICustomers
{
    Task<List<T_Customers>> GetCustomersAsync();
    Task PostCustomersAsync(CustomerDto customer);
}