using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace DHTMLXSharp
{
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

		[InlineCode("{this}.$_instance.entBox.id={zone}")]
		public void AddContextMenuZone(String zone) { }

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
				int srcColumn = (int)sColumn;
				int dstColumn = (int)dColumn;
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
		public int GetRowCount() { return (int)_GetRowCount(); }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		[InlineCode("{this}.$_instance.getRowId({index})")]
		object _GetRowId(int index) { return null; }

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
		public DHTMLXTreeGrid(DHTMLXCell parent, DHTMLXTreeGridSettings settings)
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
		public DHTMLXTreeGrid(DHTMLXCell parent, String url)
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
		public DHTMLXTreeGrid(DHTMLXTab parent, String url)
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
		public DHTMLXGridCell Cells(String row_id, int column) { return null; }

		/// <summary>
		/// Clear the grid, keep the header
		/// </summary>
		[InlineCode("{this}.$_instance.clearAll()")]
		public void ClearContent() { }

		/// <summary>
		/// 
		/// </summary>
		[InlineCode("{this}.$_instance.deleteSelectedRows()")]
		public void Cut() { }

		/// <summary>
		/// 
		/// </summary>
		[InlineCode("{this}.$_instance.selectAll()")]
		public void SelectAll() { }

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
}
