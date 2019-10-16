using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDemoVS2017.Models;

namespace WebApiDemoVS2017.Data
{
    public interface IStudentRepository
    {

        IEnumerable<Student> GetAll();
        Student GetStudentById(int Id);
    }
}
