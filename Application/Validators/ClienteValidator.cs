using System;
using System.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Application.Validators;

public class ClienteValidator 
{
    public bool Validate(Cliente cliente, out List<string> errors)
    {
        errors = new List<string>();

        // Campos obligatorios
        if (string.IsNullOrEmpty(cliente.Documento))
        {
            errors.Add("El documento es un campo requerido.");
        }

        if(string.IsNullOrEmpty(cliente.IdTipoCliente.ToString()))
        {
            errors.Add("El tipo de persona es un campo obligatorio.");
        }

        if (string.IsNullOrEmpty(cliente.IdTipoDocumento.ToString()))
        {
            errors.Add("El tipo de documento es un campo obligatorio.");
        }


        return errors.Count == 0;
    }
}

