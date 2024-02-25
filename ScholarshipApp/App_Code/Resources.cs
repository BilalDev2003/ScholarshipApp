using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

/// <summary>
/// Summary description for Resources
/// </summary>
public class Resources
{
	public Resources()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	public void ToastBox(string toastScript)
	{
		try
		{
			Page page = HttpContext.Current.Handler as Page;
			if (string.IsNullOrEmpty(toastScript))
			{
				toastScript = "Error";
			}
			ScriptManager.RegisterStartupScript(page, page.GetType(), "err_msg", toastScript, true);
		}
		catch (Exception)
		{
			throw;

		}

	}

	public enum ToastType
	{
		error,
		info,
		success,
		warning
	}

	[Serializable]
	public class ToastMessage
	{
		public string Title { get; set; }

		public string Message { get; set; }

		public ToastType ToastType { get; set; }

		public bool IsSticky { get; set; }
	}

	[Serializable]
	public class ToastNotifications
	{
		public bool ShowNewestOnTop { get; set; }

		public bool ShowCloseButton { get; set; }

		public List<ToastMessage> ToastMessages { get; set; }

		public ToastMessage AddToastMessage(string title, string message, ToastType toastType)
		{
			var toast = new ToastMessage()
			{
				Title = title,
				Message = message,
				ToastType = toastType
			};

			ToastMessages.Add(toast);
			return toast;
		}

		public ToastNotifications()
		{
			ToastMessages = new List<ToastMessage>();
			ShowNewestOnTop = false;
			ShowCloseButton = false;
		}
	}

	public class ToasterMessage
	{
		public static string Message(ToastType type, string message)
		{
			string msg = @"Command: toastr['" + type + "']('" + message + "');" +
											"toastr.options = {" +
											"'closeButton': false," +
											  "'debug': false," +
											  "'newestOnTop': false," +
											  "'progressBar': false," +
											  "'positionClass': 'toast-top-right'," +
											  "'preventDuplicates': false," +
											  "'onclick': null," +
											  "'showDuration': '5000'," +
											  "'hideDuration': '1000'," +
											  "'timeOut': '3000'," +
											  "'extendedTimeOut': '1000'," +
											  "'showEasing': 'swing'," +
											  "'hideEasing': 'linear'," +
											  "'showMethod': 'fadeIn'," +
											  "'hideMethod': 'fadeOut'" +
											"}";
			return msg;
		}
	}
}