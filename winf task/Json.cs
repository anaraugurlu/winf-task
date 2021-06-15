
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winf_task
{
    class Json
    {
        //static void JsonDeserializer()
        //{


        //        Human[] humans2 = null;
        //        var serializer = new JsonSerializer();
        //        using (var sr = new StreamReader("humans.json"))
        //        {
        //            using (var jw = new JsonTextWriter(sr))
        //            {

        //                humans2 = serializer.Deserialize(sr)
        //            }
        //        } //static void JsonDeserializer()

        //}
        static void JsonSerialize()
        {
            List<Human> humans = new List<Human>
                        {
                            new Human
                            {
                                Email ="ZeynebHesenova@gmail.com",
                                Name="zeyneb",
                                Surname ="hesenova",
                                PhoneNumber ="12312323535",

                            },

                            new Human
                            {
            Name ="fuad",
            Surname ="ugurlu",
            Email ="fuad123@gmail.com",
            PhoneNumber ="+12235256"
                            },
                            new Human
                            {
                                Name ="nezrin",
                                Surname ="rehimli",
                                Email="nezrin123@gmail.com",
                                PhoneNumber ="+9941312334"
                            }



                    };
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("humans.json"))


            {


                using (var jw = new JsonTextWriter(sw))


                {


                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;


                    serializer.Serialize(jw, humans);


                }


            }
        }
    }
}

