using LegacyECommerce.Application.DTOs.Requests;
using LegacyECommerce.Application.DTOs.Responses;
using LegacyECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Application.Mappers
{
    internal static class CategoryMapper
    {
        internal static Expression<Func<Category, CategoryResponse>> EntityToResponse = entity =>
        new CategoryResponse
        {
            CategoryId = entity.Id,
            CategoryName = entity.Name,
            CategoryImageUrl = entity.ImageUrl,
            CategoryDescription = entity.Description,
            PopularCategory = entity.Popular
        };

        internal static Category RequestToEntity(CategoryRequest request)
        {
            return new Category
            {
                Id = request.CategoryId,
                Name = request.CategoryName,
                ImageUrl = request.CategoryImageUrl,
                Description = request.CategoryDescription,
                Popular = request.PopularCategory
            };
        }
    }
}
