﻿using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encyption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CretaSigningCredentials(SecurityKey securityKey) 
        {
            return new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
