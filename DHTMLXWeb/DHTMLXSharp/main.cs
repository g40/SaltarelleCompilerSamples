/*

 
 
  
 */


using System;
using System.Html;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jQueryApi;
using System.Runtime.CompilerServices;

namespace DHTMLXSharp
{
public class main
{	
	//
	DHTMLXWindowFactory wf = null;

	/// <summary>
	/// 
	/// </summary>
	// private DHTMLXForm form = null;
	DHTMLXWindow win = null;

	/// <summary>
	/// prototype for an AJAX Success handler (avoiding use of lambdas)
	/// </summary>
	/// <param name="callback"></param>
	/// <returns></returns>
	public void OnJSONSuccess(object data, string textStatus, jQueryXmlHttpRequest request)
	{
		string s = data.ToString();
	}

	/// <summary>
	/// Menu click handler
	/// </summary>
	/// <param name="id"></param>
	/// <param name="zoneId"></param>
	/// <param name="caState"></param>
	private void OnMenuClick(String id, String zoneId, object caState)
	{
		String s;
		if (id == "Server_JSON")
		{
			JSONThing js = new JSONThing();
			js.FName = "Hello";
			js.LName = "World";
			s = NativeCode.toJSON(js);
			if (s.Length > 0)
			{
				Window.Alert(s);
			}
			//
			JSONThing js2 = jQuery.ParseJson(s) as JSONThing;
			//
			if (js2 == null)
			{

			}
		}
		else if (id == "Server_Ajax")
		{
			// set up the AJAX options
			//jQueryAjaxOptions opts = new jQueryAjaxOptio
			jQueryAjaxOptions opts = new jQueryAjaxOptions 
			{ 
				Url = "http://localhost:8888/data/form1.json", 
				DataType = "json", 
				Async = true, 
				Success = OnJSONSuccess
			};
			// make the request
			var req = jQuery.Ajax(opts);
		}
		else
		{
			if (win == null)
			{
			}
			win.SetText(id);
//			form = win.attachForm();
//			form.OnClick += FormButtonClicked;
		}
	}

	// These end up being in the 'global' scope
	[Serializable]
	[PreserveMemberCase]
	public class JSONThing
	{
		public string FName { get; set; }
		public string LName { get; set; }
	}
	
	/// <summary>
	/// /// The main application layout object
	/// </summary>
	DHTMLXLayoutObject layout = null;
	
	/// <summary>
	/// The main application menu
	/// </summary>
	DHTMLXMenu main_menu = null;
	//
	DHTMLXTreeGrid tree_grid = null;
	//
	/// <summary>
	/// layout definition stored as a JSON object
	/// we retrieve at startup ...
	/// </summary>
	object json_layout = null;

	///
	private void OnButtonClick(object window, object cell)
	{
		Window.Alert("OnButtonClick");
	}

	public void OnAjaxCallback(object data)
	{

	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="btnName"></param>
	private void OnFormButtonClick(object sender,object arg)
	{
		Window.Alert(" OnFormButtonClick " + sender.ToString());
	}

	/// <summary>
	/// Called when document is loaded
	/// </summary>
	private void Attach()
	{
		//
		NativeCode.CallJS("init");
		//NativeCode.InitializeDHTMLX();
		 //
		layout = new DHTMLXLayoutObject(Document.Body,"1C");
		// this is transient and obeys C# scoping
		DHTMLXCell cell = layout.Cells("a");
		//
		tree_grid = cell.AttachGrid();
		if (tree_grid != null)
		{
//			tree_grid.LoadXML("data/treegrid.xml");
			tree_grid.SetColumnTitles("Text,Filter1,Filter2,Filter3");
			tree_grid.SetColumnWidths("100,80,80,80");
			tree_grid.Init();
			tree_grid.AddRow(0, "Row 0", 0);
			tree_grid.AddRow(1, "Row 1", 1);
			tree_grid.AddRow(2, "Row 2", 2);
			tree_grid.AddRow(3, "Row 4", 3);
			tree_grid.AddRow(4, "Row 5", 4);
			tree_grid.AddRow(5, "Row 6", 5);
		}
		//
		main_menu = cell.AttachMenu();
		//
		if (main_menu != null)
		{

			main_menu.AddMenu(null, "Form", "Form", false);
			main_menu.AddMenuItem("Form", 0, "Form_Show", "Show Form...", false);
			main_menu.AddMenuItem("Form", 1, "Form_Hide", "Hide Form...", false);
			//			main_menu.Load("data/menu.xml");
			// menus get built in reverse. imagine push_back ...
			main_menu.AddMenu(null, "Server", "Server", false);
			main_menu.AddMenuItem("Server", 0, "Server_Ajax", "Make AJAX call...", false);
			main_menu.AddMenuItem("Server", 1, "Server_JSON", "To JSON string...", false);

			main_menu.AddMenu(null,"file","File",false);
			main_menu.AddMenuItem("file",0,"open","Open",false);
			main_menu.AddMenuItem("file",1, "new", "New", false);
			main_menu.AddMenuItem("file",2, "exit", "Exit", false);
			main_menu.AddSeparator("new");

			main_menu.OnClick += OnMenuClick;
		}

		//
		wf = new DHTMLXWindowFactory();
		// create the Window factory
		//win = wf.Create("Window",60,60,640,480);
		win = new DHTMLXWindow(wf,"Window",60,60,640,480);
		//
		object flayout = NativeCode.getLayout("formLayout");
		// object instance = win.CreateForm(layout);
		//
		DHTMLXForm form = new DHTMLXForm(win,flayout);
		//
		String s = form.getFormData();
		//
		form.OnButtonClick += OnFormButtonClick;
		//form.OnButtonClick += win.FormButtonHandler;
		//
		Test t = new Test("Just testing");
		//
		if (t != null)
		{
			Window.Alert(t.Value());
		}

		//
		// jQuery.Ajax()
		jQueryAjaxOptions opts = new jQueryAjaxOptions { Url = "http://localhost:8888/data/form1.json", DataType = "json", Async = true };
		// make the request
		var req = jQuery.Ajax(opts);
		// on success ...
		req.Success(data => 
		{
			json_layout = data;
		});
	}

	/// <summary>
	/// This is effectively the program entry point
	/// </summary>
	static void Main()
	{
		jQuery.OnDocumentReady(new main().Attach);
	}
}
}