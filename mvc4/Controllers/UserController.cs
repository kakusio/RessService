using System;
using System.IO;
using System.Net;
using System.Web.Http;
using System.Web.Mvc;
using mvc4.Account;

namespace mvc4.Controllers
{
	public class UserController : Controller
	{
		[System.Web.Http.HttpGet]
		public string Get([FromUri] string url)
		{
			var realPath = GetRealPath(url);
			return RequestUsing(WebRequestMethods.Http.Get, realPath);
		}
		
		[System.Web.Http.HttpPost]
		public string Post([FromUri] string url)
		{
			var realPath = GetRealPath(url);
			return RequestUsing(WebRequestMethods.Http.Post, realPath);
		}
		
		[System.Web.Http.HttpPut]
		public string Put([FromUri] string url)
		{
			var realPath = GetRealPath(url);
			return RequestUsing(WebRequestMethods.Http.Put, realPath);
		}
		
		[System.Web.Http.HttpDelete]
		public string Delete([FromUri] string url)
		{
			var realPath = GetRealPath(url);
			return RequestUsing("DELETE", realPath);
		}


		private static string RequestUsing(string method, string path)
		{
			string result;
			var request = (HttpWebRequest) WebRequest.Create(path);
			request.Method = method;
			request.ContentType = "application/x-www-form-urlencoded";
			request.Accept = "Accept=text/html";
			if (method.Contains("P")) request.ContentLength = 0;
			try
			{
				var response = (HttpWebResponse) request.GetResponse();

				using (var reader = new StreamReader(response.GetResponseStream()))
				{
					result = reader.ReadToEnd();
				}
			}
			catch (Exception e)
			{
				result = e.Message;
			}
			return result;
		}

		private static string GetRealPath(string path)
		{
			var realPath = "http://localhost:4001";
			try
			{
				realPath += new SecureEncrypt().Decrypt(path,"password");
				if (realPath.Contains("?"))
					realPath += "&";
				else
					realPath += "?";
				realPath += "Address=token";
			}
			catch
			{
				realPath = "";
			}

			return realPath;
		}
	}
}