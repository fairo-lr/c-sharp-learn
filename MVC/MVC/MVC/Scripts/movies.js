$(function () {

    var ajaxFormSubmit = function () { 
        $form = $(this); 
        var option =
            {
                url: $form.attr("action"),
                type: $form.attr("method"),
                data: $form.serialize()
            }
        $.ajax(option).done(function (data) {
            var $target = $($form.attr("data-movies-target"));
            $target.replaceWith(data); 
        });

        return false; 
    }

    var submitAutoCompleteForm = function (event,ui) {
        var $input = $(this);
        $input.val(ui.item.label);

        var $form = $input.parents("form:first");
        $form.submit();
    }

    var createAutoComplete = function () {
        var $input = $(this);
        var option = {
            select:submitAutoCompleteForm,
            source: $input.attr("data-movies-autocomplete")
        };
        $input.autocomplete(option);
    }

    $("form[data-movies-ajax='true']").submit(ajaxFormSubmit);
    $("input[data-movies-autocomplete]").each(createAutoComplete);

});