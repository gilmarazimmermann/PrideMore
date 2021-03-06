using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace newPrideMore.Models
{
    public class ProfessionalType
    {
        public int Id { get; set; }
        public string Profission { get; set; }
        public string Speciality { get; set; }
        public ICollection<Professional> Professionals { get; set; } = new List<Professional>();

        public ProfessionalType()
        {

        }

        public ProfessionalType(int id, string profission, string speciality)
        {
            Id = id;
            Profission = profission;
            Speciality = speciality;
        }

        public void AddProfessional(Professional professional)
        {
            Professionals.Add(professional);
        }

        public void RemoveProfessional(Professional professional)
        {
            Professionals.Remove(professional);
        }

        /*public void AllProfessionals(ProfessionalType professionals)
        {
            return Professionals.ToList(professionals);
        }*/
    }
}
