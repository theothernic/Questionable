using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionController : Controller
    {
        private readonly QuestionRepository _repo;
        public QuestionController(QuestionRepository repo)
        {
            _repo = repo;
        }
        // GET
        public async Task<IEnumerable<Question>> Index()
        {
            return await _repo.All();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Question> Show(Guid id)
        {
            return await _repo.Find(id);
        }
    }
}