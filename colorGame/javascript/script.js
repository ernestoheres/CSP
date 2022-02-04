var a = {};
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
	a.randomBlock = null;
	a.ultraBlock = document.getElementById("ultrablock");
	a.colorBlock = document.getElementsByClassName("colorblock");
	a.score = document.getElementById("score");
	a.clickable = true;
	a.clicked = false;
	a.started = false;
	a.goed = 0;
	a.fout = 0;
	a.gemist = -1;
	a.timer = null;
}

//LOAD
function load() {
	setVars();
	if (!a.started) {
		setColors();
		started = true;
	}
	for (var i = 0; i < a.colorBlock.length; i++) {
		let element = a.colorBlock[i];
		element.addEventListener("click", () => {
			input(element);
		});
	}
}

//START
function setColors() {
	if (a.clicked == false) {
		a.gemist += 1;
		a.score.innerHTML = `Goed: ${a.goed} | Fout: ${a.fout} | Gemist ${a.gemist}`;
	}
	a.clicked = false;
	a.clickable = true;
	colorArr.sort(() => Math.random() - Math.random());
	for (let i = 0; i < a.colorBlock.length; i++) {
		a.randomBlock = a.colorBlock[Math.floor(Math.random() * a.colorBlock.length)];
		a.colorBlock[i].style.backgroundColor = colorArr[i];;
		a.ultraBlock.style.backgroundColor = a.randomBlock.style.backgroundColor;
	}
	a.timer = setTimeout(function () {
		setColors();
	}, 2000);
}

//STOP
function stop() {
	clearInterval(a.timer);
}

//CLICK CHECK
function input(element) {
	a.clicked = true;
	if (a.clickable === true) {
		if (element.style.backgroundColor === a.ultraBlock.style.backgroundColor) {
			a.goed += 1;
			new Audio("content/goed.wav").play();
			for (let i = 0; i < a.colorBlock.length; i++) {
				const element = a.colorBlock[i];
				element.style.backgroundColor = "green";
			}
		} else {
			a.fout += 1;
			new Audio("content/bad.wav").play();
			for (let i = 0; i < a.colorBlock.length; i++) {
				const element = a.colorBlock[i];
				element.style.backgroundColor = "red";
			}
		}
		a.clickable = false;
		a.score.innerHTML = `Goed: ${a.goed} | Fout: ${a.fout} | Gemist ${a.gemist}`;
	}
}