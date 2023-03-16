using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DoctorOffice.Models
{
  public class Patient
  {
    public string Name { get; set; }
    public int PatientId { get; set; }
    public List<DoctorPatient> JoinEntities { get; set; }

  }
}