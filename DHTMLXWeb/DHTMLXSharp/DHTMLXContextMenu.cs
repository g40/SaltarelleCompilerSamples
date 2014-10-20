using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using jQueryApi;

namespace DHTMLXSharp
{
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
		/*public*/
		void _SetIconPath(String url) { }

		[InlineCode("{this}.$_instance.loadStruct({menuDefinition})")]
		public void Load(string menuDefinition) { }

		[InlineCode("{this}.$_instance.addContextZone({zone})")]
		public void AddContextMenuZone(String zone) { }
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

}
