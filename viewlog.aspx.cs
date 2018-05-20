﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using BSTStatics;

public partial class ViewLog : CbstHelper
{

	public string NetworkFormat(string strPath)
	{
		string strReturn = strPath.Replace(
													string.Format("http://{0}/BST/", BSTStat.globalIPAddress), 
													string.Format("\\\\{0}\\Public\\BST\\", BSTStat.networkBSTMachine));
		return strReturn;
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		string urlLog = Request.Params["log"];

		if (urlLog == null)
		{
			Response.Clear();
			Response.Write("Error: no file path found in URL.");
			Response.End();
			return;
		}

		string filename = NetworkFormat(urlLog);
		FileInfo fi = new FileInfo(filename);
		if (!fi.Exists)
		{
			Response.Clear();
			Response.Write(string.Format("Error: file not found: {0}", filename));
			Response.End();
			return;
		}

		String text = System.IO.File.ReadAllText(filename);
		Response.Clear();

		string output = text.Replace("http://mps.resnet.com/bst/web/", "").
			Replace(BSTStat.globalIPAddress, BSTStat.newBSTAddress);
		Response.Write(output);
		Response.End();
	}
}