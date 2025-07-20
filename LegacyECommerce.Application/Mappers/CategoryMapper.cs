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
            CategoryImage = entity.Image,
            CategoryDescription = entity.Description,
            FeaturedCategory = entity.Featured
        };

        internal static Category RequestToEntity(CategoryRequest request)
        {
            return new Category
            {
                Id = request.CategoryId,
                Name = request.CategoryName,
                Image = request.CategoryImage,
                Description = request.CategoryDescription,
                Featured = request.FeaturedCategory
            };
        }

        internal static Category CreateToEntity(CreateCategoryRequest request)
        {
            return new Category
            {
                Id = request.Id,
                Name = request.Name,
                Image = request.Image,
                Description = request.Description,
                Featured = request.Featured
            };
        }
    }
}
