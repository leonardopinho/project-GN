function remove(id) {
    $.ajax({
        url: '/api/Customers/' + id,
        type: 'DELETE',
        success: function (result) {
            alert('Registro removido com sucesso.');
            window.location = "/";
        }
    });
}