@ModelType ElectroStore2.GamingLaptop
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>GamingLaptop</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.RefreshRate_Hz)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.RefreshRate_Hz)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.ResponseTime_ms)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.ResponseTime_ms)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Laptop.Brand)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Laptop.Brand)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
