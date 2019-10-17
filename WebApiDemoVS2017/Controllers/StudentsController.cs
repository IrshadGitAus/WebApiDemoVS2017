using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDemoVS2017.Data;

namespace WebApiDemoVS2017.Controllers
{
    public class StudentsController : ApiController
    {
        //private StudentRespository _respository = new StudentRespository();

        private IStudentRepository _repository; 

        public StudentsController(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IHttpActionResult Get()
        {
            return Ok(_repository.GetAll());
        }
    }
}
