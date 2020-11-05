
class UploadImage {

    archivo(evt, id) {
        let files = evt.target.files;
        let f = files[0];
        if (f.type.match('image.*')) {
            let reader = new FileReader;
            reader.onload = ((thefile) => {
                return (e) => {
                    document.getElementById(id).innerHTML['<img class="responsive-img ' + id
                        + ' " src="', e.target.result, '" title="', escape(thefile.name), '"/>'].join('');
                }
            })(f);
            reader.readAsDataURL(f);
        }
    }
}