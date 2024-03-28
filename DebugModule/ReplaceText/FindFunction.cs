using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugModule
{
	public class FindFunction
	{

		/// <summary>
		/// 目标文件夹的全路径
		/// </summary>
		public static string targetFilesPath = "";

		/// <summary>
		/// 处理后的文件夹存放路径
		/// </summary>
		public static string fileDealedPath = "";

		/// <summary>
		/// 函数的语法规则，识别函数
		/// </summary>
		public static string funcPartten = "";

		/// <summary>
		/// 注释的格式
		/// </summary>
		public static string debugCodeFormat = "";

		/// <summary>
		/// 忽略的函数名列表
		/// </summary>
		public static List<string> ignoreFunctionName = new List<string>();


		//public static List<string> theSuffixFilePath = new List<string>();

		/// <summary>
		/// 增加 debug 代码
		/// </summary>
		/// <param name="targetFilesPath"></param>
		/// <param name="funcPartten"></param>
		/// <param name="debugFormat"></param>
		public static void StartAddDebugCode(string _targetFilesPath, string _funcPartten, string _fileDealedPath, string _debugFormat) 
		{
			targetFilesPath = _targetFilesPath;
			funcPartten = _funcPartten;
			fileDealedPath = _fileDealedPath;
			debugCodeFormat = _debugFormat;

			List<string> filesPath = TraverseFolder(targetFilesPath, ".cs");
			Console.WriteLine($"FindFunction.StartAddDebugCode, filesPath.Count:{filesPath.Count}");

			foreach (string filePath in filesPath) {
				matchFunction(funcPartten, filePath, debugCodeFormat);
			}

		}


		/// <summary>
		/// 遍历指定文件夹中的所有文件，指定文件后缀
		/// </summary>
		/// <param name="folderPath"></param>
		public static List<string> TraverseFolder(string folderPath, string suffix)
		{
			List<string> theFilePath = new List<string>();
			try
			{
				// 获取指定文件夹中的所有文件，包括子文件夹中的文件
				foreach (string filePath in Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories))
				{
					FileInfo fileInfo = new FileInfo(filePath);
					if (fileInfo.FullName.EndsWith(suffix)) { }
					theFilePath.Append(fileInfo.FullName);

					Console.WriteLine(fileInfo.FullName);			// 输出文件的全路径
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}

			return theFilePath;
		}

		public static void matchFunction(string patternFunc, string _filePath, string debugCode) { 
			
			string fileAllText = File.ReadAllText(_filePath);


			File.WriteAllText(_filePath, fileAllText);
		}


	}

}
