﻿using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MoneyKepper_Core.BL
{
    public static class BugetBL
    {
        public static void Run(HttpClient client)
        {
            client.BaseAddress = new Uri("http://localhost:63840/api/Buget/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }



        public static IList<Buget> GetBugetByDatesAndType(DateTime startDateTime, DateTime endDateTime, int? typeID)
        {
            List<Buget> bugets = new List<Buget>();
            Task task = Task.Run(async () =>
            {
                using (var client = new HttpClient())
                {
                    Run(client);
                    HttpResponseMessage response = await client.PostAsJsonAsync("GetBugetByDatesAndType", new { startDateTime, endDateTime, typeID });
                    string httpResponseBody = "";
                    if (response.IsSuccessStatusCode)
                    {
                        httpResponseBody = await response.Content.ReadAsStringAsync();
                        bugets = JsonConvert.DeserializeObject<List<Buget>>(httpResponseBody);
                    }
                    return bugets;
                }
            });
            task.Wait(); // Wait
            return bugets;
        }

        public static bool CreateNewBuget(Buget buget)
        {
            bool result = false;
            Task task = Task.Run(async () =>
            {
                using (var client = new HttpClient())
                {
                    Run(client);
                    HttpResponseMessage response = await client.PostAsJsonAsync("CreateNewBuget", buget);
                    string httpResponseBody = "";
                    if (response.IsSuccessStatusCode)
                    {
                        httpResponseBody = await response.Content.ReadAsStringAsync();
                        result = true;
                    }
                }
            });
            task.Wait(); // Wait
            return result;
        }


        public static bool DeleteBuget(int bugetID)
        {
            bool result = false;
            Task task = Task.Run(async () =>
            {
                using (var client = new HttpClient())
                {
                    Run(client);
                    HttpResponseMessage response = await client.DeleteAsync($"DeleteBuget/{bugetID}");
                    string httpResponseBody = "";
                    if (response.IsSuccessStatusCode)
                    {
                        httpResponseBody = await response.Content.ReadAsStringAsync();
                        result = true;
                    }
                }
            });
            task.Wait(); // Wait
            return result;
        }

        public static bool UpdateBuget(Buget buget)
        {
            bool result = false;
            Task task = Task.Run(async () =>
            {
                using (var client = new HttpClient())
                {
                    Run(client);
                    HttpResponseMessage response = await client.PostAsJsonAsync("UpdateBuget", buget);
                    string httpResponseBody = "";
                    if (response.IsSuccessStatusCode)
                    {
                        httpResponseBody = await response.Content.ReadAsStringAsync();
                        result = true;
                    }
                }
            });
            task.Wait(); // Wait
            return result;
        }
    }
}
