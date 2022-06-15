using Microsoft.AspNetCore.Mvc;
using PetCare.Models;
using System.Diagnostics;

namespace PetCare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        //CRUD Usuarios
        public IActionResult CadastroUsuario()
        {
            return View("~/Views/Home/CadastroUsuario.cshtml");
        }
        [HttpPost]
        public IActionResult CadastroUsuario(Usuario user)
        {
            if (HttpContext.Session.GetInt32("id") == null)
            {
                if (user.senha == user.confirma_senha)
                {
                    Repositorio repo = new Repositorio();
                    repo.inserirUsuario(user);
                    ViewBag.MsgSucessoCadastro = "Usuario cadastrado com sucesso! Faça já seu login!!!";
                    return View("~/Views/Home/Index.cshtml");
                }
                else
                {
                    ViewBag.MsgErroCadastro = "Senhas diferente";
                    return View("~/Views/Home/CadastroUsuario.cshtml");
                }

            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpPost]
        public IActionResult AlterarUsuario(Usuario user)
        {
            

            if (HttpContext.Session.GetInt32("id") != null)
            {

                if (user.senha == user.confirma_senha)
                {
                    
                    Repositorio repo = new Repositorio();
                    repo.AlterarUsuario(user);
                    HttpContext.Session.SetString("imagem", user.imagem);

                    ViewBag.MsgTelaAlterarUsuario = "Seus dados foram alterados com sucesso!";
                    return View("~/Views/Home/MinhaConta.cshtml", user);
                }
                else
                {
                    ViewBag.MsgTelaAlterarUsuario = "As senhas não conferem, por favor verifique e tente novamente!";
                    return View("~/Views/Home/MinhaConta.cshtml");
                }

            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }
        [HttpPost]
        public IActionResult ExcluirUsuario(Usuario user)
        {

            if (HttpContext.Session.GetInt32("id") != null)
            {

                int id = (int)HttpContext.Session.GetInt32("id");
                Repositorio repo = new Repositorio();
                Usuario userLogado = repo.RetornaUsuario(id);
                if (user.senha == user.confirma_senha)
                {
                    if (user.senha == userLogado.senha)
                    {
                        repo.ExcluirUsuario(id);
                        Logout();
                        return View("~/Views/Home/Index.cshtml");
                    }
                    else
                    {
                        ViewBag.MsgTelaAlterarUsuario = "A senha está incorreta, verifique e tente novamente!";
                        return View("~/Views/Home/MinhaConta.cshtml");
                    }

                }
                else
                {
                    ViewBag.MsgTelaAlterarUsuario = "As senhas não conferem, por favor verifique e tente novamente!";
                    return View("~/Views/Home/MinhaConta.cshtml");
                }

            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }
        


        //CRUD pets
        public IActionResult CadastroPet()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                return View("~/Views/Home/CadastroPet.cshtml");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }


        }
        [HttpPost]
        public IActionResult CadastroPet(Pet pet)
        {

            if (HttpContext.Session.GetInt32("id") != null)
            {
                if (pet.id != 0)
                {
                    return View("~/Views/Home/CadastroPet.cshtml", pet);
                }
                else
                {
                    Repositorio repo = new Repositorio();
                    if(pet.imagem != null)
                    {

                    repo.inserirPet(pet);
                    }
                    else
                    {
                        pet.imagem = "../assets/profileDefault.png";
                        repo.inserirPet(pet);

                    }
                    return RedirectToAction("Main");
                }
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }




        }
        public IActionResult AlterarPet()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                return View("~/Views/Home/Main.cshtml");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpGet]
        public IActionResult AlterarPet(int idPet)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                if (idPet > 0)
                {
                    Repositorio repo = new Repositorio();
                    Pet pet = repo.RetornaPet(idPet);

                    return View("~/Views/Home/CadastroPet.cshtml", pet);
                }
                else
                {
                    return RedirectToAction("Main");
                }

            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpPost]
        public IActionResult AlterarPet(Pet pet)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();

                repo.AlterarPet(pet);

                return RedirectToAction("Main");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }
        public IActionResult ExcluirPet(Pet pet)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                repo.ExcluirPet(pet.id);
                return RedirectToAction("Main");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }
        


        //CRUD pesos
        [HttpPost]
        public IActionResult CadastrarPeso(IndexModelView indexModel)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                repo.inserirPeso(indexModel);
                return RedirectToAction("CuidarPet", new { idpet = indexModel.idPet });
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpGet]
        public IActionResult ExcluirPeso([FromQuery] int idPeso, [FromQuery] int idPet)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {

                Repositorio repo = new Repositorio();
                repo.excluirPeso(idPeso);
                return RedirectToAction("CuidarPet", new { idPet = idPet });

            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }
        public IActionResult AlterarPeso()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                return View("~/Views/Home/Main.cshtml");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpPost]
        public IActionResult AlterarPeso(int idPet, int idReg, string tipoReg)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                return Json(repo.retornaRegistro(idPet, idReg, tipoReg));
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpPost]
        public IActionResult SalvarAlteracaoPeso(IndexModelView indexModel)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                repo.AlterarPeso(indexModel);
                return RedirectToAction("CuidarPet", new { idPet = indexModel.idPet });
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }



        //CRUD Medicamentos
        [HttpPost]
        public IActionResult CadastrarMedicamento(IndexModelView indexModel)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                repo.inserirMedicamento(indexModel);
                return RedirectToAction("CuidarPet", new { idpet = indexModel.idPet });
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpGet]
        public IActionResult ExcluirMedicamento([FromQuery] int idMedicamento, [FromQuery] int idPet)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {

                Repositorio repo = new Repositorio();
                repo.excluirPeso(idMedicamento);
                return RedirectToAction("CuidarPet", new { idPet = idPet });

            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }
        public IActionResult AlterarMedicamento()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                return View("~/Views/Home/Main.cshtml");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpPost]
        public IActionResult AlterarMedicamento(int idPet, int idReg, string tipoReg)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                return Json(repo.retornaRegistro(idPet, idReg,tipoReg));
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpPost]
        public IActionResult SalvarAlteracaoMedicamento(IndexModelView indexModel)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                repo.AlterarMedicamento(indexModel);
                return RedirectToAction("CuidarPet", new { idPet = indexModel.idPet });
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }



        //CRUD Vacinas
        [HttpPost]
        public IActionResult CadastrarVacina(IndexModelView indexModel)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                repo.inserirVacina(indexModel);
                return RedirectToAction("CuidarPet", new { idpet = indexModel.idPet });
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        public IActionResult AlterarVacina()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                return View("~/Views/Home/Main.cshtml");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpPost]
        public IActionResult AlterarVacina(int idPet, int idReg, string tipoReg)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                return Json(repo.retornaRegistro(idPet, idReg, tipoReg));
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        public IActionResult SalvarAlteracaoVacina(IndexModelView indexModel)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                repo.AlterarVacina(indexModel);
                return RedirectToAction("CuidarPet", new { idPet = indexModel.idPet });
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }
        [HttpGet]
        public IActionResult ExcluirVacina([FromQuery] int idVacina, [FromQuery] int idPet)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {

                Repositorio repo = new Repositorio();
                repo.excluirPeso(idVacina);
                return RedirectToAction("CuidarPet", new { idPet = idPet });

            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }

        
        
        //Regras de negócio tela Cuidar Pet
        [HttpGet]
        public IActionResult CuidarPet(int idPet)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                IndexModelView indexModel = new IndexModelView();
                indexModel.idPet = idPet;
                Repositorio repo = new Repositorio();
                indexModel.ListaRegistrosPesos = repo.listarRegistrosPesos(idPet);
                indexModel.ListaRegistrosMedicamentos = repo.listarRegistrosMedicamentos(idPet);
                indexModel.ListaRegistrosVacinas = repo.listarRegistrosVacinas(idPet);
                

                return View(indexModel);
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }

        [HttpGet]
        public IActionResult GetJsonPesos(int idPet)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                return Json(repo.listarRegistrosPesos(idPet));
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        [HttpGet]
        public IActionResult GetJsonCalendario(int idPet)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                return Json(repo.retornaCalendarioIndividual(idPet));
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }

        public IActionResult GetJsonCalendarioGeral(int idUsuario)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                return Json(repo.retornaCalendarioGeral());
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }


        [HttpPost]
        public IActionResult Buscar(string textBuscado)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                Repositorio repo = new Repositorio();
                return Json(repo.buscaFinal(textBuscado));
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }

        }

        //Roteamento de telas
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Main()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("id");
                Repositorio repo = new Repositorio();
                List<Pet> listaPet = repo.listaPets(id);
                return View("~/Views/Home/Main.cshtml", listaPet);
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        public IActionResult MinhaConta()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                int id = (int)HttpContext.Session.GetInt32("id");
                Repositorio repo = new Repositorio();
                Usuario userLogado = repo.RetornaUsuario(id);

                return View("~/Views/Home/MinhaConta.cshtml", userLogado);
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }
        public IActionResult CalendarioVacinas()
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                return View("~/Views/Home/CalendarioVacinas.cshtml");
            }
            else
            {
                return View("~/Views/Home/Index.cshtml");
            }
        }



        //Tratativa do sistema de login e sessão.
        [HttpPost]
        public IActionResult Login(Usuario user)
        {
            try
            {
                Repositorio repo = new Repositorio();
                Usuario userLogado = repo.Login(user);

                if (userLogado != null)
                {
                    if(userLogado.imagem != null)
                    {
                        HttpContext.Session.SetInt32("id", userLogado.id);
                        HttpContext.Session.SetString("nome", userLogado.nome);
                        HttpContext.Session.SetString("email", userLogado.email);
                        HttpContext.Session.SetString("imagem", userLogado.imagem);
                    }
                    else
                    {
                        userLogado.imagem = "../assets/profileDefault.png";
                        HttpContext.Session.SetInt32("id", userLogado.id);
                        HttpContext.Session.SetString("nome", userLogado.nome);
                        HttpContext.Session.SetString("email", userLogado.email);
                        HttpContext.Session.SetString("imagem", userLogado.imagem);

                    }


                    return RedirectToAction("Main");

                }
                else
                {
                    ViewBag.MsgErroLogin = "Não foi possivel fazer seu login. Tente novamente!";
                    return View("~/Views/Home/Index.cshtml");
                }
            }
            catch(Exception ex)
            {
                ViewBag.MsgErroLogin = ex;
                return View("~/Views/Home/Index.cshtml");
            }


        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("~/Views/Home/Index.cshtml");
        }

    }
}