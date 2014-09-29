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
		Window.Alert(s);

	}

	public void OnJSONError(jQueryXmlHttpRequest request, string textStatus, Exception error)
	{
		string s = textStatus.ToString();
		Window.Alert(s);

	}

	public void SendJSONviaAJAX(object data)
	{
		JsDictionary<String, object> mapper = new JsDictionary<String, object>();
		mapper["key"] = data;

		jQueryAjaxOptions opts = new jQueryAjaxOptions
		{
			Url = "http://localhost:8888/ajax",
			Type = "POST",
			DataType = "json",
			Async = true,
			Success = OnJSONSuccess,
			Error = OnJSONError
		};
		opts.Data = mapper;
		//
		//((dynamic)opts).Data = mapper.ToString();
		// make the request
		var req = jQuery.Ajax(opts);

	}
	/// <summary>
	/// Handler for Window/Form button clicks
	/// </summary>
	/// <param name="window"></param>
	/// <param name="name"></param>
	private void OnButtonClicked(DHTMLXWindow window, string name)
	{
		if (name == "save")
		{
//			string s = ;
			SendJSONviaAJAX(window.GetData());
		}
		window.Visible = false;
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
			JSONThing js = new JSONThing();
			js.FName = "Hello";
			js.LName = "World";
			JsDictionary<String, object> mapper = new JsDictionary<String, object>();
			mapper["key"] = js;

			jQueryAjaxOptions opts = new jQueryAjaxOptions 
			{ 
				Url = "http://localhost:8888/ajax", 
				DataType = "json", 
				Async = true, 
				Success = OnJSONSuccess,
				Error = OnJSONError
			};
			opts.Data = mapper;
			//
			object[] a =  { js };
			//
			opts.Data = a;
			//
			opts.Type = "POST";
			//
			//((dynamic)opts).Data = mapper.ToString();
			// make the request
			var req = jQuery.Ajax(opts);
		}
		else if (id == "Form_Show")
		{
			if (win != null)
			{
				//win.Text = id;
				win.Center = true;
				win.Visible = true;
			}
		}
		else if (id == "Form_Show_Modal")
		{
			if (win != null)
			{
				//win.Text = id;
				win.Center = true;
				win.Visible = true;
				win.Modal = true;
			}
		}
		else if (id == "Tree_Load_Local")
		{
			grid.LoadJSON("./data/data.json");
		}
		else if (id == "Tree_Load_Remote")
		{
			grid.LoadURI("http://localhost:8888/ajax");
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
	DHTMLXLayout layout = null;
	
	/// <summary>
	/// The main application menu
	/// </summary>
	DHTMLXMenu main_menu = null;
	//
	DHTMLXGrid grid = null;
	//
	DHTMLXTreeGrid tree_grid = null;
	//
	DHTMLXStatusBar status_bar = null;
	DHTMLXToolBar tool_bar = null;
	//
	/// <summary>
	/// layout definition stored as a JSON object
	/// we retrieve at startup ...
	/// </summary>
	object json_layout = null;
	///

	///
	private void OnButtonClick(object window, object cell)
	{
		Window.Alert("OnButtonClick");
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="data"></param>
	public void OnAjaxCallback(object data)
	{

	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="btnName"></param>
	private void OnFormButtonClick(object sender)
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
		layout = new DHTMLXLayout(Document.Body, DHTMLXLayout.Format.e1C);
		// this is transient and obeys C# scoping
		DHTMLXCell cell = layout.Cells("a");
		//
		status_bar = new DHTMLXStatusBar(cell);
		status_bar.Text = "Connected to localhost:8888";

		tool_bar = new DHTMLXToolBar(cell);
		tool_bar.SetIconPath("data/imgs/");
		tool_bar.LoadXML("data/toolbar.xml");
#if true

		DHTMLXTreeGridSettings settings = new DHTMLXTreeGridSettings();
		settings.column_types = "tree,ed,txt,ch,ch";
		settings.column_widths = "150,100,100,100,100";
		settings.column_text = "Tree,Plain Text,Long Text,Color,Checkbox";
		settings.content_url = "data/treegrid.xml";
		tree_grid = new DHTMLXTreeGrid(cell,settings);

#else
		grid = new DHTMLXGrid(cell);
		if (grid != null)
		{
//			tree_grid.LoadXML("data/treegrid.xml");
			grid.SetColumnTitles("Text,Filter1,Filter2,Filter3");
			grid.SetColumnWidths("100,80,80,80");
			grid.Init();
			grid.AddRow(0, "Row 0", 0);
			grid.AddRow(1, "Row 1", 1);
			grid.AddRow(2, "Row 2", 2);
			grid.AddRow(3, "Row 4", 3);
			grid.AddRow(4, "Row 5", 4);
			grid.AddRow(5, "Row 6", 5);
		}
#endif
		//
		main_menu = new DHTMLXMenu(cell);
		//
		if (main_menu != null)
		{

			main_menu.AddMenu(null, "Tree", "Tree", false);
			main_menu.AddMenuItem("Tree", 0, "Tree_Load_Local", "Load Tree from Assets...", false);
			main_menu.AddMenuItem("Tree", 1, "Tree_Load_Remote", "Load Tree from Server...", false);

			main_menu.AddMenu(null, "Form", "Form", false);
			main_menu.AddMenuItem("Form", 0, "Form_Show", "Show Form...", false);
			main_menu.AddMenuItem("Form", 1, "Form_Show_Modal", "Show Modal Form...", false);
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

		object flayout = NativeCode.getLayout("formLayout");
		//
		wf = DHTMLXWindowFactory.Instance;

		// create the Window factory
		//win = wf.Create("Window",60,60,640,480);
		win = new DHTMLXWindow(wf, "Window", 60, 60, 320, 240, flayout);
		win.Visible = false;
		win.Text = "Popup Window with embedded form";
		win.OnClick += OnButtonClicked;

		// do some AJAxing at startup
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