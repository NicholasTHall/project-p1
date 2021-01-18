using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PizzaWorld.Storing;
using PizzaWorld.WebClient.Models;

namespace PizzaWorld.WebClient.Controllers
{
  public class StoreController : Controller
  {
    private readonly PizzaWorldRepository _ctx;
    public StoreController(PizzaWorldRepository context)
    {
      _ctx = context;
    }
  }
}