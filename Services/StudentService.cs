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
    public class StudentService
    {
        private readonly UniversityContext _ctx = new UniversityContext();

        public List<Student> GetByProfessor(int profId)
            => _ctx.Students
                   .Where(s => s.ProfessorId == profId)
                   .AsNoTracking()
                   .ToList();

        public bool Add(int profId, Student dto, out string error)
        {
            error = ValidationHelper.ValidateName(dto.FirstName, "First name")
                 ?? ValidationHelper.ValidateName(dto.LastName, "Last name")
                 ?? ValidationHelper.ValidateCNP(dto.CNP)
                 ?? ValidationHelper.ValidateMatricol(dto.MatricolNumber)
                 ?? ValidationHelper.ValidateSex(dto.Sex)
                 ?? ValidationHelper.ValidateAge(dto.Age)
                 ?? ValidationHelper.ValidateDepartment(dto.Department);
            if (error != null) return false;

            dto.ProfessorId = profId;
            _ctx.Students.Add(dto);
            _ctx.SaveChanges();
            error = null;
            return true;
        }

        public bool Update(int studentId, Student dto, out string error)
        {
            var stud = _ctx.Students.Find(studentId);
            if (stud == null)
            {
                error = "Student not found.";
                return false;
            }

            // aceleași validări ca la Add
            error = ValidationHelper.ValidateName(dto.FirstName, "First name")
                 ?? ValidationHelper.ValidateName(dto.LastName, "Last name")
                 ?? ValidationHelper.ValidateCNP(dto.CNP)
                 ?? ValidationHelper.ValidateMatricol(dto.MatricolNumber)
                 ?? ValidationHelper.ValidateSex(dto.Sex)
                 ?? ValidationHelper.ValidateAge(dto.Age)
                 ?? ValidationHelper.ValidateDepartment(dto.Department);
            if (error != null) return false;

            // actualizare câmpuri
            stud.FirstName = dto.FirstName;
            stud.LastName = dto.LastName;
            stud.CNP = dto.CNP;
            stud.MatricolNumber = dto.MatricolNumber;
            stud.Sex = dto.Sex;
            stud.Age = dto.Age;
            stud.Department = dto.Department;

            _ctx.SaveChanges();
            error = null;
            return true;
        }

        public bool Delete(int studentId, out string error)
        {
            var stud = _ctx.Students.Find(studentId);
            if (stud == null)
            {
                error = "No student selected or student does not exist.";
                return false;
            }
            _ctx.Students.Remove(stud);
            _ctx.SaveChanges();
            error = null;
            return true;
        }

        public List<Student> Filter(int profId, Student filter)
        {
            var query = _ctx.Students
                            .Where(s => s.ProfessorId == profId);

            if (!string.IsNullOrWhiteSpace(filter.FirstName))
                query = query.Where(s => s.FirstName.Contains(filter.FirstName));

            if (!string.IsNullOrWhiteSpace(filter.LastName))
                query = query.Where(s => s.LastName.Contains(filter.LastName));

            if (!string.IsNullOrWhiteSpace(filter.CNP))
                query = query.Where(s => s.CNP.Contains(filter.CNP));

            if (!string.IsNullOrWhiteSpace(filter.MatricolNumber))
                query = query.Where(s => s.MatricolNumber.Contains(filter.MatricolNumber));

            if (!string.IsNullOrWhiteSpace(filter.Sex))
            {
                var sexNormalized = filter.Sex.ToLower();
                query = query.Where(s => s.Sex.ToLower() == sexNormalized);
            }

            if (!string.IsNullOrWhiteSpace(filter.Department))
                query = query.Where(s => s.Department.Contains(filter.Department));

            if (filter.Age > 0)
                query = query.Where(s => s.Age == filter.Age);

            return query
                   .AsNoTracking()
                   .ToList();
        }

        public List<Student> SortByFirstName(int professorId)
        {
           return _ctx.Students
               .Where(s => s.ProfessorId == professorId)
               .OrderBy(s => s.FirstName)
               .AsNoTracking()
               .ToList();
        }

        public List<Student> SortByLastName(int professorId)
        {
            return _ctx.Students
               .Where(s => s.ProfessorId == professorId)
               .OrderBy(s => s.LastName)
               .AsNoTracking()
               .ToList();
        }
    }
}

