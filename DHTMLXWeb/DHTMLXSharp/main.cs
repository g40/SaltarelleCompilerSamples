﻿/*

 
 
  
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
	public static class FilterTree
	{
		public const int eIndex = 0;
		public const int eDescription = 1;
		public const int eFilter = 2;
		public const int eTarget = 3;
	}

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

	/// <summary>
	/// AJAX handler for requesting catalogs
	/// </summary>
	/// <param name="data"></param>
	/// <param name="textStatus"></param>
	/// <param name="request"></param>
	public void OnCatalogSuccess(object data, string textStatus, jQueryXmlHttpRequest request)
	{
		if (data != null)
		{
			//String xml = data as String;
			//NativeCode.Log(xml);
			catalog.ClearContent();
			catalog.LoadFromXMLObject(data);
			status_bar.Text = String.Format("Loaded catalog from {0}{1}",g_http_url,"/ajax");
		}
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="request"></param>
	/// <param name="textStatus"></param>
	/// <param name="error"></param>
	public void OnCatalogError(jQueryXmlHttpRequest request, string textStatus, Exception error)
	{
		string s = textStatus.ToString();
		status_bar.Text = s;
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="request"></param>
	/// <param name="textStatus"></param>
	/// <param name="error"></param>
	public void OnJSONError(jQueryXmlHttpRequest request, string textStatus, Exception error)
	{
		string s = "unknown exception";
		if (error != null)
		{
			// s = error.Message;
		}
		status_bar.Text = String.Format("{0} {1}", textStatus, s);
	}

	/// <summary>
	/// Send an arbitrary object to the server
	/// </summary>
	/// <param name="key"></param>
	/// <param name="format"></param>
	/// <param name="data"></param>
	public void SendJSONviaAJAX(String key,String format,object data_object)
	{
		JsDictionary<String, object> mapper = new JsDictionary<String, object>();
		mapper[key] = data_object;

		jQueryAjaxOptions opts = new jQueryAjaxOptions
		{
			Url = g_http_url + "/ajax",
			Type = "POST",
			DataType = format,
			Async = true,
			Success = OnJSONSuccess,
			Error = OnJSONError
		};
		opts.ContentType = "application/json";
		opts.Data = mapper;
		//
		var req = jQuery.Ajax(opts);
		// on success ...
		req.Success(data =>
		{
			//NativeCode.Log("Posted data OK");
			status_bar.Text = String.Format("Posted {0} to {1}", key,opts.Url);
		});
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
		if (id == "Server_Catalog")
		{
			jQueryAjaxOptions opts = new jQueryAjaxOptions
			{
				Url = g_http_url + "/ajax",
				DataType = "xml",
				Async = true,
				Success = OnCatalogSuccess,
				Error = OnCatalogError,
				Type = "GET"
			};
			var req = jQuery.Ajax(opts);
		}
#if false
		else if (id == "Server_JSON")
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
			catalog.ClearContent();
			catalog.LoadXML("/data/catalog3.xml");
		}
		else if (id == "Tree_Load_Remote")
		{
			//grid_results.LoadURI("http://localhost:8888/ajax");
			grid_results.Clear(true);
			grid_results.LoadXML("data/grid.xml");
		}
#endif
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
	/// Default URL for all AJAX etc.
	/// </summary>
	static String g_http_url = "http://192.168.101.12:8888";
	static String g_ws_url = "ws://192.168.101.12:8888";

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

	/// <summary>
	/// Our web-socket instance for communication with server
	/// </summary>
	WebSocket ws = null;
	//

	/// <summary>
	/// Queue of things waiting to be JSON posted via socket
	/// </summary>
	List<String> _queue = new List<String>();

	//
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
		tool_bar.OnClick += tool_bar_OnClick;

		//
		main_menu = new DHTMLXMenu(main_cell);
		//
		if (main_menu != null)
		{

			main_menu.AddMenu(null, "Tree", "Tree", false);
			main_menu.AddMenuItem("Tree", 0, "Tree_Load_Local", "Load catalog from Assets...", false);
			main_menu.AddMenuItem("Tree", 1, "Tree_Load_Remote", "Load Tree from Server...", false);

			main_menu.AddMenu(null, "Form", "Form", false);
			main_menu.AddMenuItem("Form", 0, "Form_Show", "Show Form...", false);
			main_menu.AddMenuItem("Form", 1, "Form_Show_Modal", "Show Modal Form...", false);
			//			main_menu.Load("data/menu.xml");
			// menus get built in reverse. imagine push_back ...
			main_menu.AddMenu(null, "Server", "Server", false);
			main_menu.AddMenuItem("Server", 0, "Server_Ajax", "Make AJAX call...", false);
			main_menu.AddMenuItem("Server", 1, "Server_JSON", "To JSON string...", false);
			main_menu.AddMenuItem("Server", 2, "Server_Catalog", "Get Catalog via AJAX...", false);

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
		// so we can pop-up in empty regions
		base_filters.AddContextMenuZone("gridBody");
		base_filters.MultipleSelection = true;
		base_filters.OnDragDrop += BaseTreeDragDropHandler;

		// base tree context menu
		DHTMLXContextMenu ctx_base_filters = new DHTMLXContextMenu("data/imgs/");
		ctx_base_filters.Load("data/context_edit_menu.xml");
		base_filters.SetContextMenu(ctx_base_filters);
		ctx_base_filters.AddContextMenuZone("gridBody");
		ctx_base_filters.OnClick += ctx_base_filters_OnClick;

		//---------------------------------------------------------------------------
		// filter tree
		cell = central_panel.Cells("c");
		tree_filters = new DHTMLXTreeGrid(cell, "data/tree_filter.xml");
		tree_filters.EnableDragDrop();
		tree_filters.AddContextMenuZone("gridBody");
		tree_filters.MultipleSelection = true;
		tree_filters.OnDragDrop += FilterTreeDragDropHandler;

		// filter tree context menu
		DHTMLXContextMenu ctx_tree_filters = new DHTMLXContextMenu("data/imgs/");
		ctx_tree_filters.Load("data/context_edit_menu.xml");
		tree_filters.SetContextMenu(ctx_tree_filters);
		ctx_tree_filters.AddContextMenuZone("gridBody");
		ctx_tree_filters.OnClick += ctx_tree_filters_OnClick;

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

		//---------------------------------------------------------------------------
		// catalog context menu
		DHTMLXContextMenu ctx_catalog = new DHTMLXContextMenu("data/imgs/");
		ctx_catalog.Load("data/menu_ctx_catalog.xml");
		catalog.SetContextMenu(ctx_catalog);
		catalog.OnDragDrop += catalog_OnDragDrop;

		//---------------------------------------------------------------------------
		// Create results grid
		tab = tabbar.Tabs("Results");
		grid_results = new DHTMLXGrid(tab);
		grid_results.EnableDragDrop();
		grid_results.EnableMultipleSelection = true;

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

		// load the default catalog (whatever that may be)
		Window.SetTimeout(PostActivation,2000);
	}

	/// <summary>
	/// Context menu handler for bases
	/// </summary>
	/// <param name="id"></param>
	void ctx_base_filters_OnClick(string id)
	{
		NativeCode.Log("ctx_base_filters_OnClick " + id);
		if (id == "cut")
		{
			base_filters.Cut();
		}
		else if (id == "selectAll")
		{
			base_filters.SelectAll();
		}
	}

	/// <summary>
	/// Context menu handler for main tree
	/// </summary>
	/// <param name="id"></param>
	void ctx_tree_filters_OnClick(string id)
	{
		NativeCode.Log("ctx_tree_filters_OnClick " + id);
		if (id == "cut")
		{
			tree_filters.Cut();
		}
		else if (id == "selectAll")
		{
			tree_filters.SelectAll();
		}
	}

	/// <summary>
	/// Timer callback in which we load default catalog
	/// </summary>
	private void PostActivation()
	{
		NativeCode.Log("PostActivation()");
		// pop an AJAX request to get catalog
		jQueryAjaxOptions opts = new jQueryAjaxOptions
		{
			Url = g_http_url + "/ajax",
			DataType = "xml",
			Async = true,
			Success = OnCatalogSuccess,
			Error = OnCatalogError,
			Type = "GET"
		};
		var req = jQuery.Ajax(opts);
	}

	/// <summary>
	/// Create the web socket. The Disconnection event will null the instance
	/// </summary>
	void CreateSocket()
	{
		if (ws == null)
		{
			ws = new WebSocket(g_ws_url + "/ajax");
			ws.OnConnected += ws_OnConnected;
			ws.OnDisconnected += ws_OnDisconnected;
			ws.OnDataReceived += ws_OnDataReceived;
		}
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="data"></param>
	void ws_OnDataReceived(WebSocket sender, object data)
	{
		if (data != null)
		{
			String s = data as String;
			status_bar.Text = String.Format("Got {0} from {1}",s,g_ws_url);
		}
	}

	void ws_OnDisconnected()
	{
 		NativeCode.Log("ws_OnDisconnected()");
		status_bar.Text = String.Format("*No* connection to {0}", g_ws_url);
		ws = null;
	}

	/// <summary>
	/// Send any queued items ....
	/// </summary>
	void ws_OnConnected()
	{
		NativeCode.Log("ws_OnConnected()");
		status_bar.Text = String.Format("Connected to {0}/ajax",g_ws_url);
		for (int i = 0; i < _queue.Count; i++)
		{
			ws.Send(_queue[i]);
		}
		_queue.Clear();
	}

	/// <summary>
	/// Quickie string quoter to help JSON
	/// </summary>
	/// <param name="arg"></param>
	/// <returns></returns>
	String QS(String arg)
	{
		String ret = "\"";
		if (arg != null)
		{
			ret += arg;
		}
		ret += "\"";
		return ret;
	}
	/// <summary>
	/// Invoked when toolbar is clicked
	/// </summary>
	/// <param name="id"></param>
	void tool_bar_OnClick(string id)
	{
		NativeCode.Log(String.Format("tool_bar_OnClick {0}",id));
		if (id == "save")
		{
			// serialize to raw JSON
			StringBuilder sb = new StringBuilder();
			sb.Append("{");
			sb.Append(QS("Query"));
			sb.Append(":");
			sb.Append("{");
			//
			sb.Append(QS("filter_data"));
			sb.Append(":[");
			SerializeTree(tree_filters,ref sb);
			sb.Append("],");
			//
			sb.Append(QS("base_data"));
			sb.Append(":[");
			SerializeTree(base_filters,ref sb);
			sb.Append("]");
			// close class scope Query
			sb.Append("}");
			// close header for Query
			sb.Append("}");
			//
			//object json_object = jQuery.ParseJson(sb.ToString());
			//SendJSONviaAJAX("tree", "json", sb.ToString());
			if (ws == null)
			{
				CreateSocket();
				_queue.Add(sb.ToString());
			}
			else
			{
				ws.Send(sb.ToString());
			}
		}
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="tree"></param>
	/// <param name="sb"></param>
	void SerializeTree(DHTMLXTreeGrid tree, ref StringBuilder sb)
	{
		int count = tree.GetRowCount();
		for (int i = 0; i < count; i++)
		{
			//String sf = null;
			//String st = null;
			String rid = tree.GetRowId(i);
			String obj = tree.GetRowData(rid, "type");
			String pid = tree.GetParentRowId(rid);
			{
				sb.Append("{\"rid\":");
				sb.Append(QS(rid));
				sb.Append(",\"pid\":");
				sb.Append(QS(pid));
				// verbatim text
				DHTMLXGridCell cell = tree.Cells(rid, FilterTree.eDescription);
				sb.Append(",\"desc\":");
				sb.Append(QS(cell.getValue()));
				// filter(s)
				cell = tree.Cells(rid, FilterTree.eFilter);
				sb.Append(",\"filter\":");
				sb.Append(QS(cell.getValue()));
				// target
				cell = tree.Cells(rid, FilterTree.eTarget);
				sb.Append(",\"target\":");
				sb.Append(QS(cell.getValue()));
				sb.Append("}");
				// gak ...
				if (i < count - 1)
				{
					sb.Append(",");
				}
			}
		}
	}

	/// <summary>
	/// Disallow any drag/drop onto catalog
	/// </summary>
	/// <param name="srcIDs"></param>
	/// <param name="dstID"></param>
	/// <param name="srcWidget"></param>
	/// <param name="dstWidget"></param>
	/// <param name="srcColumn"></param>
	/// <param name="dstColumn"></param>
	/// <returns></returns>
	bool catalog_OnDragDrop(string[] srcIDs, string dstID, object srcWidget, object dstWidget, int srcColumn, int dstColumn)
	{
		return false;
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
		return DragDropCopyHandler(srcIDs,dstID,catalog,tree_filters,srcColumn,dstColumn);
	}

	private bool BaseTreeDragDropHandler(String[] srcIDs, String dstID, object srcWidget, object dstWidget, int srcColumn, int dstColumn)
	{
		return DragDropCopyHandler(srcIDs, dstID, catalog, base_filters, srcColumn, dstColumn);
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="srcIDs"></param>
	/// <param name="dstID"></param>
	/// <param name="srcWidget"></param>
	/// <param name="dstWidget"></param>
	/// <param name="srcColumn"></param>
	/// <param name="dstColumn"></param>
	/// <returns></returns>
	private bool DragDropCopyHandler(String[] srcIDs, String dstID, DHTMLXTreeGrid srcWidget, DHTMLXTreeGrid dstWidget, int srcColumn, int dstColumn)
	{
		if (dstColumn == 2)
		{
			String userdata = null;
			DHTMLXGridCell dstCell = dstWidget.Cells(dstID, dstColumn);
			if (dstCell != null)
			{
				String row_id = null;
				//
				for (int s = 0; s < srcIDs.Length; s++)
				{
					row_id = srcIDs[s];
					userdata = srcWidget.GetRowData(row_id,"type");
					NativeCode.Log(userdata);
					// filters are additive
					if (userdata == "F")
					{
						DHTMLXGridCell srcCell = catalog.Cells(row_id, srcColumn);
						//
						String dv = dstCell.getValue();
						if (dv.Length > 0)
						{
							dv += ",";
						}
						dv += srcCell.getValue();
						dstCell.setValue(dv);
					}
				}
				//
				return false;
			}
		}
		else if (dstColumn == 3)
		{
			String userdata = null;
			DHTMLXGridCell dstCell = dstWidget.Cells(dstID, dstColumn);
			if (dstCell != null)
			{
				String row_id = null;
				//
				for (int s = 0; s < srcIDs.Length; s++)
				{
					row_id = srcIDs[s];
					userdata = srcWidget.GetRowData(row_id,"type");
					NativeCode.Log(userdata);
					// targets simply replace 
					if (userdata == "T")
					{
						DHTMLXGridCell srcCell = catalog.Cells(row_id, srcColumn);
						dstCell.setValue(srcCell.getValue());
					}
				}
				// disallow any further drag/drop
				return false;
			}
		}
		return true;
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