using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QLBH.Data;
using QLBH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLBH.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController: ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext  context)
        {
            _context = context;
        }
        [HttpGet]
        public List<User> get()
        {
            return _context.User.ToList();
        }
        [HttpPut]
        [Route("id")]
        public ActionResult PutItem(User change, int? id)
        {
            _context.Entry(change).State = EntityState.Modified;
              _context.SaveChanges();
            return null;
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var it = _context.User.Find(id,id);
            var item = _context.User.Where(x => x.ID.ToString() == id.ToString()).FirstOrDefault();
            _context.User.Remove(item);
            _context.SaveChanges();
            return null;
        }
    }
}
