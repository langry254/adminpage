﻿function toggleMenu() {
    let toggle = document.querySelector('.toggle');
    let navigation = document.querySelector('.navigation');
    let main = document.querySelector('.main');
    let dash = document.querySelector('.dash');
    toggle.classList.toggle('active');
    navigation.classList.toggle('active');
    main.classList.toggle('active');
    dash.classList.toggle('active');
   
}
function togglecreate() {
    var dash = document.querySelector('.dash');
    dash.classList.toggle('active');
    var popup = document.querySelector('.create');
    popup.classList.toggle('active');
}
