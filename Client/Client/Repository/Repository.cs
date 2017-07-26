using Client.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Newtonsoft.Json;

namespace Client.Commands
{
    public class Repository : IRepository
    {
        private const string APP_Path = "http://localhost:43453";
        
        public Repository()
        {

        }

        public User Register(User registerUser)
        {
            if (registerUser != null)
            {
                using(var client = new HttpClient())
                {
                    var response = client.PostAsJsonAsync(APP_Path + "/api/Value", registerUser).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<User>(result);
                }
            }
            return null;
        }

        public string Update(User currentUser)
        {
            if (currentUser != null)
            {
                using (var client = new HttpClient())
                {
                    var response = client.PutAsJsonAsync(APP_Path + "/api/Value/update/" + currentUser.Id, currentUser).Result;
                    return response.StatusCode.ToString();
                }
            }
            return null;
        }

        // получение токена
        public User Login(Authorize authorizeData)
        {
            if (authorizeData != null)
            {
                using (var client = new HttpClient())
                {
                    var response = client.PostAsJsonAsync(APP_Path + "/api/Value/login/1", authorizeData).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    return JsonConvert.DeserializeObject<User>(result);
                }
            }
            return null;
        }

       
        public void Dispose()
        {

        }
    }
}
