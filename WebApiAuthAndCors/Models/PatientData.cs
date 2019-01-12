using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiAuthAndCors.Models
{
    public class PatientData
    {

        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ailment> Ailments { get; set; }
        public ICollection<Medication> Medications { get; set; }
    }

    public class Medication
    {
        public string Name { get; set; }
        public int Doses { get; set; }
    }

    public class Ailment
    {
        public string Name { get; set; }
    }

}