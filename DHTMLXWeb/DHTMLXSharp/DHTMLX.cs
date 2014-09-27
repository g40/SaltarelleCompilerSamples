using System;
using System.Collections.Generic;
using System.Html;
using System.Runtime.CompilerServices;
using jQueryApi;


namespace DHTMLXSharp
{
	class DHTMLXTreeGrid
	{
		public DHTMLXTreeGrid() { }

		[InlineCode("{this}.setHeader({titles})")]
		public void SetColumnTitles(String titles) { }

		[InlineCode("{this}.setInitWidths({widths})")]
		public void SetColumnWidths(String widths) { }

		[InlineCode("{this}.init()")]
		public void Init() { }

		//[InlineCode("{this}.addRowAfter({new_id},{text},{sibling_id},{img},{isChild})")]
		[InlineCode("{this}.addRow({new_id},{text},{index})")]
		public void AddRow(int new_id, string text, int index) { }

		//-------------------------------------------------
		/// <summary>
		/// Load content from an XML file
		/// </summary>
		/// <param name="xml_path"></param>
		[InlineCode("{this}.loadXML({xml_path})")]
		public void LoadXML(String xml_path) { }

		/// events
		public delegate void EventHandlerType(String id,String zoneId,object caState);
	}

	/// <summary>
	/// 
	/// </summary>
	class DHTMLXCell
	{
		/// <summary>
		/// Constructor must take 
		/// </summary>
		/// <param name="obj"></param>
		[InlineCode("new dhtmlXLayoutCell({obj})")]
		public DHTMLXCell(object obj) { }

		[InlineCode("{this}.attachMenu()")]
		public DHTMLXMenu AttachMenu() { return null; }

		[InlineCode("{this}.attachGrid()")]
		public DHTMLXTreeGrid AttachGrid() { return null; }

	}

	/// <summary>
	/// 
	/// </summary>
	class DHTMLXLayoutObject
	{
		/// <summary>
		/// Create a new layout instance. Note use of {} markers for argument replacements
		/// el => {el} and format => {format}
		/// </summary>
		/// Example: DHTMLXLayout layout = new DHTMLXLayout(Document.Body,"3U");
		[InlineCode("new dhtmlXLayoutObject({el},{format})")]
		public DHTMLXLayoutObject(Element el, string format) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="content"></param>
		/// where content is valid JSON according to 
		/// http://docs.dhtmlx.com/layout__init.html
		[InlineCode("new dhtmlXLayoutObject(jQuery.Parse({content}))")]
		public DHTMLXLayoutObject(string content) { }

		[InlineCode("{this}.cells({id})")]
		public DHTMLXCell Cells(string id) { return null; }
	}

	/// <summary>
	/// 
	/// </summary>
	class DHTMLXToolbar
	{

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
		object Attach(DHTMLXWindowFactory parent, string id, int x, int y, int width, int height) {  return null; }

		/// <summary>
		/// attach a new form
		/// </summary>
		/// <param name="_window"></param>
		/// <param name="layout"></param>
		/// <returns></returns>
		[InlineCode("{_window}.attachForm({layout})")]
		object Attach(object _window, object layout) { return null; }
		
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
			_window = Attach(parent,id,x,y,width,height);
			if (layout != null)
			{
				_form = Attach(_window, layout);
				_FormClickHandler += _OnInternalClick;
			}
		}


		/// <summary>
		/// Get the forms data
		/// </summary>
		/// <returns></returns>
		public String GetData() { return getFormData(); }

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
		/// typedef an event handler
		/// </summary>
		delegate void _WindowHandlerType(object window, object cell);

		/// <summary>
		/// OnClick += Function with EventHandlerType signature
		/// </summary>
		event _WindowHandlerType _OnClick
		{
			[InlineCode("{this}.$_window.attachEvent('onClick',{value})")]
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
		/// <summary>
		/// typedef an event handler
		/// </summary>
		public delegate void EventHandlerType(String id,String zoneId,object caState);

		/// <summary>
		/// OnClick += Function with EventHandlerType signature
		/// </summary>
		public event EventHandlerType OnClick
		{
			[InlineCode("{this}.attachEvent('onClick',{value})")]
			add { }
			remove { }
		}

		/// <param name="obj"></param>
		[InlineCode("new dhtmlXMenuObject({obj})")]
		public DHTMLXMenu(object obj) {}

		/// <summary>
		/// Add a separator
		/// </summary>
		/// <param name="id"></param>
		[InlineCode("{this}.addNewSeparator({id})")]
		public void AddSeparator(String id) {}
		
		[InlineCode("{this}.addNewSibling({parentId}, {id}, {caption}, {enabled})")]
		public void AddMenu(String parentId, String id, String caption, bool enabled) {}

		/// <summary>
		/// Adds a new dropdown item 
		/// </summary>
		/// <param name="parentId">ID of the parent menu</param>
		/// <param name="position">Zero indexed position</param>
		/// <param name="id">this menu items ID</param>
		/// <param name="text">Menu text</param>
		/// <param name="enabled">enabled or not</param>
		[InlineCode("{this}.addNewChild({parentId},{position},{id},{text},{enabled})")]
		public void AddMenuItem(String parentId, int position, String id, string text, bool enabled) { }

		/// <summary>
		/// Given a menuID return any parent ID or null
		/// </summary>
		/// <param name="menuId"></param>
		/// <returns></returns>
		/// JME audit:TBD
//		[InlineCode("{this}.getParentId({menuId})")]
		public static String GetParentId(String menuId) { return null; }
		

		/// <summary>
		/// Enable the menu
		/// </summary>
		/// <param name="menuId"></param>
		[InlineCode("{this}.setItemEnabled({menuId})")]
		public void EnableMenu(String menuId) {}

		/// <summary>
		/// Disable the menu
		/// </summary>
		/// <param name="menuId"></param>
		[InlineCode("{this}.setItemDisabled({menuId})")]
		public void DisableMenu(String menuId) {}

		/// <summary>
		/// Load a menu from an XML or other definition
		/// </summary>
		/// <param name="menuDefinition"></param>
		[InlineCode("{this}.loadStruct({menuDefinition})")]
		public void Load(string menuDefinition) {}
	}


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
