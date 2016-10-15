using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webSummit
{
    public class AttendeeModel
    {
        public int Id { get; set; }
        public string Bio { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }
        public string Avatar_Url { get; set; }
        public string Medium_image { get; set; }
        public string Career{ get; set; }
    }

   
    public class StartupModel
    {
        public int Id { get; set; }
        public string brandisty_url { get; set; }
        public string Name { get; set; }
        public string company_name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string description { get; set; }
        public string elevator_pitch { get; set; }
        public string parent_industry { get; set; }
        public string Track { get; set; }
        public string website_url { get; set; }
        public string[] past_conferences { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DirectoryInfo d = new DirectoryInfo(@"C:\Attendees_IMAGES");
            FileInfo[] infos = d.GetFiles();
            int i = 1;
            foreach (FileInfo f in infos)
            {
                if (i == 1001) { return; }
                File.Move(f.FullName, @"C:\Attendees_IMAGES\Yaron\" + i.ToString() + ".jpg");
                i++;
            }

            //for (int i = 1; i < 434; i++)
            //{
            //    JObject o1 = JObject.Parse(File.ReadAllText(@"c:\ws_startups_" + i.ToString() + ".json"));

            //    string json = JsonConvert.SerializeObject(o1["startups"]);
            //    List<StartupModel> outObjects = JsonConvert.DeserializeObject<StartupModel[]>(json).ToList();

            //    List<Startup> startups = outObjects.Select(a => new Startup()
            //    {
            //        Track = a.Track,
            //        brandisty_url = a.brandisty_url,
            //        City = a.City,
            //        Company = a.company_name,
            //        country = a.Country,
            //        Description = a.description,
            //        Id = a.Id,
            //        Industry = a.parent_industry,
            //        Name = a.Name,
            //        Pitch = a.elevator_pitch,
            //        WebSite= a.website_url,
            //        PastConference = string.Join(",", a.past_conferences)
            //    }).ToList();

            //    //var outObject = JsonConvert.DeserializeObject<Attendee[]>(json);

            //    using (var ctx = new WSDATAEntities())
            //    {
            //        try
            //        {
            //            ctx.Startups.AddRange(startups);
            //            ctx.SaveChanges();
            //        }
            //        catch (DbEntityValidationException dbEx)
            //        {
            //            foreach (var validationErrors in dbEx.EntityValidationErrors)
            //            {
            //                foreach (var validationError in validationErrors.ValidationErrors)
            //                {
            //                    Trace.TraceInformation("Property: {0} Error: {1}",
            //                                            validationError.PropertyName,
            //                                            validationError.ErrorMessage);
            //                }
            //            }
            //        }

            //    };

            //}

            //using (var ctx = new WSDATAEntities())
            //{
            //    var attendees = ctx.Attendees2016.ToList();
            //    string startupUrlImg = "";
            //    string fileName = "";

            //    WebClient webClient = null;
            //    foreach (var attendee in attendees)
            //    {
            //        webClient = new WebClient();
            //        startupUrlImg = attendee.MediumImage;
            //        fileName = @"c:\\Attendees_IMAGES\img_" + attendee.Id.ToString() + ".jpg";
            //        webClient.DownloadFile(startupUrlImg, fileName);
            //    }

            //}






            /* careate json files*/
            //read JSON directly from a file
            //using (StreamReader file = File.OpenText(@"c:\data_430.json"))
            //using (JsonTextReader reader = new JsonTextReader(file))
            //{
            //    JObject o2 = (JObject)JToken.ReadFrom(reader);
            //}

            //System.Net.WebClient wc = new System.Net.WebClient();
            //StringBuilder sb = new StringBuilder();

            ////int index = 2;
            //string fileName = "";
            //for (int i = 1; i < 4760; i++)
            //{
            //    sb.Append(wc.DownloadString("https://api.crunchbase.com/v/3/organizations?user_key=c0571798ea0192443b850c5c2c469436&page=" + i));

            //    fileName = @"C:\\Crunchbase\\Organizations\\CB_ORG_" + i + ".json";
            //    using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName))
            //    {
            //        file.WriteLine(sb.ToString());
            //    };
            //    sb.Clear();


            //}


        }
    }
}
