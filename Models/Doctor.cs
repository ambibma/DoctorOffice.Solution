using System.Collections.Generic;
using System.Linq;

namespace DoctorOffice.Models
{
  public class Doctor
  {
    public string Name { get; set; }
    public int DoctorId { get; set; }
    public int SpecialtyId { get; set; } //eye doctor, endocrinolgy, 
    public List<DoctorPatient> JoinEntities {get;set;}
    public List<Patient> Patients { get; set; }

    //string Gender{get;set;}


  }
}