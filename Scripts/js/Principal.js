
class Principal {
    userLink(URLactual) {
        let url = '';
        let cadena = URLactual.Split("/");
        for (var i = 0; i < cadena.length; i++ ) {
            if (cadena[i] != "Index") {
                url += cadena[i];
            }
        }
        switch (url){
            case "PostsCreate":
                document.getElementById('files').addEventListener('change', postImage, false);
                break;
        }
    }
}