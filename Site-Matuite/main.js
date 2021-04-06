function voltaImgPadrao(){
    //document.getElementById("div-big-heart").className += "a";
    document.getElementById("big-heart").style.background = "";
    document.getElementById("big-heart").src = "./images/logo.svg";
    //document.getElementById("div-big-heart").style.background = "url(./images/logo.svg) no-repeat";

}

function mudaImg(path){
    document.getElementById("big-heart").style.background = "url(" + path + ")";
    document.getElementById("big-heart").src = "./images/heart.png";

}