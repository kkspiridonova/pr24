using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WpfApp2
{
    public enum Answers
    {
        Первый = 1,
        Второй,
        Третий
    }
    public class Class1
    {
        public string title { get; set; }
        public string description { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public Answers answer { get; set; }

        public Class1() { }

        public Class1(string title, string description, string answer_1, string answer_2, string answer_3, Answers answer)
        {
            this.title = title;
            this.description = description;
            this.answer1 = answer_1;
            this.answer2 = answer_2;
            this.answer3 = answer_3;
            this.answer = answer;
        }

        public bool isAnswer(Answers answer) => this.answer == answer;
    }

    public class User
    {
        public static int result = 0;
    }

    public class Json
    {
        public static T des<T>(string path)
        {
            if (!File.Exists(path))
                File.WriteAllText(path, "");
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
        }
        public static void ser<T>(string path, T obj) => File.WriteAllText(path, JsonConvert.SerializeObject(obj));
    }
}
