using Fiap.Web.Aula02.Exemplo01.Models;
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
        
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        //Action que "cadastra no banco de dados"
        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            ViewData["msg"] = "Cliente cadastrado";
            ViewData["nome"] = cliente.Nome; //Envia o nome do cliente para a View
            ViewBag.cpf = cliente.Cpf;
            ViewBag.cliente = cliente;
            return View();
            //return Content($"Nome: {cliente.Nome}, CPF: {cliente.Cpf}");//Retorna um texto no browser
        }
    }
}
