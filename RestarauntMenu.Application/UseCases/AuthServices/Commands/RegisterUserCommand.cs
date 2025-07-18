﻿using MediatR;
using RestarauntMenu.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntMenu.Application.UseCases.AuthServices.Commands
{
    public class RegisterUserCommand : IRequest<ResponseModel>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
