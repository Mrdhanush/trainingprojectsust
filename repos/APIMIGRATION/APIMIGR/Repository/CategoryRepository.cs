using APIMIGR.Data;
using APIMIGR.Models;
using Microsoft.EntityFrameworkCore;

namespace APIMIGR.Repository
{
    public class CategoryRepository : ICategoryRepository

    {

        private readonly ProductContext _dbContext;

        public CategoryRepository(ProductContext dbContext)

        {

            _dbContext = dbContext;

        }

        public void DeleteCategory(int categoryId)

        {

            var category = _dbContext.Products.Find(categoryId);

            _dbContext.Categories.Remove(category);

            Save();

        }

        public Category GetCategoryByID(int categoryId)

        {

            return _dbContext.Categories.Find(categoryId);

        }

        public IEnumerable<Category> Getcategory()

        {

            return _dbContext.Categories.ToList();

        }

        public void InsertProduct(Category category)

        {

            _dbContext.Add(category);

            Save();
        }

        public void Save()

        {

            _dbContext.SaveChanges();

        }

        public void UpdateProduct(Category product)

        {

            _dbContext.Entry(product).State = EntityState.Modified;

            Save();

        }

    }
}

