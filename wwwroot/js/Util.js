//function ConverterImagemToPdf(imagens) {
//    // Don't forget, that there are CORS-Restrictions. So if you want to run it without a Server in your Browser you need to transform the image to a dataURL
//    // Use http://dataurl.net/#dataurlmaker
//    var doc = new jsPDF();

//    for (var i = 0; i < imagens.length; i++) {
//        doc.setFontSize(40);
//        doc.text("Octonyan loves jsPDF", 35, 25);
//        doc.addImage(imagens[i].imagem, "JPEG", 15, 40, 180, 180);
//        doc.addPage();
//    }

//}

function ConverterImagemToPdf(img) {
    // Don't forget, that there are CORS-Restrictions. So if you want to run it without a Server in your Browser you need to transform the image to a dataURL
    // Use http://dataurl.net/#dataurlmaker
    var doc = new jsPDF();

    doc.setFontSize(40);
    doc.text("Octonyan loves jsPDF", 35, 25);
    doc.addImage(img, "JPEG", 15, 40, 180, 180);
    doc.addPage();

    getImageFromUrl(img, createPDF);
}



var img = new Image();

var getImageFromUrl = function (url, callback) {

    img.onError = function () {
        alert('Cannot load image: "' + url + '"');
    };
    img.onload = function () {
        callback(img);
    };
    img.src = url;


}
var createPDF = function (imgData) {
    var doc = new jsPDF('p', 'pt', 'a4');
    var width = doc.internal.pageSize.width;
    var height = doc.internal.pageSize.height;
    var options = {
        pagesplit: true
    };
    doc.text(10, 20, 'Crazy Monkey');
    var h1 = 50;
    var aspectwidth1 = (height - h1) * (9 / 16);
    doc.addImage(imgData, 'JPEG', 10, h1, aspectwidth1, (height - h1), 'monkey');
    doc.addPage();
    doc.text(10, 20, 'Hello World');
    var h2 = 30;
    var aspectwidth2 = (height - h2) * (9 / 16);
    doc.addImage(imgData, 'JPEG', 10, h2, aspectwidth2, (height - h2), 'monkey');

    var pdf = doc.output('dataurl');

    var elemento = document.getElementById("Pdf");
    elemento.insertAdjacentHTML("afterend", "<iframe src=" + pdf + " class='btn-ver-confomidades' style='width: 100%;height: 800px;' frameborder='0' allowfullscreen></iframe>");

    // Set the document to automatically print via JS
    //doc.autoPrint();
    //
    //doc.save('two-by-four.pdf')
    //doc.output('pdfjsnewwindow');
}
getImageFromUrl(img, createPDF);