using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Mail.Interfaces;
using Application.Mail.Models;

namespace Application.Common.Interfaces
{
    public interface IMailProviderFactory
    {
        IMailServiceProvider GetProvider(Settings request);
    }
}
