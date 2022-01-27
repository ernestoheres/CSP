let stopLoop = false;
let clickable = true;
let clicked = false
let goed = 0;
let fout = 0;
let gemist = -1;
let strated = false;
let timer = null;

//LOAD
function load()
{
    let  elements = document.getElementsByClassName('colorblock');
    if (strated == false)
    {
        setColors()
    }

    for(var i=0;  i < elements.length; i++)
    {
        let element = elements[i];
        element.addEventListener("click", test => {input(element)});
    }
}

//START
function setColors()
{   
    if (clicked == false) 
    {
        gemist = gemist + 1;
        document.getElementById('score').innerHTML = `Goed: ${goed} | Fout: ${fout} | Gemist ${gemist}`;
    }
    clicked = false;
    clickable = true;
    
    const colorArr = ["#FF0000", "#FFA500", "#FFBF00", "#FFFF00", "brown", "#00FF00", "#008080", "#0000FF", "#8F00FF", "#800080", "#FF00FF", "grey"];
    colorArr.sort(() => Math.random() - Math.random());
    let  elements = document.getElementsByClassName('colorblock');

    for(let i = 0; i < elements.length; i++)
    {
        let color = colorArr[i];
        const element = elements[i];
        element.style.backgroundColor = color;
        let randomblok = elements[Math.floor(Math.random() * elements.length)]
        ultrablok.style.backgroundColor = randomblok.style.backgroundColor;
    }
    timer = setTimeout(function() {setColors()} , 2000);
}

//STOP
function stop()
{
  clearInterval(timer)
}

//CLICK CHECK
function input(element)
{
    clicked = true;
    if (clickable === true)
    {
        if(element.style.backgroundColor === document.getElementById('ultrablok').style.backgroundColor){
            goed = goed + 1;
            document.body.style.backgroundImage = "url('content/good.png')"
            var audiogood = new Audio("content/goed.wav")
            audiogood.play()  
        }   
        else {
            fout = fout + 1;
            document.body.style.backgroundImage = "url('content/bad.jpg')"
            var audiobad = new Audio("content/bad.wav")
            audiobad.play()
        }
        clickable = false;
        document.getElementById('score').innerHTML = `Goed: ${goed} | Fout: ${fout} | Gemist ${gemist}`;
    }
}