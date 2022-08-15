using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

namespace RazorPagesPizza.Pages
{
  public class PizzaModel : PageModel
  {
    [BindProperty]
    public Pizza NewPizza { get; set; }

    public void OnGet()
    {
      pizzas = PizzaService.GetAll();
    }
    public List<Pizza> pizzas = new();

    public string GlutenFreeText(Pizza pizza)
    {
      return pizza.IsGlutenFree ? "Gluten Free": "Not Gluten Free";
    }
  }
}
