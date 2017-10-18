using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DeepThoughtsLib.Entities;
using DeepThoughtsLib;
using System.Linq;

namespace DeepThoughtsWebApi.Controllers
{
    public class ProfilesController : Controller
    {
        private readonly DeepContext _context;

        public ProfilesController(DeepContext context){
            _context = context;

            if(_context.Profiles.Count() == 0){
                _context.Profiles.AddRange(new List<Profile>{
                    new Profile(){
                        Name = "philosopher"
                    },
                    new Profile(){
                        Name = "artist"
                    },
                    new Profile(){
                        Name = "musician"
                    }
                });

                _context.SaveChanges();
            }
        }


        // GET api/profiles
        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<Profile> Get()
        {
            return _context.Profiles;
        }

        [HttpGet]
        [Route("api/dosmth")]
        public string DoSmth(){
            return "hahaha";
        }
    }
}
