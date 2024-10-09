using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PresentationLayer.Validation
{
    public static class ClientFormValidation
    {
        public static bool ValidateName(string name, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(name) || name.StartsWith(" "))
            {
                errorMessage = "El nombre no puede estar vacío ni tener espacios al inicio.";
                return false;
            }

            if (Regex.IsMatch(name, @"\d"))
            {
                errorMessage = "El nombre no puede contener números.";
                return false;
            }

            return true;
        }

        public static bool ValidatePhone(string phone, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(phone) || phone.StartsWith(" "))
            {
                errorMessage = "El teléfono no puede estar vacío ni tener espacios al inicio.";
                return false;
            }

            if (!Regex.IsMatch(phone, @"^\d+$"))
            {
                errorMessage = "El teléfono solo puede contener números.";
                return false;
            }

            if (phone.Length < 8 || phone.Length > 15)
            {
                errorMessage = "El teléfono debe tener entre 8 y 15 caracteres.";
                return false;
            }

            return true;
        }

        public static bool ValidateEmail(string email, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(email) || email.StartsWith(" "))
            {
                errorMessage = "El correo electrónico no puede estar vacío ni tener espacios al inicio.";
                return false;
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage = "El correo electrónico no es válido.";
                return false;
            }

            return true;
        }
    }
}