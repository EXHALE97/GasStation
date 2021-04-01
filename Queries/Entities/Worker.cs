using System;

namespace Queries.Entities
{
    public class Worker
    {
        public int w_staff_id { private set; get; }
        public int w_station_id { private set; get; }
        public string w_surname { private set; get; }
        public string w_name { private set; get; }
        public string w_gender { private set; get; }
        public DateTime w_birthdate { private set; get; }
        public string w_function { private set; get; }
        public int w_salary { private set; get; }

        public void workerSet(int staff_id, int station_id, string surname, string name, string gender, DateTime birthdate, string function, int salary)
        {
            w_staff_id = staff_id;
            w_station_id = station_id;
            w_surname = surname;
            w_name = name;
            w_gender = gender;
            w_birthdate = birthdate;
            w_function = function;
            w_salary = salary;
        }

        public void workerSet(int station_id, string surname, string name, string gender, DateTime birthdate, string function, int salary)
        {
            w_station_id = station_id;
            w_surname = surname;
            w_name = name;
            w_gender = gender;
            w_birthdate = birthdate;
            w_function = function;
            w_salary = salary;
        }

        public void workerSet(string surname, string name, string function, int salary)
        {
            w_surname = surname;
            w_name = name;
            w_function = function;
            w_salary = salary;
        }

        public int GetStaffID() => w_staff_id;
        public int GetStationID() => w_station_id;
        public string GetSurname() => w_surname;
        public string GetName() => w_name;
        public string GetGender() => w_gender;
        public DateTime GetBirthdate() => w_birthdate;
        public string GetFunction() => w_function;
        public int GetSalary() => w_salary;
    }
}
