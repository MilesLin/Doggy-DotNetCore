using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DonNetCore.Models.Services
{
    public class ProfileOptionsService
    {
        public List<SelectListItem> ListGenders { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "Female", Text = "Female" },
            new SelectListItem { Value = "Male", Text = "Male" }
        };

    }
}
