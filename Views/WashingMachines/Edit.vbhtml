@ModelType ElectroStore2.WashingMachine
@Code
    ViewData("Title") = "Edit"
End Code
<body style="background-image: linear-gradient(to bottom right, rgb(106, 106, 138), rgb(255,255,255))">
    <h2>Edit</h2>

    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-horizontal">
            <h4>WashingMachine</h4>
            <hr />
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            @Html.HiddenFor(Function(model) model.WashID)

            <div class="form-group">
                @Html.LabelFor(Function(model) model.LoadingType, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.LoadingType, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.LoadingType, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.LoadingCapacity, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.LoadingCapacity, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.LoadingCapacity, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                @Html.LabelFor(Function(model) model.NoOfPrograms, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.NoOfPrograms, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.NoOfPrograms, "", New With {.class = "text-danger"})
                </div>
            </div>

            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Save" class="btn btn-default" />
                </div>
            </div>
        </div>
    End Using

    <div>
        @Html.ActionLink("Back to List", "Index")
    </div>

    @Section Scripts
        @Scripts.Render("~/bundles/jqueryval")
    End Section

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
