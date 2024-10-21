using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class MedicalBot
    {
        public const string BotName = "Bob";
        public string medicineName;

        public static string GetBotName()
        {
            return BotName;
        }
        public void PrescribeMedication(Patient patient)
        {
            if (patient.SymptomCode == "Headache")
            {
                System.Console.Write("ibuprofen ");
                medicineName = "ibuprofen";
                GetDosage(medicineName);
            }
            else if (patient.SymptomCode == "Skin rashes")
            {
                System.Console.Write("diphenhydramine ");
                medicineName = "diphenhydramine";
                GetDosage(medicineName);
            }
            else if (patient.SymptomCode == "Dizziness")
            {
                if (patient.MedicalHistory == "diabetes" || patient.MedicalHistory == "Diabetes")
                {
                    System.Console.Write("metformin ");
                    medicineName = "metformin";
                    GetDosage(medicineName);
                }
                else
                {
                    System.Console.Write("dimenhydrinate ");
                    medicineName = "dimenhydrinate";
                    GetDosage(medicineName);
                }
            }
            else
            {
            }

            string GetDosage(string medicineName)
            {
                if (medicineName == "ibuprofen" && patient.Age < 18)
                {
                    System.Console.Write("400 mg");
                }
                else if (medicineName == "ibuprofen" && patient.Age > 18)
                {
                    System.Console.Write("800 mg");
                }
                else if (medicineName == "diphenhydramine" && patient.Age < 18)
                {
                    System.Console.Write("50 mg");
                }
                else if (medicineName == "diphenhydramine" && patient.Age > 18)
                {
                    System.Console.Write("300 mg");
                }
                else if (medicineName == "dimenhydrinate" && patient.Age < 18)
                {
                    System.Console.Write("50 mg");
                }
                else if (medicineName == "dimenhydrinate" && patient.Age > 18)
                {
                    System.Console.Write("400 mg");
                }
                else if (medicineName == "metformin")
                {
                    System.Console.Write("500 mg");
                }
                else
                {

                }
                return "";
            }
        }

    }

    public class Patient
    {
        public string Name;
        public int Age;
        public string Gender;
        public string MedicalHistory;
        public string SymptomCode;
        public string Prescription;

        public string pritnErrorMessage;
        public void SetName(string name, out string errorMessage)
        {
            int nameCount = name.Count();
            if (nameCount == 0 || nameCount == 1 || nameCount == 2)
            {
                errorMessage = "Invalid Name. Patient name should contain at least two or more characters.\n";
                pritnErrorMessage = errorMessage;

            }
            else
            {
                Name = name;
                errorMessage = "";
                pritnErrorMessage = errorMessage;
            }
        }
        public string GetName()
        {
            System.Console.Write(pritnErrorMessage);
            //return errorMessage;
            return Name;
        }
        //-------------------------------------------------------------------------------------------------
        public void SetAge(int age, out string errorMessage)
        {
            if (age < 0 || age > 100)
            {
                errorMessage = "Invalid Age. Patient's age cannot be negative or over 100.\n";
                pritnErrorMessage = errorMessage;
                Convert.ToString(Age);

            }
            else
            {
                Age = age;
                errorMessage = "";
                pritnErrorMessage = errorMessage;
            }
        }
        public int GetAge()
        {
            System.Console.Write(pritnErrorMessage);
            return Age; //0 is printing here if age is -ve or above 100
        }
        //-------------------------------------------------------------------------------------------------
        public void SetGender(string gender, out string errorMessage)
        {
            if (gender == "Male" || gender == "Female" || gender == "Other" || gender == "male" || gender == "female" || gender == "other" || gender == "M" || gender == "F" || gender == "O" || gender == "m" || gender == "f" || gender == "o")
            {
                Gender = gender;
                errorMessage = "";
                pritnErrorMessage = errorMessage;
            }
            else
            {
                errorMessage = "Invalid Gender. Patient's gender should be either Male, Female or Other.\n";
                pritnErrorMessage = errorMessage;

            }
        }
        public string GetGender()
        {
            System.Console.Write(pritnErrorMessage);
            //return errorMessage;
            return Gender;
        }
        //-------------------------------------------------------------------------------------------------
        public void SetMedicalHistory(string medicalHistory)
        {
            MedicalHistory = medicalHistory;
        }
        public string GetMedicalHistory()
        {
            return MedicalHistory;
        }
        //-------------------------------------------------------------------------------------------------
        public void SetSymptomCode(string symptomCode, out string errorMessage)
        {
            if (symptomCode == "S1" || symptomCode == "s1")
            {
                symptomCode = "Headache";
                SymptomCode = symptomCode;
                errorMessage = "";
                pritnErrorMessage = errorMessage;
            }
            else if (symptomCode == "S2" || symptomCode == "s2")
            {
                symptomCode = "Skin rashes";
                SymptomCode = symptomCode;
                errorMessage = "";
                pritnErrorMessage = errorMessage;
            }
            else if (symptomCode == "S3" || symptomCode == "s3")
            {
                symptomCode = "Dizziness";
                SymptomCode = symptomCode;
                errorMessage = "";
                pritnErrorMessage = errorMessage;
            }
            else
            {
                errorMessage = "Invalid SymptomCode. Please enter S1, S2 or S3.\n";
                pritnErrorMessage = errorMessage;

            }
        }
        public string GetSymptomCode()
        {
            System.Console.Write(pritnErrorMessage);
            //return errorMessage;
            return SymptomCode;
        }
        //-------------------------------------------------------------------------------------------------
        public void SetPrescription(string prescription)
        {
            Prescription = prescription;
        }
        public string GetPrescription()
        {
            return Prescription;
        }
        //-------------------------------------------------------------------------------------------------
    }

}
