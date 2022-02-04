var game = {};
const colorArr = [
	"#FF0000",
	"#FFA500",
	"#FFBF00",
	"#FFFF00",
	"brown",
	"#00FF00",
	"#008080",
	"#0000FF",
	"#8F00FF",
	"#800080",
	"#FF00FF",
	"grey",
];

//SET/RESET VAR
function setVars() {
	game.randomBlock = null;
	game.ultraBlock = document.getElementById("ultrablock");
	game.colorBlock = document.getElementsByClassName("colorblock");
	game.settings = document.getElementById("settings");
	game.score = document.getElementById("score");
	game.clickable = true;
	game.clicked = false;
	game.started = false;
	game.goed = 0;
	game.fout = 0;
	game.gemist = -1;
	game.timer = null;
	game.timeout = document.getElementById("timeout").value;
	game.loops = document.getElementById("loops").value;
	game.looptimes = 0;
	game.basischange = document.getElementById("basis").value;
}

//LOAD
function load() {
	console.log(game.basischange);
	setVars();
	if (!game.started) {
		setColors();
		started = true;
	}
	for (var i = 0; i < game.colorBlock.length; i++) {
		let element = game.colorBlock[i];
		element.addEventListener("click", () => {
			input(element);
		});
	}
	
console.log(game.timeout)
console.log(game.loops)
}

//START
function setColors() {
	if (game.clicked == false) {
		game.gemist += 1;
		game.score.innerHTML = `Goed: ${game.goed} | Fout: ${game.fout} | Gemist ${game.gemist}`;
	}
	game.clicked = false;
	game.clickable = true;
	colorArr.sort(() => Math.random() - Math.random());
	for (let i = 0; i < game.colorBlock.length; i++) {
		game.randomBlock =
			game.colorBlock[Math.floor(Math.random() * game.colorBlock.length)];
		game.colorBlock[i].style.backgroundColor = colorArr[i];
		game.ultraBlock.style.backgroundColor =
			game.randomBlock.style.backgroundColor;
	}
	if (game.looptimes == game.loops) {}else {
		game.timer = setTimeout(function () {
			setColors();
		}, game.timeout);
		game.looptimes ++
	}
}

//STOP
function stop() {
	clearInterval(game.timer);
}

//CLICK CHECK
function input(element) {
	game.clicked = true;
	if (game.clickable === true) {
		if (
			element.style.backgroundColor === game.ultraBlock.style.backgroundColor
		) {
			game.goed ++;
			new Audio("content/goed.wav").play();
			for (let i = 0; i < game.colorBlock.length; i++) {
				const element = game.colorBlock[i];
				element.style.backgroundColor = "green";
			}
		} else {
			game.fout ++;
			new Audio("content/bad.wav").play();
			for (let i = 0; i < game.colorBlock.length; i++) {
				const element = game.colorBlock[i];
				element.style.backgroundColor = "red";
			}
		}
		game.clickable = false;
		game.score.innerHTML = `Goed: ${game.goed} | Fout: ${game.fout} | Gemist ${game.gemist}`;
	}
}

function settings() {
	if (document.getElementById("settings").className == "settings--disabled") {
		document.getElementById("settings").className = "settings--enabled";
	} else {
		document.getElementById("settings").className = "settings--disabled";
	}
}
