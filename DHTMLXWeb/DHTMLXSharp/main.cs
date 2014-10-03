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
		//
		NativeCode.Log("OnButtonClicked => " + name);

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
			grid_results.LoadJSON("./data/data.json");
		}
		else if (id == "Tree_Load_Remote")
		{
			grid_results.LoadURI("http://localhost:8888/ajax");
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
	DHTMLXTreeGrid catalog = null;

	//
	DHTMLXGrid grid_results = null;

	//
	DHTMLXTreeGrid base_filters = null;
	DHTMLXTreeGrid tree_filters = null;
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
	private bool GridDragDropHandler(String[] srcIDs, String dstID, object srcWidget, object dstWidget, int srcColumn, int dstColumn)
	{
		if (srcWidget == dstWidget)
		{
			NativeCode.Log("Source is grid");
		}
		if (dstWidget == base_filters.Instance)
		{
			NativeCode.Log("Dest is base filters");
		}
		else if (dstWidget == tree_filters.Instance)
		{
			NativeCode.Log("Dest is tree filters");
		}
		//return true;
		return !(srcWidget == dstWidget);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="window"></param>
	/// <param name="cell"></param>
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
		DHTMLXCell main_cell = layout.Cells("a");
		main_cell.HideHeader();
		//
		status_bar = new DHTMLXStatusBar(main_cell);
		status_bar.Text = "Connected to localhost:8888";

		tool_bar = new DHTMLXToolBar(main_cell);
		tool_bar.SetIconPath("data/imgs/");
		tool_bar.LoadXML("data/toolbar.xml");

		//
		main_menu = new DHTMLXMenu(main_cell);
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

			main_menu.AddMenu(null, "file", "File", false);
			main_menu.AddMenuItem("file", 0, "open", "Open", false);
			main_menu.AddMenuItem("file", 1, "new", "New", false);
			main_menu.AddMenuItem("file", 2, "exit", "Exit", false);
			main_menu.AddSeparator("new");

			main_menu.OnClick += OnMenuClick;
		}

		// set up left hand side
		DHTMLXLayout central_panel = new DHTMLXLayout(main_cell, DHTMLXLayout.Format.e3J);
		central_panel.Cells("a").HideHeader();
		central_panel.Cells("b").HideHeader();
		central_panel.Cells("c").HideHeader();
		//central_panel.Cells("c").SetText("Drag and drop from Catalog");
		DHTMLXCell cell = central_panel.Cells("a");

		//---------------------------------------------------------------------------
		// bases tree
		cell = central_panel.Cells("a");
		base_filters = new DHTMLXTreeGrid(cell, "data/filter_bases.xml");
		base_filters.EnableDragDrop();
		base_filters.MultipleSelection = true;
		base_filters.OnDragDrop += GridDragDropHandler;

		// base tree context menu
		DHTMLXContextMenu menu = new DHTMLXContextMenu("data/imgs/");
		menu.Load("data/context_edit_menu.xml");
		base_filters.SetContextMenu(menu);

		//---------------------------------------------------------------------------
		// filter tree
		cell = central_panel.Cells("c");
		tree_filters = new DHTMLXTreeGrid(cell, "data/tree_filter.xml");
		tree_filters.EnableDragDrop();
		tree_filters.MultipleSelection = true;
		tree_filters.OnDragDrop += FilterTreeDragDropHandler;

		// filter tree context menu
		DHTMLXContextMenu ctx_tree_filters = new DHTMLXContextMenu("data/imgs/");
		ctx_tree_filters.Load("data/context_edit_menu.xml");
		tree_filters.SetContextMenu(ctx_tree_filters);

		//---------------------------------------------------------------------------
		// Right-hand panel contains catalog/results/charts
		cell = central_panel.Cells("b");
		DHTMLXLayout right_panel = new DHTMLXLayout(cell, DHTMLXLayout.Format.e1C);
		DHTMLXTabBar tabbar = new DHTMLXTabBar(right_panel.Cells("a"));
		tabbar.AddTab("Catalog","Catalog",100);
		tabbar.AddTab("Results", "Results", 100);
		tabbar.AddTab("Charts", "Charts", 100);
		tabbar.Activate("Catalog");

		//---------------------------------------------------------------------------
		// Create the variable catalog
		DHTMLXTab tab = tabbar.Tabs("Catalog");
		
		catalog = new DHTMLXTreeGrid(tab, "data/catalog.xml");
		catalog.EnableDragDrop();
		catalog.MultipleSelection = true;

		// base tree context menu
		DHTMLXContextMenu ctx_catalog = new DHTMLXContextMenu("data/imgs/");
		ctx_catalog.Load("data/menu_ctx_catalog.xml");
		catalog.SetContextMenu(ctx_catalog);

		//---------------------------------------------------------------------------
		tab = tabbar.Tabs("Results");
		grid_results = new DHTMLXGrid(tab);
		if (grid_results != null)
		{
			grid_results.EnableDragDrop();
			grid_results.SetColumnTitles("Text,Filter1,Filter2,Filter3");
			grid_results.SetColumnWidths("100,80,80,80");
			grid_results.Init();
			grid_results.AddRow(0, "Row 0", 0);
			grid_results.AddRow(1, "Row 1", 1);
			grid_results.AddRow(2, "Row 2", 2);
			grid_results.AddRow(3, "Row 4", 3);
			grid_results.AddRow(4, "Row 5", 4);
			grid_results.AddRow(5, "Row 6", 5);
		}

		//---------------------------------------------------------------------------
		object flayout = NativeCode.getLayout("formLayout");
		//
		wf = DHTMLXWindowFactory.Instance;

		// create the Window factory
		//win = wf.Create("Window",60,60,640,480);
		win = new DHTMLXWindow(wf, "Window", 60, 60, 400, 320, flayout);
		win.Visible = false;
		win.Text = "Popup Window with embedded form";
		win.OnClick += OnButtonClicked;
//		win.ShowModal();

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
	/// Aha!
	/// </summary>
	/// <param name="srcID"></param>
	/// <param name="dstID"></param>
	/// <param name="srcWidget"></param>
	/// <param name="dstWidget"></param>
	/// <param name="srcColumn"></param>
	/// <param name="dstColumn"></param>
	/// <returns></returns>
	private bool FilterTreeDragDropHandler(String[] srcIDs, String dstID, object srcWidget, object dstWidget, int srcColumn, int dstColumn)
	{
		if (srcWidget == dstWidget)
		{
			NativeCode.Log("Source == destination");
		}	
		else if (srcWidget == catalog.Instance &&
			dstWidget == tree_filters.Instance)
		{
			if (dstColumn > 0)
			{
				DHTMLXGridCell dstCell = tree_filters.Cells(dstID, dstColumn);
				if (dstCell != null)
				{
					//
					String dv = dstCell.getValue();
					//
					for (int s = 0; s < srcIDs.Length; s++)
					{
						DHTMLXGridCell srcCell = catalog.Cells(srcIDs[s], srcColumn);
						dv += srcCell.getValue();
						dv += ",";
					}
					//
					dstCell.setValue(dv);
					//
					return false;
				}
			}
		}
		return !(srcWidget == dstWidget);
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