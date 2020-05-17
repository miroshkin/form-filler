using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVFiller.Data
{
    public class CurriculumVitae : ICurriculumVitae
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }

        public string Profile { get; set; }

        public List<string> KeySkills { get; set; }

        public List<string> ProfessionalAccomplishments { get; set; }



    }
}
