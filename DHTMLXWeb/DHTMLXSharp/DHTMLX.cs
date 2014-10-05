using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;


namespace DHTMLXSharp
{
	/// <summary>
	/// Extremely thin wrapper around cell object
	/// </summary>
	class DHTMLXGridCell
	{
		/// <summary>
		/// Set textual value
		/// </summary>
		/// <param name="value"></param>
		[InlineCode("{this}.setValue({value})")]
		public void setValue(String value) { }

		/// <summary>
		/// Get textual value
		/// </summary>
		/// <returns></returns>
		[InlineCode("{this}.getValue({})")]
		public String getValue() { return null; }

		/// <summary>
		/// Constructor must take 
		/// </summary>
		/// <param name="obj"></param>
		public DHTMLXGridCell(object obj)
		{
		}
	}

	/// <summary>
	/// 
	/// </summary>
	class DHTMLXCell
	{
		[InlineCode("{this}.hideHeader()")]
		public void HideHeader() { }

		/// <summary>
		/// Set the cell header text
		/// </summary>
		/// <param name="text"></param>
		[InlineCode("{this}.setText({text})")]
		public void SetText(String text) { }

		/// <summary>
		/// Constructor must take 
		/// </summary>
		/// <param name="obj"></param>
		public DHTMLXCell(object obj) 
		{
		}
	}

	/// <summary>
	/// Status bar
	/// </summary>
	class DHTMLXStatusBar
	{
		/// <summary>
		/// The widget instance
		/// </summary>
		object _instance = null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// <returns></returns>
		[InlineCode("{parent}.attachStatusBar()")]
		object _Attach(DHTMLXCell parent) { return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg"></param>
		[InlineCode("{this}.$_instance.setText({arg})")]
		void _text(String arg) { }

		/// <summary>
		/// 
		/// </summary>
		public String Text
		{
			set
			{
				_text(value);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXStatusBar(DHTMLXCell parent)
		{
			_instance = _Attach(parent);
		}
	}

	/// <summary>
	/// Status bar
	/// </summary>
	class DHTMLXToolBar
	{
		/// <summary>
		/// The widget instance
		/// </summary>
		object _instance = null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// <returns></returns>
		[InlineCode("{parent}.attachToolbar()")]
		object _Attach(DHTMLXCell parent) { return null; }

		/// <summary>
		/// Set server-side path for icons (i.e. "data/imgs/")
		/// </summary>
		/// <param name="arg"></param>
		[InlineCode("{this}.$_instance.setIconsPath({arg})")]
		public void SetIconPath(String arg) { }

		/// <summary>
		/// Load toolbar structure from XML
		/// </summary>
		/// <param name="arg"></param>
		[InlineCode("{this}.$_instance.loadStruct({arg})")]
		public void LoadXML(String arg) { }

		/// <summary>
		/// Add a new button
		/// </summary>
		/// <param name="id"></param>
		/// <param name="text"></param>
		/// <param name="imgEnabled"></param>
		/// <param name="imgDisabled"></param>
		[InlineCode("{this}.$_instance.addButton({id},{text},{imgEnabled},{imgDisabled})")]
		public void AddButton(String id,String text,String imgEnabled,String imgDisabled) {}

		/// <summary>
		/// Add a separator
		/// </summary>
		[InlineCode("{this}.$_instance.addSeparator()")]
		public void AddSeparator() { }

		/// <summary>
		/// typedef an event handler
		/// </summary>
		public delegate void ClickHandlerType(String id);

		/// <summary>
		/// OnClick += Function with EventHandlerType signature
		/// </summary>
		public event ClickHandlerType OnClick
		{
			[InlineCode("{this}.$_instance.attachEvent('onClick',{value})")]
			add { }

			// [InlineCode("{this}.$_instance.attachEvent('onClick',{value})")]
			remove { }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXToolBar(DHTMLXCell parent)
		{
			_instance = _Attach(parent);
		}

	}

	/// <summary>
	/// 
	/// </summary>
	class DHTMLXTab
	{
		[InlineCode("{this}.hideHeader()")]
		public void HideHeader() { }

		/// <summary>
		/// Set the cell header text
		/// </summary>
		/// <param name="text"></param>
		[InlineCode("{this}.setText({text})")]
		public void SetText(String text) { }

		/// <summary>
		/// 
		/// </summary>
		public DHTMLXTab()
		{
		}
	}

	/// <summary>
	/// Status bar
	/// </summary>
	class DHTMLXTabBar
	{
		/// <summary>
		/// The widget instance
		/// </summary>
		object _instance = null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// <returns></returns>
		[InlineCode("{parent}.attachTabbar()")]
		object _Attach(DHTMLXCell parent) { return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="text"></param>
		/// <param name="Width"></param>
		[InlineCode("{this}.$_instance.addTab({id},{text},{width})")]
		public void AddTab(String id, String text, int width) { }

		[InlineCode("{this}.$_instance.cells({id}).setActive()")]
		public void Activate(String id) { }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[InlineCode("{this}.$_instance.cells({id})")]
		public DHTMLXTab Tabs(String id) { return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXTabBar(DHTMLXCell parent)
		{
			_instance = _Attach(parent);
		}

	}

	/// <summary>
	/// 
	/// </summary>
	class DHTMLXGrid
	{
		/// <summary>
		/// The widget instance
		/// </summary>
		object _instance = null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// <returns></returns>
		[InlineCode("{parent}.attachGrid()")]
		object _Attach(object parent) { return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXGrid(DHTMLXCell parent)
		{
			_instance = _Attach(parent);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXGrid(DHTMLXTab parent)
		{
			_instance = _Attach(parent);
		}

		[InlineCode("{this}.$_instance.enableDragAndDrop(true,true)")]
		void _EnableDragDrop() { }

		[InlineCode("{this}.$_instance.enableMercyDrag(true)")]
		void _EnableDragDropCopy() { }

		/// <summary>
		/// 
		/// </summary>
		public void EnableDragDrop()
		{
			_EnableDragDrop();
			_EnableDragDropCopy();
		}

		[InlineCode("{this}.$_instance.enableMultiselect({arg})")]
		void _EnableMultipleSelection(bool arg) { }

		/// <summary>
		/// 
		/// </summary>
		public bool EnableMultipleSelection
		{
			set
			{
				if (Instance != null)
				{
					_EnableMultipleSelection(value);
				}
			}
		}

		/// <summary>
		/// Wire up drag/drop events
		/// </summary>
		/// <param name="srcID"></param>
		/// <param name="dstID"></param>
		/// <param name="srcWidget"></param>
		/// <param name="dstWidget"></param>
		/// <param name="srcColumn"></param>
		/// <param name="dstColumn"></param>
		delegate bool _GridDragDropHandler(object srcID,object dstID,object srcWidget,object dstWidget,object srcColumn,object dstColumn);

		event _GridDragDropHandler _DragDropHandler
		{
			[InlineCode("{this}.$_instance.attachEvent('onDrag',{value})")]
			add { }
			remove { }
		}

		[InlineCode("{this}.$_instance.setHeader({titles})")]
		public void SetColumnTitles(String titles) { }

		[InlineCode("{this}.$_instance.setInitWidths({widths})")]
		public void SetColumnWidths(String widths) { }

		[InlineCode("{this}.$_instance.init()")]
		public void Init() { }

		//[InlineCode("{this}.addRowAfter({new_id},{text},{sibling_id},{img},{isChild})")]
		[InlineCode("{this}.$_instance.addRow({new_id},{text},{index})")]
		public void AddRow(int new_id, string text, int index) { }

		/// <summary>
		/// Clear the grid. Clears header if arg is true
		/// </summary>
		/// <param name="bHeader"></param>
		[InlineCode("{this}.$_instance.clearAll({bHeader})")]
		public void Clear(bool bHeader) { }

		//-------------------------------------------------
		/// <summary>
		/// Load content from an XML file
		/// </summary>
		/// <param name="xml_path"></param>
		[InlineCode("{this}.$_instance.loadXML({xml_path})")]
		public void LoadXML(String xml_path) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="json_path"></param>
		[InlineCode("{this}.$_instance.load({json_path},\"json\")")]
		public void LoadJSON(String json_path) { }

		[InlineCode("{this}.$_instance.load({uri})")]
		public void LoadURI(String uri) { }

		//
		[InlineCode("{this}.$_instance.enableContextMenu({menu})")]
		void _SetContextMenu(object menu) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		public void SetContextMenu(DHTMLXContextMenu menu)
		{
			_SetContextMenu(menu.Instance);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="row_id"></param>
		/// <param name="column"></param>
		/// <returns></returns>
		[InlineCode("{this}.$_instance.cells({row_id},{column})")]
		public DHTMLXGridCell Cells(String row_id, int column) { return null; }

		/// <summary>
		/// For those times we need the underlying JS object
		/// </summary>
		public object Instance
		{
			get
			{
				return _instance;
			}
		}
	}

	/// <summary>
	/// Settings for creating a TreeGrid
	/// </summary>
	[Serializable]
	public class DHTMLXTreeGridSettings
	{
		public String image_path;
		/// <summary>
		/// column separated header types as in
		/// "Tree,Plain Text,Long Text,Color,Checkbox"
		/// </summary>
		public String column_text;
		/// <summary>
		/// comma separated column widths
		/// </summary>
		public String column_widths;
		/// <summary>
		/// "tree,ed,txt,ch,ch"
		/// </summary>
		public String column_types;
		/// <summary>
		/// "dhx_skyblue"
		/// </summary>
		public String skin;
		/// <summary>
		/// server side data as in 
		/// "../common/data.json"
		/// </summary>
		public String content_url;
	}
	
	/// <summary>
	/// 
	/// </summary>
	class DHTMLXTreeGrid
	{
		/// <summary>
		/// The widget instance
		/// </summary>
		object _instance = null;

		[InlineCode("{this}.$_instance.setHeader({titles})")]
		public void SetColumnTitles(String titles) { }

		[InlineCode("{this}.$_instance.setInitWidths({widths})")]
		public void SetColumnWidths(String widths) { }

		[InlineCode("{this}.$_instance.setColTypes({arg})")]
		public void SetColumnTypes(String arg) { }

		[InlineCode("{this}.$_instance.init()")]
		public void Init() { }

		[InlineCode("{this}.$_instance.load({json_path},\"json\")")]
		public void LoadJSON(String json_path) { }

		[InlineCode("{this}.$_instance.loadXML({xml_path})")]
		public void LoadXML(String xml_path) { }

		/// <summary>
		/// Given an object (say) retrieved from server as XML, build tree
		/// </summary>
		/// <param name="xml_obj"></param>
		[InlineCode("{this}.$_instance.parse({xml_obj},\"xml\")")]
		public void LoadFromXMLObject(object xml_obj) { }

		/// <summary>
		/// Given an object (say) retrieved from server as JSON, build tree
		/// </summary>
		/// <param name="xml_obj"></param>
		[InlineCode("{this}.$_instance.parse({json_obj},\"json\")")]
		public void LoadFromJSONObject(object json_obj) { }

		/// <summary>
		/// Get content in XML format
		/// </summary>
		/// <returns></returns>
		[InlineCode("{this}.$_instance.serialize()")]
		public object SaveToXML() { return null; }

		//
		[InlineCode("{this}.$_instance.enableContextMenu({menu})")]
		void _SetContextMenu(object menu) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="menu"></param>
		public void SetContextMenu(DHTMLXContextMenu menu)
		{
			_SetContextMenu(menu.Instance);
		}

		[InlineCode("{this}.$_instance.enableDragAndDrop(true,true)")]
		void _EnableDragDrop() { }

		[InlineCode("{this}.$_instance.enableMercyDrag(true)")]
		void _EnableDragDropCopy() { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg"></param>
		[InlineCode("{this}.$_instance.enableMultiselect({arg})")]
		void _EnableMultipleSelection(bool arg) { }

		/// <summary>
		/// 
		/// </summary>
		public void EnableDragDrop()
		{
			_EnableDragDrop();
			_EnableDragDropCopy();
		}

		/// <summary>
		/// 
		/// </summary>
		public bool MultipleSelection
		{
			set
			{
				if (Instance != null)
				{
					_EnableMultipleSelection(value);
				}
			}
		}


		/// <summary>
		/// Wire up drag/drop events
		/// </summary>
		/// <param name="srcID"></param>
		/// <param name="dstID"></param>
		/// <param name="srcWidget"></param>
		/// <param name="dstWidget"></param>
		/// <param name="srcColumn"></param>
		/// <param name="dstColumn"></param>
		delegate bool _DragDropHandlerType(object srcID, object dstID, object srcWidget, object dstWidget, object srcColumn, object dstColumn);

		/// <summary>
		/// Internal handler 
		/// </summary>
		event _DragDropHandlerType _DragDropHandler
		{
			[InlineCode("{this}.$_instance.attachEvent('onDrag',{value})")]
			add { }
			remove { }
		}

		/// <summary>
		/// This handler does tpye conversion and forwards to proper delegate
		/// </summary>
		/// <param name="sID"></param>
		/// <param name="dID"></param>
		/// <param name="srcWidget"></param>
		/// <param name="dstWidget"></param>
		/// <param name="sColumn"></param>
		/// <param name="dColumn"></param>
		/// <returns></returns>
		private bool _ForwardDragDropHandler(object sID, object dID, object srcWidget, object dstWidget, object sColumn, object dColumn)
		{
			bool ret = true;
			if (OnDragDrop != null && 
				sID != null && 
				dID != null && 
				sColumn != null && 
				dColumn != null)
			{
				String srcID = sID as String;
				String[] srcIDs = srcID.Split(',');
				String dstID = dID as String;
				int srcColumn = (int) sColumn;
				int dstColumn = (int) dColumn;
				ret = OnDragDrop(srcIDs, dstID, srcWidget, dstWidget, srcColumn, dstColumn);
			}
			return ret;
		}

		public delegate bool DragDropHandlerType(String[] srcIDs, String dstID, object srcWidget, object dstWidget, int srcColumn, int dstColumn);

		/// <summary>
		/// Return false to disable drop, true to enable
		/// </summary>
		public event DragDropHandlerType OnDragDrop;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// <returns></returns>
		//[InlineCode("{parent}.attachTreeGrid()")]
		[InlineCode("{parent}.attachGrid()")]
		object _Attach(object parent) { return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		[InlineCode("{this}.$_instance.getRowsNum()")]
		object _GetRowCount() { return null; }

		/// <summary>
		/// How many rows in the grid?
		/// </summary>
		/// <returns></returns>
		public int GetRowCount() { return (int) _GetRowCount(); }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		[InlineCode("{this}.$_instance.getRowId({index})")]
		object _GetRowId(int index) {  return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		[InlineCode("{this}.$_instance.getParentId({rowID})")]
		object _GetParentRowId(String rowID) { return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public String GetRowId(int index) { return _GetRowId(index) as String; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="row_id"></param>
		/// <returns></returns>
		[InlineCode("{this}.$_instance.getUserData({row_id},{key})")]
		public String GetRowData(String row_id, String key) { return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public String GetParentRowId(String rowID) 
		{
			object obj = _GetParentRowId(rowID);
			return (obj == null ? null : obj as String);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXTreeGrid(DHTMLXCell parent,DHTMLXTreeGridSettings settings)
		{
			//
			_instance = _Attach(parent);
			if (_instance != null && settings != null)
			{
				LoadXML(settings.content_url);
			}
			//
			_DragDropHandler += _ForwardDragDropHandler;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="url"></param>
		public DHTMLXTreeGrid(DHTMLXCell parent,String url)
		{
			//
			_instance = _Attach(parent);
			if (_instance != null && url != null)
			{
				LoadXML(url);
			}
			//
			_DragDropHandler += _ForwardDragDropHandler;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXTreeGrid(DHTMLXTab parent,String url)
		{
			//
			_instance = _Attach(parent);
			if (_instance != null && url != null)
			{
				LoadXML(url);
			}
			//
			_DragDropHandler += _ForwardDragDropHandler;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="row_id"></param>
		/// <param name="column"></param>
		/// <returns></returns>
		[InlineCode("{this}.$_instance.cells({row_id},{column})")]
		public DHTMLXGridCell Cells(String row_id,int column) { return null; }

		/// <summary>
		/// Clear the grid, keep the header
		/// </summary>
		[InlineCode("{this}.$_instance.clearAll()")]
		public void ClearContent() { }

		/// <summary>
		/// For those times we need the underlying JS object
		/// </summary>
		public object Instance
		{
			get
			{
				return _instance;
			}
		}
	}

	/// <summary>
	/// Light-weight object.
	/// </summary>
	class DHTMLXCombo
	{
		/// <summary>
		/// 
		/// </summary>
		private object _instance = null;

		/// <summary>
		/// 
		/// </summary>
		public DHTMLXCombo()
		{

		}
		
		/// <summary>
		/// For those times we need the underlying JS object
		/// </summary>
		public object Instance
		{
			get
			{
				return _instance;
			}
		}
	}

	/// <summary>
	/// 
	/// </summary>
	class DHTMLXLayout
	{
		// the native instance
		object _instance = null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="el"></param>
		/// <param name="format"></param>
		/// <returns></returns>
		[InlineCode("new dhtmlXLayoutObject({parent},{format})")]
		object _Attach(object parent, string format) { return null; }

		/// <summary>
		/// JSON helper
		/// </summary>
		/// <param name="content"></param>
		/// <returns></returns>
		[InlineCode("jQuery.Parse({content})")]
		object toJSON(String content) { return null; }

		/// <summary>
		/// Layout formats
		/// http://docs.dhtmlx.com/layout__patterns.html
		/// </summary>
		public enum Format
		{
			e1C,
			e2E,
			e2U,
			e3J, // 3 cell vertical div, lhs splitter
			e3L, // 3 cell vertical div, rhs splitter
			e3U, // 3 cell horz div, top splitter
		}

		//////////////////////////////////////////////////////////////////////////
		static Dictionary<Format,String> formats = new Dictionary<Format,String>();

		/// <summary>
		/// Create a new layout instance. Note use of {} markers for argument replacements
		/// el => {el} and format => {format}
		/// </summary>
		/// Example: DHTMLXLayout layout = new DHTMLXLayout(Document.Body,"3U");
		public DHTMLXLayout(Element parent, Format format)
		{
			_Initialize(parent,format);
		}

		public DHTMLXLayout(DHTMLXCell parent, Format format)
		{
			_Initialize(parent,format);
		}

		private void _Initialize(object parent,Format format)
		{
			String formatString = "1C";
			if (formats.Count == 0)
			{
				formats.Add(Format.e1C,"1C");
				formats.Add(Format.e2E, "2E");
				formats.Add(Format.e2U, "2U");
				formats.Add(Format.e3J, "3J");
				formats.Add(Format.e3L, "3L");
				formats.Add(Format.e3U, "3U");
			}
			formats.TryGetValue(format,out formatString);
			_instance = _Attach(parent, formatString);
		}

		[InlineCode("{this}.$_instance.cells({id})")]
		public DHTMLXCell Cells(string id) { return null; }
	}

	/// <summary>
	/// Wrap both pop-up Window and associated Form into a single class
	/// we can show/hide, operate modally and attach external event
	/// // handlers
	/// </summary>
	class DHTMLXWindow
	{
		// the enclosing Window (frame)
		private object _window = null;
		// the internal form object contains controls + data
		private object _form = null;

		/// <summary>
		/// Get the form data
		/// </summary>
		/// <returns></returns>
		[InlineCode("{this}.$_form.getFormData()")]
		String getFormData() { return null; }

		/// <summary>
		/// create a new window
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="id"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <returns></returns>
		[InlineCode("{parent}.createWindow({id},{x},{y},{width},{height})")]
		object _Attach(DHTMLXWindowFactory parent, string id, int x, int y, int width, int height) {  return null; }

		/// <summary>
		/// attach a new form
		/// </summary>
		/// <param name="_window"></param>
		/// <param name="layout"></param>
		/// <returns></returns>
		[InlineCode("{_window}.attachForm({layout})")]
		object _Attach(object _window, object layout) { return null; }
		
		/// <summary>
		/// Much better. Uses strongly typed parent
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="id"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		public DHTMLXWindow(DHTMLXWindowFactory parent, string id, int x, int y, int width, int height, object layout)
		{
			// set up the window
			_window = _Attach(parent,id,x,y,width,height);
			if (layout != null)
			{
				// set up the form
				_form = _Attach(_window, layout);
				_FormClickHandler += _OnInternalClick;
				_WindowClickHandler += _OnInternalClick;
			}
		}


		/// <summary>
		/// Get the forms data
		/// </summary>
		/// <returns></returns>
		public String GetData() { return getFormData(); }

		/// <summary>
		/// Set the window text
		/// </summary>
		/// <param name="text"></param>
		[InlineCode("{this}.$_window.setText({text})")]
		void _SetText(string text) { }

		/// <summary>
		/// Show the window
		/// </summary>
		[InlineCode("{this}.$_window.show()")]
		void _Show() { }

		/// <summary>
		/// Hide the window
		/// </summary>
		[InlineCode("{this}.$_window.hide()")]
		void _Hide() { }

		[InlineCode("{this}.$_window.setModal({state})")]
		void _Modal(bool state) { }

		[InlineCode("{this}.$_window.center()")]
		void _Center() { }

		/// <summary>
		/// Set the Window's caption
		/// </summary>
		public String Text
		{
			set
			{
				if (_window != null)
				{
					_SetText(value);
				}
			}
		}

		/// <summary>
		/// Center the Window in the viewport ...
		/// </summary>
		public bool Center
		{
			set
			{
				if (_window != null)
				{
					_Center();
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public bool Visible
		{
			set
			{
				if (_window != null)
				{
					if (value == true)
					{
						_Show();
					}
					else
					{
						_Hide();
						_Modal(false);
					}
				}
			}
		}

		/// <summary>
		/// true = modal, false = not
		/// </summary>
		public void ShowModal()
		{
			if (_window != null)
			{
				_Modal(true);
				_Center();
				_Show();
			}
		}

		/// <summary>
		/// true = modal, false = not
		/// </summary>
		public bool Modal
		{
			set
			{
				if (_window != null)
				{
					_Modal(value);
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="btnName"></param>
		delegate void _FormEventHandler(string btnName);

		event _FormEventHandler _FormClickHandler
		{
			[InlineCode("{this}.$_form.attachEvent('onButtonClick',{value})")]
			add { }
			remove { }
		}

		/// <summary>
		/// typedef an event handler
		/// </summary>
		delegate void _WindowHandlerType(string btnName);

		/// <summary>
		/// OnClick += Function with EventHandlerType signature
		/// </summary>
		event _WindowHandlerType _WindowClickHandler
		{
			[InlineCode("{this}.$_window.attachEvent('onClose',{value})")]
			add { }
			remove { }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="window"></param>
		/// <param name="name"></param>
		public delegate void ExternalHandlerType(DHTMLXWindow window,string name);

		/// <summary>
		/// Interested 3rd parties will be notified of button clicks in the form
		/// if they add an event handler to OnClick
		/// </summary>
		public event ExternalHandlerType OnClick;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="btnName"></param>
		//public 
		void _OnInternalClick(string arg)
		{
			// forward to external delegate
			if (OnClick != null)
			{
				// this means we know which Window instance and which button
				OnClick(this, arg);
			}
		}
	}

	/// <summary>
	/// Window factory. Need to reference the factory in order to be able 
	/// to create Windows ...
	/// </summary>
	class DHTMLXWindowFactory
	{
		/// <summary>
		/// singleton instance. Note that _factory will sctually resolve to a JS object instance
		/// </summary>
 		static private DHTMLXWindowFactory _factory = null;

		/// <summary>
		/// This is the internal in-line code
		/// </summary>
		[InlineCode("new dhtmlXWindows()")]
		private static DHTMLXWindowFactory _Attach() { return null; }

		/// <summary>
		/// Attach to the singleton instance
		/// </summary>
		/// <returns></returns>
		static DHTMLXWindowFactory Attach()
		{
			if (_factory == null)
			{
				_factory = _Attach();
			}
			return _factory;
		}

		/// <summary>
		/// Returns the singleton Window Factory instance
		/// So to use this we do DHTMLXWindowFactory.Instance
		/// </summary>
		public static DHTMLXWindowFactory Instance
		{
			get
			{
				return Attach();
			}
		}
	}

	/// <summary>
	/// Menus
	/// </summary>
	class DHTMLXMenu
	{
		object _instance = null;
		/// <summary>
		/// typedef an event handler
		/// </summary>
		public delegate void EventHandlerType(String id,String zoneId,object caState);

		/// <summary>
		/// OnClick += Function with EventHandlerType signature
		/// </summary>
		public event EventHandlerType OnClick
		{
			[InlineCode("{this}.$_instance.attachEvent('onClick',{value})")]
			add { }
			remove { }
		}

		[InlineCode("{parent}.attachMenu()")]
		public object _Attach(DHTMLXCell parent) { return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXMenu(DHTMLXCell parent)
		{
			_instance = _Attach(parent);
		}

		/// <summary>
		/// Add a separator
		/// </summary>
		/// <param name="id"></param>
		[InlineCode("{this}.$_instance.addNewSeparator({id})")]
		public void AddSeparator(String id) {}

		[InlineCode("{this}.$_instance.addNewSibling({parentId}, {id}, {caption}, {enabled})")]
		public void AddMenu(String parentId, String id, String caption, bool enabled) {}

		/// <summary>
		/// Adds a new dropdown item 
		/// </summary>
		/// <param name="parentId">ID of the parent menu</param>
		/// <param name="position">Zero indexed position</param>
		/// <param name="id">this menu items ID</param>
		/// <param name="text">Menu text</param>
		/// <param name="enabled">enabled or not</param>
		[InlineCode("{this}.$_instance.addNewChild({parentId},{position},{id},{text},{enabled})")]
		public void AddMenuItem(String parentId, int position, String id, string text, bool enabled) { }

		/// <summary>
		/// Enable the menu
		/// </summary>
		/// <param name="menuId"></param>
		[InlineCode("{this}.$_instance.setItemEnabled({menuId})")]
		public void EnableMenu(String menuId) {}

		/// <summary>
		/// Disable the menu
		/// </summary>
		/// <param name="menuId"></param>
		[InlineCode("{this}.$_instance.setItemDisabled({menuId})")]
		public void DisableMenu(String menuId) {}

		/// <summary>
		/// Load a menu from an XML or other definition
		/// </summary>
		/// <param name="menuDefinition"></param>
		[InlineCode("{this}.$_instance.loadStruct({menuDefinition})")]
		public void Load(string menuDefinition) {}

		/// <summary>
		/// For those times we need the underlying JS object
		/// </summary>
		public object Instance
		{
			get
			{
				return _instance;
			}
		}
	}

		/// <summary>
	/// Menus
	/// </summary>
	class DHTMLXContextMenu
	{
		object _instance = null;
		/// <summary>
		/// typedef an event handler
		/// </summary>
		public delegate void ClickHandlerType(String id);

		/// <summary>
		/// OnClick += Function with EventHandlerType signature
		/// </summary>
		public event ClickHandlerType OnClick
		{
			[InlineCode("{this}.$_instance.attachEvent('onClick',{value})")]
			add { }
			remove { }
		}

		[InlineCode("new dhtmlXMenuObject()")]
		object _Attach() { return null; }

		[InlineCode("this.$_instance.renderAsContextMenu()")]
		void _Render() { }

		[InlineCode("this.$_instance.setIconsPath({url})")]
		/*public*/ void _SetIconPath(String url) { }

		[InlineCode("{this}.$_instance.loadStruct({menuDefinition})")]
		public void Load(string menuDefinition) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXContextMenu(String iconURL)
		{
			_instance = _Attach();
			if (_instance != null)
			{
				_SetIconPath(iconURL);
				_Render();
			}
		}
		/// <summary>
		/// For those times we need the underlying JS object
		/// </summary>
		public object Instance
		{
			get
			{
				return _instance;
			}
		}
	}

	/// <summary>
	/// Websocket wrapper
	/// </summary>
	class WebSocket
	{
		/// <summary>
		/// 
		/// </summary>
		object _instance = null;
		//
		bool _connected = false;

		[InlineCode("new WebSocket({url})")]
		object _Attach(String url) { return null; }

		[InlineCode("{this}.$_instance.send({arg})")]
		public void Send(String arg) { }
		
		[InlineCode("{this}.$_instance.close()")]
		public void Close() { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg"></param>
		/// <returns></returns>
		[InlineCode("{arg}.data")]
		public object _Data(object arg) { return null; }

		/// <summary>
		/// Internal delegate for receving data
		/// </summary>
		/// <param name="data"></param>
		delegate void _MessageHandlerType(object data);
		event _MessageHandlerType _OnDataReceived
		{
			[InlineCode("{this}.$_instance.onmessage = {value}")]
			add { }
			remove { }
		}
		/// <summary>
		/// 
		/// </summary>
		delegate void _ConnectedHandlerType();
		event _ConnectedHandlerType _OnConnected
		{
			[InlineCode("{this}.$_instance.onopen = {value}")]
			add { }
			remove { }
		}

		/// <summary>
		/// 
		/// </summary>
		delegate void _DisconnectedHandlerType();
		event _DisconnectedHandlerType _OnDisconnected
		{
			[InlineCode("{this}.$_instance.onclose = {value}")]
			add { }
			remove { }
		}

		/// <summary>
		/// For external consumers
		/// </summary>
		public delegate void ConnectedHandlerType();
		public event ConnectedHandlerType OnConnected;

		/// <summary>
		/// For external consumers
		/// </summary>
		public delegate void DisconnectedHandlerType();
		public event DisconnectedHandlerType OnDisconnected;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="data"></param>
		public delegate void ReceivedHandlerType(WebSocket sender,object data);
		public event ReceivedHandlerType OnDataReceived;

		//
		public bool Connected
		{
			get {  return _connected; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="url"></param>
		public WebSocket(String url)
		{
			_instance = _Attach(url);
			if (_instance != null)
			{
				_OnConnected += WebSocket_OnConnected;
				_OnDisconnected += WebSocket__OnDisconnected;
				_OnDataReceived += WebSocket__OnDataReceived;
			}
		}

		/// <summary>
		/// We have got data, do something with it ...
		/// </summary>
		/// <param name="data"></param>
		void WebSocket__OnDataReceived(object data)
		{
			if (OnDataReceived != null)
			{
				object content = _Data(data);
				OnDataReceived(this,content);
			}
		}

		void WebSocket__OnDisconnected()
		{
			NativeCode.Log("WebSocket__OnDisconnected()");
			_connected = false;
			if (OnDisconnected != null)
			{
				OnDisconnected();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		void WebSocket_OnConnected()
		{
			NativeCode.Log("WebSocket_OnConnected()");
			_connected = true;
			if (OnConnected != null)
			{
				OnConnected();
			}
		}
	}

	/// <summary>
	/// 
	/// </summary>
	class NativeCode
	{
		/// <summary>
		/// Simply inline a call to existing Javascript code
		/// </summary>
		[InlineCode("init()")]
		static public void InitializeDHTMLX() {}

		/// <summary>
		/// @ suppresses emission of function_name as a 'string'
		/// </summary>
		[InlineCode("{@function_name}()")]
		static public void CallJS(String function_name) {}

		[InlineCode("$.toJSON({obj})")]
		static public String toJSON(object obj) { return null; }

		[InlineCode("Mapper[{layout_name}]")]
		static public object getLayout(String layout_name) { return null; }

		[InlineCode("console.log({arg})")]
		static public void Log(String arg) {  }
	}

	/// <summary>
	/// 
	/// </summary>
	class Test
	{
		private String _s = null;

		public Test(String s)
		{
			_s = s;
		}

		public String Value()
		{
			return _s;
		}
	}
}
