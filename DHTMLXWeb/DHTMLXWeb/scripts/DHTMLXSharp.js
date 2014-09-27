(function() {
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXCell
	var $DHTMLXSharp_$DHTMLXCell = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXLayoutObject
	var $DHTMLXSharp_$DHTMLXLayoutObject = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXMenu
	var $DHTMLXSharp_$DHTMLXMenu = function() {
	};
	$DHTMLXSharp_$DHTMLXMenu.prototype = {
		remove_$onClick: function(value) {
		}
	};
	$DHTMLXSharp_$DHTMLXMenu.$getParentId = function(menuId) {
		return null;
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXToolbar
	var $DHTMLXSharp_$DHTMLXToolbar = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXTreeGrid
	var $DHTMLXSharp_$DHTMLXTreeGrid = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXWindow
	var $DHTMLXSharp_$DHTMLXWindow = function(parent, id, x, y, width, height, layout) {
		this.$_window = null;
		this.$_form = null;
		this.$1$OnClickField = null;
		this.$_window = parent.createWindow(id, x, y, width, height);
		if (ss.isValue(layout)) {
			this.$_form = this.$_window.attachForm(layout);
			this.$_form.attachEvent('onButtonClick', ss.mkdel(this, this.$_OnInternalClick));
		}
	};
	$DHTMLXSharp_$DHTMLXWindow.prototype = {
		$getData: function() {
			return this.$_form.getFormData();
		},
		remove_$_FormClickHandler: function(value) {
		},
		set_$text: function(value) {
			if (ss.isValue(this.$_window)) {
				this.$_window.setText(value);
			}
		},
		set_$visible: function(value) {
			if (ss.isValue(this.$_window)) {
				if (value === true) {
					this.$_window.show();
				}
				else {
					this.$_window.hide();
					this.$_window.setModal(false);
				}
			}
		},
		set_$modal: function(value) {
			if (ss.isValue(this.$_window)) {
				this.$_window.setModal(value);
			}
		},
		remove_$_OnClick: function(value) {
		},
		add_$onClick: function(value) {
			this.$1$OnClickField = ss.delegateCombine(this.$1$OnClickField, value);
		},
		remove_$onClick: function(value) {
			this.$1$OnClickField = ss.delegateRemove(this.$1$OnClickField, value);
		},
		$_OnInternalClick: function(arg) {
			// forward to external delegate
			if (!ss.staticEquals(this.$1$OnClickField, null)) {
				// this means we know which Window instance and which button
				this.$1$OnClickField(this, arg);
			}
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXWindowFactory
	var $DHTMLXSharp_$DHTMLXWindowFactory = function() {
	};
	$DHTMLXSharp_$DHTMLXWindowFactory.$attach = function() {
		if (ss.isNullOrUndefined($DHTMLXSharp_$DHTMLXWindowFactory.$_factory)) {
			$DHTMLXSharp_$DHTMLXWindowFactory.$_factory = new dhtmlXWindows();
		}
		return $DHTMLXSharp_$DHTMLXWindowFactory.$_factory;
	};
	$DHTMLXSharp_$DHTMLXWindowFactory.get_$instance = function() {
		return $DHTMLXSharp_$DHTMLXWindowFactory.$attach();
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.NativeCode
	var $DHTMLXSharp_$NativeCode = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.Test
	var $DHTMLXSharp_$Test = function(s) {
		this.$_s = null;
		this.$_s = s;
	};
	$DHTMLXSharp_$Test.prototype = {
		$value: function() {
			return this.$_s;
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.main
	var $DHTMLXSharp_main = function() {
		this.$wf = null;
		this.$win = null;
		this.$layout = null;
		this.$main_menu = null;
		this.$tree_grid = null;
		this.$json_layout = null;
	};
	$DHTMLXSharp_main.prototype = {
		onJSONSuccess: function(data, textStatus, request) {
			var s = data.toString();
			window.alert(s);
		},
		onJSONError: function(request, textStatus, error) {
			var s = textStatus.toString();
			window.alert(s);
		},
		sendJSONviaAJAX: function(data) {
			var mapper = {};
			mapper['key'] = data;
			var opts = { url: 'http://localhost:8888/ajax', type: 'POST', dataType: 'json', async: true, success: ss.mkdel(this, this.onJSONSuccess), error: ss.mkdel(this, this.onJSONError) };
			opts.data = mapper;
			//
			//((dynamic)opts).Data = mapper.ToString();
			// make the request
			var req = $.ajax(opts);
		},
		$onButtonClicked: function(window, name) {
			if (name === 'save') {
				//			string s = ;
				this.sendJSONviaAJAX(window.$getData());
			}
			window.set_$visible(false);
		},
		$onMenuClick: function(id, zoneId, caState) {
			var s;
			if (id === 'Server_JSON') {
				var js = $DHTMLXSharp_main$JSONThing.$ctor();
				js.FName = 'Hello';
				js.LName = 'World';
				s = $.toJSON(js);
				if (s.length > 0) {
					window.alert(s);
				}
				//
				var js2 = $.parseJSON(s);
				//
				if (ss.isNullOrUndefined(js2)) {
				}
			}
			else if (id === 'Server_Ajax') {
				// set up the AJAX options
				//jQueryAjaxOptions opts = new jQueryAjaxOptio
				var js1 = $DHTMLXSharp_main$JSONThing.$ctor();
				js1.FName = 'Hello';
				js1.LName = 'World';
				var mapper = {};
				mapper['key'] = js1;
				var opts = { url: 'http://localhost:8888/ajax', dataType: 'json', async: true, success: ss.mkdel(this, this.onJSONSuccess), error: ss.mkdel(this, this.onJSONError) };
				opts.data = mapper;
				//
				var a = [js1];
				//
				opts.data = a;
				//
				opts.type = 'POST';
				//
				//((dynamic)opts).Data = mapper.ToString();
				// make the request
				var req = $.ajax(opts);
			}
			else if (id === 'Form_Show') {
				if (ss.isValue(this.$win)) {
					//win.Text = id;
					this.$win.set_$visible(true);
				}
			}
			else if (id === 'Form_Show_Modal') {
				if (ss.isValue(this.$win)) {
					//win.Text = id;
					this.$win.set_$visible(true);
					this.$win.set_$modal(true);
				}
			}
		},
		$onButtonClick: function(window, cell) {
			window.alert('OnButtonClick');
		},
		onAjaxCallback: function(data) {
		},
		$onFormButtonClick: function(sender) {
			window.alert(' OnFormButtonClick ' + sender.toString());
		},
		$attach: function() {
			//
			init();
			//NativeCode.InitializeDHTMLX();
			//
			this.$layout = new dhtmlXLayoutObject(document.body, '1C');
			// this is transient and obeys C# scoping
			var cell = this.$layout.cells('a');
			//
			this.$tree_grid = cell.attachGrid();
			if (ss.isValue(this.$tree_grid)) {
				//			tree_grid.LoadXML("data/treegrid.xml");
				this.$tree_grid.setHeader('Text,Filter1,Filter2,Filter3');
				this.$tree_grid.setInitWidths('100,80,80,80');
				this.$tree_grid.init();
				this.$tree_grid.addRow(0, 'Row 0', 0);
				this.$tree_grid.addRow(1, 'Row 1', 1);
				this.$tree_grid.addRow(2, 'Row 2', 2);
				this.$tree_grid.addRow(3, 'Row 4', 3);
				this.$tree_grid.addRow(4, 'Row 5', 4);
				this.$tree_grid.addRow(5, 'Row 6', 5);
			}
			//
			this.$main_menu = cell.attachMenu();
			//
			if (ss.isValue(this.$main_menu)) {
				this.$main_menu.addNewSibling(null, 'Form', 'Form', false);
				this.$main_menu.addNewChild('Form', 0, 'Form_Show', 'Show Form...', false);
				this.$main_menu.addNewChild('Form', 1, 'Form_Show_Modal', 'Show Modal Form...', false);
				//			main_menu.Load("data/menu.xml");
				// menus get built in reverse. imagine push_back ...
				this.$main_menu.addNewSibling(null, 'Server', 'Server', false);
				this.$main_menu.addNewChild('Server', 0, 'Server_Ajax', 'Make AJAX call...', false);
				this.$main_menu.addNewChild('Server', 1, 'Server_JSON', 'To JSON string...', false);
				this.$main_menu.addNewSibling(null, 'file', 'File', false);
				this.$main_menu.addNewChild('file', 0, 'open', 'Open', false);
				this.$main_menu.addNewChild('file', 1, 'new', 'New', false);
				this.$main_menu.addNewChild('file', 2, 'exit', 'Exit', false);
				this.$main_menu.addNewSeparator('new');
				this.$main_menu.attachEvent('onClick', ss.mkdel(this, this.$onMenuClick));
			}
			var flayout = Mapper['formLayout'];
			//
			this.$wf = $DHTMLXSharp_$DHTMLXWindowFactory.get_$instance();
			// create the Window factory
			//win = wf.Create("Window",60,60,640,480);
			this.$win = new $DHTMLXSharp_$DHTMLXWindow(this.$wf, 'Window', 60, 60, 640, 480, flayout);
			this.$win.set_$visible(false);
			this.$win.set_$text('Popup Window with embedded form');
			this.$win.add_$onClick(ss.mkdel(this, this.$onButtonClicked));
			// do some AJAxing at startup
			var opts = { url: 'http://localhost:8888/data/form1.json', dataType: 'json', async: true };
			// make the request
			var req = $.ajax(opts);
			// on success ...
			req.success(ss.mkdel(this, function(data) {
				this.$json_layout = data;
			}));
		}
	};
	$DHTMLXSharp_main.$main = function() {
		var $t1 = new $DHTMLXSharp_main();
		$(ss.mkdel($t1, $t1.$attach));
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.main.JSONThing
	var $DHTMLXSharp_main$JSONThing = function() {
	};
	$DHTMLXSharp_main$JSONThing.createInstance = function() {
		return $DHTMLXSharp_main$JSONThing.$ctor();
	};
	$DHTMLXSharp_main$JSONThing.$ctor = function() {
		var $this = {};
		$this.FName = null;
		$this.LName = null;
		return $this;
	};
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXCell', $DHTMLXSharp_$DHTMLXCell);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXLayoutObject', $DHTMLXSharp_$DHTMLXLayoutObject);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXMenu', $DHTMLXSharp_$DHTMLXMenu);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXToolbar', $DHTMLXSharp_$DHTMLXToolbar);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXTreeGrid', $DHTMLXSharp_$DHTMLXTreeGrid);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXWindow', $DHTMLXSharp_$DHTMLXWindow);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXWindowFactory', $DHTMLXSharp_$DHTMLXWindowFactory);
	ss.registerClass(null, 'DHTMLXSharp.$NativeCode', $DHTMLXSharp_$NativeCode);
	ss.registerClass(null, 'DHTMLXSharp.$Test', $DHTMLXSharp_$Test);
	ss.registerClass(global, 'DHTMLXSharp.main', $DHTMLXSharp_main);
	ss.registerClass(global, 'DHTMLXSharp.main$JSONThing', $DHTMLXSharp_main$JSONThing);
	$DHTMLXSharp_$DHTMLXWindowFactory.$_factory = null;
	$DHTMLXSharp_main.$main();
})();
