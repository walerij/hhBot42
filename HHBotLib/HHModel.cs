using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HHBotLib
{
    public struct Work
    {
        public string id;
        public string Name;
        public string employer;


        public string salary_from;
        public string salary_to;

        public string info;


        public Work(dynamic obj)
        {
            this.id =obj.id;
            this.Name = obj.name;

            this.employer =  obj.employer.name;

            try
            {
                this.salary_from = (obj.salary.from == null) ? " " : obj.salary.from;
                this.salary_to = (obj.salary.to == null) ? " " : obj.salary.to;
            }

            catch
            {
                this.salary_from = "-";
                this.salary_to = "-";
            }

            if(obj.description!=null)
            {
                this.info = obj.description;

            }
            else
            {
                this.info = "==";
            }

        }
    }
    public class HHModel
    {
        /// <summary>
        /// https://api.hh.ru/vacancies?text=программист?city=Москва
        /// Получение данных с сервера по Get-запросу 
        /// </summary>
        /// <returns>строка в формате json</returns>
        public string WEbClientGet(string GetRequest)
        {
            string tmp = "";
            try {

                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Chrome");

                Stream stream = client.OpenRead(GetRequest);
                StreamReader sr = new StreamReader(stream);
                string newLine;
                while ((newLine = sr.ReadLine()) != null)
                    tmp += newLine;

                stream.Close();
            }
            catch (Exception e)
            {
                tmp += e.Message;

            }
            return tmp;

        }



        public string WebClientPost(string PostUri, string grant_type, string client_id, string client_secret)
        {
            string tmp = "";
            try {                

                string URI = "https://hh.ru/oauth/token";
                string myParameters = "grant_type=value1&client_id=value2&client_secret=value3";

                using (WebClient wc = new WebClient())
                {
                    wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                                                                 
                    tmp = wc.UploadString(URI, myParameters);
                }

            }

            catch (Exception e)
            {
                tmp += e.Message;
            }

            return tmp;

        }


        public string JsonParseString(string data)
        {
            string tmp = "";
            dynamic obj = JObject.Parse(data);

            tmp += obj.alternate_url+"\r\n";
            tmp += obj.address + "--\r\n";
            //tmp += "+++ "+obj.address.raw + "--\r\n";
            // obj.close();

            return tmp;

        }


        public string JsonParseStringMany(string data)
        {
            string tmp = "";
            dynamic obj = JObject.Parse(data);
            foreach (dynamic item in obj.items)
            {
                 tmp += item.id + "--\r\n";
                 tmp += item.name + "--\r\n";
                 tmp += item.alternate_url + "\r\n";

                 //tmp += "Адрес: "+item.address + "--\r\n";
                 if(item.address!=null)
                    tmp += "Адрес: " + item.address.city + "--\r\n";
                 else
                    tmp += "Адрес: отсутствует \r\n";
                // dynamic s = JObject.Parse(item.address);

                // tmp += "+++ " + item.address.city + "--\r\n";
                // tmp += "+++ " + item.address.street + "--\r\n";
                //item.close();
            }
            //tmp += "+++ "+obj.address.raw + "--\r\n";
             //obj.close();

            return tmp;

        }

        public List<Work> JsonParseList(string data)
        {
            List<Work> work = new List<Work>();
            dynamic obj = JObject.Parse(data);
            foreach (dynamic item in obj.items)
            {

                work.Add(new Work(item));
            }
            //tmp += "+++ "+obj.address.raw + "--\r\n";
            //obj.close();

            return work;

        }




    }
}
