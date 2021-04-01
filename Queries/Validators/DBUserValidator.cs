using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.Common;
using System.Collections;
using Queries;
using Queries.Entities;
using Queries.dgvControllers;
using Queries.comboBoxFillers;
using Queries.Repositories;
using Queries.Interfaces;

namespace Queries.Validators
{
    public class DBUserValidator
    {
        public DBUserValidator()
        {

        }

        public bool CheckAddition(DBUser user, out List<string> errorList)
        {
            errorList = new List<string>();
            bool checkFlag = true;
            if (user.GetDBUserLogin() == String.Empty || user.GetDBUserLogin().Length < 4 && !user.GetDBUserRole().Equals("worker"))
            {
                checkFlag = false;
                errorList.Add("Логин должн быть не меньше 4 символов!");
            }
            if (user.GetDBUserPass() == String.Empty || user.GetDBUserPass().Length < 6)
            {
                checkFlag = false;
                errorList.Add("Пароль должн быть не меньше 6 символов!");
            }
            if (user.GetDBUserRole() == String.Empty)
            {
                checkFlag = false;
                errorList.Add("Роль указана неверно!");
            }

            return checkFlag;
        }
    }
}
