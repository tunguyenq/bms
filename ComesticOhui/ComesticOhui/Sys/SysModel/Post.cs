using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace BMS.Models.SysModel
{
    public class metas
    {
        public string Title { get; set; }
        public string type { get; set; }
        public string Class { get; set; }
        public string Name { get; set; }
        public string PlaceHolder { get; set; }
        public string Data_atr { get; set; }
    }

    public class ModelPost
    {
        public string type_post { get; set; }
        public string title { get; set; }
        public List<metas> metas { get; set; }
        private string path = "data.json";


        public static List<ModelPost> Load(string path)
        {
            JObject jt = JObject.Parse(File.ReadAllText(path));
            IList<JToken> results = jt["posts"].Children().ToList();
            List<ModelPost> jtran = new List<ModelPost>();
            foreach (var item in results)
            {
                var i = JsonConvert.DeserializeObject<ModelPost>(item.ToString());
                jtran.Add(i);
            }
            return jtran;
        }
    }


   
}