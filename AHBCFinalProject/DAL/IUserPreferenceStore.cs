using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.DAL
{
    public interface IUserPreferenceStore
    {
        UserPreferenceDALModel SelectUserPreferences(int userId);
        bool InsertUserPreferences(UserPreferenceDALModel dalModel);
        bool UpdateUserPreferences(UserPreferenceDALModel dalModel);
        //void CreateNewUserPrefEntry(int id);


    }
}
