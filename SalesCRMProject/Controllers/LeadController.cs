using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using SalesCRMProject.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace SalesCRMProject.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {

        private static readonly List<Lead> leads = new()
        {
            new Lead
                {
                    Id = 1,
                    Contact = new Contact
                        {
                            Name = "John Ashley",
                            Email = "JohnAshley@company.com",
                            Phone = "5555555555"
                        },
                    Company = new Company
                    {
                        Name = "Dogwood Logistics",
                        Industry = "Transportation",
                        NumOfEmployees= 17
                    },
                    LeadClass = "hot"

                },
                 new Lead
                {
                    Id = 2,
                    Contact = new Contact
                        {
                            Name = "Mark Johnson",
                            Email = "markjohnson@company.com",
                            Phone = "5555555555"
                        },
                    Company = new Company
                    {
                        Name = "Transpire Logistics",
                        Industry = "Transportation",
                        NumOfEmployees= 35
                    },
                    LeadClass = "cold"

                }

        };
        [HttpGet]
        public async Task<ActionResult<List<Lead>>> GetAllLeads()
        {
            return Ok(leads);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Lead>> GetLead(int id)
        {
            var lead = leads.Find(x => x.Id == id);
            if (lead is null)
            {
                return NotFound("Lead not found");
            }
            return Ok(lead);
        }

        [HttpPost]
        public async Task<ActionResult<Lead>> AddLead(Lead lead)
        {
            leads.Add(lead);
            return Ok(leads);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Lead>> GetLead(int id)
        {
            var lead = leads.Find(x => x.Id == id);
            if (lead is null)
            {
                return NotFound("Lead not found");
            }
            return Ok(lead);
        }
    }

}
