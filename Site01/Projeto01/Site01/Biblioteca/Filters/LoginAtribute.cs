using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site01.Biblioteca.Filters
{
    public class LoginAtribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if(context.HttpContext.Session.GetString("Login") == null)
            {
                if (context.Controller != null)
                {
                    Controller controlador = context.Controller as Controller;
                    controlador.TempData["MensagemErro"] = "Faça o login para ter acesso dentro da página!";
                }
                context.Result = new RedirectToActionResult("Login", "Home", null);
            }
        }
    }
}
