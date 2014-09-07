(function() {
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.DHTMLXSharp
	var $DHTMLXSharp_DHTMLXSharp = function() {
		this.$ms = null;
	};
	$DHTMLXSharp_DHTMLXSharp.prototype = {
		$attach: function() {
			// new MessageShower("showMessage", "messageContainer").Attach();
			this.$ms = new $DHTMLXSharp_MessageShower('showMessage', 'messageContainer');
			this.$ms.attach();
			(new $DHTMLXSharp_MessageFlasher('flashMessage', 'messageContainer')).attach();
		}
	};
	$DHTMLXSharp_DHTMLXSharp.$main = function() {
		var $t1 = new $DHTMLXSharp_DHTMLXSharp();
		$(ss.mkdel($t1, $t1.$attach));
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.MessageFlasher
	var $DHTMLXSharp_MessageFlasher = function(buttonId, containerId) {
		this.$_buttonId = null;
		this.$_containerId = null;
		this.$_buttonId = buttonId;
		this.$_containerId = containerId;
	};
	$DHTMLXSharp_MessageFlasher.prototype = {
		attach: function() {
			$('#' + this.$_buttonId).click(ss.mkdel(this, function(evt) {
				var $state = 0, newEl, $t1, $t2;
				var $sm = ss.mkdel(this, function() {
					$sm1:
					for (;;) {
						switch ($state) {
							case 0: {
								$state = -1;
								newEl = $('<div>Hello, world</div>');
								newEl.hide();
								$('#' + this.$_containerId).append(newEl);
								$t1 = ss.Task.fromDoneCallback(newEl, 'fadeIn', 500);
								$state = 1;
								$t1.continueWith($sm);
								return;
							}
							case 1: {
								$state = -1;
								$t1.getResult();
								$t2 = ss.Task.fromDoneCallback(newEl, 'fadeOut', 500);
								$state = 2;
								$t2.continueWith($sm);
								return;
							}
							case 2: {
								$state = -1;
								$t2.getResult();
								$state = -1;
								break $sm1;
							}
							default: {
								break $sm1;
							}
						}
					}
				});
				$sm();
			}));
		}
	};
	////////////////////////////////////////////////////////////////////////////////
	// DHTMLXSharp.MessageShower
	var $DHTMLXSharp_MessageShower = function(buttonId, containerId) {
		this.$_buttonId = null;
		this.$_containerId = null;
		this.$_buttonId = buttonId;
		this.$_containerId = containerId;
	};
	$DHTMLXSharp_MessageShower.prototype = {
		attach: function() {
			$('#' + this.$_buttonId).click(ss.mkdel(this, function(evt) {
				var newEl = $('<div>Hello, world</div>');
				$('#' + this.$_containerId).append(newEl);
			}));
		}
	};
	ss.registerClass(global, 'DHTMLXSharp.DHTMLXSharp', $DHTMLXSharp_DHTMLXSharp);
	ss.registerClass(global, 'DHTMLXSharp.MessageFlasher', $DHTMLXSharp_MessageFlasher);
	ss.registerClass(global, 'DHTMLXSharp.MessageShower', $DHTMLXSharp_MessageShower);
	$DHTMLXSharp_DHTMLXSharp.$main();
})();
