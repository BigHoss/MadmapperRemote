using System;
using MadMapperRemote.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MadMapperRemote.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			var structure = MadMapperAccess.GetStructure("http://localhost:8010");
			
		}
	}
}
