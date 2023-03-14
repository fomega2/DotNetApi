using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetApi.Entities;
using DotNetApi.Interfaces;
using DotNetApi.Helpers;
using Microsoft.EntityFrameworkCore;
using DotNetApi.Helpers.DTOs;

namespace DotNetApi.services
{
    public class ServCustomer : ICustomers
    {
        public DataContext _dataContext;
        public ServCustomer(DataContext context)
        {
            _dataContext = context;
        }
        
        public async Task<List<T_Customers>> GetCustomersAsync()
        {
            var resultLstUsers = await _dataContext.Customers.ToListAsync();
            return resultLstUsers;
        }

        public async Task PostCustomersAsync(CustomerDto customer)
        {
            var newCustomer = new T_Customers(){
                Active = true,
                CreateAt = DateTime.Now,
                Id = Guid.NewGuid().ToString(),
                Identification = customer.Identification,
                LastName = customer.LastName,
                Mail = customer.Mail,
                Name = customer.Name,
                UpdateAt = null
            };

            await _dataContext.AddAsync<T_Customers>(newCustomer);
            await _dataContext.SaveChangesAsync();
        }
    }
}