using System;

namespace AgeCalculatorKata
{
    public class AgeCalc
    {
        public int CalculateAge(DateTime birthDate, DateTime ageDate)
        {
            var age = ageDate.Year - birthDate.Year;
            if (HasHadBirthday(birthDate, ageDate))
            {
                return age;
            }
            return age -1;
        }

        private static bool HasHadBirthday(DateTime birthDate, DateTime ageDate)
        {

            var hasHadBDay = false;
            if (ageDate.Month > birthDate.Month)
            {
                hasHadBDay =  true;
            }
            else if (ageDate.Month == birthDate.Month
                     && ageDate.Day >= birthDate.Day)
            {
                hasHadBDay = true;
            }
            return hasHadBDay;
        }
    }
}