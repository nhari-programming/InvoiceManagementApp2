using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceManagementApp2.Application.Common.Interfaces
{
    public interface ICurrentUserService
    {
        string UserId { get; set; }
    }
}
