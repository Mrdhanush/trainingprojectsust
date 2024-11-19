using APIMIGR.Models;

namespace APIMIGR.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Getcategory();

        Product GetCategoryByID(int category);

        void Insertcategory(Product category);

        void DeleteCategory(int categoryId);

        void UpdateCategory(Category category);

        void Save();

    }
}
