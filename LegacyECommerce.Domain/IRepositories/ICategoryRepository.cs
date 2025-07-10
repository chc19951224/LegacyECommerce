using LegacyECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegacyECommerce.Domain.IRepositories
{
    ///【 抽 象 接 口 類 】
    public interface ICategoryRepository
    {
        /// 獲取所有分類
        IQueryable<Category> GetAll();
        /// 獲取指定分類
        Category GetById(int id);

        /// 新增分類
        void Add(Category category);

        /// 修改分類
        void Update(Category category);

        /// 刪除分類
        void Delete(int id);                    
    }
}
