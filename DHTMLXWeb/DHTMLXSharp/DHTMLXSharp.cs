using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jQueryApi;

namespace DHTMLXSharp
{
public class DHTMLXSharp
{
	private MessageShower ms = null;

	private void Attach()
	{
		// new MessageShower("showMessage", "messageContainer").Attach();
		ms = new MessageShower("showMessage", "messageContainer");
		ms.Attach();
		new MessageFlasher("flashMessage", "messageContainer").Attach();
	}

	static void Main()
	{
		jQuery.OnDocumentReady(new DHTMLXSharp().Attach);
	}
}
}