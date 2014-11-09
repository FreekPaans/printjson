using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace printjson {
	class Program {
		static void Main(string[] args) {
			var @in = Console.In.ReadToEnd();
			try {
				var pretty = JsonConvert.SerializeObject(JToken.Parse(@in),Formatting.Indented);

				Console.WriteLine(pretty);
			}
			catch(JsonReaderException) {
				Console.Error.WriteLine("Couldn't parse json");
				Console.WriteLine(@in);
			}
		}
	}
}
