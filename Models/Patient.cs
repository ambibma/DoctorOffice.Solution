using System.Collections.Generic;

namespace DoctorOffice.Models
{
  public class Patient
  {
    public string Name { get; set; }
    public int PatientId { get; set; }
    
    public List<DoctorPatient> JoinEntities { get; set; }

  }
}