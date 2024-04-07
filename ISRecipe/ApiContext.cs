using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ISRecipe
{
    internal class ApiContext
    {
        public DataTable ShowTable(string name)
        {
            DataTable tables = new DataTable();
            using (var httpClient = new HttpClient())
            {
                tables = JsonConvert.DeserializeObject<DataTable>(httpClient.GetStringAsync("https://localhost:7173/api/" + name).GetAwaiter().GetResult().ToString());
            }
            return tables;
        }

        public void AddTable(string name, ArrayList array)
        {
            StringContent content = new StringContent("");
            switch(name)
            {
                case "Categories":
                    Category category = new Category(array[0].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                    break;
                case "HistoryVisits":
                    HistoryVisit history = new HistoryVisit(DateTime.Parse(array[0].ToString()), Boolean.Parse(array[1].ToString()));
                    content = new StringContent(JsonConvert.SerializeObject(history), Encoding.UTF8, "application/json");
                    break;
                case "Recipes":
                    Recipe recipe = new Recipe(array[0].ToString(), array[1].ToString(), array[2].ToString(), array[3].ToString(), array[4].ToString(), array[5].ToString(), array[6].ToString(), array[7].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(recipe), Encoding.UTF8, "application/json");
                    break;
                case "Users":
                    User user = new User(array[0].ToString(), array[1].ToString(), array[2].ToString(), array[3].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
                    break;
                /*case "Category":
                    Category category = new Category(array[0].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                    break;
                case "Category":
                    Category category = new Category(array[0].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                    break;
                case "Category":
                    Category category = new Category(array[0].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                    break;
                case "Category":
                    Category category = new Category(array[0].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                    break;
                case "Category":
                    Category category = new Category(array[0].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                    break;
                case "Category":
                    Category category = new Category(array[0].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                    break;
                case "Category":
                    Category category = new Category(array[0].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                    break;*/
            }
            using (var httpClient = new HttpClient())
            {
                httpClient.PostAsync("https://localhost:7173/api/" + name + "/", content).GetAwaiter().GetResult();
            }
        }

        public void EditTable(string name, ArrayList array, DataRowView rV)
        {
            StringContent content = new StringContent("");
            switch (name)
            {
                case "Categories":
                    Category category = new Category(Convert.ToInt32(rV[0]), array[0].ToString());
                    content = new StringContent(JsonConvert.SerializeObject(category), Encoding.UTF8, "application/json");
                    break;
            }
            using (var httpClient = new HttpClient())
            {
                httpClient.PutAsync("https://localhost:7173/api/" + name + "/" + rV[0], content).GetAwaiter().GetResult();
            }
        }

        public void DeleteTable(string name, DataRowView rV)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.DeleteAsync("https://localhost:7173/api/" + name + "/" + rV[0]).GetAwaiter().GetResult();
            }
        }
    }
}
