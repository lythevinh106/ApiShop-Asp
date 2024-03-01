
function initTextEditor(select) {

    tinymce.init({
        selector: select,
        plugins: 'anchor autolink charmap codesample emoticons image link lists media searchreplace table visualblocks wordcount',
        toolbar: 'undo redo | blocks fontfamily fontsize | bold italic underline strikethrough | link image media table | align lineheight | numlist bullist indent outdent | emoticons charmap | removeformat',
    });
}
function initTextEditor2(select) {

    
    new RichTextEditor(select);
  

}

