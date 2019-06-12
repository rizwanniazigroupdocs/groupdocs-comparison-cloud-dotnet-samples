using GroupDocs.Comparison.Cloud.Sdk.Api;
using GroupDocs.Comparison.Cloud.Sdk.Client;
using GroupDocs.Comparison.Cloud.Sdk.Model.Requests;
using System;

namespace GroupDocs.Comparison.Cloud.Examples.CSharp
{
	// Copy File
	class Copy_File
	{
		public static void Run()
		{
			var configuration = new Configuration(Common.MyAppSid, Common.MyAppKey);
			var apiInstance = new FileApi(configuration);

			try
			{
				var request = new CopyFileRequest("Comparisondocs/one-page1.docx", "Comparisondocs/one-page-copied.docx", Common.MyStorage, Common.MyStorage);

				apiInstance.CopyFile(request);
				Console.WriteLine("Expected response type is Void: 'Comparisondocs/one-page1.docx' file copied as 'Comparisondocs/one-page-copied.docx'.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception while calling FileApi: " + e.Message);
			}
		}
	}
}