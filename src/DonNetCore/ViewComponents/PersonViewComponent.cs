using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DonNetCore.Models;
using System.Threading;

namespace DonNetCore.ViewComponents
{
    public class PersonViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(bool isMask)
        {
            Person p = await this.GetData();

            if (isMask)
            {
                p.Name = p.Name.Substring(0, 1) + "XX";
            }
            
            return View(p);
        }

        private async Task<Person> GetData()
        {
            return await Task.Run(() =>
            {
                var p = new Person()
                {
                    Id = "A123",
                    Name = "林峻同"
                };

                return p;
            });
        }
    }
}
