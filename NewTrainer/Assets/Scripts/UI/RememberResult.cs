using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using PatientObj;

namespace StudentsData
{
    public class RememberResult : MonoBehaviour
    {
        public void Finish()
        {
            Student.NumberPatient = "Пациент №" + PatientChoice.patientName;

            if(CreateStudents.resultDiagnosis == 1)
                Student.Result = "Диагноз поставлен правильно";
            else
                if(CreateStudents.resultDiagnosis == 0)
                    Student.Result = "Диагноз поставлен не правильно";
                    else
                    {
                        Student.Result = "Диагноз не поставлен";
                        Student.NumberPatient = "";
                    }
        }
    }
}