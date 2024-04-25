using Newtonsoft.Json;
using Nova_Medical_Center.Scripts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Nova_Medical_Center.Models
{
    public class Employee
    {
        private readonly static byte[] salt = new byte[] { 46,35,41,88,131,103,115,155,203,77,205,158,70,204,77,88 ,53,229,179,176,204,197,45,164,233,133,51,192,253,176,181,30 };
        public string Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set;}
        public DateTime DoB { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HiredDate { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = HashPassword(value);
            }
        }

        public static void SerializeEmployees(List<Employee> employees)
        {
            string jsonString = JsonConvert.SerializeObject(employees, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("employees.json", jsonString, Encoding.UTF8);
        }

        public static async Task<Dictionary<string, List<Employee>>> DeserializeEmployees()
        {
            Dictionary<string, List<Employee>> employees;

            try 
            {
                string jsonString = await Task.Run(() => File.ReadAllText("employees.json", Encoding.UTF8));
                #region Deserialization approach
                employees = await Task.Run(() => JsonConvert.DeserializeObject<Dictionary<string, List<Employee>>>(jsonString));

                #endregion
                return employees;
            }
            catch (Exception e) 
            {
                MessageBox.Show("" + e);
                Events.OnEmployeeLoad.Invoke(false);
                return null;
            }

        }

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] combinedBytes = Encoding.UTF8.GetBytes(password + Convert.ToBase64String(salt));
                byte[] hashedBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToBase64String(hashedBytes);//ToHexString(hashedBytes);
            }
        }

        public virtual string ToString()
        {
            return Id + "\t" + First_Name + "\t" + Last_Name + "\t\n" + Address + "\t" + City + "\t" + PhoneNumber + "\t" + Department + "\t" + Position + "\t\n" + Password;
        }
    }
}
