using System;
namespace PatientInfo;

class Program
{
    public static void Main(string[] args)
    {
        PatientInfo patient = new PatientInfo("patient1","father1",5,"District","Fever");
        patient.DisplayInfo();
        DoctorInfo doctor = new DoctorInfo("doctor","father2");
        doctor.DisplayInfo();
    }
}