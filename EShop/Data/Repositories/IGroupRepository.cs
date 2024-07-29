using EShop.Models.Dto;
using EShop.Models.Entities;

namespace EShop.Data.Repositories
{
    public interface IGroupRepository
    {
        public IEnumerable<Category> Categories();
        public IEnumerable<ShowProductGroupsDto> GetGroupCategories();
    }
    public class GroupRepository : IGroupRepository
    {
        private readonly AppDbContext _context;

        public GroupRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Categories()
        {
            return _context.Categories
                .ToList();
        }

        public IEnumerable<ShowProductGroupsDto> GetGroupCategories()
        {
            return _context.Categories
                .Select(c => new ShowProductGroupsDto
                {
                    Name = c.Name,
                    GroupId = c.Id,
                    ProductCount = _context.CategoryToProducts.Count(gr => gr.CategoryId == c.Id)
                }).ToList();
        }
    }
}
