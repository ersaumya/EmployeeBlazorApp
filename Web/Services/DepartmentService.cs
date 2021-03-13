﻿using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace Web.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient _httpClient;

        public DepartmentService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<Department> GetDepartment(int id)
        {
            return await _httpClient.GetJsonAsync<Department>($"api/departments/{id}");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await _httpClient.GetJsonAsync<Department[]>("api/departments");
        }
    }
}
