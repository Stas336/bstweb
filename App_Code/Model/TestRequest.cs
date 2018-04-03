﻿using System;

public class TestRequest : IdBasedObject
{
	public string USERID
	{
		get { return this["USERID"].ToString(); }
		set { this["USERID"] = value; }
	}
	public string TESTED
	{
		get { return this["TESTED"].ToString(); }
		set { this["TESTED"] = value; }
	}
	public string IGNORE
	{
		get { return this["IGNORE"].ToString(); }
		set { this["IGNORE"] = value; }
	}
	public string PROGABB
	{
		get { return this["PROGABB"].ToString(); }
		set { this["PROGABB"] = value; }
	}
	public string TTID
	{
		get { return this["TTID"].ToString(); }
		set { this["TTID"] = value; }
	}
	public string COMMENT
	{
		get { return this["COMMENT"].ToString(); }
		set { this["COMMENT"] = value; }
	}
	public string VERSIONID
	{
		get { return this["VERSIONID"].ToString(); }
		set { this["VERSIONID"] = value; }
	}
	public string REQUESTDATETIME
	{
		get { return this["REQUESTDATETIME"].ToString(); }
		set { this["REQUESTDATETIME"] = value; }
	}
	public int ID
	{
		get { return Convert.ToInt32(this["ID"]); }
		set { this["ID"] = value; }
	}
    public int REQUEST_PRIORITY
    {
        get { return Convert.ToInt32(this["REQUEST_PRIORITY"]); }
        set { this["REQUEST_PRIORITY"] = value; }
    }
    public TestRequest(string id, string guid = "")
		: base("TESTREQUESTS", new string[] { "ID", "TTID", "GUID", "REQUESTDATETIME", "USERID", "PROGABB", "COMMENT", "VERSIONID", "IGNORE", "TESTED", "GITHASH", "REQUEST_PRIORITY" }, 
			string.IsNullOrEmpty(id) ?
			string.Format("(SELECT ID FROM [TESTREQUESTS] WHERE [GUID] = '{0}')", guid) 
			: id)
	{
	}
}