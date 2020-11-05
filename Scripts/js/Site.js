
var posts = new Posts();

var postImage = (evt) => {
    posts.archivo(evt, postImage);
}

var principal = new Principal();

$().ready(() => {
    let URLactual = window.location.pathname;
    principal.userLink(URLactual);
});