using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Kinesia.Gestion.Web.Authentication.JwtBearer
{
    public class AsyncJwtBearerOptions : JwtBearerOptions
    {
        public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;
        
        private readonly GestionAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new GestionAsyncJwtSecurityTokenHandler();

        public AsyncJwtBearerOptions()
        {
            AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() {_defaultAsyncHandler};
        }
    }

}
