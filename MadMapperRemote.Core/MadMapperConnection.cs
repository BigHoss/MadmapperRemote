using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace MadMapperRemote.Core
{
    public class MadMapperConnection
    {
        public string MadMapperAddress { get; set; }
        public MadMapperConnection(string address)
        {
            MadMapperAddress = address;
        }
        public void OpenConnection()
        {
            using (WebClient webClient = new WebClient())
            {
                string jsonString = webClient.DownloadString(MadMapperAddress);

                object deserializeObject = JsonConvert.DeserializeObject(jsonString);


            }
            
        }
    }
}
