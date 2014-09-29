(function() {
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXCell
	var $DHTMLXSharp_$DHTMLXCell = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXGrid
	var $DHTMLXSharp_$DHTMLXGrid = function(parent) {
		this.$_layout = null;
		this.$_layout = parent.attachGrid();
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXLayout
	var $DHTMLXSharp_$DHTMLXLayout = function(el, format) {
		this.$_layout = null;
		var formatString = { $: '1C' };
		if ($DHTMLXSharp_$DHTMLXLayout.$formats.get_count() === 0) {
			$DHTMLXSharp_$DHTMLXLayout.$formats.add(0, '1C');
			$DHTMLXSharp_$DHTMLXLayout.$formats.add(1, '2E');
			$DHTMLXSharp_$DHTMLXLayout.$formats.add(2, '2U');
			$DHTMLXSharp_$DHTMLXLayout.$formats.add(3, '3L');
			$DHTMLXSharp_$DHTMLXLayout.$formats.add(4, '3U');
		}
		$DHTMLXSharp_$DHTMLXLayout.$formats.tryGetValue(format, formatString);
		this.$_layout = new dhtmlXLayoutObject(el, formatString.$);
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXLayout.Format
	var $DHTMLXSharp_$DHTMLXLayout$Format = function() {
	};
	$DHTMLXSharp_$DHTMLXLayout$Format.prototype = { $e1C: 0, $e2E: 1, $e2U: 2, $e3L: 3, $e3U: 4 };
	ss.registerEnum(null, 'DHTMLXSharp.$DHTMLXLayout$Format', $DHTMLXSharp_$DHTMLXLayout$Format, false);
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXMenu
	var $DHTMLXSharp_$DHTMLXMenu = function(parent) {
		this.$_menu = null;
		this.$_menu = parent.attachMenu();
	};
	$DHTMLXSharp_$DHTMLXMenu.prototype = {
		remove_$onClick: function(value) {
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXStatusBar
	var $DHTMLXSharp_$DHTMLXStatusBar = function(parent) {
		this.$_layout = null;
		this.$_layout = parent.attachStatusBar();
	};
	$DHTMLXSharp_$DHTMLXStatusBar.prototype = {
		set_$text: function(value) {
			this.$_layout.setText(value);
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXToolbar
	var $DHTMLXSharp_$DHTMLXToolbar = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXToolBar
	var $DHTMLXSharp_$DHTMLXToolBar = function(parent) {
		this.$_layout = null;
		this.$_layout = parent.attachToolbar();
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXTreeGrid
	var $DHTMLXSharp_$DHTMLXTreeGrid = function(parent, settings) {
		this.$_layout = null;
		//
		this.$_layout = parent.attachGrid();
		if (ss.isValue(this.$_layout) && ss.isValue(settings)) {
			this.$_layout.loadXML(settings.content_url);
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXWindow
	var $DHTMLXSharp_$DHTMLXWindow = function(parent, id, x, y, width, height, layout) {
		this.$_window = null;
		this.$_form = null;
		this.$1$OnClickField = null;
		// set up the window
		this.$_window = parent.createWindow(id, x, y, width, height);
		if (ss.isValue(layout)) {
			// set up the form
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
		set_$center: function(value) {
			if (ss.isValue(this.$_window)) {
				this.$_window.center();
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
	// DHTMLXSharp.DHTMLXTreeGridSettings
	var $DHTMLXSharp_DHTMLXTreeGridSettings = function() {
	};
	$DHTMLXSharp_DHTMLXTreeGridSettings.createInstance = function() {
		return $DHTMLXSharp_DHTMLXTreeGridSettings.$ctor();
	};
	$DHTMLXSharp_DHTMLXTreeGridSettings.$ctor = function() {
		var $this = {};
		$this.image_path = null;
		$this.column_text = null;
		$this.column_widths = null;
		$this.column_types = null;
		$this.skin = null;
		$this.content_url = null;
		return $this;
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.main
	var $DHTMLXSharp_main = function() {
		this.$wf = null;
		this.$win = null;
		this.$layout = null;
		this.$main_menu = null;
		this.$grid = null;
		this.$tree_grid = null;
		this.$status_bar = null;
		this.$tool_bar = null;
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
					this.$win.set_$center(true);
					this.$win.set_$visible(true);
				}
			}
			else if (id === 'Form_Show_Modal') {
				if (ss.isValue(this.$win)) {
					//win.Text = id;
					this.$win.set_$center(true);
					this.$win.set_$visible(true);
					this.$win.set_$modal(true);
				}
			}
			else if (id === 'Tree_Load_Local') {
				this.$grid.$_layout.load('./data/data.json', 'json');
			}
			else if (id === 'Tree_Load_Remote') {
				this.$grid.$_layout.load('http://localhost:8888/ajax');
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
			this.$layout = new $DHTMLXSharp_$DHTMLXLayout(document.body, 0);
			// this is transient and obeys C# scoping
			var cell = this.$layout.$_layout.cells('a');
			//
			this.$status_bar = new $DHTMLXSharp_$DHTMLXStatusBar(cell);
			this.$status_bar.set_$text('Connected to localhost:8888');
			this.$tool_bar = new $DHTMLXSharp_$DHTMLXToolBar(cell);
			this.$tool_bar.$_layout.setIconsPath('data/imgs/');
			this.$tool_bar.$_layout.loadStruct('data/toolbar.xml');
			var settings = $DHTMLXSharp_DHTMLXTreeGridSettings.$ctor();
			settings.column_types = 'tree,ed,txt,ch,ch';
			settings.column_widths = '150,100,100,100,100';
			settings.column_text = 'Tree,Plain Text,Long Text,Color,Checkbox';
			settings.content_url = 'data/treegrid.xml';
			this.$tree_grid = new $DHTMLXSharp_$DHTMLXTreeGrid(cell, settings);
			//
			this.$main_menu = new $DHTMLXSharp_$DHTMLXMenu(cell);
			//
			if (ss.isValue(this.$main_menu)) {
				this.$main_menu.$_menu.addNewSibling(null, 'Tree', 'Tree', false);
				this.$main_menu.$_menu.addNewChild('Tree', 0, 'Tree_Load_Local', 'Load Tree from Assets...', false);
				this.$main_menu.$_menu.addNewChild('Tree', 1, 'Tree_Load_Remote', 'Load Tree from Server...', false);
				this.$main_menu.$_menu.addNewSibling(null, 'Form', 'Form', false);
				this.$main_menu.$_menu.addNewChild('Form', 0, 'Form_Show', 'Show Form...', false);
				this.$main_menu.$_menu.addNewChild('Form', 1, 'Form_Show_Modal', 'Show Modal Form...', false);
				//			main_menu.Load("data/menu.xml");
				// menus get built in reverse. imagine push_back ...
				this.$main_menu.$_menu.addNewSibling(null, 'Server', 'Server', false);
				this.$main_menu.$_menu.addNewChild('Server', 0, 'Server_Ajax', 'Make AJAX call...', false);
				this.$main_menu.$_menu.addNewChild('Server', 1, 'Server_JSON', 'To JSON string...', false);
				this.$main_menu.$_menu.addNewSibling(null, 'file', 'File', false);
				this.$main_menu.$_menu.addNewChild('file', 0, 'open', 'Open', false);
				this.$main_menu.$_menu.addNewChild('file', 1, 'new', 'New', false);
				this.$main_menu.$_menu.addNewChild('file', 2, 'exit', 'Exit', false);
				this.$main_menu.$_menu.addNewSeparator('new');
				this.$main_menu.$_menu.attachEvent('onClick', ss.mkdel(this, this.$onMenuClick));
			}
			var flayout = Mapper['formLayout'];
			//
			this.$wf = $DHTMLXSharp_$DHTMLXWindowFactory.get_$instance();
			// create the Window factory
			//win = wf.Create("Window",60,60,640,480);
			this.$win = new $DHTMLXSharp_$DHTMLXWindow(this.$wf, 'Window', 60, 60, 320, 240, flayout);
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
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXGrid', $DHTMLXSharp_$DHTMLXGrid);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXLayout', $DHTMLXSharp_$DHTMLXLayout);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXMenu', $DHTMLXSharp_$DHTMLXMenu);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXStatusBar', $DHTMLXSharp_$DHTMLXStatusBar);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXToolbar', $DHTMLXSharp_$DHTMLXToolbar);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXToolBar', $DHTMLXSharp_$DHTMLXToolBar);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXTreeGrid', $DHTMLXSharp_$DHTMLXTreeGrid);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXWindow', $DHTMLXSharp_$DHTMLXWindow);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXWindowFactory', $DHTMLXSharp_$DHTMLXWindowFactory);
	ss.registerClass(null, 'DHTMLXSharp.$NativeCode', $DHTMLXSharp_$NativeCode);
	ss.registerClass(null, 'DHTMLXSharp.$Test', $DHTMLXSharp_$Test);
	ss.registerClass(global, 'DHTMLXSharp.DHTMLXTreeGridSettings', $DHTMLXSharp_DHTMLXTreeGridSettings);
	ss.registerClass(global, 'DHTMLXSharp.main', $DHTMLXSharp_main);
	ss.registerClass(global, 'DHTMLXSharp.main$JSONThing', $DHTMLXSharp_main$JSONThing);
	$DHTMLXSharp_$DHTMLXLayout.$formats = new (ss.makeGenericType(ss.Dictionary$2, [$DHTMLXSharp_$DHTMLXLayout$Format, String]))();
	$DHTMLXSharp_$DHTMLXWindowFactory.$_factory = null;
	$DHTMLXSharp_main.$main();
})();
