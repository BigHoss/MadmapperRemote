using System;
using System.Net;

namespace MadMapperRemote.Core
{
	public class MadMapperAccess
	{
		public static MadMapperOscConfig GetStructure(string url)
		{
			using (var webClient = new WebClient())
			{
				var json_data = string.Empty;
				MadMapperOscConfig config = new MadMapperOscConfig();
				try
				{
					json_data = webClient.DownloadString(url);
					config = MadMapperOscConfig.FromJson(json_data);
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					throw;
				}

				return config;
			}
		}
	}
}
