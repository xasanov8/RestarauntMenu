﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestarauntMenu.Application.UseCases.QrCodeServices
{
    public interface IQrCodeService
    {
        byte[] GenerateQrCode(string content);
    }
}
