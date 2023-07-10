using System;
using System.Resources;
using FluentValidation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Application.Validators;

public class AdicionValidator : AbstractValidator<Cliente>
{
    /*public ClienteValidator()
    {

        RuleFor(inc => inc.TipoCliente)
            .NotEmpty().WithMessage(String.Format("Debe especificar si el cliente es persona natural o jurídica", "TipoCliente"));

        RuleFor(inc => inc.RazonSocial)
            .NotEmpty().WithMessage(String.Format("Si es persona jurídica, el campo Razón Social no debe estar vacío", "RazonSocial"));
    }*/
}

