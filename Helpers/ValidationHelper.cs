using Facultate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Facultate.Helpers
{
    public static class ValidationHelper
    {
        public static string ValidateName(string value, string field)
        {
            if (string.IsNullOrWhiteSpace(value))
                return $"{field} is required.";
            if (value.Length < 3)
                return $"{field} must have at least 3 letters.";
            if (!value.All(char.IsLetter))
                return $"{field} must contain only letters.";
            return null;
        }

        public static string ValidateCNP(string cnp)
        {
            if (string.IsNullOrWhiteSpace(cnp)) return "CNP is required.";
            if (!Regex.IsMatch(cnp, @"^\d{13}$"))
                return "CNP must be exactly 13 digits.";
            return null;
        }
        public static string ValidateMatricol(string m)
        {
            if (string.IsNullOrWhiteSpace(m)) return "Matricol number is required.";
            if (!Regex.IsMatch(m, @"^\d{4}$"))
                return "Matricol number must be exactly 4 digits.";
            return null;
        }
        public static string ValidateSex(string sex)
        {
            return (sex?.ToLower() == "male" || sex?.ToLower() == "female")
               ? null
               : "Sex must be 'male' or 'female'.";
        }
        public static string ValidateAge(int age)
        {
            return (age >= 18 && age <= 100)
               ? null
               : "Age must be between 18 and 100.";
        }
        public static string ValidateDepartment(string d)
        {
            return string.IsNullOrWhiteSpace(d)
               ? "Department is required."
               : null;
        }

        public static string ValidateFilterCriteria(Student filter)
        {
            if (!string.IsNullOrWhiteSpace(filter.FirstName))
            {
                var err = ValidateName(filter.FirstName, "First name");
                if (err != null) return err;
            }
            if (!string.IsNullOrWhiteSpace(filter.LastName))
            {
                var err = ValidateName(filter.LastName, "Last name");
                if (err != null) return err;
            }
            if (!string.IsNullOrWhiteSpace(filter.Sex))
            {
                var err = ValidateSex(filter.Sex);
                if (err != null) return err;
            }
            if (!string.IsNullOrWhiteSpace(filter.Department))
            {
                var err = ValidateDepartment(filter.Department);
                if (err != null) return err;
            }
            if (filter.Age != 0)
            {
                var err = ValidateAge(filter.Age);
                if (err != null) return err;
            }
            if (!string.IsNullOrWhiteSpace(filter.CNP))
            {
                var err = ValidateCNP(filter.CNP);
                if (err != null) return err;
            }
            if (!string.IsNullOrWhiteSpace(filter.MatricolNumber))
            {
                var err = ValidateMatricol(filter.MatricolNumber);
                if (err != null) return err;
            }

            return null;
        }

    }
}
