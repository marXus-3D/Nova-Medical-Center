using Nova_Medical_Center.Models;
using Nova_Medical_Center.Views.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova_Medical_Center.Scripts
{
    internal class CustomDialog
    {
        private static bool value;
        public static Action<bool> OnEmployeeUpdate = (val) => value = val;
        public static bool ShowDialog(Employee employee,ref int i) 
        {
           new DialogBox(ref employee).ShowDialog();
           Data.Data.employees[i] = employee;
           return value;
        }

        public static bool ShowPasswordDialog(Employee employee, ref int i)
        {
            new PasswordDialogBox(ref employee).ShowDialog();
            Data.Data.employees[i] = employee;
            return value;
        }
        public static void ShowQuestionDialog(ref int i)
        {
            new QuestionDialog("What is the Patient current urgency level", "Patient Urgency Level", ref i).ShowDialog();
        }
        public static void ShowDischargeDialog(ref int i)
        {
            new DischargeDialogBox(ref i).ShowDialog();
        }
    }
}
