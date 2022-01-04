$(function (e) {
    $(document).on("click", ".img-box", function (e) {

        let id = $(this).attr("data-id")
        console.log(id)

        fetch(`/home/getportfolio/${id}`)
            .then(res => res.text())
            .then(data => {
                $("#exampleModal .modal-content").html(data)
            })
        $("#exampleModal").modal("show")
    })

    $(document).on("click", ".delete-btn", function (e) {
        $("#exampleModal").modal("hide")
    })

    $(document).on("click", ".close-btn", function () {
        $("#exampleModal").modal("hide")
    })
})
