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
	$DHTMLXSharp_$DHTMLXToolBar.prototype = {
		remove_$onClick: function(value) {
		}
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
		$getRowCount: function() {
			return ss.Nullable.unbox(ss.cast(this.$_instance.getRowsNum(), ss.Int32));
		},
		$getRowId: function(index) {
			return ss.safeCast(this.$_instance.getRowId(index), String);
		},
		$getParentRowId: function(rowID) {
			var obj = this.$_instance.getParentId(rowID);
			return (ss.isNullOrUndefined(obj) ? null : ss.safeCast(obj, String));
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
	// DHTMLXSharp.SingleshotTimer
	var $DHTMLXSharp_$SingleshotTimer = function() {
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
	// DHTMLXSharp.WebSocket
	var $DHTMLXSharp_$WebSocket = function(url) {
		this.$_instance = null;
		this.$_connected = false;
		this.$1$OnConnectedField = null;
		this.$1$OnDisconnectedField = null;
		this.$1$OnDataReceivedField = null;
		this.$_instance = new WebSocket(url);
		if (ss.isValue(this.$_instance)) {
			this.$_instance.onopen = ss.mkdel(this, this.$webSocket_OnConnected);
			this.$_instance.onclose = ss.mkdel(this, this.$webSocket__OnDisconnected);
			this.$_instance.onmessage = ss.mkdel(this, this.$webSocket__OnDataReceived);
		}
	};
	$DHTMLXSharp_$WebSocket.prototype = {
		remove_$_OnDataReceived: function(value) {
		},
		remove_$_OnConnected: function(value) {
		},
		remove_$_OnDisconnected: function(value) {
		},
		add_$onConnected: function(value) {
			this.$1$OnConnectedField = ss.delegateCombine(this.$1$OnConnectedField, value);
		},
		remove_$onConnected: function(value) {
			this.$1$OnConnectedField = ss.delegateRemove(this.$1$OnConnectedField, value);
		},
		add_$onDisconnected: function(value) {
			this.$1$OnDisconnectedField = ss.delegateCombine(this.$1$OnDisconnectedField, value);
		},
		remove_$onDisconnected: function(value) {
			this.$1$OnDisconnectedField = ss.delegateRemove(this.$1$OnDisconnectedField, value);
		},
		add_$onDataReceived: function(value) {
			this.$1$OnDataReceivedField = ss.delegateCombine(this.$1$OnDataReceivedField, value);
		},
		remove_$onDataReceived: function(value) {
			this.$1$OnDataReceivedField = ss.delegateRemove(this.$1$OnDataReceivedField, value);
		},
		get_$connected: function() {
			return this.$_connected;
		},
		$webSocket__OnDataReceived: function(data) {
			if (!ss.staticEquals(this.$1$OnDataReceivedField, null)) {
				var content = data.data;
				this.$1$OnDataReceivedField(this, content);
			}
		},
		$webSocket__OnDisconnected: function() {
			console.log('WebSocket__OnDisconnected()');
			this.$_connected = false;
			if (!ss.staticEquals(this.$1$OnDisconnectedField, null)) {
				this.$1$OnDisconnectedField();
			}
		},
		$webSocket_OnConnected: function() {
			console.log('WebSocket_OnConnected()');
			this.$_connected = true;
			if (!ss.staticEquals(this.$1$OnConnectedField, null)) {
				this.$1$OnConnectedField();
			}
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
		this.$ws = null;
		this.$_queue = [];
	};
	$DHTMLXSharp_main.prototype = {
		onJSONSuccess: function(data, textStatus, request) {
			var s = data.toString();
			window.alert(s);
		},
		onCatalogSuccess: function(data, textStatus, request) {
			if (ss.isValue(data)) {
				//String xml = data as String;
				//NativeCode.Log(xml);
				this.$catalog.$_instance.clearAll();
				this.$catalog.$_instance.parse(data, 'xml');
				this.$status_bar.set_$text(ss.formatString('Loaded catalog from {0}{1}', $DHTMLXSharp_main.$g_http_url, '/ajax'));
			}
		},
		onCatalogError: function(request, textStatus, error) {
			var s = textStatus.toString();
			this.$status_bar.set_$text(s);
		},
		onJSONError: function(request, textStatus, error) {
			var s = 'unknown exception';
			if (ss.isValue(error)) {
				// s = error.Message;
			}
			this.$status_bar.set_$text(ss.formatString('{0} {1}', textStatus, s));
		},
		sendJSONviaAJAX: function(key, format, data_object) {
			var mapper = {};
			mapper[key] = data_object;
			var opts = { url: $DHTMLXSharp_main.$g_http_url + '/ajax', type: 'POST', dataType: format, async: true, success: ss.mkdel(this, this.onJSONSuccess), error: ss.mkdel(this, this.onJSONError) };
			opts.contentType = 'application/json';
			opts.data = mapper;
			//
			var req = $.ajax(opts);
			// on success ...
			req.success(ss.mkdel(this, function(data) {
				//NativeCode.Log("Posted data OK");
				this.$status_bar.set_$text(ss.formatString('Posted {0} to {1}', key, opts.url));
			}));
		},
		$onButtonClicked: function(window, name) {
			//
			console.log('OnButtonClicked => ' + name);
			window.set_$visible(false);
		},
		$onMenuClick: function(id, zoneId, caState) {
			if (id === 'Server_Catalog') {
				var opts = { url: $DHTMLXSharp_main.$g_http_url + '/ajax', dataType: 'xml', async: true, success: ss.mkdel(this, this.onCatalogSuccess), error: ss.mkdel(this, this.onCatalogError), type: 'GET' };
				var req = $.ajax(opts);
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
			this.$tool_bar.$_instance.attachEvent('onClick', ss.mkdel(this, this.$tool_bar_OnClick));
			//
			this.$main_menu = new $DHTMLXSharp_$DHTMLXMenu(main_cell);
			//
			if (ss.isValue(this.$main_menu)) {
				this.$main_menu.$_instance.addNewSibling(null, 'Tree', 'Tree', false);
				this.$main_menu.$_instance.addNewChild('Tree', 0, 'Tree_Load_Local', 'Load catalog from Assets...', false);
				this.$main_menu.$_instance.addNewChild('Tree', 1, 'Tree_Load_Remote', 'Load Tree from Server...', false);
				this.$main_menu.$_instance.addNewSibling(null, 'Form', 'Form', false);
				this.$main_menu.$_instance.addNewChild('Form', 0, 'Form_Show', 'Show Form...', false);
				this.$main_menu.$_instance.addNewChild('Form', 1, 'Form_Show_Modal', 'Show Modal Form...', false);
				//			main_menu.Load("data/menu.xml");
				// menus get built in reverse. imagine push_back ...
				this.$main_menu.$_instance.addNewSibling(null, 'Server', 'Server', false);
				this.$main_menu.$_instance.addNewChild('Server', 0, 'Server_Ajax', 'Make AJAX call...', false);
				this.$main_menu.$_instance.addNewChild('Server', 1, 'Server_JSON', 'To JSON string...', false);
				this.$main_menu.$_instance.addNewChild('Server', 2, 'Server_Catalog', 'Get Catalog via AJAX...', false);
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
			// so we can pop-up in empty regions
			this.$base_filters.$_instance.entBox.id = 'gridBody';
			this.$base_filters.set_$multipleSelection(true);
			this.$base_filters.add_$onDragDrop(ss.mkdel(this, this.$baseTreeDragDropHandler));
			// base tree context menu
			var ctx_base_filters = new $DHTMLXSharp_$DHTMLXContextMenu('data/imgs/');
			ctx_base_filters.$_instance.loadStruct('data/context_edit_menu.xml');
			this.$base_filters.$setContextMenu(ctx_base_filters);
			ctx_base_filters.$_instance.addContextZone('gridBody');
			ctx_base_filters.$_instance.attachEvent('onClick', ss.mkdel(this, this.$ctx_base_filters_OnClick));
			//---------------------------------------------------------------------------
			// filter tree
			cell = central_panel.$_instance.cells('c');
			this.$tree_filters = new $DHTMLXSharp_$DHTMLXTreeGrid.$ctor1(cell, 'data/tree_filter.xml');
			this.$tree_filters.$enableDragDrop();
			this.$tree_filters.$_instance.entBox.id = 'gridBody';
			this.$tree_filters.set_$multipleSelection(true);
			this.$tree_filters.add_$onDragDrop(ss.mkdel(this, this.$filterTreeDragDropHandler));
			// filter tree context menu
			var ctx_tree_filters = new $DHTMLXSharp_$DHTMLXContextMenu('data/imgs/');
			ctx_tree_filters.$_instance.loadStruct('data/context_edit_menu.xml');
			this.$tree_filters.$setContextMenu(ctx_tree_filters);
			ctx_tree_filters.$_instance.addContextZone('gridBody');
			ctx_tree_filters.$_instance.attachEvent('onClick', ss.mkdel(this, this.$ctx_tree_filters_OnClick));
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
			//---------------------------------------------------------------------------
			// catalog context menu
			var ctx_catalog = new $DHTMLXSharp_$DHTMLXContextMenu('data/imgs/');
			ctx_catalog.$_instance.loadStruct('data/menu_ctx_catalog.xml');
			this.$catalog.$setContextMenu(ctx_catalog);
			this.$catalog.add_$onDragDrop(ss.mkdel(this, this.$catalog_OnDragDrop));
			//---------------------------------------------------------------------------
			// Create results grid
			tab = tabbar.$_instance.cells('Results');
			this.$grid_results = new $DHTMLXSharp_$DHTMLXGrid.$ctor1(tab);
			this.$grid_results.$enableDragDrop();
			this.$grid_results.set_$enableMultipleSelection(true);
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
			// load the default catalog (whatever that may be)
			window.setTimeout(ss.mkdel(this, this.$postActivation), 2000);
		},
		$ctx_base_filters_OnClick: function(id) {
			console.log('ctx_base_filters_OnClick ' + id);
			if (id === 'cut') {
				this.$base_filters.$_instance.deleteSelectedRows();
			}
			else if (id === 'selectAll') {
				this.$base_filters.$_instance.selectAll();
			}
		},
		$ctx_tree_filters_OnClick: function(id) {
			console.log('ctx_tree_filters_OnClick ' + id);
			if (id === 'cut') {
				this.$tree_filters.$_instance.deleteSelectedRows();
			}
			else if (id === 'selectAll') {
				this.$tree_filters.$_instance.selectAll();
			}
		},
		$postActivation: function() {
			console.log('PostActivation()');
			// pop an AJAX request to get catalog
			var opts = { url: $DHTMLXSharp_main.$g_http_url + '/ajax', dataType: 'xml', async: true, success: ss.mkdel(this, this.onCatalogSuccess), error: ss.mkdel(this, this.onCatalogError), type: 'GET' };
			var req = $.ajax(opts);
		},
		$createSocket: function() {
			if (ss.isNullOrUndefined(this.$ws)) {
				this.$ws = new $DHTMLXSharp_$WebSocket($DHTMLXSharp_main.$g_ws_url + '/ajax');
				this.$ws.add_$onConnected(ss.mkdel(this, this.$ws_OnConnected));
				this.$ws.add_$onDisconnected(ss.mkdel(this, this.$ws_OnDisconnected));
				this.$ws.add_$onDataReceived(ss.mkdel(this, this.$ws_OnDataReceived));
			}
		},
		$ws_OnDataReceived: function(sender, data) {
			if (ss.isValue(data)) {
				var s = ss.safeCast(data, String);
				this.$status_bar.set_$text(ss.formatString('Got {0} from {1}', s, $DHTMLXSharp_main.$g_ws_url));
			}
		},
		$ws_OnDisconnected: function() {
			console.log('ws_OnDisconnected()');
			this.$status_bar.set_$text(ss.formatString('*No* connection to {0}', $DHTMLXSharp_main.$g_ws_url));
			this.$ws = null;
		},
		$ws_OnConnected: function() {
			console.log('ws_OnConnected()');
			this.$status_bar.set_$text(ss.formatString('Connected to {0}/ajax', $DHTMLXSharp_main.$g_ws_url));
			for (var i = 0; i < this.$_queue.length; i++) {
				this.$ws.$_instance.send(this.$_queue[i]);
			}
			ss.clear(this.$_queue);
		},
		$QS: function(arg) {
			var ret = '"';
			if (ss.isValue(arg)) {
				ret += arg;
			}
			ret += '"';
			return ret;
		},
		$tool_bar_OnClick: function(id) {
			console.log(ss.formatString('tool_bar_OnClick {0}', id));
			if (id === 'save') {
				// serialize to raw JSON
				var sb = { $: new ss.StringBuilder() };
				sb.$.append('{');
				sb.$.append(this.$QS('Query'));
				sb.$.append(':');
				sb.$.append('{');
				//
				sb.$.append(this.$QS('filter_data'));
				sb.$.append(':[');
				this.$serializeTree(this.$tree_filters, sb);
				sb.$.append('],');
				//
				sb.$.append(this.$QS('base_data'));
				sb.$.append(':[');
				this.$serializeTree(this.$base_filters, sb);
				sb.$.append(']');
				// close class scope Query
				sb.$.append('}');
				// close header for Query
				sb.$.append('}');
				//
				//object json_object = jQuery.ParseJson(sb.ToString());
				//SendJSONviaAJAX("tree", "json", sb.ToString());
				if (ss.isNullOrUndefined(this.$ws)) {
					this.$createSocket();
					ss.add(this.$_queue, sb.$.toString());
				}
				else {
					this.$ws.$_instance.send(sb.$.toString());
				}
			}
		},
		$serializeTree: function(tree, sb) {
			var count = tree.$getRowCount();
			for (var i = 0; i < count; i++) {
				//String sf = null;
				//String st = null;
				var rid = tree.$getRowId(i);
				var obj = tree.$_instance.getUserData(rid, 'type');
				var pid = tree.$getParentRowId(rid);
				{
					sb.$.append('{"rid":');
					sb.$.append(this.$QS(rid));
					sb.$.append(',"pid":');
					sb.$.append(this.$QS(pid));
					// verbatim text
					var cell = tree.$_instance.cells(rid, $DHTMLXSharp_main$FilterTree.eDescription);
					sb.$.append(',"desc":');
					sb.$.append(this.$QS(cell.getValue({})));
					// filter(s)
					cell = tree.$_instance.cells(rid, $DHTMLXSharp_main$FilterTree.eFilter);
					sb.$.append(',"filter":');
					sb.$.append(this.$QS(cell.getValue({})));
					// target
					cell = tree.$_instance.cells(rid, $DHTMLXSharp_main$FilterTree.eTarget);
					sb.$.append(',"target":');
					sb.$.append(this.$QS(cell.getValue({})));
					sb.$.append('}');
					// gak ...
					if (i < count - 1) {
						sb.$.append(',');
					}
				}
			}
		},
		$catalog_OnDragDrop: function(srcIDs, dstID, srcWidget, dstWidget, srcColumn, dstColumn) {
			return false;
		},
		$filterTreeDragDropHandler: function(srcIDs, dstID, srcWidget, dstWidget, srcColumn, dstColumn) {
			return this.$dragDropCopyHandler(srcIDs, dstID, this.$catalog, this.$tree_filters, srcColumn, dstColumn);
		},
		$baseTreeDragDropHandler: function(srcIDs, dstID, srcWidget, dstWidget, srcColumn, dstColumn) {
			return this.$dragDropCopyHandler(srcIDs, dstID, this.$catalog, this.$base_filters, srcColumn, dstColumn);
		},
		$dragDropCopyHandler: function(srcIDs, dstID, srcWidget, dstWidget, srcColumn, dstColumn) {
			if (dstColumn === 2) {
				var userdata = null;
				var dstCell = dstWidget.$_instance.cells(dstID, dstColumn);
				if (ss.isValue(dstCell)) {
					var row_id = null;
					//
					for (var s = 0; s < srcIDs.length; s++) {
						row_id = srcIDs[s];
						userdata = srcWidget.$_instance.getUserData(row_id, 'type');
						console.log(userdata);
						// filters are additive
						if (userdata === 'F') {
							var srcCell = this.$catalog.$_instance.cells(row_id, srcColumn);
							//
							var dv = dstCell.getValue({});
							if (dv.length > 0) {
								dv += ',';
							}
							dv += srcCell.getValue({});
							dstCell.setValue(dv);
						}
					}
					//
					return false;
				}
			}
			else if (dstColumn === 3) {
				var userdata1 = null;
				var dstCell1 = dstWidget.$_instance.cells(dstID, dstColumn);
				if (ss.isValue(dstCell1)) {
					var row_id1 = null;
					//
					for (var s1 = 0; s1 < srcIDs.length; s1++) {
						row_id1 = srcIDs[s1];
						userdata1 = srcWidget.$_instance.getUserData(row_id1, 'type');
						console.log(userdata1);
						// targets simply replace 
						if (userdata1 === 'T') {
							var srcCell1 = this.$catalog.$_instance.cells(row_id1, srcColumn);
							dstCell1.setValue(srcCell1.getValue({}));
						}
					}
					// disallow any further drag/drop
					return false;
				}
			}
			return true;
		}
	};
	$DHTMLXSharp_main.$main = function() {
		var $t1 = new $DHTMLXSharp_main();
		$(ss.mkdel($t1, $t1.$attach));
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.main.FilterTree
	var $DHTMLXSharp_main$FilterTree = function() {
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
	ss.registerClass(null, 'DHTMLXSharp.$SingleshotTimer', $DHTMLXSharp_$SingleshotTimer);
	ss.registerClass(null, 'DHTMLXSharp.$Test', $DHTMLXSharp_$Test);
	ss.registerClass(null, 'DHTMLXSharp.$WebSocket', $DHTMLXSharp_$WebSocket);
	ss.registerClass(global, 'DHTMLXSharp.DHTMLXTreeGridSettings', $DHTMLXSharp_DHTMLXTreeGridSettings);
	ss.registerClass(global, 'DHTMLXSharp.main', $DHTMLXSharp_main);
	ss.registerClass(global, 'DHTMLXSharp.main$FilterTree', $DHTMLXSharp_main$FilterTree);
	ss.registerClass(global, 'DHTMLXSharp.main$JSONThing', $DHTMLXSharp_main$JSONThing);
	$DHTMLXSharp_$DHTMLXLayout.$formats = new (ss.makeGenericType(ss.Dictionary$2, [$DHTMLXSharp_$DHTMLXLayout$Format, String]))();
	$DHTMLXSharp_$DHTMLXWindowFactory.$_factory = null;
	$DHTMLXSharp_main$FilterTree.eIndex = 0;
	$DHTMLXSharp_main$FilterTree.eDescription = 1;
	$DHTMLXSharp_main$FilterTree.eFilter = 2;
	$DHTMLXSharp_main$FilterTree.eTarget = 3;
	$DHTMLXSharp_main.$g_http_url = 'http://192.168.101.12:8888';
	$DHTMLXSharp_main.$g_ws_url = 'ws://192.168.101.12:8888';
	$DHTMLXSharp_main.$main();
})();
