﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using AHBCFinalProject.DAL;
using AHBCFinalProject.Models;
using Newtonsoft.Json;

namespace AHBCFinalProject.SpoonacularServices
{
    public class RecipeByIdStore : IRecipeByIdStore
    {
        private string apiKey = "dc427c57ac7d4169bdb990b3893ebe80";

        public async Task<RecipeResponse> GetRecipeResponseFromId(int recipeId)
        {
            using(var httpClient = new HttpClient { BaseAddress = new Uri("https://api.spoonacular.com/recipes/") })
            {
                var result = await httpClient.GetStringAsync($"{recipeId}/information?apiKey={apiKey}");
                return JsonConvert.DeserializeObject<RecipeResponse>(result);
            }
        }

       
    }
}