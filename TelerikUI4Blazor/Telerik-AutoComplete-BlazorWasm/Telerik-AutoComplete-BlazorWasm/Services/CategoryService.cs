﻿using System.Net.Http.Json;
using TelerikAutoComplete_simple.Dto;

namespace TelerikAutoComplete_simple.Services
{
    public class CategoryService
    {
        private HttpClient _http;

        public CategoryService(HttpClient http)
        {
            _http = http;
        }

        public Task<IEnumerable<CategoryDto>> GetCategories()
        {
            return _http.GetFromJsonAsync<IEnumerable<CategoryDto>>("https://demos.telerik.com/blazor-ui-service/api/Category/GetCategories");
        }
    }
}
