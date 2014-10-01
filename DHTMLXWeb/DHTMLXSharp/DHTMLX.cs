using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;


namespace DHTMLXSharp
{
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
		object _layout = null;

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
		[InlineCode("{this}.$_layout.setText({arg})")]
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
			_layout = _Attach(parent);
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
		object _layout = null;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// <returns></returns>
		[InlineCode("{parent}.attachToolbar()")]
		object _Attach(DHTMLXCell parent) { return null; }

		[InlineCode("{this}.$_layout.setIconsPath({arg})")]
		public void SetIconPath(String arg) { }

		[InlineCode("{this}.$_layout.loadStruct({arg})")]
		public void LoadXML(String arg) { }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXToolBar(DHTMLXCell parent)
		{
			_layout = _Attach(parent);
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
		object _layout = null;

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
		[InlineCode("{this}.$_layout.addTab({id},{text},{width})")]
		public void AddTab(String id, String text, int width) { }

		[InlineCode("{this}.$_layout.cells({id}).setActive()")]
		public void Activate(String id) { }
		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		[InlineCode("{this}.$_layout.cells({id})")]
		public DHTMLXTab Tabs(String id) { return null; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXTabBar(DHTMLXCell parent)
		{
			_layout = _Attach(parent);
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
		object _layout = null;

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
			_layout = _Attach(parent);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXGrid(DHTMLXTab parent)
		{
			_layout = _Attach(parent);
		}

		[InlineCode("{this}.$_layout.enableDragAndDrop(true,true)")]
		void _EnableDragDrop() { }

		[InlineCode("{this}.$_layout.enableMercyDrag(true)")]
		void _EnableDragDropCopy() { }

		public void EnableDragDrop()
		{
			_EnableDragDrop();
			_EnableDragDropCopy();
		}	

		[InlineCode("{this}.$_layout.setHeader({titles})")]
		public void SetColumnTitles(String titles) { }

		[InlineCode("{this}.$_layout.setInitWidths({widths})")]
		public void SetColumnWidths(String widths) { }

		[InlineCode("{this}.$_layout.init()")]
		public void Init() { }

		//[InlineCode("{this}.addRowAfter({new_id},{text},{sibling_id},{img},{isChild})")]
		[InlineCode("{this}.$_layout.addRow({new_id},{text},{index})")]
		public void AddRow(int new_id, string text, int index) { }

		//-------------------------------------------------
		/// <summary>
		/// Load content from an XML file
		/// </summary>
		/// <param name="xml_path"></param>
		[InlineCode("{this}.$_layout.loadXML({xml_path})")]
		public void LoadXML(String xml_path) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="json_path"></param>
		[InlineCode("{this}.$_layout.load({json_path},\"json\")")]
		public void LoadJSON(String json_path) { }

		[InlineCode("{this}.$_layout.load({uri})")]
		public void LoadURI(String uri) { }

		/// events
		public delegate void EventHandlerType(String id, String zoneId, object caState);
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
		object _layout = null;

		[InlineCode("{this}.$_layout.setHeader({titles})")]
		public void SetColumnTitles(String titles) { }

		[InlineCode("{this}.$_layout.setInitWidths({widths})")]
		public void SetColumnWidths(String widths) { }

		[InlineCode("{this}.$_layout.setColTypes({arg})")]
		public void SetColumnTypes(String arg) { }

		[InlineCode("{this}.$_layout.init()")]
		public void Init() { }

		[InlineCode("{this}.$_layout.load({json_path},\"json\")")]
		public void LoadJSON(String json_path) { }

		[InlineCode("{this}.$_layout.loadXML({xml_path})")]
		public void LoadXML(String xml_path) { }

		[InlineCode("{this}.$_layout.enableDragAndDrop(true,true)")]
		void _EnableDragDrop() { }

		[InlineCode("{this}.$_layout.enableMercyDrag(true)")]
		void _EnableDragDropCopy() { }

		public void EnableDragDrop()
		{
			_EnableDragDrop();
			_EnableDragDropCopy();
		}

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
		/// <param name="parent"></param>
		public DHTMLXTreeGrid(DHTMLXCell parent,DHTMLXTreeGridSettings settings)
		{
			//
			_layout = _Attach(parent);
			if (_layout != null && settings != null)
			{
				LoadXML(settings.content_url);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="url"></param>
		public DHTMLXTreeGrid(DHTMLXCell parent,String url)
		{
			//
			_layout = _Attach(parent);
			if (_layout != null && url != null)
			{
				LoadXML(url);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="parent"></param>
		public DHTMLXTreeGrid(DHTMLXTab parent, DHTMLXTreeGridSettings settings)
		{
			//
			_layout = _Attach(parent);
			if (_layout != null && settings != null)
			{
				LoadXML(settings.content_url);
			}
		}
	}

	/// <summary>
	/// 
	/// </summary>
	class DHTMLXLayout
	{
		// the native instance
		object _layout = null;

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
			_layout = _Attach(parent, formatString);
		}

		[InlineCode("{this}.$_layout.cells({id})")]
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
		object _menu = null;
		/// <summary>
		/// typedef an event handler
		/// </summary>
		public delegate void EventHandlerType(String id,String zoneId,object caState);

		/// <summary>
		/// OnClick += Function with EventHandlerType signature
		/// </summary>
		public event EventHandlerType OnClick
		{
			[InlineCode("{this}.$_menu.attachEvent('onClick',{value})")]
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
			_menu = _Attach(parent);
		}

		/// <summary>
		/// Add a separator
		/// </summary>
		/// <param name="id"></param>
		[InlineCode("{this}.$_menu.addNewSeparator({id})")]
		public void AddSeparator(String id) {}

		[InlineCode("{this}.$_menu.addNewSibling({parentId}, {id}, {caption}, {enabled})")]
		public void AddMenu(String parentId, String id, String caption, bool enabled) {}

		/// <summary>
		/// Adds a new dropdown item 
		/// </summary>
		/// <param name="parentId">ID of the parent menu</param>
		/// <param name="position">Zero indexed position</param>
		/// <param name="id">this menu items ID</param>
		/// <param name="text">Menu text</param>
		/// <param name="enabled">enabled or not</param>
		[InlineCode("{this}.$_menu.addNewChild({parentId},{position},{id},{text},{enabled})")]
		public void AddMenuItem(String parentId, int position, String id, string text, bool enabled) { }

		/// <summary>
		/// Enable the menu
		/// </summary>
		/// <param name="menuId"></param>
		[InlineCode("{this}.$_menu.setItemEnabled({menuId})")]
		public void EnableMenu(String menuId) {}

		/// <summary>
		/// Disable the menu
		/// </summary>
		/// <param name="menuId"></param>
		[InlineCode("{this}.$_menu.setItemDisabled({menuId})")]
		public void DisableMenu(String menuId) {}

		/// <summary>
		/// Load a menu from an XML or other definition
		/// </summary>
		/// <param name="menuDefinition"></param>
		[InlineCode("{this}.$_menu.loadStruct({menuDefinition})")]
		public void Load(string menuDefinition) {}
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
