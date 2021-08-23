using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.Aula02.Exemplo01.Controllers
{
    public class ClienteController : Controller
    {
        //URL: /Cliente/Index ou /Cliente
        public IActionResult Index()
        {
            return View();
        }

        //URL: /Cliente/Cadastrar
        //Criar uma Action Cadastrar que retorna uma página
        //A página terá um formulario HTML com os campos nome, cpf e botao
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
