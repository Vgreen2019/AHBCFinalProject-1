using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AHBCFinalProject.Services
{
    public class UserPreferenceService: IUserPreferenceService
    {
        private readonly IUserPreferenceStore _userPreferenceStore;
        private readonly IUserIdService _userIdService;
        private readonly int UserID;

        public UserPreferenceService(IUserPreferenceStore userPreferenceStore, IUserIdService userIdService)
        {
            _userPreferenceStore = userPreferenceStore;
            _userIdService = userIdService;
            UserID = _userIdService.UserId;
        }

        public UserPreferencesViewModel GetUserPreferencesFromId()
        {
            var dalModel = _userPreferenceStore.SelectUserPreferences(UserID);

            string[] diet = { "" };
            string[] intolerances = { "" };
         
            
            if (dalModel.Diet != null)
            {
                diet = dalModel.Diet.Split(',');
            }

            if (dalModel.Intolerances != null)
            {
                intolerances = dalModel.Intolerances.Split(',');
            }
            
            var viewModel = new UserPreferencesViewModel();
            viewModel.UserId = UserID; //CHANGE BACK TO BLANK

            if (diet.Contains("Gluten Free"))
                viewModel.GlutenFree = true;
            if (diet.Contains("Ketogenic"))
                viewModel.Ketogenic = true;
            if (diet.Contains("Vegetarian"))
                viewModel.Vegetarian = true;
            if (diet.Contains("Lacto-Vegetarian"))
                viewModel.LactoVegetarian = true;
            if (diet.Contains("Ovo-Vegetarian"))
                viewModel.OvoVegetarian = true;
            if (diet.Contains("Vegan"))
                viewModel.Vegan = true;
            if (diet.Contains("Pescetarian"))
                viewModel.Pescetarian = true;
            if (diet.Contains("Paleo"))
                viewModel.Paleo = true;
            if (diet.Contains("Primal"))
                viewModel.Primal = true;
            if (diet.Contains("Whole30"))
                viewModel.Whole30 = true;

            if (intolerances.Contains("Dairy"))
                viewModel.Dairy = true;
            if (intolerances.Contains("Egg"))
                viewModel.Egg = true;
            if (intolerances.Contains("Gluten"))
                viewModel.Gluten = true;
            if (intolerances.Contains("Grain"))
                viewModel.Grain = true;
            if (intolerances.Contains("Peanut"))
                viewModel.Peanut = true;
            if (intolerances.Contains("Seafood"))
                viewModel.Seafood = true;
            if (intolerances.Contains("Sesame"))
                viewModel.Sesame = true;
            if (intolerances.Contains("Shellfish"))
                viewModel.Shellfish = true;
            if (intolerances.Contains("Soy"))
                viewModel.Soy = true;
            if (intolerances.Contains("Sulfite"))
                viewModel.Sulfite = true;
            if (intolerances.Contains("'Tree Nut'"))
                viewModel.TreeNut = true;
            if (intolerances.Contains("Wheat"))
                viewModel.Wheat = true;

            return viewModel;
        }

        public void SetUserPreferences(UserPreferencesViewModel viewModel)
        {
            var dalModel = UPViewModelToDAL(viewModel);

            _userPreferenceStore.InsertUserPreferences(dalModel);
        }

        public void UpdateUserPreferences(UserPreferencesViewModel viewModel)
        {
            var dalModel = UPViewModelToDAL(viewModel);

            _userPreferenceStore.UpdateUserPreferences(dalModel);
        }

        private UserPreferenceDALModel UPViewModelToDAL(UserPreferencesViewModel viewModel)
        {
            var dalModel = new UserPreferenceDALModel();
            var intolerances = new List<string>();
            var diets = new List<string>();

            dalModel.Id = UserID;

            if (viewModel.GlutenFree)
                diets.Add("Gluten Free");
            if (viewModel.Ketogenic)
                diets.Add("Ketogenic");
            if (viewModel.Vegetarian)
                diets.Add("Vegetarian");
            if (viewModel.LactoVegetarian)
                diets.Add("Lacto-Vegetarian");
            if (viewModel.OvoVegetarian)
                diets.Add("Ovo-Vegetarian");
            if (viewModel.Vegan)
                diets.Add("Vegan");
            if (viewModel.Pescetarian)
                diets.Add("Pescetarian");
            if (viewModel.Paleo)
                diets.Add("Paleo");
            if (viewModel.Primal)
                diets.Add("Primal");
            if (viewModel.Whole30)
                diets.Add("Whole30");

            if (viewModel.TreeNut)
                intolerances.Add("Tree Nut");
            if (viewModel.Dairy)
                intolerances.Add("Dairy");
            if (viewModel.Egg)
                intolerances.Add("Egg");
            if (viewModel.Gluten)
                intolerances.Add("Gluten");
            if (viewModel.Grain)
                intolerances.Add("Grain");
            if (viewModel.Peanut)
                intolerances.Add("Peanut");
            if (viewModel.Seafood)
                intolerances.Add("Seafood");
            if (viewModel.Sesame)
                intolerances.Add("Sesame");
            if (viewModel.Shellfish)
                intolerances.Add("Shellfish");
            if (viewModel.Soy)
                intolerances.Add("Soy");
            if (viewModel.Sulfite)
                intolerances.Add("Sulfite");
            if (viewModel.Wheat)
                intolerances.Add("Wheat");

            dalModel.Diet = String.Join(",", diets);
            dalModel.Intolerances = String.Join(",", intolerances);

            if (viewModel.ExcludedIngredients != null)
            {
                dalModel.ExcludedIngredients = viewModel.ExcludedIngredients;
            }

            return dalModel;
        }

        //may need some revisions
        public UpdateUserViewModel GetUpdatedPreferenceView()
        {
            var dalPreference = _userPreferenceStore.SelectUserPreferences(UserID);
            var updatedPreference = new UpdateUserViewModel()
            {
                Diet = dalPreference.Diet,
                Intolerances = dalPreference.Intolerances,
                ExcludedIngredients = dalPreference.ExcludedIngredients
            };

            return updatedPreference;
        }

       
    }
}