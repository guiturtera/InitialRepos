var ships = [[], []];
var totalHits = 0;
var hits = 0;
var map;
var twoPlayers = false;
var numGuesses = 0;
var wrongGuesses = 0;
var isSunk = false;
var turn = 1;

function startGame(numShips, sizeMap) {

    var aux = document.getElementsByName('numPlayers')
    for (var i = 0; i < aux.length; i++) {
        if (aux[i].checked) {
            map = parseInt(aux[i].value);
            if (map == 1) {
                twoPlayers = true;
            }
        }
    }

    createSea(sizeMap);
    console.log('numero de barcos = ' + numShips);
    for (var i = map; i < 2; i++){
        for (var j = 0; j < numShips; j++) {
            ships[i].push(createShip(sizeMap, ships, i));
        }
    }
    // Teste
    /*console.log('total hits -- ' + totalHits);
    var a =0;
    for (var i = 0; i < ships.length; i++){
        for (var j = 0; j < ships[i].length; j++){
            console.log(ships[i][j].x + "" + ships[i][j].y);
            a++;
        }
    }
    console.log('total de pontos --> ' + a)*/
}

//Length - 1 a 3, side 0 - horizontal 1 - vertical, locationX - 0 a 4, locationY - 0 a 4
function createShip(sizeMap, ships, sea) {

    var length = Math.floor(Math.random() * ((sizeMap / 2) - 1));
    var side = Math.floor(Math.random() * 2);
    var locationX;
    var locationY;

    if (length < 2) {
        length = 2;
    }

    var shipAux = new Array();
    for (var i = 0; i < length; i++) {

        if (i == 0) {

            console.log('tentativa');
            locationX = Math.floor(Math.random() * (sizeMap - ((sizeMap / 2) - 2)));
            locationY = Math.floor(Math.random() * (sizeMap - ((sizeMap / 2) - 2)));

        }

        if (side == 0) {
            var aux = {
                x: locationX + i,
                y: locationY
            }
            shipAux.push(aux);
        }
        else {
            var aux = {
                x: locationX,
                y: locationY + i
            }
            shipAux.push(aux);
        }
        console.log(aux.x + "" + aux.y);
        if (colision(ships[sea], aux.x, aux.y) == true) {
            console.log('quebrou');
            i = -1;
            shipAux = new Array();
        }

    }
    for (var j = 0; j < shipAux.length; j++) {
        totalHits++;
    }
    return shipAux;
}

function createSea(sizeMap) {

    for (var h = map; h < 2; h++) {
        document.getElementById('corpo').innerHTML += '<br><br><br><table id="mapa' + h + '">'
        for (var i = 0; i < sizeMap; i++) {
            document.getElementById('mapa' + h).innerHTML += '<tr id="' + "" + i + h + '">'
            for (var j = 0; j < sizeMap; j++) {
                document.getElementById(i + "" + h).innerHTML += '<td id="' + "" + i + j + h + '" onclick="atira(' + i + ',' + j + "," + h + ')" class="normalPosition"></td>'
            }
            document.getElementById('mapa' + h).innerHTML += '</tr>'
        }
    }
    document.getElementById('corpo').innerHTML += '</table>'
}


function colision(ships, x, y) {
    for (var i = 0; i < ships.length; i++) {
        for (var j = 0; j < ships[i].length; j++) {
            if (x == ships[i][j].x && y == ships[i][j].y) {
                return true;
            }
        }
    }
    return false;
}

function correctGuess(ships, x, y) {

    for (var i = 0; i < ships.length; i++) {
        for (var j = 0; j < ships[i].length; j++) {
            if (x == ships[i][j].x && y == ships[i][j].y) {
                ships[i].splice(j, 1);
                return true;
            }
        }
    }
    return false;
}

function atira(x, y, round) {
    numGuesses++;

    if (turn == round) {


        if (correctGuess(ships[turn], x, y) == true) {
            hits++;
            document.getElementById('interaction').textContent = 'FIRE!';
            document.getElementById('interaction').style.background = 'green';
            document.getElementById(x + "" + y + turn).className = 'rightShotPosition resetHover';
            if (hits == totalHits) {
                isSunk = true;
                alert('You sank my battleship!');
            }
        }
        else {
            document.getElementById('interaction').textContent = 'MISS!';
            document.getElementById('interaction').style.background = 'red';
            console.log(x + "" + y + "" + turn);
            document.getElementById(x + "" + y + "" + turn).className = 'wrongShotPosition resetHover';
            wrongGuesses++;
        }
        document.getElementById(x + "" + y + turn).onclick = null;


        if (twoPlayers == true) {
            if (wrongGuesses == 10) {
                document.write("<h1 background='red' display='inline'>PERDEU!</h1>");
            }
            else {
                document.getElementById('remainingWrongGuesses').innerText = 'Tentativas restantes: ' + (10 - wrongGuesses);
            }
        }
        else{
            if (turn == 0)
                turn = 1;
            else 
                turn = 0;
        }

    }

    else {
        alert('Não é sua vez!');
    }



}
