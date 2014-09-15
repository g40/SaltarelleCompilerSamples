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

	class DHTMLXToolbar
	{

	}

	class DHTMLXWindowFactory
	{
		/// <summary>
		/// We need a singleton here
		/// </summary>
		[InlineCode("new dhtmlXWindows()")]
		public DHTMLXWindowFactory () { }
	}
	
	class DHTMLXWindow
	{
		/// <summary>
		/// Create a new window from the factory instance
		/// </summary>
		/// <param name="wf"></param>
		/// <param name="id"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="width"></param>
		/// <param name="height"></param>
		[InlineCode("{wf}.createWindow({id},{x},{y},{width},{height})")]
		public DHTMLXWindow(DHTMLXWindowFactory wf,string id, int x, int y, int width, int height) { }

		[InlineCode("{this}.setText({text})")]
		public void SetText(string text) { }

		/// <summary>
		/// typedef an event handler
		/// </summary>
		public delegate void EventHandlerType(object window,object cell);

		/// <summary>
		/// OnClick += Function with EventHandlerType signature
		/// </summary>
		public event EventHandlerType OnClick
		{
			[InlineCode("{this}.attachEvent('onClick',{value})")]
			add { }
			remove { }
		}
	}

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
	}
}
