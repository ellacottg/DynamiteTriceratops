using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using Godot;

namespace SpectreDispatcher {

	// Common class for functions and properties commonly used
	public class Common {

		public Common() {}
		public static int total;
		public static int nFoods;
		public static int nMaterials;
		public static int nBlocks;
		public static int nTraps;
		public static int nTools;


		//public static string resourcesFilePath = "Resources.txt";
		//public static string resourcesFilePath = "res://Logic/Resources.txt";
		//public static string resourcesFilePath = "\\Logic\\Resources.txt";
		public static string resourcesFilePath = "ResourcesT.txt";

		// function to count the different resources in the Resources.txt file
		public static int CountAllResources() {
			int count;
			if (!File.Exists(resourcesFilePath)) {
				//Console.WriteLine("Resources file does not exist | " + resourcesFilePath);
				Console.WriteLine("Resources file does not exist | " + resourcesFilePath);
				GD.Print("Resources file does not exist | " + resourcesFilePath);
				GD.Print("Directory = " + Directory.GetCurrentDirectory());
				count = 0;
			} else {
				string[] textResources = File.ReadAllLines(resourcesFilePath);
				count = textResources.Length;
				//total = textResources.Length;
				Console.Write(resourcesFilePath + " line count = " + count);
				GD.Print(resourcesFilePath + " line count = " + count);
				count = CountResources(textResources);
			}
			// Console.Write(resourcesFilePath + " line count = " + count);
			// GD.Print(resourcesFilePath + " line count = " + count);

			return count;
		}

		public static int CountResources(string[] txtResources) {
			nFoods = 0;
			nMaterials = 0;
			nBlocks = 0;
			nTraps = 0;
			nTools = 0;

			int i = 0;
			foreach (string s in txtResources) {
				//GD.Print("first char of line " + i + " = " + s[0]);
				if (s[0].ToString() != "-") {
					string[] resource = s.Split(',');
					//GD.Print(resource[0] + " resource code = " + resource[2][0]);
					switch (resource[2][0]) {
						case '0':
							nFoods++;
							break;
						case '1':
							nMaterials++;
							break;
						case '2':
							nBlocks++;
							break;
						case '3':
							nTraps++;
							break;
						case '4':
							nTools++;
							break;
						default:
							GD.Print("Error in Common.CountResources");
							Console.WriteLine("Error in Common.CountResources");
							break;
					}
					i++;
				}
				//GD.Print("nResource count = " +nFoods+nMaterials+nBlocks+nTraps+nTools);
			}
			GD.Print("nResource count = " +nFoods+nMaterials+nBlocks+nTraps+nTools);
			return i;
		}


	}

}
