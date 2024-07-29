using EShop.Data;
using EShop.Data.Repositories;
using EShop.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace EShop.Components
{
    [ViewComponent]
    public class ProductGroupsComponent : ViewComponent
    {
        private readonly IGroupRepository _groupRepository;

        public ProductGroupsComponent(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _groupRepository.GetGroupCategories();
            return View("/Views/Components/ProductGroupsComponent.cshtml", categories);
        }
    }
}
