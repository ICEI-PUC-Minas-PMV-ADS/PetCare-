/*Bloco responsável por abrir e fechar o menu lateral em dispositivos mobile */
//A ideia  por tras desse botão é: ao clicar no elemento, dispara o evento de click,
//o evento chama a função controlarMenu(), que adiciona ou remove a classe open e closed, alterando assim,
//a imagem do botão e o estado do menu.
const btMenu = document.getElementById("bt-menu");
const menu = document.getElementById("menu-lateral");

function controlarMenu() {
    if (btMenu.classList.contains("closed")) {
        btMenu.classList.remove("closed");
        menu.classList.add("open");

        btMenu.innerHTML = `<i class="fas fa-times"></i>`
    } else {
        btMenu.classList.add("closed");
        menu.classList.remove("open");
        btMenu.innerHTML = `<i class="fas fa-bars"></i>`
    }
}
if (btMenu) btMenu.addEventListener('click', () => controlarMenu());
/*--------------------------------------------------------------------*/

