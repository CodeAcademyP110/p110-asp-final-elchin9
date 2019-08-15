$(function () {
    $("#brands").change(function () {
        var brandId = $(this).val();

        if (brandId) {
            $.ajax({
                url: "/Ajax/LoadModelsByBrandId?BrandId=" + brandId,
                type: "POST",
                success: function (res) {
                    $("#ModelId").html(res);
                    $("#ModelId").prepend("<option value=''>Secin</option>");
                }
            });
        }
    });
});
