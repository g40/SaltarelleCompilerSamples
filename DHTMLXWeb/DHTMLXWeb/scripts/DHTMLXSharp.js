(function() {
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXCell
	var $DHTMLXSharp_$DHTMLXCell = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXForm
	var $DHTMLXSharp_$DHTMLXForm = function() {
	};
	$DHTMLXSharp_$DHTMLXForm.prototype = {
		remove_$onClick: function(value) {
		}
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
	var $DHTMLXSharp_$DHTMLXWindow = function() {
	};
	$DHTMLXSharp_$DHTMLXWindow.prototype = {
		remove_$onClick: function(value) {
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXWindowFactory
	var $DHTMLXSharp_$DHTMLXWindowFactory = function() {
	};
	$DHTMLXSharp_$DHTMLXWindowFactory.createInstance = function() {
		return new dhtmlXWindows();
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.NativeCode
	var $DHTMLXSharp_$NativeCode = function() {
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.main
	var $DHTMLXSharp_main = function() {
		this.$form = null;
		this.$layout = null;
		this.$main_menu = null;
		this.$tree_grid = null;
		this.$wf = null;
		this.$json_layout = null;
	};
	$DHTMLXSharp_main.prototype = {
		onJSONSuccess: function(data, textStatus, request) {
			var s = data.toString();
		},
		$formButtonClicked: function(btnName) {
			if (btnName === 'save') {
				var s = null;
				var obj = this.$form.getFormData();
				if (ss.isValue(obj)) {
					s = obj.toString();
				}
			}
			if (ss.isValue(this.$form)) {
				this.$form.unload();
			}
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
				var opts = { url: 'http://localhost:8888/data/form1.json', dataType: 'json', async: true, success: ss.mkdel(this, this.onJSONSuccess) };
				// make the request
				var req = $.ajax(opts);
			}
			else {
				var win = this.$wf.createWindow(id, 100, 100, 320, 200);
				win.attachEvent('onClick', ss.mkdel(this, this.$onButtonClick));
				win.setText(id);
				this.$form = win.attachForm(Mapper['formLayout']);
				this.$form.attachEvent('onButtonClick', ss.mkdel(this, this.$formButtonClicked));
			}
		},
		$onButtonClick: function(window, cell) {
			window.alert('OnButtonClick');
		},
		onAjaxCallback: function(data) {
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
			// create the Window factory
			this.$wf = new dhtmlXWindows();
			//
			// jQuery.Ajax()
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
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXForm', $DHTMLXSharp_$DHTMLXForm);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXLayoutObject', $DHTMLXSharp_$DHTMLXLayoutObject);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXMenu', $DHTMLXSharp_$DHTMLXMenu);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXToolbar', $DHTMLXSharp_$DHTMLXToolbar);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXTreeGrid', $DHTMLXSharp_$DHTMLXTreeGrid);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXWindow', $DHTMLXSharp_$DHTMLXWindow);
	ss.registerClass(null, 'DHTMLXSharp.$DHTMLXWindowFactory', $DHTMLXSharp_$DHTMLXWindowFactory);
	ss.registerClass(null, 'DHTMLXSharp.$NativeCode', $DHTMLXSharp_$NativeCode);
	ss.registerClass(global, 'DHTMLXSharp.main', $DHTMLXSharp_main);
	ss.registerClass(global, 'DHTMLXSharp.main$JSONThing', $DHTMLXSharp_main$JSONThing);
	$DHTMLXSharp_main.$main();
})();
