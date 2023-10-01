using Exemplo1.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exemplo1.MVC.Controllers
{
    public class AlunoController : Controller
    {
        private IList<Aluno> alunos = new List<Aluno>()
        {
            new Aluno()
            {
                alunoId = 1,
                nome = "José",
                nota = 9.5
            },

            new Aluno()
            {
                alunoId = 2,
                nome = "Maria",
                nota = 7.5
            },

            new Aluno()
            {
                alunoId = 3,
                nome = "Gabriela",
                nota = 7.5
            },
        };
        public IActionResult Index()
        {
            return View(alunos);
        }
    }
}
