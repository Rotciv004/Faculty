using Facultate.Data;
using Facultate.Helpers;
using Facultate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Facultate.Services
{
    public class ProfessorService
    {
        private readonly UniversityContext _ctx = new UniversityContext();

        public bool Connect(string first, string last, out Professor prof, out string error)
        {
            error = ValidationHelper.ValidateName(first, "First name")
                 ?? ValidationHelper.ValidateName(last, "Last name");
            if (error != null) { prof = null; return false; }

            prof = _ctx.Professors
                       .FirstOrDefault(p => p.FirstName == first && p.LastName == last);
            if (prof == null)
            {
                error = "Professor not found. Use Add to create a new one.";
                return false;
            }
            return true;
        }

        public bool Add(string first, string last, out string error)
        {
            error = ValidationHelper.ValidateName(first, "First name")
                 ?? ValidationHelper.ValidateName(last, "Last name");
            if (error != null) return false;

            if (_ctx.Professors.Any(p => p.FirstName == first && p.LastName == last))
            {
                error = "Professor already exists.";
                return false;
            }

            _ctx.Professors.Add(new Professor { FirstName = first, LastName = last });
            _ctx.SaveChanges();
            return true;
        }

        public bool Delete(string first, string last, out string error)
        {
            error = ValidationHelper.ValidateName(first, "First name")
                 ?? ValidationHelper.ValidateName(last, "Last name");
            if (error != null) return false;

            var prof = _ctx.Professors
                           .Include(p => p.Students)
                           .FirstOrDefault(p => p.FirstName == first && p.LastName == last);
            if (prof == null)
            {
                error = "Professor not found.";
                return false;
            }

            _ctx.Professors.Remove(prof);
            _ctx.SaveChanges();  // va şterge în cascadă şi studenţii
            return true;
        }

        public List<Professor> GetAll() => _ctx.Professors.AsNoTracking().ToList();
    }
}
