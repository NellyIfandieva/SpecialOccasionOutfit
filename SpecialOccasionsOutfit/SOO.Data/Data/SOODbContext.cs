using DataModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace Data
{
    public class SOODbContext : IdentityDbContext<SOOUser>
    {
    }
}
