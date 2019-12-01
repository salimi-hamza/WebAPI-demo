using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    /// <summary>
    /// This is where I give you all the info about my peeps.
    /// </summary>
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Korry",Id=1 });
            people.Add(new Person { FirstName = "Hakim", LastName = "bouasta",Id=2});
            people.Add(new Person { FirstName = "abd aziz", LastName = "chaabi" ,Id=3});
        }

        /// <summary>
        /// Get a list of the firstnames of all users.
        /// </summary>
        /// <param name="userId">The unique identifier for this person</param>
        /// <param name="age">We want to know how old they are</param>
        /// <returns>A list of first names</returns>
        [Route("api/People/GetFirstnames/{userId:int}/{age:int}")]
        [HttpGet]
        public List<string> GetFirstNames(int userId,int age)
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.FirstName);
            }
            return output;
        }
        /// <summary>
        /// Get a listof the Lastnames of all users.
        /// </summary>
        /// <returns> A List of Last Names</returns>
        [Route("api/People/GetLastNames")]
        [HttpGet]
        public List<string> GetLastNames()
        {
            List<string> output = new List<string>();
            foreach (var p in people)
            {
                output.Add(p.LastName);
            }
            return output;
        }

        // GET: api/People
        public List<Person> Get()
        {
            return people;
        }

        // GET: api/People/5
        public Person Get(int id)
        {
            return people.Where(x => x.Id == id).FirstOrDefault();
               
        }

        // POST: api/People
        public void   Post(Person val)
        {
            people.Add(val);
        }

        // PUT: api/People/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/People/5
        public void Delete(int id)
        {
              
        }
    }
}
