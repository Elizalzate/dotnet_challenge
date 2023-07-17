using System;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Application.Validators;

public class ClienteDetallesValidator 
{
    public bool Validate(ClienteDetalles clienteDetalles, out List<string> errors)
    {
        errors = new List<string>();

        // Validar campos obligatorios
        if (string.IsNullOrEmpty(clienteDetalles.Documento))
        {
            errors.Add("El documento es un campo obligatorio");
        }
        if (string.IsNullOrEmpty(clienteDetalles.Ciudad))
        {
            errors.Add("La ciudad y el país son campos obligatorios");
        }

        // Telefono celular
        if (IsTelefonoCelularValid(clienteDetalles.TelefonoCelular))
        {
            errors.Add("El celular debe tener una longitud entre 7 y 12 dígitos");
        }

        return errors.Count == 0;
    }

    private bool IsTelefonoCelularValid(string Celular)
    {
        if (!string.IsNullOrEmpty(Celular) && Celular.Length >= 7 && Celular.Length <= 12)
        {
            return true;
        }
        return false;
    }
}

