using Casgem.Business.Abstract;
using Casgem.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("getlistcategory")]
    public IActionResult GetListCategory()
    {
        var results = _categoryService.GetList();

        return Ok(results);
    }

    [HttpPost("addcategory")]
    public IActionResult AddCategory(Category category)
    {
        _categoryService.Insert(category);

        return StatusCode(201, category);
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteCategory(int id)
    {
        var result = _categoryService.GetById(id);
        _categoryService.Delete(result);

        return NoContent();
    }

    [HttpGet("getcategorybyid/{id:int}")]
    public IActionResult GetCategoryById(int id)
    {
        var result = _categoryService.GetById(id);

        return Ok(result);
    }

    [HttpPut]
    public IActionResult UpdateCategory(Category category)
    {
        _categoryService.Update(category);

        return NoContent();
    }
}

