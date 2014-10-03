(function() {
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXCell
	var $DHTMLXSharp_$DHTMLXCell = function(obj) {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXCombo
	var $DHTMLXSharp_$DHTMLXCombo = function() {
		this.$_instance = null;
	};
	$DHTMLXSharp_$DHTMLXCombo.prototype = {
		get_$instance: function() {
			return this.$_instance;
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXContextMenu
	var $DHTMLXSharp_$DHTMLXContextMenu = function(iconURL) {
		this.$_instance = null;
		this.$_instance = new dhtmlXMenuObject();
		if (ss.isValue(this.$_instance)) {
			this.$_instance.setIconsPath(iconURL);
			this.$_instance.renderAsContextMenu();
		}
	};
	$DHTMLXSharp_$DHTMLXContextMenu.prototype = {
		remove_$onClick: function(value) {
		},
		get_$instance: function() {
			return this.$_instance;
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXGrid
	var $DHTMLXSharp_$DHTMLXGrid = function(parent) {
		this.$_instance = null;
		this.$_instance = parent.attachGrid();
	};
	$DHTMLXSharp_$DHTMLXGrid.prototype = {
		$enableDragDrop: function() {
			this.$_instance.enableDragAndDrop(true, true);
			this.$_instance.enableMercyDrag(true);
		},
		set_$enableMultipleSelection: function(value) {
			if (ss.isValue(this.get_$instance())) {
				this.$_instance.enableMultiselect(value);
			}
		},
		remove_$_DragDropHandler: function(value) {
		},
		$setContextMenu: function(menu) {
			this.$_instance.enableContextMenu(menu.get_$instance());
		},
		get_$instance: function() {
			return this.$_instance;
		}
	};
	$DHTMLXSharp_$DHTMLXGrid.$ctor1 = function(parent) {
		this.$_instance = null;
		this.$_instance = parent.attachGrid();
	};
	$DHTMLXSharp_$DHTMLXGrid.$ctor1.prototype = $DHTMLXSharp_$DHTMLXGrid.prototype;
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXGridCell
	var $DHTMLXSharp_$DHTMLXGridCell = function(obj) {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXLayout
	var $DHTMLXSharp_$DHTMLXLayout = function(parent, format) {
		this.$_instance = null;
		this.$_Initialize(parent, format);
	};
	$DHTMLXSharp_$DHTMLXLayout.prototype = {
		$_Initialize: function(parent, format) {
			var formatString = { $: '1C' };
			if ($DHTMLXSharp_$DHTMLXLayout.$formats.get_count() === 0) {
				$DHTMLXSharp_$DHTMLXLayout.$formats.add(0, '1C');
				$DHTMLXSharp_$DHTMLXLayout.$formats.add(1, '2E');
				$DHTMLXSharp_$DHTMLXLayout.$formats.add(2, '2U');
				$DHTMLXSharp_$DHTMLXLayout.$formats.add(3, '3J');
				$DHTMLXSharp_$DHTMLXLayout.$formats.add(4, '3L');
				$DHTMLXSharp_$DHTMLXLayout.$formats.add(5, '3U');
			}
			$DHTMLXSharp_$DHTMLXLayout.$formats.tryGetValue(format, formatString);
			this.$_instance = new dhtmlXLayoutObject(parent, formatString.$);
		}
	};
	$DHTMLXSharp_$DHTMLXLayout.$ctor1 = function(parent, format) {
		this.$_instance = null;
		this.$_Initialize(parent, format);
	};
	$DHTMLXSharp_$DHTMLXLayout.$ctor1.prototype = $DHTMLXSharp_$DHTMLXLayout.prototype;
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXLayout.Format
	var $DHTMLXSharp_$DHTMLXLayout$Format = function() {
	};
	$DHTMLXSharp_$DHTMLXLayout$Format.prototype = { $e1C: 0, $e2E: 1, $e2U: 2, $e3J: 3, $e3L: 4, $e3U: 5 };
	ss.registerEnum(null, 'DHTMLXSharp.$DHTMLXLayout$Format', $DHTMLXSharp_$DHTMLXLayout$Format, false);
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXMenu
	var $DHTMLXSharp_$DHTMLXMenu = function(parent) {
		this.$_instance = null;
		this.$_instance = parent.attachMenu();
	};
	$DHTMLXSharp_$DHTMLXMenu.prototype = {
		remove_$onClick: function(value) {
		},
		get_$instance: function() {
			return this.$_instance;
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXStatusBar
	var $DHTMLXSharp_$DHTMLXStatusBar = function(parent) {
		this.$_instance = null;
		this.$_instance = parent.attachStatusBar();
	};
	$DHTMLXSharp_$DHTMLXStatusBar.prototype = {
		set_$text: function(value) {
			this.$_instance.setText(value);
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXTab
	var $DHTMLXSharp_$DHTMLXTab = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXTabBar
	var $DHTMLXSharp_$DHTMLXTabBar = function(parent) {
		this.$_instance = null;
		this.$_instance = parent.attachTabbar();
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXToolBar
	var $DHTMLXSharp_$DHTMLXToolBar = function(parent) {
		this.$_instance = null;
		this.$_instance = parent.attachToolbar();
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXTreeGrid
	var $DHTMLXSharp_$DHTMLXTreeGrid = function(parent, settings) {
		this.$_instance = null;
		this.$1$OnDragDropField = null;
		//
		this.$_instance = parent.attachGrid();
		if (ss.isValue(this.$_instance) && ss.isValue(settings)) {
			this.$_instance.loadXML(settings.content_url);
		}
		//
		this.$_instance.attachEvent('onDrag', ss.mkdel(this, this.$_ForwardDragDropHandler));
	};
	$DHTMLXSharp_$DHTMLXTreeGrid.prototype = {
		$setContextMenu: function(menu) {
			this.$_instance.enableContextMenu(menu.get_$instance());
		},
		$enableDragDrop: function() {
			this.$_instance.enableDragAndDrop(true, true);
			this.$_instance.enableMercyDrag(true);
		},
		set_$multipleSelection: function(value) {
			if (ss.isValue(this.get_$instance())) {
				this.$_instance.enableMultiselect(value);
			}
		},
		remove_$_DragDropHandler: function(value) {
		},
		$_ForwardDragDropHandler: function(sID, dID, srcWidget, dstWidget, sColumn, dColumn) {
			var ret = true;
			if (!ss.staticEquals(this.$1$OnDragDropField, null) && ss.isValue(sID) && ss.isValue(dID) && ss.isValue(sColumn) && ss.isValue(dColumn)) {
				var srcID = ss.safeCast(sID, String);
				var srcIDs = srcID.split(String.fromCharCode(44));
				var dstID = ss.safeCast(dID, String);
				var srcColumn = ss.Nullable.unbox(ss.cast(sColumn, ss.Int32));
				var dstColumn = ss.Nullable.unbox(ss.cast(dColumn, ss.Int32));
				ret = this.$1$OnDragDropField(srcIDs, dstID, srcWidget, dstWidget, srcColumn, dstColumn);
			}
			return ret;
		},
		add_$onDragDrop: function(value) {
			this.$1$OnDragDropField = ss.delegateCombine(this.$1$OnDragDropField, value);
		},
		remove_$onDragDrop: function(value) {
			this.$1$OnDragDropField = ss.delegateRemove(this.$1$OnDragDropField, value);
		},
		get_$instance: function() {
			return this.$_instance;
		}
	};
	$DHTMLXSharp_$DHTMLXTreeGrid.$ctor1 = function(parent, url) {
		this.$_instance = null;
		this.$1$OnDragDropField = null;
		//
		this.$_instance = parent.attachGrid();
		if (ss.isValue(this.$_instance) && ss.isValue(url)) {
			this.$_instance.loadXML(url);
		}
		//
		this.$_instance.attachEvent('onDrag', ss.mkdel(this, this.$_ForwardDragDropHandler));
	};
	$DHTMLXSharp_$DHTMLXTreeGrid.$ctor2 = function(parent, url) {
		this.$_instance = null;
		this.$1$OnDragDropField = null;
		//
		this.$_instance = parent.attachGrid();
		if (ss.isValue(this.$_instance) && ss.isValue(url)) {
			this.$_instance.loadXML(url);
		}
		//
		this.$_instance.attachEvent('onDrag', ss.mkdel(this, this.$_ForwardDragDropHandler));
	};
	$DHTMLXSharp_$DHTMLXTreeGrid.$ctor1.prototype = $DHTMLXSharp_$DHTMLXTreeGrid.$ctor2.prototype = $DHTMLXSharp_$DHTMLXTreeGrid.prototype;
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
			this.$_window.attachEvent('onClose', ss.mkdel(this, this.$_OnInternalClick));
		}
	};
	$DHTMLXSharp_$DHTMLXWindow.prototype = {
		$getData: function() {
			return this.$_form.getFormData();
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
		$showModal: function() {
			if (ss.isValue(this.$_window)) {
				this.$_window.setModal(true);
				this.$_window.center();
				this.$_window.show();
			}
		},
		set_$modal: function(value) {
			if (ss.isValue(this.$_window)) {
				this.$_window.setModal(value);
			}
		},
		remove_$_FormClickHandler: function(value) {
		},
		remove_$_WindowClickHandler: function(value) {
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
		this.$catalog = null;
		this.$grid_results = null;
		this.$base_filters = null;
		this.$tree_filters = null;
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
			//
			console.log('OnButtonClicked => ' + name);
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
				this.$grid_results.$_instance.load('./data/data.json', 'json');
			}
			else if (id === 'Tree_Load_Remote') {
				this.$grid_results.$_instance.load('http://localhost:8888/ajax');
			}
		},
		$gridDragDropHandler: function(srcIDs, dstID, srcWidget, dstWidget, srcColumn, dstColumn) {
			if (ss.referenceEquals(srcWidget, dstWidget)) {
				console.log('Source is grid');
			}
			if (ss.referenceEquals(dstWidget, this.$base_filters.get_$instance())) {
				console.log('Dest is base filters');
			}
			else if (ss.referenceEquals(dstWidget, this.$tree_filters.get_$instance())) {
				console.log('Dest is tree filters');
			}
			//return true;
			return !ss.referenceEquals(srcWidget, dstWidget);
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
			this.$layout = new $DHTMLXSharp_$DHTMLXLayout.$ctor1(document.body, 0);
			// this is transient and obeys C# scoping
			var main_cell = this.$layout.$_instance.cells('a');
			main_cell.hideHeader();
			//
			this.$status_bar = new $DHTMLXSharp_$DHTMLXStatusBar(main_cell);
			this.$status_bar.set_$text('Connected to localhost:8888');
			this.$tool_bar = new $DHTMLXSharp_$DHTMLXToolBar(main_cell);
			this.$tool_bar.$_instance.setIconsPath('data/imgs/');
			this.$tool_bar.$_instance.loadStruct('data/toolbar.xml');
			//
			this.$main_menu = new $DHTMLXSharp_$DHTMLXMenu(main_cell);
			//
			if (ss.isValue(this.$main_menu)) {
				this.$main_menu.$_instance.addNewSibling(null, 'Tree', 'Tree', false);
				this.$main_menu.$_instance.addNewChild('Tree', 0, 'Tree_Load_Local', 'Load Tree from Assets...', false);
				this.$main_menu.$_instance.addNewChild('Tree', 1, 'Tree_Load_Remote', 'Load Tree from Server...', false);
				this.$main_menu.$_instance.addNewSibling(null, 'Form', 'Form', false);
				this.$main_menu.$_instance.addNewChild('Form', 0, 'Form_Show', 'Show Form...', false);
				this.$main_menu.$_instance.addNewChild('Form', 1, 'Form_Show_Modal', 'Show Modal Form...', false);
				//			main_menu.Load("data/menu.xml");
				// menus get built in reverse. imagine push_back ...
				this.$main_menu.$_instance.addNewSibling(null, 'Server', 'Server', false);
				this.$main_menu.$_instance.addNewChild('Server', 0, 'Server_Ajax', 'Make AJAX call...', false);
				this.$main_menu.$_instance.addNewChild('Server', 1, 'Server_JSON', 'To JSON string...', false);
				this.$main_menu.$_instance.addNewSibling(null, 'file', 'File', false);
				this.$main_menu.$_instance.addNewChild('file', 0, 'open', 'Open', false);
				this.$main_menu.$_instance.addNewChild('file', 1, 'new', 'New', false);
				this.$main_menu.$_instance.addNewChild('file', 2, 'exit', 'Exit', false);
				this.$main_menu.$_instance.addNewSeparator('new');
				this.$main_menu.$_instance.attachEvent('onClick', ss.mkdel(this, this.$onMenuClick));
			}
			// set up left hand side
			var central_panel = new $DHTMLXSharp_$DHTMLXLayout(main_cell, 3);
			central_panel.$_instance.cells('a').hideHeader();
			central_panel.$_instance.cells('b').hideHeader();
			central_panel.$_instance.cells('c').hideHeader();
			//central_panel.Cells("c").SetText("Drag and drop from Catalog");
			var cell = central_panel.$_instance.cells('a');
			//---------------------------------------------------------------------------
			// bases tree
			cell = central_panel.$_instance.cells('a');
			this.$base_filters = new $DHTMLXSharp_$DHTMLXTreeGrid.$ctor1(cell, 'data/filter_bases.xml');
			this.$base_filters.$enableDragDrop();
			this.$base_filters.set_$multipleSelection(true);
			this.$base_filters.add_$onDragDrop(ss.mkdel(this, this.$gridDragDropHandler));
			// base tree context menu
			var menu = new $DHTMLXSharp_$DHTMLXContextMenu('data/imgs/');
			menu.$_instance.loadStruct('data/context_edit_menu.xml');
			this.$base_filters.$setContextMenu(menu);
			//---------------------------------------------------------------------------
			// filter tree
			cell = central_panel.$_instance.cells('c');
			this.$tree_filters = new $DHTMLXSharp_$DHTMLXTreeGrid.$ctor1(cell, 'data/tree_filter.xml');
			this.$tree_filters.$enableDragDrop();
			this.$tree_filters.set_$multipleSelection(true);
			this.$tree_filters.add_$onDragDrop(ss.mkdel(this, this.$filterTreeDragDropHandler));
			// filter tree context menu
			var ctx_tree_filters = new $DHTMLXSharp_$DHTMLXContextMenu('data/imgs/');
			ctx_tree_filters.$_instance.loadStruct('data/context_edit_menu.xml');
			this.$tree_filters.$setContextMenu(ctx_tree_filters);
			//---------------------------------------------------------------------------
			// Right-hand panel contains catalog/results/charts
			cell = central_panel.$_instance.cells('b');
			var right_panel = new $DHTMLXSharp_$DHTMLXLayout(cell, 0);
			var tabbar = new $DHTMLXSharp_$DHTMLXTabBar(right_panel.$_instance.cells('a'));
			tabbar.$_instance.addTab('Catalog', 'Catalog', 100);
			tabbar.$_instance.addTab('Results', 'Results', 100);
			tabbar.$_instance.addTab('Charts', 'Charts', 100);
			tabbar.$_instance.cells('Catalog').setActive();
			//---------------------------------------------------------------------------
			// Create the variable catalog
			var tab = tabbar.$_instance.cells('Catalog');
			this.$catalog = new $DHTMLXSharp_$DHTMLXTreeGrid.$ctor2(tab, 'data/catalog.xml');
			this.$catalog.$enableDragDrop();
			this.$catalog.set_$multipleSelection(true);
			// base tree context menu
			var ctx_catalog = new $DHTMLXSharp_$DHTMLXContextMenu('data/imgs/');
			ctx_catalog.$_instance.loadStruct('data/menu_ctx_catalog.xml');
			this.$catalog.$setContextMenu(ctx_catalog);
			//---------------------------------------------------------------------------
			tab = tabbar.$_instance.cells('Results');
			this.$grid_results = new $DHTMLXSharp_$DHTMLXGrid.$ctor1(tab);
			if (ss.isValue(this.$grid_results)) {
				this.$grid_results.$enableDragDrop();
				this.$grid_results.$_instance.setHeader('Text,Filter1,Filter2,Filter3');
				this.$grid_results.$_instance.setInitWidths('100,80,80,80');
				this.$grid_results.$_instance.init();
				this.$grid_results.$_instance.addRow(0, 'Row 0', 0);
				this.$grid_results.$_instance.addRow(1, 'Row 1', 1);
				this.$grid_results.$_instance.addRow(2, 'Row 2', 2);
				this.$grid_results.$_instance.addRow(3, 'Row 4', 3);
				this.$grid_results.$_instance.addRow(4, 'Row 5', 4);
				this.$grid_results.$_instance.addRow(5, 'Row 6', 5);
			}
			//---------------------------------------------------------------------------
			var flayout = Mapper['formLayout'];
			//
			this.$wf = $DHTMLXSharp_$DHTMLXWindowFactory.get_$instance();
			// create the Window factory
			//win = wf.Create("Window",60,60,640,480);
			this.$win = new $DHTMLXSharp_$DHTMLXWindow(this.$wf, 'Window', 60, 60, 400, 320, flayout);
			this.$win.set_$visible(false);
			this.$win.set_$text('Popup Window with embedded form');
			this.$win.add_$onClick(ss.mkdel(this, this.$onButtonClicked));
			//		win.ShowModal();
			// do some AJAxing at startup
			var opts = { url: 'http://localhost:8888/data/form1.json', dataType: 'json', async: true };
			// make the request
			var req = $.ajax(opts);
			// on success ...
			req.success(ss.mkdel(this, function(data) {
				this.$json_layout = data;
			}));
		},
		$filterTreeDragDropHandler: function(srcIDs, dstID, srcWidget, dstWidget, srcColumn, dstColumn) {
			if (ss.referenceEquals(srcWidget, dstWidget)) {
				console.log('Source == destination');
			}
			else if (ss.referenceEquals(srcWidget, this.$catalog.get_$instance()) && ss.referenceEquals(dstWidget, this.$tree_filters.get_$instance())) {
				if (dstColumn > 0) {
					var dstCell = this.$tree_filters.$_instance.cells(dstID, dstColumn);
					if (ss.isValue(dstCell)) {
						//
						var dv = dstCell.getValue({});
						//
						for (var s = 0; s < srcIDs.length; s++) {
							var srcCell = this.$catalog.$_instance.cells(srcIDs[s], srcColumn);
							dv += srcCell.getValue({});
							dv += ',';
						}
						//
						dstCell.setValue(dv);
						//
						return false;
					}
				}
			}
			return !ss.referenceEquals(srcWidget, dstWidget);
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
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXCombo', $DHTMLXSharp_$DHTMLXCombo);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXContextMenu', $DHTMLXSharp_$DHTMLXContextMenu);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXGrid', $DHTMLXSharp_$DHTMLXGrid);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXGridCell', $DHTMLXSharp_$DHTMLXGridCell);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXLayout', $DHTMLXSharp_$DHTMLXLayout);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXMenu', $DHTMLXSharp_$DHTMLXMenu);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXStatusBar', $DHTMLXSharp_$DHTMLXStatusBar);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXTab', $DHTMLXSharp_$DHTMLXTab);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXTabBar', $DHTMLXSharp_$DHTMLXTabBar);
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
