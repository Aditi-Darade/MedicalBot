using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

 
namespace Sec6_Assign17_MedicalBot
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hi, I'm " + MedicalBot.GetBotName() + ", I'm here to help you in your medication.");
            Patient patient = new Patient();
            string nothing;

            System.Console.WriteLine("Enter your (patient) details:");
            do
            {
                System.Console.Write("Enter Patient Name: ");
                string tempName = System.Console.ReadLine();
                patient.SetName(tempName, out nothing);
                //System.Console.Write("Name = ");
                //System.Console.Write(patient.GetName());
                patient.GetName();
            }
            while (patient.pritnErrorMessage != "");

            do
            {
                System.Console.Write("Enter Patient Age: ");
                string stringAge = System.Console.ReadLine();
                int tempAge = Convert.ToInt32(stringAge);
                patient.SetAge(tempAge, out nothing);
                //System.Console.Write("Age = ");
                //System.Console.Write(patient.GetAge());
                patient.GetAge();
            }
            while (patient.pritnErrorMessage != "");

            do
            {
                System.Console.Write("Enter Patient Gender: ");
                string tempGender = System.Console.ReadLine();
                patient.SetGender(tempGender, out nothing);
                //System.Console.Write("Gender = ");
                //System.Console.Write(patient.GetGender());
                patient.GetGender();
            }
            while (patient.pritnErrorMessage != "");

            System.Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for None: ");
            string tempMedHis = System.Console.ReadLine();
            patient.SetMedicalHistory(tempMedHis);
            //System.Console.Write("Medical History = ");
            //System.Console.Write(patient.GetMedicalHistory());
            patient.GetMedicalHistory();

            System.Console.WriteLine("\n\nWelcome, " + patient.Name + ", " + patient.Age);
            do
            {
                System.Console.Write("Which of the following symptoms do you have:\nS1. Headache \nS2. Skin rashes \nS3. Dizziness \nEnter the symptom code from above list (S1, S2 or S3): ");
                string tempSymCod = System.Console.ReadLine();
                patient.SetSymptomCode(tempSymCod, out nothing);
                //System.Console.Write("\nSymptom Code = ");
                //System.Console.Write(patient.GetSymptomCode());
                patient.GetSymptomCode();
            }
            while (patient.pritnErrorMessage != "");

            System.Console.WriteLine("\n\nYour prescription based on your age, symptoms and medical history:");
            MedicalBot medicalBot = new MedicalBot();
            medicalBot.PrescribeMedication(patient);

            System.Console.WriteLine("\n\nThank you for coming.");
            System.Console.ReadKey();
        }
    }
}
