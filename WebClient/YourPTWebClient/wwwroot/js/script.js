﻿let hidden = false;
let visible = true;
function toggleSideMenu() {
	if (window.innerWidth >= 641) {
		if (!hidden) {
			document.getElementById("sidebar").style.width = 0;
			hidden = true;
			switchMenuButtonIcon()
		} else if (hidden) {
			document.getElementById("sidebar").style.width = '250px';
			hidden = false;
			switchMenuButtonIcon()
		}
	}
}

function switchMenuButtonIcon() {
	if (!hidden) {
		document.getElementById("menuButton").innerHTML = `<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-arrow-bar-left" viewBox="0 0 16 16">
						<path fill-rule="evenodd" d="M12.5 15a.5.5 0 0 1-.5-.5v-13a.5.5 0 0 1 1 0v13a.5.5 0 0 1-.5.5M10 8a.5.5 0 0 1-.5.5H3.707l2.147 2.146a.5.5 0 0 1-.708.708l-3-3a.5.5 0 0 1 0-.708l3-3a.5.5 0 1 1 .708.708L3.707 7.5H9.5a.5.5 0 0 1 .5.5"/>
					</svg>`;
	} else if (hidden) {
		document.getElementById("menuButton").innerHTML = `<svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" fill="currentColor" class="bi bi-arrow-bar-right" viewBox="0 0 16 16">
					<path fill-rule="evenodd" d="M6 8a.5.5 0 0 0 .5.5h5.793l-2.147 2.146a.5.5 0 0 0 .708.708l3-3a.5.5 0 0 0 0-.708l-3-3a.5.5 0 0 0-.708.708L12.293 7.5H6.5A.5.5 0 0 0 6 8m-2.5 7a.5.5 0 0 1-.5-.5v-13a.5.5 0 0 1 1 0v13a.5.5 0 0 1-.5.5"/>
					</svg>`
	}
}

function maxWidthSideBar() {
	if (window.innerWidth >= 641) {
		return '250px';
	} else {
		return '100%'
	}
}

//not finished (improve performance and more)
function updateMenuWidth() {
	if (!visible && !hidden && window.innerWidth >= 641 /* && document.getElementById("sidebar").offsetWidth > 250 */) {
		visible = true;
		switchMenuButtonIcon();
		document.getElementById("sidebar").style.width = maxWidthSideBar();
		//document.getElementById("menuButton").style.visibility = 'visible';
		console.log("test1")
	} else if (visible && window.innerWidth < 641 /*&& document.getElementById("sidebar").offsetWidth != window.innerWidth */ /* (document.getElementById("sidebar").offsetWidth == 250 || document.getElementById("sidebar").offsetWidth == 0) */) {
		hidden = false;
		visible = false;
		switchMenuButtonIcon();
		document.getElementById("sidebar").style.width = maxWidthSideBar();
		//document.getElementById("menuButton").style.visibility = 'hidden';
		console.log("test2")
	}
}

// // Call the function initially to set the width
updateMenuWidth();

// // Add event listener for window resize
window.addEventListener("resize", updateMenuWidth);